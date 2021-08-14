using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTilesServers));
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.ckMapServer = new System.Windows.Forms.CheckBox();
            this._ListMapServers = new System.Windows.Forms.ListBox();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(209, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 108);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Label1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 9);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(109, 13);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Available Tile Servers";
            // 
            // ckMapServer
            // 
            this.ckMapServer.AutoSize = true;
            this.ckMapServer.Enabled = false;
            this.ckMapServer.Location = new System.Drawing.Point(15, 151);
            this.ckMapServer.Name = "ckMapServer";
            this.ckMapServer.Size = new System.Drawing.Size(15, 14);
            this.ckMapServer.TabIndex = 5;
            this.ckMapServer.UseVisualStyleBackColor = true;
            // 
            // _ListMapServers
            // 
            this._ListMapServers.Enabled = false;
            this._ListMapServers.FormattingEnabled = true;
            this._ListMapServers.Location = new System.Drawing.Point(15, 25);
            this._ListMapServers.Name = "_ListMapServers";
            this._ListMapServers.Size = new System.Drawing.Size(182, 108);
            this._ListMapServers.TabIndex = 4;
            this._ListMapServers.SelectedIndexChanged += new System.EventHandler(this.ListMapServers_SelectedIndexChanged);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(286, 145);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(54, 25);
            this._cmdOK.TabIndex = 28;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(212, 145);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(54, 25);
            this._cmdCancel.TabIndex = 27;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // frmTilesServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 181);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.ckMapServer);
            this.Controls.Add(this._ListMapServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTilesServers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Tile Servers";
            this.Load += new System.EventHandler(this.frmTilesServers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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