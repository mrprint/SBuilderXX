using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmLPSample : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLPSample));
            _cmdSample = new Button();
            _cmdSample.Click += new EventHandler(CmdSample_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            Label2 = new Label();
            Label1 = new Label();
            _txtDistance = new TextBox();
            _txtDistance.Click += new EventHandler(TxtDistance_Click);
            SuspendLayout();
            // 
            // cmdSample
            // 
            _cmdSample.Location = new Point(99, 126);
            _cmdSample.Name = "_cmdSample";
            _cmdSample.Size = new Size(60, 25);
            _cmdSample.TabIndex = 19;
            _cmdSample.Text = "Sample";
            _cmdSample.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(18, 126);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(60, 25);
            _cmdCancel.TabIndex = 18;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(182, 127);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(61, 23);
            _cmdOK.TabIndex = 17;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.Location = new Point(15, 9);
            Label2.Name = "Label2";
            Label2.Size = new Size(239, 77);
            Label2.TabIndex = 16;
            Label2.Text = "By sampling (or decimating) a Line or Poly, points are deleted if there are adjac" + "ent points closer than the Minimum Distance shown below. Each time you press \"Sa" + "mple\" more points are deleted.";

            // 
            // Label1
            // 
            Label1.Location = new Point(96, 86);
            Label1.Name = "Label1";
            Label1.Size = new Size(147, 30);
            Label1.TabIndex = 15;
            Label1.Text = "Minimum Distance in meters between adjacent points";
            // 
            // txtDistance
            // 
            _txtDistance.Location = new Point(18, 89);
            _txtDistance.Name = "_txtDistance";
            _txtDistance.Size = new Size(70, 20);
            _txtDistance.TabIndex = 14;
            _txtDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // frmLPSample
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 166);
            Controls.Add(_cmdSample);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdOK);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_txtDistance);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLPSample";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SbuilderX - Line or Poly Sampling";
            Load += new EventHandler(FrmLPSample_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _cmdSample;

        internal Button cmdSample
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSample;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSample != null)
                {
                    _cmdSample.Click -= CmdSample_Click;
                }

                _cmdSample = value;
                if (_cmdSample != null)
                {
                    _cmdSample.Click += CmdSample_Click;
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

        internal Label Label2;
        internal Label Label1;
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
                    _txtDistance.Click -= TxtDistance_Click;
                }

                _txtDistance = value;
                if (_txtDistance != null)
                {
                    _txtDistance.Click += TxtDistance_Click;
                }
            }
        }
    }
}