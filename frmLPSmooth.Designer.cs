using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLPSmooth));
            this._chNoEnds = new System.Windows.Forms.CheckBox();
            this._chCorner = new System.Windows.Forms.CheckBox();
            this._txtDistance = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdSmooth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _chNoEnds
            // 
            this._chNoEnds.Location = new System.Drawing.Point(25, 85);
            this._chNoEnds.Name = "_chNoEnds";
            this._chNoEnds.Size = new System.Drawing.Size(168, 44);
            this._chNoEnds.TabIndex = 3;
            this._chNoEnds.Text = "Do not smooth start/end segments (Lines only)";
            this._chNoEnds.UseVisualStyleBackColor = true;
            this._chNoEnds.CheckedChanged += new System.EventHandler(this.ChNoEnds_CheckedChanged);
            // 
            // _chCorner
            // 
            this._chCorner.AutoSize = true;
            this._chCorner.Location = new System.Drawing.Point(25, 129);
            this._chCorner.Name = "_chCorner";
            this._chCorner.Size = new System.Drawing.Size(158, 17);
            this._chCorner.TabIndex = 4;
            this._chCorner.Text = "Do not smooth sharp angles";
            this._chCorner.UseVisualStyleBackColor = true;
            this._chCorner.CheckedChanged += new System.EventHandler(this.ChCorner_CheckedChanged);
            // 
            // _txtDistance
            // 
            this._txtDistance.Location = new System.Drawing.Point(25, 152);
            this._txtDistance.Name = "_txtDistance";
            this._txtDistance.Size = new System.Drawing.Size(70, 20);
            this._txtDistance.TabIndex = 5;
            this._txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtDistance.TextChanged += new System.EventHandler(this.TxtDistance_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(22, 175);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(147, 30);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Minimum Distance in meters between adjacent points";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(25, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(225, 77);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "By smoothing (or interpolating) a Line or Poly, you introduce more points except " +
    "when they become closer than the Minimum Distance shown below. Each time you pre" +
    "ss \"Smooth\" more points are inserted.";
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(190, 174);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(61, 23);
            this._cmdOK.TabIndex = 9;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(190, 98);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(60, 25);
            this._cmdCancel.TabIndex = 10;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdSmooth
            // 
            this._cmdSmooth.Location = new System.Drawing.Point(191, 135);
            this._cmdSmooth.Name = "_cmdSmooth";
            this._cmdSmooth.Size = new System.Drawing.Size(60, 25);
            this._cmdSmooth.TabIndex = 11;
            this._cmdSmooth.Text = "Smooth";
            this._cmdSmooth.UseVisualStyleBackColor = true;
            this._cmdSmooth.Click += new System.EventHandler(this.CmdSmooth_Click);
            // 
            // FrmLPSmooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 210);
            this.Controls.Add(this._cmdSmooth);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._txtDistance);
            this.Controls.Add(this._chCorner);
            this.Controls.Add(this._chNoEnds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLPSmooth";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Line or Poly Smoothing";
            this.Load += new System.EventHandler(this.FrmLPSmooth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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