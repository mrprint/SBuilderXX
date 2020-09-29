using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRAW));
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            GroupBox1 = new GroupBox();
            _optWater = new RadioButton();
            _optWater.CheckedChanged += new EventHandler(OptWater_CheckedChanged);
            _optLand = new RadioButton();
            _optLand.CheckedChanged += new EventHandler(OptLand_CheckedChanged);
            _txtJ = new TextBox();
            _txtJ.TextChanged += new EventHandler(TxtJ_TextChanged);
            _txtK = new TextBox();
            _txtK.TextChanged += new EventHandler(TxtK_TextChanged);
            Label1 = new Label();
            Label2 = new Label();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(248, 25);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(56, 26);
            _cmdCancel.TabIndex = 0;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(248, 68);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(56, 26);
            _cmdOK.TabIndex = 0;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_optWater);
            GroupBox1.Controls.Add(_optLand);
            GroupBox1.Location = new Point(21, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(79, 79);
            GroupBox1.TabIndex = 1;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Class Type";
            // 
            // optWater
            // 
            _optWater.AutoSize = true;
            _optWater.Location = new Point(15, 47);
            _optWater.Name = "_optWater";
            _optWater.Size = new Size(54, 17);
            _optWater.TabIndex = 0;
            _optWater.Text = "Water";
            _optWater.UseVisualStyleBackColor = true;
            // 
            // optLand
            // 
            _optLand.AutoSize = true;
            _optLand.Checked = true;
            _optLand.Location = new Point(15, 24);
            _optLand.Name = "_optLand";
            _optLand.Size = new Size(49, 17);
            _optLand.TabIndex = 0;
            _optLand.TabStop = true;
            _optLand.Text = "Land";
            _optLand.UseVisualStyleBackColor = true;
            // 
            // txtJ
            // 
            _txtJ.Location = new Point(124, 25);
            _txtJ.Name = "_txtJ";
            _txtJ.Size = new Size(33, 20);
            _txtJ.TabIndex = 2;
            _txtJ.Text = "95";
            _txtJ.TextAlign = HorizontalAlignment.Center;
            // 
            // txtK
            // 
            _txtK.Location = new Point(124, 68);
            _txtK.Name = "_txtK";
            _txtK.Size = new Size(33, 20);
            _txtK.TabIndex = 2;
            _txtK.Text = "63";
            _txtK.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.Location = new Point(163, 22);
            Label1.Name = "Label1";
            Label1.Size = new Size(64, 31);
            Label1.TabIndex = 3;
            Label1.Text = "W/E QMID (0 up to 95)";
            // 
            // Label2
            // 
            Label2.Location = new Point(163, 64);
            Label2.Name = "Label2";
            Label2.Size = new Size(64, 27);
            Label2.TabIndex = 3;
            Label2.Text = "N/S QMID (0 up to 63)";
            // 
            // frmRAW
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 108);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(_txtK);
            Controls.Add(_txtJ);
            Controls.Add(GroupBox1);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRAW";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Raw file parameters";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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