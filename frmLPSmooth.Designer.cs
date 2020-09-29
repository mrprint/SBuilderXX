using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmLPSmooth : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLPSmooth));
            _chNoEnds = new CheckBox();
            _chNoEnds.CheckedChanged += new EventHandler(ChNoEnds_CheckedChanged);
            _chCorner = new CheckBox();
            _chCorner.CheckedChanged += new EventHandler(ChCorner_CheckedChanged);
            _txtDistance = new TextBox();
            _txtDistance.TextChanged += new EventHandler(TxtDistance_TextChanged);
            Label1 = new Label();
            Label2 = new Label();
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdSmooth = new Button();
            _cmdSmooth.Click += new EventHandler(CmdSmooth_Click);
            SuspendLayout();
            // 
            // chNoEnds
            // 
            _chNoEnds.Location = new Point(25, 85);
            _chNoEnds.Name = "_chNoEnds";
            _chNoEnds.Size = new Size(168, 44);
            _chNoEnds.TabIndex = 3;
            _chNoEnds.Text = "Do not smooth start/end segments (Lines only)";
            _chNoEnds.UseVisualStyleBackColor = true;
            // 
            // chCorner
            // 
            _chCorner.AutoSize = true;
            _chCorner.Location = new Point(25, 129);
            _chCorner.Name = "_chCorner";
            _chCorner.Size = new Size(158, 17);
            _chCorner.TabIndex = 4;
            _chCorner.Text = "Do not smooth sharp angles";
            _chCorner.UseVisualStyleBackColor = true;
            // 
            // txtDistance
            // 
            _txtDistance.Location = new Point(25, 152);
            _txtDistance.Name = "_txtDistance";
            _txtDistance.Size = new Size(70, 20);
            _txtDistance.TabIndex = 5;
            _txtDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.Location = new Point(22, 175);
            Label1.Name = "Label1";
            Label1.Size = new Size(147, 30);
            Label1.TabIndex = 6;
            Label1.Text = "Minimum Distance in meters between adjacent points";
            // 
            // Label2
            // 
            Label2.Location = new Point(25, 9);
            Label2.Name = "Label2";
            Label2.Size = new Size(225, 77);
            Label2.TabIndex = 7;
            Label2.Text = "By smoothing (or interpolating) a Line or Poly, you introduce more points except " + "when they become closer than the Minimum Distance shown below. Each time you pre" + "ss \"Smooth\" more points are inserted.";

            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(190, 174);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(61, 23);
            _cmdOK.TabIndex = 9;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(190, 98);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(60, 25);
            _cmdCancel.TabIndex = 10;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSmooth
            // 
            _cmdSmooth.Location = new Point(191, 135);
            _cmdSmooth.Name = "_cmdSmooth";
            _cmdSmooth.Size = new Size(60, 25);
            _cmdSmooth.TabIndex = 11;
            _cmdSmooth.Text = "Smooth";
            _cmdSmooth.UseVisualStyleBackColor = true;
            // 
            // frmLPSmooth
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 210);
            Controls.Add(_cmdSmooth);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdOK);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_txtDistance);
            Controls.Add(_chCorner);
            Controls.Add(_chNoEnds);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLPSmooth";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Line or Poly Smoothing";
            Load += new EventHandler(FrmLPSmooth_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox _chNoEnds;

        internal CheckBox chNoEnds
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chNoEnds;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chNoEnds != null)
                {
                    _chNoEnds.CheckedChanged -= ChNoEnds_CheckedChanged;
                }

                _chNoEnds = value;
                if (_chNoEnds != null)
                {
                    _chNoEnds.CheckedChanged += ChNoEnds_CheckedChanged;
                }
            }
        }

        private CheckBox _chCorner;

        internal CheckBox chCorner
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _chCorner;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chCorner != null)
                {
                    _chCorner.CheckedChanged -= ChCorner_CheckedChanged;
                }

                _chCorner = value;
                if (_chCorner != null)
                {
                    _chCorner.CheckedChanged += ChCorner_CheckedChanged;
                }
            }
        }

        private TextBox _txtDistance;

        internal TextBox txtDistance
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtDistance;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtDistance != null)
                {
                    _txtDistance.TextChanged -= TxtDistance_TextChanged;
                }

                _txtDistance = value;
                if (_txtDistance != null)
                {
                    _txtDistance.TextChanged += TxtDistance_TextChanged;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
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

        private Button _cmdSmooth;

        internal Button cmdSmooth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSmooth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSmooth != null)
                {
                    _cmdSmooth.Click -= CmdSmooth_Click;
                }

                _cmdSmooth = value;
                if (_cmdSmooth != null)
                {
                    _cmdSmooth.Click += CmdSmooth_Click;
                }
            }
        }
    }
}