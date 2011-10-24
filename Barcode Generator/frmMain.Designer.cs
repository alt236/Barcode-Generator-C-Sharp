namespace BarcodeGenerator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picEncode = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.fldOutpuFolder = new System.Windows.Forms.TextBox();
            this.btnGetListFile = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cmbBarcodeType = new System.Windows.Forms.ComboBox();
            this.btnSetOutputPath = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.fldBarcodeText = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.grpBoxSingleBarcode = new System.Windows.Forms.GroupBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grpFileLocations = new System.Windows.Forms.GroupBox();
            this.btnEncodeList = new System.Windows.Forms.Button();
            this.fldInputFile = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelEncoder = new System.Windows.Forms.Panel();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grpBarcodeProperties = new System.Windows.Forms.GroupBox();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptFileFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).BeginInit();
            this.grpBoxSingleBarcode.SuspendLayout();
            this.grpFileLocations.SuspendLayout();
            this.panelEncoder.SuspendLayout();
            this.grpBarcodeProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picEncode
            // 
            this.picEncode.BackColor = System.Drawing.Color.White;
            this.picEncode.Location = new System.Drawing.Point(3, 3);
            this.picEncode.Name = "picEncode";
            this.picEncode.Size = new System.Drawing.Size(128, 78);
            this.picEncode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEncode.TabIndex = 1;
            this.picEncode.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(464, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fldOutpuFolder
            // 
            this.fldOutpuFolder.Location = new System.Drawing.Point(106, 42);
            this.fldOutpuFolder.Name = "fldOutpuFolder";
            this.fldOutpuFolder.ReadOnly = true;
            this.fldOutpuFolder.Size = new System.Drawing.Size(434, 20);
            this.fldOutpuFolder.TabIndex = 3;
            // 
            // btnGetListFile
            // 
            this.btnGetListFile.Location = new System.Drawing.Point(546, 16);
            this.btnGetListFile.Name = "btnGetListFile";
            this.btnGetListFile.Size = new System.Drawing.Size(75, 23);
            this.btnGetListFile.TabIndex = 4;
            this.btnGetListFile.Text = "Browse";
            this.btnGetListFile.UseVisualStyleBackColor = true;
            this.btnGetListFile.Click += new System.EventHandler(this.btnGetListFile_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(6, 42);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(74, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Output Folder:";
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncode.Location = new System.Drawing.Point(307, 105);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(151, 23);
            this.btnEncode.TabIndex = 54;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // cmbBarcodeType
            // 
            this.cmbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarcodeType.FormattingEnabled = true;
            this.cmbBarcodeType.Location = new System.Drawing.Point(389, 28);
            this.cmbBarcodeType.Name = "cmbBarcodeType";
            this.cmbBarcodeType.Size = new System.Drawing.Size(226, 21);
            this.cmbBarcodeType.Sorted = true;
            this.cmbBarcodeType.TabIndex = 53;
            this.cmbBarcodeType.SelectedIndexChanged += new System.EventHandler(this.cmbBarcodeType_SelectedIndexChanged);
            // 
            // btnSetOutputPath
            // 
            this.btnSetOutputPath.Location = new System.Drawing.Point(546, 42);
            this.btnSetOutputPath.Name = "btnSetOutputPath";
            this.btnSetOutputPath.Size = new System.Drawing.Size(75, 23);
            this.btnSetOutputPath.TabIndex = 5;
            this.btnSetOutputPath.Text = "Browse";
            this.btnSetOutputPath.UseVisualStyleBackColor = true;
            this.btnSetOutputPath.Click += new System.EventHandler(this.btnSetOutputPath_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(306, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 13);
            this.Label2.TabIndex = 52;
            this.Label2.Text = "Barcode Type:";
            // 
            // fldBarcodeText
            // 
            this.fldBarcodeText.Location = new System.Drawing.Point(3, 19);
            this.fldBarcodeText.Multiline = true;
            this.fldBarcodeText.Name = "fldBarcodeText";
            this.fldBarcodeText.Size = new System.Drawing.Size(612, 80);
            this.fldBarcodeText.TabIndex = 6;
            this.fldBarcodeText.TextChanged += new System.EventHandler(this.fldBarcodeText_TextChanged);
            // 
            // cmbOperation
            // 
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(74, 28);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(226, 21);
            this.cmbOperation.TabIndex = 51;
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 50;
            this.Label3.Text = "Operation:";
            // 
            // grpBoxSingleBarcode
            // 
            this.grpBoxSingleBarcode.Controls.Add(this.btnSave);
            this.grpBoxSingleBarcode.Controls.Add(this.lblLength);
            this.grpBoxSingleBarcode.Controls.Add(this.label8);
            this.grpBoxSingleBarcode.Controls.Add(this.btnEncode);
            this.grpBoxSingleBarcode.Controls.Add(this.fldBarcodeText);
            this.grpBoxSingleBarcode.Location = new System.Drawing.Point(12, 167);
            this.grpBoxSingleBarcode.Name = "grpBoxSingleBarcode";
            this.grpBoxSingleBarcode.Size = new System.Drawing.Size(630, 140);
            this.grpBoxSingleBarcode.TabIndex = 49;
            this.grpBoxSingleBarcode.TabStop = false;
            this.grpBoxSingleBarcode.Text = "Single Barcode";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(55, 106);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(16, 13);
            this.lblLength.TabIndex = 56;
            this.lblLength.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Length:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(493, 568);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 23);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Height";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFileLocations
            // 
            this.grpFileLocations.Controls.Add(this.btnEncodeList);
            this.grpFileLocations.Controls.Add(this.btnSetOutputPath);
            this.grpFileLocations.Controls.Add(this.btnGetListFile);
            this.grpFileLocations.Controls.Add(this.fldOutpuFolder);
            this.grpFileLocations.Controls.Add(this.Label4);
            this.grpFileLocations.Controls.Add(this.fldInputFile);
            this.grpFileLocations.Controls.Add(this.Label1);
            this.grpFileLocations.Location = new System.Drawing.Point(12, 55);
            this.grpFileLocations.Name = "grpFileLocations";
            this.grpFileLocations.Size = new System.Drawing.Size(630, 106);
            this.grpFileLocations.TabIndex = 48;
            this.grpFileLocations.TabStop = false;
            this.grpFileLocations.Text = "Barcode Script File options:";
            // 
            // btnEncodeList
            // 
            this.btnEncodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncodeList.Location = new System.Drawing.Point(470, 77);
            this.btnEncodeList.Name = "btnEncodeList";
            this.btnEncodeList.Size = new System.Drawing.Size(151, 23);
            this.btnEncodeList.TabIndex = 56;
            this.btnEncodeList.Text = "Encode List";
            this.btnEncodeList.UseVisualStyleBackColor = true;
            this.btnEncodeList.Click += new System.EventHandler(this.btnEncodeList_Click);
            // 
            // fldInputFile
            // 
            this.fldInputFile.Location = new System.Drawing.Point(106, 16);
            this.fldInputFile.Name = "fldInputFile";
            this.fldInputFile.ReadOnly = true;
            this.fldInputFile.Size = new System.Drawing.Size(434, 20);
            this.fldInputFile.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Barcode script file:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Width";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEncoder
            // 
            this.panelEncoder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEncoder.AutoScroll = true;
            this.panelEncoder.BackColor = System.Drawing.Color.White;
            this.panelEncoder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEncoder.Controls.Add(this.richLog);
            this.panelEncoder.Controls.Add(this.picEncode);
            this.panelEncoder.Location = new System.Drawing.Point(12, 313);
            this.panelEncoder.Name = "panelEncoder";
            this.panelEncoder.Size = new System.Drawing.Size(473, 278);
            this.panelEncoder.TabIndex = 44;
            // 
            // richLog
            // 
            this.richLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richLog.BackColor = System.Drawing.SystemColors.Control;
            this.richLog.Location = new System.Drawing.Point(-1, -1);
            this.richLog.Name = "richLog";
            this.richLog.ReadOnly = true;
            this.richLog.Size = new System.Drawing.Size(473, 278);
            this.richLog.TabIndex = 2;
            this.richLog.Text = "";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Location = new System.Drawing.Point(0, 594);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(656, 22);
            this.StatusStrip1.TabIndex = 46;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // grpBarcodeProperties
            // 
            this.grpBarcodeProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBarcodeProperties.Controls.Add(this.numWidth);
            this.grpBarcodeProperties.Controls.Add(this.label6);
            this.grpBarcodeProperties.Controls.Add(this.label7);
            this.grpBarcodeProperties.Controls.Add(this.numHeight);
            this.grpBarcodeProperties.Location = new System.Drawing.Point(491, 313);
            this.grpBarcodeProperties.Name = "grpBarcodeProperties";
            this.grpBarcodeProperties.Size = new System.Drawing.Size(151, 76);
            this.grpBarcodeProperties.TabIndex = 45;
            this.grpBarcodeProperties.TabStop = false;
            this.grpBarcodeProperties.Text = "Barcode Properties";
            // 
            // numWidth
            // 
            this.numWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numWidth.Location = new System.Drawing.Point(74, 19);
            this.numWidth.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(66, 20);
            this.numWidth.TabIndex = 26;
            this.numWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numHeight.Location = new System.Drawing.Point(74, 45);
            this.numHeight.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(66, 20);
            this.numHeight.TabIndex = 27;
            this.numHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptFileFormatToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // scriptFileFormatToolStripMenuItem
            // 
            this.scriptFileFormatToolStripMenuItem.Name = "scriptFileFormatToolStripMenuItem";
            this.scriptFileFormatToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.scriptFileFormatToolStripMenuItem.Text = "Script file format";
            this.scriptFileFormatToolStripMenuItem.Click += new System.EventHandler(this.scriptFileFormatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 616);
            this.Controls.Add(this.cmbBarcodeType);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.grpBoxSingleBarcode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpFileLocations);
            this.Controls.Add(this.panelEncoder);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpBarcodeProperties);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Barcode Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEncode)).EndInit();
            this.grpBoxSingleBarcode.ResumeLayout(false);
            this.grpBoxSingleBarcode.PerformLayout();
            this.grpFileLocations.ResumeLayout(false);
            this.grpFileLocations.PerformLayout();
            this.panelEncoder.ResumeLayout(false);
            this.panelEncoder.PerformLayout();
            this.grpBarcodeProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEncode;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox fldOutpuFolder;
        internal System.Windows.Forms.Button btnGetListFile;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnEncode;
        internal System.Windows.Forms.ComboBox cmbBarcodeType;
        internal System.Windows.Forms.Button btnSetOutputPath;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox fldBarcodeText;
        internal System.Windows.Forms.ComboBox cmbOperation;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox grpBoxSingleBarcode;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox grpFileLocations;
        internal System.Windows.Forms.TextBox fldInputFile;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelEncoder;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.GroupBox grpBarcodeProperties;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richLog;
        internal System.Windows.Forms.Button btnEncodeList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptFileFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

