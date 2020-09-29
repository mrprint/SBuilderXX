using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiles));
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            GroupBox1 = new GroupBox();
            _RadioButton5 = new RadioButton();
            _RadioButton5.CheckedChanged += new EventHandler(RadioButton5_CheckedChanged);
            _RadioButton4 = new RadioButton();
            _RadioButton4.CheckedChanged += new EventHandler(RadioButton4_CheckedChanged);
            _RadioButton3 = new RadioButton();
            _RadioButton3.CheckedChanged += new EventHandler(RadioButton3_CheckedChanged);
            _RadioButton2 = new RadioButton();
            _RadioButton2.CheckedChanged += new EventHandler(RadioButton2_CheckedChanged);
            _RadioButton1 = new RadioButton();
            _RadioButton1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
            Label1 = new Label();
            Label2 = new Label();
            labelSize = new Label();
            labelCount = new Label();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = Color.Transparent;
            _cmdCancel.Location = new Point(855, 430);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(59, 23);
            _cmdCancel.TabIndex = 0;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = Color.Transparent;
            _cmdOK.Location = new Point(855, 468);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(59, 23);
            _cmdOK.TabIndex = 1;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.Controls.Add(_RadioButton5);
            GroupBox1.Controls.Add(_RadioButton4);
            GroupBox1.Controls.Add(_RadioButton3);
            GroupBox1.Controls.Add(_RadioButton2);
            GroupBox1.Controls.Add(_RadioButton1);
            GroupBox1.Location = new Point(809, 85);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(160, 141);
            GroupBox1.TabIndex = 2;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Size in Tiles";
            // 
            // RadioButton5
            // 
            _RadioButton5.AutoSize = true;
            _RadioButton5.Checked = true;
            _RadioButton5.Location = new Point(15, 119);
            _RadioButton5.Name = "_RadioButton5";
            _RadioButton5.Size = new Size(14, 13);
            _RadioButton5.TabIndex = 9;
            _RadioButton5.TabStop = true;
            _RadioButton5.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            _RadioButton4.AutoSize = true;
            _RadioButton4.Location = new Point(15, 95);
            _RadioButton4.Name = "_RadioButton4";
            _RadioButton4.Size = new Size(14, 13);
            _RadioButton4.TabIndex = 8;
            _RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            _RadioButton3.AutoSize = true;
            _RadioButton3.Location = new Point(14, 71);
            _RadioButton3.Name = "_RadioButton3";
            _RadioButton3.Size = new Size(14, 13);
            _RadioButton3.TabIndex = 7;
            _RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            _RadioButton2.AutoSize = true;
            _RadioButton2.Location = new Point(14, 47);
            _RadioButton2.Name = "_RadioButton2";
            _RadioButton2.Size = new Size(14, 13);
            _RadioButton2.TabIndex = 6;
            _RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            _RadioButton1.AutoSize = true;
            _RadioButton1.BackColor = Color.Transparent;
            _RadioButton1.Location = new Point(14, 23);
            _RadioButton1.Name = "_RadioButton1";
            _RadioButton1.Size = new Size(14, 13);
            _RadioButton1.TabIndex = 0;
            _RadioButton1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = Color.Transparent;
            Label1.Location = new Point(806, 15);
            Label1.Name = "Label1";
            Label1.Size = new Size(165, 34);
            Label1.TabIndex = 5;
            Label1.Text = "To change the map size make a selection box with the mouse";
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Location = new Point(806, 239);
            Label2.Name = "Label2";
            Label2.Size = new Size(178, 172);
            Label2.TabIndex = 5;
            Label2.Text = resources.GetString("Label2.Text");
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.ForeColor = SystemColors.Desktop;
            labelSize.Location = new Point(806, 58);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(89, 13);
            labelSize.TabIndex = 6;
            labelSize.Text = "Size = 20,185 KB";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.BackColor = Color.White;
            labelCount.Location = new Point(15, 15);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(39, 13);
            labelCount.TabIndex = 7;
            labelCount.Text = "Label3";
            // 
            // frmTiles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 523);
            Controls.Add(labelCount);
            Controls.Add(labelSize);
            Controls.Add(GroupBox1);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTiles";
            Text = "SBuilderX - Add Map from Background";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(FrmTiles_Load);
            MouseDown += new MouseEventHandler(FrmTiles_MouseDown);
            MouseMove += new MouseEventHandler(FrmTiles_MouseMove);
            MouseUp += new MouseEventHandler(FrmTiles_MouseUp);
            Paint += new PaintEventHandler(FrmTiles_Paint);
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