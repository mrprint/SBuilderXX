using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    public partial class frmTilesServers : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTilesServers));
            Label1 = new Label();
            Label6 = new Label();
            ckMapServer = new CheckBox();
            _ListMapServers = new ListBox();
            _ListMapServers.SelectedIndexChanged += new EventHandler(ListMapServers_SelectedIndexChanged);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(cmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(cmdCancel_Click);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.Location = new Point(209, 25);
            Label1.Name = "Label1";
            Label1.Size = new Size(131, 108);
            Label1.TabIndex = 7;
            Label1.Text = "Label1";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(12, 9);
            Label6.Name = "Label6";
            Label6.Size = new Size(109, 13);
            Label6.TabIndex = 6;
            Label6.Text = "Available Tile Servers";
            // 
            // ckMapServer
            // 
            ckMapServer.AutoSize = true;
            ckMapServer.Enabled = false;
            ckMapServer.Location = new Point(15, 151);
            ckMapServer.Name = "ckMapServer";
            ckMapServer.Size = new Size(15, 14);
            ckMapServer.TabIndex = 5;
            ckMapServer.UseVisualStyleBackColor = true;
            // 
            // ListMapServers
            // 
            _ListMapServers.Enabled = false;
            _ListMapServers.FormattingEnabled = true;
            _ListMapServers.Location = new Point(15, 25);
            _ListMapServers.Name = "_ListMapServers";
            _ListMapServers.Size = new Size(182, 108);
            _ListMapServers.TabIndex = 4;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(286, 145);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(54, 25);
            _cmdOK.TabIndex = 28;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(212, 145);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(54, 25);
            _cmdCancel.TabIndex = 27;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmTilesServers
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 181);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(Label1);
            Controls.Add(Label6);
            Controls.Add(ckMapServer);
            Controls.Add(_ListMapServers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTilesServers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Tile Servers";
            Load += new EventHandler(frmTilesServers_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Label Label6;
        internal CheckBox ckMapServer;
        private ListBox _ListMapServers;

        internal ListBox ListMapServers
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListMapServers;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListMapServers != null)
                {
                    _ListMapServers.SelectedIndexChanged -= ListMapServers_SelectedIndexChanged;
                }

                _ListMapServers = value;
                if (_ListMapServers != null)
                {
                    _ListMapServers.SelectedIndexChanged += ListMapServers_SelectedIndexChanged;
                }
            }
        }

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
                    _cmdOK.Click -= cmdOK_Click;
                }

                _cmdOK = value;
                if (_cmdOK != null)
                {
                    _cmdOK.Click += cmdOK_Click;
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
                    _cmdCancel.Click -= cmdCancel_Click;
                }

                _cmdCancel = value;
                if (_cmdCancel != null)
                {
                    _cmdCancel.Click += cmdCancel_Click;
                }
            }
        }
    }
}