using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjectFolders));
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Label11 = new Label();
            _cmdAPI = new Button();
            _cmdAPI.Click += new EventHandler(CmdAPI_Click);
            _cmdRyw12 = new Button();
            _cmdRyw12.Click += new EventHandler(CmdRyw12_Click);
            txtAPIFolder = new TextBox();
            txtRwy12Folder = new TextBox();
            _cmdASD = new Button();
            _cmdASD.Click += new EventHandler(CmdASD_Click);
            txtASDFolder = new TextBox();
            _cmdLibObjects = new Button();
            _cmdLibObjects.Click += new EventHandler(CmdLibObjects_Click);
            txtLibObjectsFolder = new TextBox();
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            SuspendLayout();
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.Transparent;
            Label8.Cursor = Cursors.Default;
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(12, 48);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(138, 13);
            Label8.TabIndex = 85;
            Label8.Text = "Path to Rwy12 programme :";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.Transparent;
            Label9.Cursor = Cursors.Default;
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(12, 87);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(137, 13);
            Label9.TabIndex = 86;
            Label9.Text = "Path to API macros (*.API) :";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.Transparent;
            Label10.Cursor = Cursors.Default;
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(12, 126);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(145, 13);
            Label10.TabIndex = 89;
            Label10.Text = "Path to ASD macros (*.SCM):";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.BackColor = Color.Transparent;
            Label11.Cursor = Cursors.Default;
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(12, 9);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(117, 13);
            Label11.TabIndex = 92;
            Label11.Text = "Path to Library Objects:";
            // 
            // cmdAPI
            // 
            _cmdAPI.BackColor = Color.Transparent;
            _cmdAPI.Cursor = Cursors.Default;
            _cmdAPI.ForeColor = SystemColors.ControlText;
            _cmdAPI.Location = new Point(357, 101);
            _cmdAPI.Name = "_cmdAPI";
            _cmdAPI.RightToLeft = RightToLeft.No;
            _cmdAPI.Size = new Size(31, 22);
            _cmdAPI.TabIndex = 81;
            _cmdAPI.Text = "...";
            _cmdAPI.UseVisualStyleBackColor = false;
            // 
            // cmdRyw12
            // 
            _cmdRyw12.BackColor = Color.Transparent;
            _cmdRyw12.Cursor = Cursors.Default;
            _cmdRyw12.ForeColor = SystemColors.ControlText;
            _cmdRyw12.Location = new Point(357, 62);
            _cmdRyw12.Name = "_cmdRyw12";
            _cmdRyw12.RightToLeft = RightToLeft.No;
            _cmdRyw12.Size = new Size(31, 22);
            _cmdRyw12.TabIndex = 82;
            _cmdRyw12.Text = "...";
            _cmdRyw12.UseVisualStyleBackColor = false;
            // 
            // txtAPIFolder
            // 
            txtAPIFolder.AcceptsReturn = true;
            txtAPIFolder.BackColor = SystemColors.Window;
            txtAPIFolder.Cursor = Cursors.IBeam;
            txtAPIFolder.ForeColor = SystemColors.WindowText;
            txtAPIFolder.Location = new Point(15, 103);
            txtAPIFolder.MaxLength = 0;
            txtAPIFolder.Name = "txtAPIFolder";
            txtAPIFolder.RightToLeft = RightToLeft.No;
            txtAPIFolder.Size = new Size(326, 20);
            txtAPIFolder.TabIndex = 83;
            // 
            // txtRwy12Folder
            // 
            txtRwy12Folder.AcceptsReturn = true;
            txtRwy12Folder.BackColor = SystemColors.Window;
            txtRwy12Folder.Cursor = Cursors.IBeam;
            txtRwy12Folder.ForeColor = SystemColors.WindowText;
            txtRwy12Folder.Location = new Point(15, 64);
            txtRwy12Folder.MaxLength = 0;
            txtRwy12Folder.Name = "txtRwy12Folder";
            txtRwy12Folder.RightToLeft = RightToLeft.No;
            txtRwy12Folder.Size = new Size(326, 20);
            txtRwy12Folder.TabIndex = 84;
            // 
            // cmdASD
            // 
            _cmdASD.BackColor = Color.Transparent;
            _cmdASD.Cursor = Cursors.Default;
            _cmdASD.ForeColor = SystemColors.ControlText;
            _cmdASD.Location = new Point(357, 140);
            _cmdASD.Name = "_cmdASD";
            _cmdASD.RightToLeft = RightToLeft.No;
            _cmdASD.Size = new Size(31, 22);
            _cmdASD.TabIndex = 87;
            _cmdASD.Text = "...";
            _cmdASD.UseVisualStyleBackColor = false;
            // 
            // txtASDFolder
            // 
            txtASDFolder.AcceptsReturn = true;
            txtASDFolder.BackColor = SystemColors.Window;
            txtASDFolder.Cursor = Cursors.IBeam;
            txtASDFolder.ForeColor = SystemColors.WindowText;
            txtASDFolder.Location = new Point(15, 142);
            txtASDFolder.MaxLength = 0;
            txtASDFolder.Name = "txtASDFolder";
            txtASDFolder.RightToLeft = RightToLeft.No;
            txtASDFolder.Size = new Size(326, 20);
            txtASDFolder.TabIndex = 88;
            // 
            // cmdLibObjects
            // 
            _cmdLibObjects.BackColor = Color.Transparent;
            _cmdLibObjects.Cursor = Cursors.Default;
            _cmdLibObjects.ForeColor = SystemColors.ControlText;
            _cmdLibObjects.Location = new Point(357, 23);
            _cmdLibObjects.Name = "_cmdLibObjects";
            _cmdLibObjects.RightToLeft = RightToLeft.No;
            _cmdLibObjects.Size = new Size(31, 22);
            _cmdLibObjects.TabIndex = 90;
            _cmdLibObjects.Text = "...";
            _cmdLibObjects.UseVisualStyleBackColor = false;
            // 
            // txtLibObjectsFolder
            // 
            txtLibObjectsFolder.AcceptsReturn = true;
            txtLibObjectsFolder.BackColor = SystemColors.Window;
            txtLibObjectsFolder.Cursor = Cursors.IBeam;
            txtLibObjectsFolder.ForeColor = SystemColors.WindowText;
            txtLibObjectsFolder.Location = new Point(15, 25);
            txtLibObjectsFolder.MaxLength = 0;
            txtLibObjectsFolder.Name = "txtLibObjectsFolder";
            txtLibObjectsFolder.RightToLeft = RightToLeft.No;
            txtLibObjectsFolder.Size = new Size(326, 20);
            txtLibObjectsFolder.TabIndex = 91;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(334, 178);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(54, 25);
            _cmdOK.TabIndex = 94;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(262, 178);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(54, 25);
            _cmdCancel.TabIndex = 93;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // FrmObjectFolders
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 218);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(Label8);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label11);
            Controls.Add(_cmdAPI);
            Controls.Add(_cmdRyw12);
            Controls.Add(txtAPIFolder);
            Controls.Add(txtRwy12Folder);
            Controls.Add(_cmdASD);
            Controls.Add(txtASDFolder);
            Controls.Add(_cmdLibObjects);
            Controls.Add(txtLibObjectsFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmObjectFolders";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Object Folders";
            Load += new EventHandler(FrmObjectFolders_Load);
            ResumeLayout(false);
            PerformLayout();
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