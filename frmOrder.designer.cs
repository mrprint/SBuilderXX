using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            ToolTip1 = new ToolTip(components);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            lstObject = new ListBox();
            _cmdDOWN = new Button();
            _cmdDOWN.Click += new EventHandler(CmdDOWN_Click);
            _cmdUP = new Button();
            _cmdUP.Click += new EventHandler(CmdUp_Click);
            Label1 = new Label();
            SuspendLayout();
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(435, 177);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(61, 25);
            _cmdOK.TabIndex = 4;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(435, 136);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(61, 25);
            _cmdCancel.TabIndex = 3;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // lstObject
            // 
            lstObject.BackColor = SystemColors.Window;
            lstObject.Cursor = Cursors.Default;
            lstObject.Font = new Font("Courier New", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstObject.ForeColor = SystemColors.WindowText;
            lstObject.ItemHeight = 15;
            lstObject.Location = new Point(12, 33);
            lstObject.Name = "lstObject";
            lstObject.RightToLeft = RightToLeft.No;
            lstObject.Size = new Size(400, 169);
            lstObject.TabIndex = 2;
            // 
            // cmdDOWN
            // 
            _cmdDOWN.BackColor = SystemColors.Control;
            _cmdDOWN.Cursor = Cursors.Default;
            _cmdDOWN.ForeColor = SystemColors.ControlText;
            _cmdDOWN.Image = (Image)resources.GetObject("cmdDOWN.Image");
            _cmdDOWN.Location = new Point(450, 78);
            _cmdDOWN.Name = "_cmdDOWN";
            _cmdDOWN.RightToLeft = RightToLeft.No;
            _cmdDOWN.Size = new Size(28, 28);
            _cmdDOWN.TabIndex = 1;
            _cmdDOWN.TextAlign = ContentAlignment.BottomCenter;
            _cmdDOWN.UseVisualStyleBackColor = false;
            // 
            // cmdUP
            // 
            _cmdUP.BackColor = SystemColors.Control;
            _cmdUP.Cursor = Cursors.Default;
            _cmdUP.ForeColor = SystemColors.ControlText;
            _cmdUP.Image = (Image)resources.GetObject("cmdUP.Image");
            _cmdUP.Location = new Point(450, 39);
            _cmdUP.Name = "_cmdUP";
            _cmdUP.RightToLeft = RightToLeft.No;
            _cmdUP.Size = new Size(28, 28);
            _cmdUP.TabIndex = 0;
            _cmdUP.TextAlign = ContentAlignment.BottomCenter;
            _cmdUP.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(12, 15);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(364, 19);
            Label1.TabIndex = 5;
            Label1.Text = "Select the object and use the arrows to change the order";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(513, 215);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(lstObject);
            Controls.Add(_cmdDOWN);
            Controls.Add(_cmdUP);
            Controls.Add(Label1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrder";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Object drawing order";
            Load += new EventHandler(FrmOrder_Load);
            ResumeLayout(false);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}