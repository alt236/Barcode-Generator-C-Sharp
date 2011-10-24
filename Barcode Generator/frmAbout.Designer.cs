namespace BarcodeGenerator
{
    partial class frmAbout
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tpNotes = new System.Windows.Forms.TabPage();
            this.fldNotes = new System.Windows.Forms.TextBox();
            this.tpAcknowledgements = new System.Windows.Forms.TabPage();
            this.fldAck = new System.Windows.Forms.TextBox();
            this.fldChange = new System.Windows.Forms.TextBox();
            this.tpChangelog = new System.Windows.Forms.TabPage();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.tpNotes.SuspendLayout();
            this.tpAcknowledgements.SuspendLayout();
            this.tpChangelog.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.Location = new System.Drawing.Point(0, 123);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(350, 20);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Location = new System.Drawing.Point(0, 103);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(350, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpNotes
            // 
            this.tpNotes.Controls.Add(this.fldNotes);
            this.tpNotes.Location = new System.Drawing.Point(4, 22);
            this.tpNotes.Name = "tpNotes";
            this.tpNotes.Size = new System.Drawing.Size(342, 224);
            this.tpNotes.TabIndex = 2;
            this.tpNotes.Text = "Notes";
            // 
            // fldNotes
            // 
            this.fldNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldNotes.Location = new System.Drawing.Point(0, 0);
            this.fldNotes.Multiline = true;
            this.fldNotes.Name = "fldNotes";
            this.fldNotes.ReadOnly = true;
            this.fldNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fldNotes.Size = new System.Drawing.Size(342, 224);
            this.fldNotes.TabIndex = 1;
            // 
            // tpAcknowledgements
            // 
            this.tpAcknowledgements.Controls.Add(this.fldAck);
            this.tpAcknowledgements.Location = new System.Drawing.Point(4, 22);
            this.tpAcknowledgements.Name = "tpAcknowledgements";
            this.tpAcknowledgements.Size = new System.Drawing.Size(342, 224);
            this.tpAcknowledgements.TabIndex = 3;
            this.tpAcknowledgements.Text = "Acknowledgements";
            // 
            // fldAck
            // 
            this.fldAck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldAck.Location = new System.Drawing.Point(0, 0);
            this.fldAck.Multiline = true;
            this.fldAck.Name = "fldAck";
            this.fldAck.ReadOnly = true;
            this.fldAck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fldAck.Size = new System.Drawing.Size(342, 224);
            this.fldAck.TabIndex = 2;
            // 
            // fldChange
            // 
            this.fldChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldChange.Location = new System.Drawing.Point(0, 0);
            this.fldChange.Multiline = true;
            this.fldChange.Name = "fldChange";
            this.fldChange.ReadOnly = true;
            this.fldChange.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fldChange.Size = new System.Drawing.Size(342, 224);
            this.fldChange.TabIndex = 0;
            // 
            // tpChangelog
            // 
            this.tpChangelog.Controls.Add(this.fldChange);
            this.tpChangelog.Location = new System.Drawing.Point(4, 22);
            this.tpChangelog.Name = "tpChangelog";
            this.tpChangelog.Size = new System.Drawing.Size(342, 224);
            this.tpChangelog.TabIndex = 1;
            this.tpChangelog.Text = "Changelog";
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.tpChangelog);
            this.TabControl1.Controls.Add(this.tpNotes);
            this.TabControl1.Controls.Add(this.tpAcknowledgements);
            this.TabControl1.Location = new System.Drawing.Point(0, 1);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(350, 250);
            this.TabControl1.TabIndex = 8;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.lblCopyright);
            this.TabPage1.Controls.Add(this.lblVersion);
            this.TabPage1.Controls.Add(this.lblName);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(342, 224);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Info";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(0, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(350, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(267, 257);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 292);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.btnOK);
            this.Menu = this.mainMenu1;
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.tpNotes.ResumeLayout(false);
            this.tpNotes.PerformLayout();
            this.tpAcknowledgements.ResumeLayout(false);
            this.tpAcknowledgements.PerformLayout();
            this.tpChangelog.ResumeLayout(false);
            this.tpChangelog.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        internal System.Windows.Forms.Label lblCopyright;
        internal System.Windows.Forms.Label lblVersion;
        internal System.Windows.Forms.TabPage tpNotes;
        internal System.Windows.Forms.TextBox fldNotes;
        internal System.Windows.Forms.TabPage tpAcknowledgements;
        internal System.Windows.Forms.TextBox fldAck;
        internal System.Windows.Forms.TextBox fldChange;
        internal System.Windows.Forms.TabPage tpChangelog;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Button btnOK;

    }
}