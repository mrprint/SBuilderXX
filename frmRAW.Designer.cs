using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    public partial class FrmRAW : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRAW));
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._optWater = new System.Windows.Forms.RadioButton();
            this._optLand = new System.Windows.Forms.RadioButton();
            this._txtJ = new System.Windows.Forms.TextBox();
            this._txtK = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(248, 25);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(56, 26);
            this._cmdCancel.TabIndex = 0;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(248, 68);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(56, 26);
            this._cmdOK.TabIndex = 0;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this._optWater);
            this.GroupBox1.Controls.Add(this._optLand);
            this.GroupBox1.Location = new System.Drawing.Point(21, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(79, 79);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Class Type";
            // 
            // _optWater
            // 
            this._optWater.AutoSize = true;
            this._optWater.Location = new System.Drawing.Point(15, 47);
            this._optWater.Name = "_optWater";
            this._optWater.Size = new System.Drawing.Size(54, 17);
            this._optWater.TabIndex = 0;
            this._optWater.Text = "Water";
            this._optWater.UseVisualStyleBackColor = true;
            this._optWater.CheckedChanged += new System.EventHandler(this.OptWater_CheckedChanged);
            // 
            // _optLand
            // 
            this._optLand.AutoSize = true;
            this._optLand.Checked = true;
            this._optLand.Location = new System.Drawing.Point(15, 24);
            this._optLand.Name = "_optLand";
            this._optLand.Size = new System.Drawing.Size(49, 17);
            this._optLand.TabIndex = 0;
            this._optLand.TabStop = true;
            this._optLand.Text = "Land";
            this._optLand.UseVisualStyleBackColor = true;
            this._optLand.CheckedChanged += new System.EventHandler(this.OptLand_CheckedChanged);
            // 
            // _txtJ
            // 
            this._txtJ.Location = new System.Drawing.Point(124, 25);
            this._txtJ.Name = "_txtJ";
            this._txtJ.Size = new System.Drawing.Size(33, 20);
            this._txtJ.TabIndex = 2;
            this._txtJ.Text = "95";
            this._txtJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtJ.TextChanged += new System.EventHandler(this.TxtJ_TextChanged);
            // 
            // _txtK
            // 
            this._txtK.Location = new System.Drawing.Point(124, 68);
            this._txtK.Name = "_txtK";
            this._txtK.Size = new System.Drawing.Size(33, 20);
            this._txtK.TabIndex = 2;
            this._txtK.Text = "63";
            this._txtK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtK.TextChanged += new System.EventHandler(this.TxtK_TextChanged);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(163, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 31);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "W/E QMID (0 up to 95)";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(163, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 27);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "N/S QMID (0 up to 63)";
            // 
            // FrmRAW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 108);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._txtK);
            this.Controls.Add(this._txtJ);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRAW";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Raw file parameters";
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
        private RadioButton _optWater;

        internal RadioButton optWater
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optWater;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optWater != null)
                {
                    _optWater.CheckedChanged -= OptWater_CheckedChanged;
                }

                _optWater = value;
                if (_optWater != null)
                {
                    _optWater.CheckedChanged += OptWater_CheckedChanged;
                }
            }
        }

        private RadioButton _optLand;

        internal RadioButton optLand
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLand;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLand != null)
                {
                    _optLand.CheckedChanged -= OptLand_CheckedChanged;
                }

                _optLand = value;
                if (_optLand != null)
                {
                    _optLand.CheckedChanged += OptLand_CheckedChanged;
                }
            }
        }

        private TextBox _txtJ;

        internal TextBox txtJ
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtJ;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtJ != null)
                {
                    _txtJ.TextChanged -= TxtJ_TextChanged;
                }

                _txtJ = value;
                if (_txtJ != null)
                {
                    _txtJ.TextChanged += TxtJ_TextChanged;
                }
            }
        }

        private TextBox _txtK;

        internal TextBox txtK
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtK;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtK != null)
                {
                    _txtK.TextChanged -= TxtK_TextChanged;
                }

                _txtK = value;
                if (_txtK != null)
                {
                    _txtK.TextChanged += TxtK_TextChanged;
                }
            }
        }

        internal Label Label1;
        internal Label Label2;
    }
}