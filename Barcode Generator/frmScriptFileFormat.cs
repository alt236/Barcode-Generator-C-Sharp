using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace BarcodeGenerator
{
    public partial class frmScriptFileFormat : Form
    {
        public frmScriptFileFormat()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.IconMain;
            object empty = System.Reflection.Missing.Value;
            loadDocument();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void loadDocument()
        {
            //string[] a = Assembly.GetEntryAssembly().GetManifestResourceNames();

            //Console.WriteLine("*** " + a.Length);

            //foreach (string s in a)
            //{
            //    Console.WriteLine("*** " + s);
            //}
            
            string html = null;

            using (var s = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("BarcodeGenerator.instructions.script_file_info.htm"))
            
            using (var r = new StreamReader(s))
                html = r.ReadToEnd();

            webBrowser.DocumentText = html;
        }
    }
}
