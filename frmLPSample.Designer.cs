using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLPSample));
            this._cmdSample = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._txtDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _cmdSample
            // 
            this._cmdSample.Location = new System.Drawing.Point(99, 126);
            this._cmdSample.Name = "_cmdSample";
            this._cmdSample.Size = new System.Drawing.Size(60, 25);
            this._cmdSample.TabIndex = 19;
            this._cmdSample.Text = "Sample";
            this._cmdSample.UseVisualStyleBackColor = true;
            this._cmdSample.Click += new System.EventHandler(this.CmdSample_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(18, 126);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(60, 25);
            this._cmdCancel.TabIndex = 18;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(182, 127);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(61, 23);
            this._cmdOK.TabIndex = 17;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(15, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(239, 77);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "By sampling (or decimating) a Line or Poly, points are deleted if there are adjac" +
    "ent points closer than the Minimum Distance shown below. Each time you press \"Sa" +
    "mple\" more points are deleted.";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(96, 86);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(147, 30);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Minimum Distance in meters between adjacent points";
            // 
            // _txtDistance
            // 
            this._txtDistance.Location = new System.Drawing.Point(18, 89);
            this._txtDistance.Name = "_txtDistance";
            this._txtDistance.Size = new System.Drawing.Size(70, 20);
            this._txtDistance.TabIndex = 14;
            this._txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtDistance.Click += new System.EventHandler(this.TxtDistance_Click);
            // 
            // FrmLPSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 166);
            this.Controls.Add(this._cmdSample);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._txtDistance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLPSample";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SbuilderX - Line or Poly Sampling";
            this.Load += new System.EventHandler(this.FrmLPSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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