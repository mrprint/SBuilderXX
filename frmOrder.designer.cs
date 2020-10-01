using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmOrder
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FrmOrder() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTip1;
        private Button _cmdOK;

        public Button cmdOK
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

        public Button cmdCancel
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

        public ListBox lstObject;
        private Button _cmdDOWN;

        public Button cmdDOWN
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDOWN;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDOWN != null)
                {
                    _cmdDOWN.Click -= CmdDOWN_Click;
                }

                _cmdDOWN = value;
                if (_cmdDOWN != null)
                {
                    _cmdDOWN.Click += CmdDOWN_Click;
                }
            }
        }

        private Button _cmdUP;

        public Button cmdUP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUP != null)
                {
                    _cmdUP.Click -= CmdUp_Click;
                }

                _cmdUP = value;
                if (_cmdUP != null)
                {
                    _cmdUP.Click += CmdUp_Click;
                }
            }
        }

        public Label Label1;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.lstObject = new System.Windows.Forms.ListBox();
            this._cmdDOWN = new System.Windows.Forms.Button();
            this._cmdUP = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(435, 177);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(61, 25);
            this._cmdOK.TabIndex = 4;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(435, 136);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(61, 25);
            this._cmdCancel.TabIndex = 3;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // lstObject
            // 
            this.lstObject.BackColor = System.Drawing.SystemColors.Window;
            this.lstObject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstObject.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstObject.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstObject.ItemHeight = 15;
            this.lstObject.Location = new System.Drawing.Point(12, 33);
            this.lstObject.Name = "lstObject";
            this.lstObject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstObject.Size = new System.Drawing.Size(400, 169);
            this.lstObject.TabIndex = 2;
            // 
            // _cmdDOWN
            // 
            this._cmdDOWN.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDOWN.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDOWN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDOWN.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDOWN.Image")));
            this._cmdDOWN.Location = new System.Drawing.Point(450, 78);
            this._cmdDOWN.Name = "_cmdDOWN";
            this._cmdDOWN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDOWN.Size = new System.Drawing.Size(28, 28);
            this._cmdDOWN.TabIndex = 1;
            this._cmdDOWN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDOWN.UseVisualStyleBackColor = false;
            this._cmdDOWN.Click += new System.EventHandler(this.CmdDOWN_Click);
            // 
            // _cmdUP
            // 
            this._cmdUP.BackColor = System.Drawing.SystemColors.Control;
            this._cmdUP.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdUP.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUP.Image = ((System.Drawing.Image)(resources.GetObject("_cmdUP.Image")));
            this._cmdUP.Location = new System.Drawing.Point(450, 39);
            this._cmdUP.Name = "_cmdUP";
            this._cmdUP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUP.Size = new System.Drawing.Size(28, 28);
            this._cmdUP.TabIndex = 0;
            this._cmdUP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUP.UseVisualStyleBackColor = false;
            this._cmdUP.Click += new System.EventHandler(this.CmdUp_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(364, 19);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Select the object and use the arrows to change the order";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(513, 215);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.lstObject);
            this.Controls.Add(this._cmdDOWN);
            this.Controls.Add(this._cmdUP);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(3, 29);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Object drawing order";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.ResumeLayout(false);

        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}