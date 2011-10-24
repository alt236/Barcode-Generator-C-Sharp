using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Linq;
using System.Collections;

using MessagingToolkit.Barcode.Multi;
using MessagingToolkit.Barcode;
using MessagingToolkit.Barcode.Common;
using System.IO;

namespace BarcodeGenerator
{
    public partial class frmMain : Form
    {
        private const string FILE_MARKER = "BarcodeGenerator";

        private const string KEYWORD_OPTION = "bcg_option";
        private const string KEYWORD_WIDTH = "bc_width";
        private const string KEYWORD_HEIGHT = "bc_height";
        private const string KEYWORD_PREFIX = "bc_prefix";
        private const string KEYWORD_SUFFIX = "bc_suffix";
        private const string COMMENT_INDICATOR = "#";

        private const string OPERATION_TYPE_FILE = "Use a Barcode script file";
        private const string OPERATION_TYPE_SINGLE = "Single Barcode";

        private const int INTIAL_BARCODE_HEIGHT = 200;
        private const int INTIAL_BARCODE_WIDTH = 200;

        private Bitmap bitmap = null;

        private Dictionary<string, BarcodeFormat> barcodeFormat = new Dictionary<string, BarcodeFormat>
        {
            { "QRCode", BarcodeFormat.QrCode },
            { "EAN 8", BarcodeFormat.Ean8},
            { "EAN 13", BarcodeFormat.Ean13}, 
            //{ "Code 128", BarcodeFormat.Code128},
            //{ "Code39", BarcodeFormat.Code39},
            //{ "DataMatrix", BarcodeFormat.DataMatrix },
            //{ "ITF", BarcodeFormat.Itf },
            //{ "PDF417", BarcodeFormat.Pdf417 },
            //{ "UPC-A", BarcodeFormat.UpcA  },
            //{ "UPC-E", BarcodeFormat.UpcE  },                      
        };

        private Dictionary<string, int> operationType = new Dictionary<string, int>
        {
            { OPERATION_TYPE_FILE, 0 },
            { OPERATION_TYPE_SINGLE, 1},                       
        };



        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = BarcodeGenerator.Properties.Resources.IconMain;
            cmbBarcodeType.Items.AddRange(barcodeFormat.Keys.ToArray());
            cmbBarcodeType.SelectedIndex = cmbBarcodeType.FindStringExact("QRCode");


            cmbOperation.Items.AddRange(operationType.Keys.ToArray());
            cmbOperation.SelectedIndex = 0;

            clear();
        }

