using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.Security.Cryptography;
using System.IO;

namespace BarcodeGenerator
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.IconMain;

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Dictionary<String, String> dictionaryOfProperties = GetAssemblyInfoDictionary(currentAssembly);

            //Dim dictionaryOfProperties As Dictionary(Of String, String) = GetAssemblyInfoDictionary(currentAssembly);

            lblName.Text = dictionaryOfProperties["AssemblyName"];
            lblVersion.Text = "v" + dictionaryOfProperties["Version"];
            lblCopyright.Text = dictionaryOfProperties["Copyright"];

            fldAck.Text = Properties.Resources.acknowledgements;
            fldChange.Text = Properties.Resources.changelog;
            fldNotes.Text = Properties.Resources.notes;

            if (fldAck.Text.Trim().Length == 0)
            {
                TabControl1.TabPages.RemoveAt(TabControl1.TabPages.IndexOf(tpAcknowledgements));
            }
            if (fldChange.Text.Trim().Length == 0)
            {
                TabControl1.TabPages.RemoveAt(TabControl1.TabPages.IndexOf(tpChangelog));
            }
            if (fldNotes.Text.Trim().Length == 0)
            {
                TabControl1.TabPages.RemoveAt(TabControl1.TabPages.IndexOf(tpNotes));
            }

            TabControl1.SelectedIndex = 0;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private Dictionary<String, String> GetAssemblyInfoDictionary(Assembly selectedAssembly)
        {
            //Create the dictionary 
            Dictionary<String, String> dictionaryOfProperties = new Dictionary<String, String>();

            //Dim dictionaryOfProperties As New Dictionary(Of String, String)();

            //get the location of the assembly 
            //Dim assemblyPath As String = selectedAssembly.Location

            //add the assembly location to out dictionary 
            //dictionaryOfProperties.Add("AssemblyLocation", assemblyPath)

            //create the AssemblyName object based on our Assembly 
            //this will enable us to get the version information 
            //and other properties related to our assembly 
            System.Reflection.AssemblyName assemblyName = selectedAssembly.GetName();

            //add the FullName of our assembly 
            dictionaryOfProperties.Add("AssemblyFullName", assemblyName.FullName);
            //add the Name of the assembly
            dictionaryOfProperties.Add("AssemblyName", assemblyName.Name);

            //add the assembly version information 
            dictionaryOfProperties.Add("Version", assemblyName.Version.ToString());
            dictionaryOfProperties.Add("Version.Major", assemblyName.Version.Major.ToString());
            dictionaryOfProperties.Add("Version.Minor", assemblyName.Version.Minor.ToString());
            dictionaryOfProperties.Add("Version.Build", assemblyName.Version.Build.ToString());
            dictionaryOfProperties.Add("Version.Revision", assemblyName.Version.Revision.ToString());

            //Get the Copyright info.
            AssemblyCopyrightAttribute copyrightInstance = (AssemblyCopyrightAttribute)(AssemblyCopyrightAttribute.GetCustomAttribute(System.Reflection.Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute)));
            dictionaryOfProperties.Add("Copyright", copyrightInstance.Copyright);

            //add the creation time 
            //Dim creationTime As DateTime = File.GetCreationTime(assemblyPath)
            //dictionaryOfProperties.Add("CreationTime", creationTime.ToString())

            //add the last write time 
            //Dim lastWriteTime As DateTime = File.GetLastWriteTime(assemblyPath)
            //dictionaryOfProperties.Add("LastWriteTime", creationTime.ToString())

            //return our dictionary obeject 
            return dictionaryOfProperties;
        }
    }
}
