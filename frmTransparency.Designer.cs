using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmTransparency : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransparency));
            _BarA = new HScrollBar();
            _BarA.ValueChanged += new EventHandler(BarA_ValueChanged);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _BarR = new HScrollBar();
            _BarR.ValueChanged += new EventHandler(BarR_ValueChanged);
            _BarG = new HScrollBar();
            _BarG.ValueChanged += new EventHandler(BarG_ValueChanged);
            _BarB = new HScrollBar();
            _BarB.ValueChanged += new EventHandler(BarB_ValueChanged);
            _txtR = new TextBox();
            _txtR.TextChanged += new EventHandler(TxtR_TextChanged);
            _txtG = new TextBox();
            _txtG.TextChanged += new EventHandler(TxtG_TextChanged);
            _txtB = new TextBox();
            _txtB.TextChanged += new EventHandler(TxtB_TextChanged);
            _txtA = new TextBox();
            _txtA.TextChanged += new EventHandler(TxtA_TextChanged);
            _Label1 = new Label();
            _Label1.Click += new EventHandler(Label1_Click);
            _Label2 = new Label();
            _Label2.Click += new EventHandler(Label2_Click);
            _Label3 = new Label();
            _Label3.Click += new EventHandler(Label3_Click);
            _Label4 = new Label();
            _Label4.Click += new EventHandler(Label4_Click);
            _Label5 = new Label();
            _Label5.Click += new EventHandler(Label5_Click);
            _Label6 = new Label();
            _Label6.Click += new EventHandler(Label6_Click);
            _Label7 = new Label();
            _Label7.Click += new EventHandler(Label7_Click);
            _Label8 = new Label();
            _Label8.Click += new EventHandler(Label8_Click);
            _Label9 = new Label();
            _Label9.Click += new EventHandler(Label9_Click);
            _Label10 = new Label();
            _Label10.Click += new EventHandler(Label10_Click);
            _Label11 = new Label();
            _Label11.Click += new EventHandler(Label11_Click);
            _Label12 = new Label();
            _Label12.Click += new EventHandler(Label12_Click);
            _Label13 = new Label();
            _Label13.Click += new EventHandler(Label13_Click);
            _Label14 = new Label();
            _Label14.Click += new EventHandler(Label14_Click);
            _Label15 = new Label();
            _Label15.Click += new EventHandler(Label15_Click);
            _Label16 = new Label();
            _Label16.Click += new EventHandler(Label16_Click);
            _Label17 = new Label();
            _Label17.Click += new EventHandler(Label17_Click);
            _Label18 = new Label();
            _Label18.Click += new EventHandler(Label18_Click);
            _Label19 = new Label();
            _Label19.Click += new EventHandler(Label19_Click);
            _Label20 = new Label();
            _Label20.Click += new EventHandler(Label20_Click);
            _Label21 = new Label();
            _Label21.Click += new EventHandler(Label21_Click);
            _Label22 = new Label();
            _Label22.Click += new EventHandler(Label22_Click);
            _Label23 = new Label();
            _Label23.Click += new EventHandler(Label23_Click);
            _Label24 = new Label();
            _Label24.Click += new EventHandler(Label24_Click);
            _Label25 = new Label();
            _Label25.Click += new EventHandler(Label25_Click);
            _Label26 = new Label();
            _Label26.Click += new EventHandler(Label26_Click);
            _Label27 = new Label();
            _Label27.Click += new EventHandler(Label27_Click);
            Label28 = new Label();
            Label29 = new Label();
            Label30 = new Label();
            GroupBox1 = new GroupBox();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BarA
            // 
            _BarA.LargeChange = 20;
            _BarA.Location = new Point(12, 16);
            _BarA.Maximum = 274;
            _BarA.Name = "_BarA";
            _BarA.Size = new Size(108, 20);
            _BarA.TabIndex = 2;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(195, 186);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(71, 25);
            _cmdCancel.TabIndex = 4;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(297, 186);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(71, 25);
            _cmdOK.TabIndex = 5;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // BarR
            // 
            _BarR.LargeChange = 20;
            _BarR.Location = new Point(15, 120);
            _BarR.Maximum = 274;
            _BarR.Name = "_BarR";
            _BarR.Size = new Size(108, 20);
            _BarR.TabIndex = 6;
            // 
            // BarG
            // 
            _BarG.LargeChange = 20;
            _BarG.Location = new Point(15, 156);
            _BarG.Maximum = 274;
            _BarG.Name = "_BarG";
            _BarG.Size = new Size(108, 20);
            _BarG.TabIndex = 7;
            // 
            // BarB
            // 
            _BarB.LargeChange = 20;
            _BarB.Location = new Point(15, 192);
            _BarB.Maximum = 274;
            _BarB.Name = "_BarB";
            _BarB.Size = new Size(108, 20);
            _BarB.TabIndex = 8;
            // 
            // txtR
            // 
            _txtR.Location = new Point(130, 120);
            _txtR.Name = "_txtR";
            _txtR.Size = new Size(30, 20);
            _txtR.TabIndex = 10;
            _txtR.Text = "255";
            _txtR.TextAlign = HorizontalAlignment.Center;
            // 
            // txtG
            // 
            _txtG.Location = new Point(130, 156);
            _txtG.Name = "_txtG";
            _txtG.Size = new Size(30, 20);
            _txtG.TabIndex = 11;
            _txtG.Text = "255";
            _txtG.TextAlign = HorizontalAlignment.Center;
            // 
            // txtB
            // 
            _txtB.Location = new Point(130, 192);
            _txtB.Name = "_txtB";
            _txtB.Size = new Size(30, 20);
            _txtB.TabIndex = 12;
            _txtB.Text = "255";
            _txtB.TextAlign = HorizontalAlignment.Center;
            // 
            // txtA
            // 
            _txtA.Location = new Point(139, 16);
            _txtA.Name = "_txtA";
            _txtA.Size = new Size(30, 20);
            _txtA.TabIndex = 13;
            _txtA.Text = "255";
            _txtA.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            _Label1.BackColor = Color.Black;
            _Label1.FlatStyle = FlatStyle.Popup;
            _Label1.Location = new Point(140, 20);
            _Label1.Name = "_Label1";
            _Label1.Size = new Size(20, 20);
            _Label1.TabIndex = 14;
            // 
            // Label2
            // 
            _Label2.BackColor = Color.Maroon;
            _Label2.Location = new Point(166, 20);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(20, 20);
            _Label2.TabIndex = 15;
            // 
            // Label3
            // 
            _Label3.BackColor = Color.Green;
            _Label3.Location = new Point(192, 20);
            _Label3.Name = "_Label3";
            _Label3.Size = new Size(20, 20);
            _Label3.TabIndex = 16;
            // 
            // Label4
            // 
            _Label4.BackColor = Color.Lime;
            _Label4.Location = new Point(270, 20);
            _Label4.Name = "_Label4";
            _Label4.Size = new Size(20, 20);
            _Label4.TabIndex = 19;
            // 
            // Label5
            // 
            _Label5.BackColor = Color.Red;
            _Label5.Location = new Point(244, 20);
            _Label5.Name = "_Label5";
            _Label5.Size = new Size(20, 20);
            _Label5.TabIndex = 18;
            // 
            // Label6
            // 
            _Label6.BackColor = Color.Navy;
            _Label6.Location = new Point(218, 20);
            _Label6.Name = "_Label6";
            _Label6.Size = new Size(20, 20);
            _Label6.TabIndex = 17;
            // 
            // Label7
            // 
            _Label7.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(128)));
            _Label7.Location = new Point(192, 49);
            _Label7.Name = "_Label7";
            _Label7.Size = new Size(20, 20);
            _Label7.TabIndex = 22;
            // 
            // Label8
            // 
            _Label8.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)));
            _Label8.Location = new Point(166, 49);
            _Label8.Name = "_Label8";
            _Label8.Size = new Size(20, 20);
            _Label8.TabIndex = 21;
            // 
            // Label9
            // 
            _Label9.BackColor = Color.Blue;
            _Label9.Location = new Point(296, 20);
            _Label9.Name = "_Label9";
            _Label9.Size = new Size(20, 20);
            _Label9.TabIndex = 20;
            // 
            // Label10
            // 
            _Label10.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(255)));
            _Label10.Location = new Point(218, 79);
            _Label10.Name = "_Label10";
            _Label10.Size = new Size(20, 20);
            _Label10.TabIndex = 31;
            // 
            // Label11
            // 
            _Label11.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)));
            _Label11.Location = new Point(192, 79);
            _Label11.Name = "_Label11";
            _Label11.Size = new Size(20, 20);
            _Label11.TabIndex = 30;
            // 
            // Label12
            // 
            _Label12.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(128)));
            _Label12.Location = new Point(166, 79);
            _Label12.Name = "_Label12";
            _Label12.Size = new Size(20, 20);
            _Label12.TabIndex = 29;
            // 
            // Label13
            // 
            _Label13.BackColor = Color.Fuchsia;
            _Label13.Location = new Point(139, 79);
            _Label13.Name = "_Label13";
            _Label13.Size = new Size(20, 20);
            _Label13.TabIndex = 28;
            // 
            // Label14
            // 
            _Label14.BackColor = Color.Yellow;
            _Label14.Location = new Point(348, 49);
            _Label14.Name = "_Label14";
            _Label14.Size = new Size(20, 20);
            _Label14.TabIndex = 27;
            // 
            // Label15
            // 
            _Label15.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(255)));
            _Label15.Location = new Point(322, 49);
            _Label15.Name = "_Label15";
            _Label15.Size = new Size(20, 20);
            _Label15.TabIndex = 26;
            // 
            // Label16
            // 
            _Label16.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)));
            _Label16.Location = new Point(296, 49);
            _Label16.Name = "_Label16";
            _Label16.Size = new Size(20, 20);
            _Label16.TabIndex = 25;
            // 
            // Label17
            // 
            _Label17.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(255)));
            _Label17.Location = new Point(244, 49);
            _Label17.Name = "_Label17";
            _Label17.Size = new Size(20, 20);
            _Label17.TabIndex = 24;
            // 
            // Label18
            // 
            _Label18.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(0)));
            _Label18.Location = new Point(218, 49);
            _Label18.Name = "_Label18";
            _Label18.Size = new Size(20, 20);
            _Label18.TabIndex = 23;
            // 
            // Label19
            // 
            _Label19.BackColor = Color.Purple;
            _Label19.Location = new Point(348, 20);
            _Label19.Name = "_Label19";
            _Label19.Size = new Size(20, 20);
            _Label19.TabIndex = 40;
            // 
            // Label20
            // 
            _Label20.BackColor = Color.Olive;
            _Label20.Location = new Point(322, 20);
            _Label20.Name = "_Label20";
            _Label20.Size = new Size(20, 20);
            _Label20.TabIndex = 39;
            // 
            // Label21
            // 
            _Label21.BackColor = Color.Teal;
            _Label21.Location = new Point(139, 49);
            _Label21.Name = "_Label21";
            _Label21.Size = new Size(20, 20);
            _Label21.TabIndex = 38;
            // 
            // Label22
            // 
            _Label22.BackColor = Color.Gray;
            _Label22.Location = new Point(270, 49);
            _Label22.Name = "_Label22";
            _Label22.Size = new Size(20, 20);
            _Label22.TabIndex = 37;
            // 
            // Label23
            // 
            _Label23.BackColor = Color.White;
            _Label23.Location = new Point(348, 79);
            _Label23.Name = "_Label23";
            _Label23.Size = new Size(20, 20);
            _Label23.TabIndex = 36;
            // 
            // Label24
            // 
            _Label24.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)));
            _Label24.Location = new Point(322, 79);
            _Label24.Name = "_Label24";
            _Label24.Size = new Size(20, 20);
            _Label24.TabIndex = 35;
            // 
            // Label25
            // 
            _Label25.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)), Conversions.ToInteger(Conversions.ToByte(255)));
            _Label25.Location = new Point(296, 79);
            _Label25.Name = "_Label25";
            _Label25.Size = new Size(20, 20);
            _Label25.TabIndex = 34;
            // 
            // Label26
            // 
            _Label26.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(128)));
            _Label26.Location = new Point(270, 79);
            _Label26.Name = "_Label26";
            _Label26.Size = new Size(20, 20);
            _Label26.TabIndex = 33;
            // 
            // Label27
            // 
            _Label27.BackColor = Color.Cyan;
            _Label27.Location = new Point(244, 79);
            _Label27.Name = "_Label27";
            _Label27.Size = new Size(20, 20);
            _Label27.TabIndex = 32;
            // 
            // Label28
            // 
            Label28.BackColor = Color.Red;
            Label28.Location = new Point(15, 115);
            Label28.Name = "Label28";
            Label28.Size = new Size(108, 5);
            Label28.TabIndex = 41;
            Label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label29
            // 
            Label29.BackColor = Color.Green;
            Label29.Location = new Point(15, 153);
            Label29.Name = "Label29";
            Label29.Size = new Size(108, 5);
            Label29.TabIndex = 42;
            Label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label30
            // 
            Label30.BackColor = Color.Blue;
            Label30.Location = new Point(15, 187);
            Label30.Name = "Label30";
            Label30.Size = new Size(108, 5);
            Label30.TabIndex = 42;
            Label30.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_BarA);
            GroupBox1.Controls.Add(_txtA);
            GroupBox1.Location = new Point(183, 120);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(185, 46);
            GroupBox1.TabIndex = 44;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Set Transparency";
            // 
            // frmTransparency
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(387, 223);
            Controls.Add(GroupBox1);
            Controls.Add(Label30);
            Controls.Add(Label29);
            Controls.Add(Label28);
            Controls.Add(_Label19);
            Controls.Add(_Label20);
            Controls.Add(_Label21);
            Controls.Add(_Label22);
            Controls.Add(_Label23);
            Controls.Add(_Label24);
            Controls.Add(_Label25);
            Controls.Add(_Label26);
            Controls.Add(_Label27);
            Controls.Add(_Label10);
            Controls.Add(_Label11);
            Controls.Add(_Label12);
            Controls.Add(_Label13);
            Controls.Add(_Label14);
            Controls.Add(_Label15);
            Controls.Add(_Label16);
            Controls.Add(_Label17);
            Controls.Add(_Label18);
            Controls.Add(_Label7);
            Controls.Add(_Label8);
            Controls.Add(_Label9);
            Controls.Add(_Label4);
            Controls.Add(_Label5);
            Controls.Add(_Label6);
            Controls.Add(_Label3);
            Controls.Add(_Label2);
            Controls.Add(_Label1);
            Controls.Add(_txtB);
            Controls.Add(_txtG);
            Controls.Add(_txtR);
            Controls.Add(_BarB);
            Controls.Add(_BarG);
            Controls.Add(_BarR);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTransparency";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Color and Transparency";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(FrmTransparency_Load);
            Paint += new PaintEventHandler(FrmTransparency_Paint);
            ResumeLayout(false);
            PerformLayout();
        }

        private HScrollBar _BarA;

        internal HScrollBar BarA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BarA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BarA != null)
                {
                    _BarA.ValueChanged -= BarA_ValueChanged;
                }

                _BarA = value;
                if (_BarA != null)
                {
                    _BarA.ValueChanged += BarA_ValueChanged;
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

        private HScrollBar _BarR;

        internal HScrollBar BarR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BarR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BarR != null)
                {
                    _BarR.ValueChanged -= BarR_ValueChanged;
                }

                _BarR = value;
                if (_BarR != null)
                {
                    _BarR.ValueChanged += BarR_ValueChanged;
                }
            }
        }

        private HScrollBar _BarG;

        internal HScrollBar BarG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BarG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BarG != null)
                {
                    _BarG.ValueChanged -= BarG_ValueChanged;
                }

                _BarG = value;
                if (_BarG != null)
                {
                    _BarG.ValueChanged += BarG_ValueChanged;
                }
            }
        }

        private HScrollBar _BarB;

        internal HScrollBar BarB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BarB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BarB != null)
                {
                    _BarB.ValueChanged -= BarB_ValueChanged;
                }

                _BarB = value;
                if (_BarB != null)
                {
                    _BarB.ValueChanged += BarB_ValueChanged;
                }
            }
        }

        private TextBox _txtR;

        internal TextBox txtR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtR != null)
                {
                    _txtR.TextChanged -= TxtR_TextChanged;
                }

                _txtR = value;
                if (_txtR != null)
                {
                    _txtR.TextChanged += TxtR_TextChanged;
                }
            }
        }

        private TextBox _txtG;

        internal TextBox txtG
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtG;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtG != null)
                {
                    _txtG.TextChanged -= TxtG_TextChanged;
                }

                _txtG = value;
                if (_txtG != null)
                {
                    _txtG.TextChanged += TxtG_TextChanged;
                }
            }
        }

        private TextBox _txtB;

        internal TextBox txtB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtB != null)
                {
                    _txtB.TextChanged -= TxtB_TextChanged;
                }

                _txtB = value;
                if (_txtB != null)
                {
                    _txtB.TextChanged += TxtB_TextChanged;
                }
            }
        }

        private TextBox _txtA;

        internal TextBox txtA
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtA;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtA != null)
                {
                    _txtA.TextChanged -= TxtA_TextChanged;
                }

                _txtA = value;
                if (_txtA != null)
                {
                    _txtA.TextChanged += TxtA_TextChanged;
                }
            }
        }

        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                    _Label1.Click -= Label1_Click;
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                    _Label1.Click += Label1_Click;
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                    _Label2.Click -= Label2_Click;
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                    _Label2.Click += Label2_Click;
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                    _Label3.Click -= Label3_Click;
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                    _Label3.Click += Label3_Click;
                }
            }
        }

        private Label _Label4;

        internal Label Label4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label4 != null)
                {
                    _Label4.Click -= Label4_Click;
                }

                _Label4 = value;
                if (_Label4 != null)
                {
                    _Label4.Click += Label4_Click;
                }
            }
        }

        private Label _Label5;

        internal Label Label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label5 != null)
                {
                    _Label5.Click -= Label5_Click;
                }

                _Label5 = value;
                if (_Label5 != null)
                {
                    _Label5.Click += Label5_Click;
                }
            }
        }

        private Label _Label6;

        internal Label Label6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label6 != null)
                {
                    _Label6.Click -= Label6_Click;
                }

                _Label6 = value;
                if (_Label6 != null)
                {
                    _Label6.Click += Label6_Click;
                }
            }
        }

        private Label _Label7;

        internal Label Label7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label7 != null)
                {
                    _Label7.Click -= Label7_Click;
                }

                _Label7 = value;
                if (_Label7 != null)
                {
                    _Label7.Click += Label7_Click;
                }
            }
        }

        private Label _Label8;

        internal Label Label8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label8 != null)
                {
                    _Label8.Click -= Label8_Click;
                }

                _Label8 = value;
                if (_Label8 != null)
                {
                    _Label8.Click += Label8_Click;
                }
            }
        }

        private Label _Label9;

        internal Label Label9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label9 != null)
                {
                    _Label9.Click -= Label9_Click;
                }

                _Label9 = value;
                if (_Label9 != null)
                {
                    _Label9.Click += Label9_Click;
                }
            }
        }

        private Label _Label10;

        internal Label Label10
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label10;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label10 != null)
                {
                    _Label10.Click -= Label10_Click;
                }

                _Label10 = value;
                if (_Label10 != null)
                {
                    _Label10.Click += Label10_Click;
                }
            }
        }

        private Label _Label11;

        internal Label Label11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label11 != null)
                {
                    _Label11.Click -= Label11_Click;
                }

                _Label11 = value;
                if (_Label11 != null)
                {
                    _Label11.Click += Label11_Click;
                }
            }
        }

        private Label _Label12;

        internal Label Label12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label12 != null)
                {
                    _Label12.Click -= Label12_Click;
                }

                _Label12 = value;
                if (_Label12 != null)
                {
                    _Label12.Click += Label12_Click;
                }
            }
        }

        private Label _Label13;

        internal Label Label13
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label13;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label13 != null)
                {
                    _Label13.Click -= Label13_Click;
                }

                _Label13 = value;
                if (_Label13 != null)
                {
                    _Label13.Click += Label13_Click;
                }
            }
        }

        private Label _Label14;

        internal Label Label14
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label14;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label14 != null)
                {
                    _Label14.Click -= Label14_Click;
                }

                _Label14 = value;
                if (_Label14 != null)
                {
                    _Label14.Click += Label14_Click;
                }
            }
        }

        private Label _Label15;

        internal Label Label15
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label15;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label15 != null)
                {
                    _Label15.Click -= Label15_Click;
                }

                _Label15 = value;
                if (_Label15 != null)
                {
                    _Label15.Click += Label15_Click;
                }
            }
        }

        private Label _Label16;

        internal Label Label16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label16 != null)
                {
                    _Label16.Click -= Label16_Click;
                }

                _Label16 = value;
                if (_Label16 != null)
                {
                    _Label16.Click += Label16_Click;
                }
            }
        }

        private Label _Label17;

        internal Label Label17
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label17;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label17 != null)
                {
                    _Label17.Click -= Label17_Click;
                }

                _Label17 = value;
                if (_Label17 != null)
                {
                    _Label17.Click += Label17_Click;
                }
            }
        }

        private Label _Label18;

        internal Label Label18
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label18;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label18 != null)
                {
                    _Label18.Click -= Label18_Click;
                }

                _Label18 = value;
                if (_Label18 != null)
                {
                    _Label18.Click += Label18_Click;
                }
            }
        }

        private Label _Label19;

        internal Label Label19
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label19;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label19 != null)
                {
                    _Label19.Click -= Label19_Click;
                }

                _Label19 = value;
                if (_Label19 != null)
                {
                    _Label19.Click += Label19_Click;
                }
            }
        }

        private Label _Label20;

        internal Label Label20
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label20;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label20 != null)
                {
                    _Label20.Click -= Label20_Click;
                }

                _Label20 = value;
                if (_Label20 != null)
                {
                    _Label20.Click += Label20_Click;
                }
            }
        }

        private Label _Label21;

        internal Label Label21
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label21;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label21 != null)
                {
                    _Label21.Click -= Label21_Click;
                }

                _Label21 = value;
                if (_Label21 != null)
                {
                    _Label21.Click += Label21_Click;
                }
            }
        }

        private Label _Label22;

        internal Label Label22
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label22;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label22 != null)
                {
                    _Label22.Click -= Label22_Click;
                }

                _Label22 = value;
                if (_Label22 != null)
                {
                    _Label22.Click += Label22_Click;
                }
            }
        }

        private Label _Label23;

        internal Label Label23
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label23;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label23 != null)
                {
                    _Label23.Click -= Label23_Click;
                }

                _Label23 = value;
                if (_Label23 != null)
                {
                    _Label23.Click += Label23_Click;
                }
            }
        }

        private Label _Label24;

        internal Label Label24
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label24;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label24 != null)
                {
                    _Label24.Click -= Label24_Click;
                }

                _Label24 = value;
                if (_Label24 != null)
                {
                    _Label24.Click += Label24_Click;
                }
            }
        }

        private Label _Label25;

        internal Label Label25
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label25;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label25 != null)
                {
                    _Label25.Click -= Label25_Click;
                }

                _Label25 = value;
                if (_Label25 != null)
                {
                    _Label25.Click += Label25_Click;
                }
            }
        }

        private Label _Label26;

        internal Label Label26
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label26;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label26 != null)
                {
                    _Label26.Click -= Label26_Click;
                }

                _Label26 = value;
                if (_Label26 != null)
                {
                    _Label26.Click += Label26_Click;
                }
            }
        }

        private Label _Label27;

        internal Label Label27
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label27;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label27 != null)
                {
                    _Label27.Click -= Label27_Click;
                }

                _Label27 = value;
                if (_Label27 != null)
                {
                    _Label27.Click += Label27_Click;
                }
            }
        }

        internal Label Label28;
        internal Label Label29;
        internal Label Label30;
        internal GroupBox GroupBox1;
    }
}