        private void clear()
        {
            numHeight.Value = INTIAL_BARCODE_HEIGHT;
            numWidth.Value = INTIAL_BARCODE_WIDTH;
            fldBarcodeText.Text = "";
            picEncode.Image = null;
            cmbOperation_SelectedIndexChanged(this, null);
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            barcodeCreator bc = new barcodeCreator();

            switch (cmbOperation.Text)
            {
                case OPERATION_TYPE_SINGLE:
                    BarcodeFormat fm;
                    if (barcodeFormat.TryGetValue(cmbBarcodeType.Text, out fm))
                    {
                        bitmap = bc.createBarcode(fldBarcodeText.Text, fm, (int)numWidth.Value, (int)numHeight.Value);
                    }
                    if (!(bitmap == null))
                    {
                        picEncode.Image = bitmap;
                    }

                    break;
                case OPERATION_TYPE_FILE:
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (cmbOperation.Text)
            {
                case OPERATION_TYPE_SINGLE:
                    Bitmap bm = (Bitmap)picEncode.Image;
                    if (bm != null)
                    {
                        SaveFileDialog sdlg = new SaveFileDialog();
                        sdlg.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
                        sdlg.FileName = cmbBarcodeType.Text;
                        if (sdlg.ShowDialog() == DialogResult.OK)
                        {
                            bm.Save(sdlg.FileName, ImageFormat.Png);
                        }
                    }
                    break;
            }
        }


        private void processListFile(String listFilePath,
            String outputFolder, String bcPrefix,
            String bcSuffix,
            int bcHeight,
            int bcWidth,
            BarcodeFormat fm,
            RichTextBox log)
        {
            string input = null;
            bool skip = false;
            Bitmap bm = null;
            UInt64 cnt = 1;
            barcodeCreator bc = new barcodeCreator();
            StringBuilder logB = new StringBuilder();



            if (!File.Exists(listFilePath))
            {
                String message = "File '" + listFilePath + "' does not exist.\nAborting...";

                log.AppendText("!! " + message + Environment.NewLine);
                MessageBox.Show(message, "Could not open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                StreamReader re = File.OpenText(listFilePath);

                while ((input = re.ReadLine()) != null)
                {

                    switch (cnt)
                    {
                        case 1:
                            if (!(input.Trim().ToLower().Equals(FILE_MARKER.ToLower())))
                            {
                                String message = "File '" + listFilePath + "' does not seem to be a valid barcode list file.\nIf it should be, make sure that the first line is '" + FILE_MARKER + "'";
                                log.AppendText("!! " + message + Environment.NewLine);

                                MessageBox.Show(message, "Invalid list file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                re.Close();
                                return;
                            }
                            break;
                        default:
                            try
                            {
                                if (input.Trim().Length == 0)
                                {
                                    skip = true;
                                }
                                else if (input.Trim().Substring(0, 1).Equals(COMMENT_INDICATOR))
                                {
                                    skip = true;
                                }
                                else
                                {
                                    skip = false;
                                }

                                if (!skip)
                                {
                                    //log.AppendText("^ Parsing line: " + input + Environment.NewLine);
                                    String[] lineArr = input.Split('\t');

                                    switch (lineArr.Length)
                                    {
                                        case 0:
                                            break;
                                        case 2:
                                            StringBuilder sb = new StringBuilder();
                                            sb.Append(bcPrefix.Trim());
                                            sb.Append(lineArr[0]);
                                            sb.Append(bcSuffix.Trim());

                                            log.AppendText("^ Creating barcode: " + sb.ToString() + Environment.NewLine);

                                            bm = bc.createBarcode(sb.ToString(), fm, bcWidth, bcHeight);
                                            if (!(bm == null))
                                            {
                                                string savePath = outputFolder + "/" + lineArr[1];
                                                try
                                                {
                                                    bm.Save(savePath, ImageFormat.Png);
                                                }
                                                catch
                                                {
                                                    String message = "Could not save barcode'" + savePath + "'.\nAborting..";
                                                    log.AppendText("!! " + message + Environment.NewLine);

                                                    MessageBox.Show(message, "Could not save barcode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    re.Close();
                                                    return;
                                                }
                                            }
                                            break;
                                        case 3:
                                            if (lineArr[0].Trim().ToLower().Equals(KEYWORD_OPTION))
                                            {
                                                try
                                                {
                                                    switch (lineArr[1])
                                                    {
                                                        case KEYWORD_WIDTH:
                                                            if (!setOptionInteger(lineArr[2].Trim(), ref bcWidth))
                                                            {
                                                                log.AppendText("! Not a valid integer: " + input + Environment.NewLine);
                                                            }
                                                            log.AppendText("^ BC Width=" + bcWidth + Environment.NewLine);
                                                            break;
                                                        case KEYWORD_HEIGHT:
                                                            if (!setOptionInteger(lineArr[2].Trim(), ref bcHeight))
                                                            {
                                                                log.AppendText("! Not a valid integer: " + input + Environment.NewLine);
                                                            }
                                                            log.AppendText("^ BC Height=" + bcHeight + Environment.NewLine);
                                                            break;
                                                        case KEYWORD_PREFIX:
                                                            bcPrefix = lineArr[2];
                                                            log.AppendText("^ BC Prefix: '" + bcPrefix + "'" + Environment.NewLine);
                                                            break;
                                                        case KEYWORD_SUFFIX:
                                                            bcSuffix = lineArr[2];
                                                            log.AppendText("^ BC Suffix: '" + bcSuffix + "'" + Environment.NewLine);
                                                            break;
                                                        default:
                                                            log.AppendText("^ Unknown option: " + input + Environment.NewLine);
                                                            break;
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    log.AppendText("!! Error parsing option. Line: '" + input + "' Error: " + e.Message + Environment.NewLine);
                                                }
                                            }
                                            break;
                                        default:
                                            log.AppendText("^ Could not process line: " + input + Environment.NewLine);
                                            break;
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                String message = "There was an error while reading the file.\nError: " + e.Message + "\nAborting..";
                                log.AppendText("!! " + message + Environment.NewLine);

                                MessageBox.Show(message, "Error reading file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                re.Close();
                                return;
                            }
                            break;
                    }
                    cnt += 1;
                }

                re.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("An error was encountered while opening file '" + listFilePath + "'.\n Error: " + e.Message, "Error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool setOptionInteger(String newValue, ref int currentValue)
        {
            int valueBak = currentValue;

            if (!int.TryParse(newValue, out currentValue))
            {
                currentValue = valueBak;
                return false;
            }
            return true;
        }

        private void cmbBarcodeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOperation.Text)
            {
                case OPERATION_TYPE_SINGLE:
                    if (fldBarcodeText.Text.Length > 0)
                    {
                        btnEncode_Click(this, null);
                    }
                    break;
            }
        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOperation.Text)
            {
                case OPERATION_TYPE_SINGLE:
                    grpBoxSingleBarcode.Enabled = true;
                    grpFileLocations.Enabled = false;
                    grpBarcodeProperties.Enabled = true;
                    btnClear.Enabled = true;
                    picEncode.Visible = true;
                    richLog.Visible = false;
                    break;
                case OPERATION_TYPE_FILE:
                    grpBoxSingleBarcode.Enabled = false;
                    grpFileLocations.Enabled = true;
                    grpBarcodeProperties.Enabled = false;
                    
                    picEncode.Visible = false;
                    richLog.Visible = true;
                    btnClear.Enabled = false;
                    richLog.BringToFront();
                    break;
            }
            this.Update();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void fldBarcodeText_TextChanged(object sender, EventArgs e)
        {
            lblLength.Text = fldBarcodeText.Text.Length + "";
        }

        private void btnSetOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fldOutpuFolder.Text.Length > 0)
            {
                fbd.SelectedPath = fldOutpuFolder.Text;
            }

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                fldOutpuFolder.Text = fbd.SelectedPath;
            }
        }

        private void btnGetListFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (fldInputFile.Text.Length > 0)
            {
                ofd.FileName = fldInputFile.Text;
            }

            ofd.Filter = "TSV files (*.tsv)|*.tsv|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fldInputFile.Text = ofd.FileName;
            }
        }

        private void btnEncodeList_Click(object sender, EventArgs e)
        {
            richLog.Text = "";
            if (!(fldInputFile.Text.Length > 0))
            {
                MessageBox.Show("Please select an input file before continuing.", "No input file selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnGetListFile.Focus();
                return;
            }

            if (!(fldOutpuFolder.Text.Length > 0))
            {
                MessageBox.Show("Please select a folder to save the barcodes.", "No folder selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnSetOutputPath.Focus();
                return;
            }

            BarcodeFormat fm;
            if (barcodeFormat.TryGetValue(cmbBarcodeType.Text, out fm))
            {
                processListFile(
                    fldInputFile.Text,
                    fldOutpuFolder.Text,
                    "",
                    "",
                    (int)numHeight.Value,
                    (int)numWidth.Value,
                    fm,
                    richLog);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmAbout();
            f.ShowDialog();
        }

        private void scriptFileFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmScriptFileFormat();
            f.Show();
        }
    }
}
