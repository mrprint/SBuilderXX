using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    public partial class FrmObjectFolders : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjectFolders));
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this._cmdAPI = new System.Windows.Forms.Button();
            this._cmdRyw12 = new System.Windows.Forms.Button();
            this.txtAPIFolder = new System.Windows.Forms.TextBox();
            this.txtRwy12Folder = new System.Windows.Forms.TextBox();
            this._cmdASD = new System.Windows.Forms.Button();
            this.txtASDFolder = new System.Windows.Forms.TextBox();
            this._cmdLibObjects = new System.Windows.Forms.Button();
            this.txtLibObjectsFolder = new System.Windows.Forms.TextBox();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(12, 48);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(138, 13);
            this.Label8.TabIndex = 85;
            this.Label8.Text = "Path to Rwy12 programme :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(12, 87);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(137, 13);
            this.Label9.TabIndex = 86;
            this.Label9.Text = "Path to API macros (*.API) :";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(12, 126);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(145, 13);
            this.Label10.TabIndex = 89;
            this.Label10.Text = "Path to ASD macros (*.SCM):";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(12, 9);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(117, 13);
            this.Label11.TabIndex = 92;
            this.Label11.Text = "Path to Library Objects:";
            // 
            // _cmdAPI
            // 
            this._cmdAPI.BackColor = System.Drawing.Color.Transparent;
            this._cmdAPI.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAPI.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAPI.Location = new System.Drawing.Point(357, 101);
            this._cmdAPI.Name = "_cmdAPI";
            this._cmdAPI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAPI.Size = new System.Drawing.Size(31, 22);
            this._cmdAPI.TabIndex = 81;
            this._cmdAPI.Text = "...";
            this._cmdAPI.UseVisualStyleBackColor = false;
            this._cmdAPI.Click += new System.EventHandler(this.CmdAPI_Click);
            // 
            // _cmdRyw12
            // 
            this._cmdRyw12.BackColor = System.Drawing.Color.Transparent;
            this._cmdRyw12.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdRyw12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdRyw12.Location = new System.Drawing.Point(357, 62);
            this._cmdRyw12.Name = "_cmdRyw12";
            this._cmdRyw12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdRyw12.Size = new System.Drawing.Size(31, 22);
            this._cmdRyw12.TabIndex = 82;
            this._cmdRyw12.Text = "...";
            this._cmdRyw12.UseVisualStyleBackColor = false;
            this._cmdRyw12.Click += new System.EventHandler(this.CmdRyw12_Click);
            // 
            // txtAPIFolder
            // 
            this.txtAPIFolder.AcceptsReturn = true;
            this.txtAPIFolder.BackColor = System.Drawing.SystemColors.Window;
            this.txtAPIFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAPIFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAPIFolder.Location = new System.Drawing.Point(15, 103);
            this.txtAPIFolder.MaxLength = 0;
            this.txtAPIFolder.Name = "txtAPIFolder";
            this.txtAPIFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAPIFolder.Size = new System.Drawing.Size(326, 20);
            this.txtAPIFolder.TabIndex = 83;
            // 
            // txtRwy12Folder
            // 
            this.txtRwy12Folder.AcceptsReturn = true;
            this.txtRwy12Folder.BackColor = System.Drawing.SystemColors.Window;
            this.txtRwy12Folder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRwy12Folder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRwy12Folder.Location = new System.Drawing.Point(15, 64);
            this.txtRwy12Folder.MaxLength = 0;
            this.txtRwy12Folder.Name = "txtRwy12Folder";
            this.txtRwy12Folder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRwy12Folder.Size = new System.Drawing.Size(326, 20);
            this.txtRwy12Folder.TabIndex = 84;
            // 
            // _cmdASD
            // 
            this._cmdASD.BackColor = System.Drawing.Color.Transparent;
            this._cmdASD.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdASD.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdASD.Location = new System.Drawing.Point(357, 140);
            this._cmdASD.Name = "_cmdASD";
            this._cmdASD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdASD.Size = new System.Drawing.Size(31, 22);
            this._cmdASD.TabIndex = 87;
            this._cmdASD.Text = "...";
            this._cmdASD.UseVisualStyleBackColor = false;
            this._cmdASD.Click += new System.EventHandler(this.CmdASD_Click);
            // 
            // txtASDFolder
            // 
            this.txtASDFolder.AcceptsReturn = true;
            this.txtASDFolder.BackColor = System.Drawing.SystemColors.Window;
            this.txtASDFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtASDFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtASDFolder.Location = new System.Drawing.Point(15, 142);
            this.txtASDFolder.MaxLength = 0;
            this.txtASDFolder.Name = "txtASDFolder";
            this.txtASDFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtASDFolder.Size = new System.Drawing.Size(326, 20);
            this.txtASDFolder.TabIndex = 88;
            // 
            // _cmdLibObjects
            // 
            this._cmdLibObjects.BackColor = System.Drawing.Color.Transparent;
            this._cmdLibObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLibObjects.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLibObjects.Location = new System.Drawing.Point(357, 23);
            this._cmdLibObjects.Name = "_cmdLibObjects";
            this._cmdLibObjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLibObjects.Size = new System.Drawing.Size(31, 22);
            this._cmdLibObjects.TabIndex = 90;
            this._cmdLibObjects.Text = "...";
            this._cmdLibObjects.UseVisualStyleBackColor = false;
            this._cmdLibObjects.Click += new System.EventHandler(this.CmdLibObjects_Click);
            // 
            // txtLibObjectsFolder
            // 
            this.txtLibObjectsFolder.AcceptsReturn = true;
            this.txtLibObjectsFolder.BackColor = System.Drawing.SystemColors.Window;
            this.txtLibObjectsFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibObjectsFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLibObjectsFolder.Location = new System.Drawing.Point(15, 25);
            this.txtLibObjectsFolder.MaxLength = 0;
            this.txtLibObjectsFolder.Name = "txtLibObjectsFolder";
            this.txtLibObjectsFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLibObjectsFolder.Size = new System.Drawing.Size(326, 20);
            this.txtLibObjectsFolder.TabIndex = 91;
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(334, 178);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(54, 25);
            this._cmdOK.TabIndex = 94;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(262, 178);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(54, 25);
            this._cmdCancel.TabIndex = 93;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // FrmObjectFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 218);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this._cmdAPI);
            this.Controls.Add(this._cmdRyw12);
            this.Controls.Add(this.txtAPIFolder);
            this.Controls.Add(this.txtRwy12Folder);
            this.Controls.Add(this._cmdASD);
            this.Controls.Add(this.txtASDFolder);
            this.Controls.Add(this._cmdLibObjects);
            this.Controls.Add(this.txtLibObjectsFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObjectFolders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Object Folders";
            this.Load += new System.EventHandler(this.FrmObjectFolders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Label Label8;
        public Label Label9;
        public Label Label10;
        public Label Label11;
        private Button _cmdAPI;

        public Button cmdAPI
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAPI;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAPI != null)
                {
                    _cmdAPI.Click -= CmdAPI_Click;
                }

                _cmdAPI = value;
                if (_cmdAPI != null)
                {
                    _cmdAPI.Click += CmdAPI_Click;
                }
            }
        }

        private Button _cmdRyw12;

        public Button cmdRyw12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRyw12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRyw12 != null)
                {
                    _cmdRyw12.Click -= CmdRyw12_Click;
                }

                _cmdRyw12 = value;
                if (_cmdRyw12 != null)
                {
                    _cmdRyw12.Click += CmdRyw12_Click;
                }
            }
        }

        public TextBox txtAPIFolder;
        public TextBox txtRwy12Folder;
        private Button _cmdASD;

        public Button cmdASD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdASD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdASD != null)
                {
                    _cmdASD.Click -= CmdASD_Click;
                }

                _cmdASD = value;
                if (_cmdASD != null)
                {
                    _cmdASD.Click += CmdASD_Click;
                }
            }
        }

        public TextBox txtASDFolder;
        private Button _cmdLibObjects;

        public Button cmdLibObjects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLibObjects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLibObjects != null)
                {
                    _cmdLibObjects.Click -= CmdLibObjects_Click;
                }

                _cmdLibObjects = value;
                if (_cmdLibObjects != null)
                {
                    _cmdLibObjects.Click += CmdLibObjects_Click;
                }
            }
        }

        public TextBox txtLibObjectsFolder;
        private Button _cmdOK;

        internal Button cmdOK
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdOK;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdOK != null)
                {
                    _cmdOK.Click -= CmdOK_Click;
                }

                _cmdOK = value;
                if (_cmdOK != null)
                {
                    _cmdOK.Click += CmdOK_Click;
                }
            }
        }

        private Button _cmdCancel;

        internal Button cmdCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCancel != null)
                {
                    _cmdCancel.Click -= CmdCancel_Click;
                }

                _cmdCancel = value;
                if (_cmdCancel != null)
                {
                    _cmdCancel.Click += CmdCancel_Click;
                }
            }
        }
    }
}