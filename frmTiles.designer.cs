using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmTiles : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            ImgBuffer.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiles));
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._RadioButton5 = new System.Windows.Forms.RadioButton();
            this._RadioButton4 = new System.Windows.Forms.RadioButton();
            this._RadioButton3 = new System.Windows.Forms.RadioButton();
            this._RadioButton2 = new System.Windows.Forms.RadioButton();
            this._RadioButton1 = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.Color.Transparent;
            this._cmdCancel.Location = new System.Drawing.Point(855, 430);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(59, 23);
            this._cmdCancel.TabIndex = 0;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.Color.Transparent;
            this._cmdOK.Location = new System.Drawing.Point(855, 468);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(59, 23);
            this._cmdOK.TabIndex = 1;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this._RadioButton5);
            this.GroupBox1.Controls.Add(this._RadioButton4);
            this.GroupBox1.Controls.Add(this._RadioButton3);
            this.GroupBox1.Controls.Add(this._RadioButton2);
            this.GroupBox1.Controls.Add(this._RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(809, 85);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(160, 141);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Size in Tiles";
            // 
            // _RadioButton5
            // 
            this._RadioButton5.AutoSize = true;
            this._RadioButton5.Checked = true;
            this._RadioButton5.Location = new System.Drawing.Point(15, 119);
            this._RadioButton5.Name = "_RadioButton5";
            this._RadioButton5.Size = new System.Drawing.Size(14, 13);
            this._RadioButton5.TabIndex = 9;
            this._RadioButton5.TabStop = true;
            this._RadioButton5.UseVisualStyleBackColor = true;
            this._RadioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // _RadioButton4
            // 
            this._RadioButton4.AutoSize = true;
            this._RadioButton4.Location = new System.Drawing.Point(15, 95);
            this._RadioButton4.Name = "_RadioButton4";
            this._RadioButton4.Size = new System.Drawing.Size(14, 13);
            this._RadioButton4.TabIndex = 8;
            this._RadioButton4.UseVisualStyleBackColor = true;
            this._RadioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // _RadioButton3
            // 
            this._RadioButton3.AutoSize = true;
            this._RadioButton3.Location = new System.Drawing.Point(14, 71);
            this._RadioButton3.Name = "_RadioButton3";
            this._RadioButton3.Size = new System.Drawing.Size(14, 13);
            this._RadioButton3.TabIndex = 7;
            this._RadioButton3.UseVisualStyleBackColor = true;
            this._RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // _RadioButton2
            // 
            this._RadioButton2.AutoSize = true;
            this._RadioButton2.Location = new System.Drawing.Point(14, 47);
            this._RadioButton2.Name = "_RadioButton2";
            this._RadioButton2.Size = new System.Drawing.Size(14, 13);
            this._RadioButton2.TabIndex = 6;
            this._RadioButton2.UseVisualStyleBackColor = true;
            this._RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // _RadioButton1
            // 
            this._RadioButton1.AutoSize = true;
            this._RadioButton1.BackColor = System.Drawing.Color.Transparent;
            this._RadioButton1.Location = new System.Drawing.Point(14, 23);
            this._RadioButton1.Name = "_RadioButton1";
            this._RadioButton1.Size = new System.Drawing.Size(14, 13);
            this._RadioButton1.TabIndex = 0;
            this._RadioButton1.UseVisualStyleBackColor = false;
            this._RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(806, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 34);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "To change the map size make a selection box with the mouse";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(806, 239);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(178, 172);
            this.Label2.TabIndex = 5;
            this.Label2.Text = resources.GetString("Label2.Text");
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelSize.Location = new System.Drawing.Point(806, 58);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(89, 13);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Size = 20,185 KB";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.White;
            this.labelCount.Location = new System.Drawing.Point(15, 15);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 13);
            this.labelCount.TabIndex = 7;
            this.labelCount.Text = "Label3";
            // 
            // FrmTiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 523);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTiles";
            this.Text = "SBuilderXX - Add Map from Background";
            this.Load += new System.EventHandler(this.FrmTiles_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTiles_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmTiles_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmTiles_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmTiles_MouseUp);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        internal GroupBox GroupBox1;
        private RadioButton _RadioButton1;

        internal RadioButton RadioButton1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButton1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButton1 != null)
                {
                    _RadioButton1.CheckedChanged -= RadioButton1_CheckedChanged;
                }

                _RadioButton1 = value;
                if (_RadioButton1 != null)
                {
                    _RadioButton1.CheckedChanged += RadioButton1_CheckedChanged;
                }
            }
        }

        internal Label Label1;
        private RadioButton _RadioButton4;

        internal RadioButton RadioButton4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButton4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButton4 != null)
                {
                    _RadioButton4.CheckedChanged -= RadioButton4_CheckedChanged;
                }

                _RadioButton4 = value;
                if (_RadioButton4 != null)
                {
                    _RadioButton4.CheckedChanged += RadioButton4_CheckedChanged;
                }
            }
        }

        private RadioButton _RadioButton3;

        internal RadioButton RadioButton3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButton3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButton3 != null)
                {
                    _RadioButton3.CheckedChanged -= RadioButton3_CheckedChanged;
                }

                _RadioButton3 = value;
                if (_RadioButton3 != null)
                {
                    _RadioButton3.CheckedChanged += RadioButton3_CheckedChanged;
                }
            }
        }

        private RadioButton _RadioButton2;

        internal RadioButton RadioButton2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButton2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButton2 != null)
                {
                    _RadioButton2.CheckedChanged -= RadioButton2_CheckedChanged;
                }

                _RadioButton2 = value;
                if (_RadioButton2 != null)
                {
                    _RadioButton2.CheckedChanged += RadioButton2_CheckedChanged;
                }
            }
        }

        private RadioButton _RadioButton5;

        internal RadioButton RadioButton5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RadioButton5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RadioButton5 != null)
                {
                    _RadioButton5.CheckedChanged -= RadioButton5_CheckedChanged;
                }

                _RadioButton5 = value;
                if (_RadioButton5 != null)
                {
                    _RadioButton5.CheckedChanged += RadioButton5_CheckedChanged;
                }
            }
        }

        internal Label Label2;
        internal Label labelSize;
        internal Label labelCount;
    }
}