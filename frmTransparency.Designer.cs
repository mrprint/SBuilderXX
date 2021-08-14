using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransparency));
            this._BarA = new System.Windows.Forms.HScrollBar();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this._BarR = new System.Windows.Forms.HScrollBar();
            this._BarG = new System.Windows.Forms.HScrollBar();
            this._BarB = new System.Windows.Forms.HScrollBar();
            this._txtR = new System.Windows.Forms.TextBox();
            this._txtG = new System.Windows.Forms.TextBox();
            this._txtB = new System.Windows.Forms.TextBox();
            this._txtA = new System.Windows.Forms.TextBox();
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label5 = new System.Windows.Forms.Label();
            this._Label6 = new System.Windows.Forms.Label();
            this._Label7 = new System.Windows.Forms.Label();
            this._Label8 = new System.Windows.Forms.Label();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label10 = new System.Windows.Forms.Label();
            this._Label11 = new System.Windows.Forms.Label();
            this._Label12 = new System.Windows.Forms.Label();
            this._Label13 = new System.Windows.Forms.Label();
            this._Label14 = new System.Windows.Forms.Label();
            this._Label15 = new System.Windows.Forms.Label();
            this._Label16 = new System.Windows.Forms.Label();
            this._Label17 = new System.Windows.Forms.Label();
            this._Label18 = new System.Windows.Forms.Label();
            this._Label19 = new System.Windows.Forms.Label();
            this._Label20 = new System.Windows.Forms.Label();
            this._Label21 = new System.Windows.Forms.Label();
            this._Label22 = new System.Windows.Forms.Label();
            this._Label23 = new System.Windows.Forms.Label();
            this._Label24 = new System.Windows.Forms.Label();
            this._Label25 = new System.Windows.Forms.Label();
            this._Label26 = new System.Windows.Forms.Label();
            this._Label27 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _BarA
            // 
            this._BarA.LargeChange = 20;
            this._BarA.Location = new System.Drawing.Point(12, 16);
            this._BarA.Maximum = 274;
            this._BarA.Name = "_BarA";
            this._BarA.Size = new System.Drawing.Size(108, 20);
            this._BarA.TabIndex = 2;
            this._BarA.ValueChanged += new System.EventHandler(this.BarA_ValueChanged);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(195, 186);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(71, 25);
            this._cmdCancel.TabIndex = 4;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(297, 186);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(71, 25);
            this._cmdOK.TabIndex = 5;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _BarR
            // 
            this._BarR.LargeChange = 20;
            this._BarR.Location = new System.Drawing.Point(15, 120);
            this._BarR.Maximum = 274;
            this._BarR.Name = "_BarR";
            this._BarR.Size = new System.Drawing.Size(108, 20);
            this._BarR.TabIndex = 6;
            this._BarR.ValueChanged += new System.EventHandler(this.BarR_ValueChanged);
            // 
            // _BarG
            // 
            this._BarG.LargeChange = 20;
            this._BarG.Location = new System.Drawing.Point(15, 156);
            this._BarG.Maximum = 274;
            this._BarG.Name = "_BarG";
            this._BarG.Size = new System.Drawing.Size(108, 20);
            this._BarG.TabIndex = 7;
            this._BarG.ValueChanged += new System.EventHandler(this.BarG_ValueChanged);
            // 
            // _BarB
            // 
            this._BarB.LargeChange = 20;
            this._BarB.Location = new System.Drawing.Point(15, 192);
            this._BarB.Maximum = 274;
            this._BarB.Name = "_BarB";
            this._BarB.Size = new System.Drawing.Size(108, 20);
            this._BarB.TabIndex = 8;
            this._BarB.ValueChanged += new System.EventHandler(this.BarB_ValueChanged);
            // 
            // _txtR
            // 
            this._txtR.Location = new System.Drawing.Point(130, 120);
            this._txtR.Name = "_txtR";
            this._txtR.Size = new System.Drawing.Size(30, 20);
            this._txtR.TabIndex = 10;
            this._txtR.Text = "255";
            this._txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtR.TextChanged += new System.EventHandler(this.TxtR_TextChanged);
            // 
            // _txtG
            // 
            this._txtG.Location = new System.Drawing.Point(130, 156);
            this._txtG.Name = "_txtG";
            this._txtG.Size = new System.Drawing.Size(30, 20);
            this._txtG.TabIndex = 11;
            this._txtG.Text = "255";
            this._txtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtG.TextChanged += new System.EventHandler(this.TxtG_TextChanged);
            // 
            // _txtB
            // 
            this._txtB.Location = new System.Drawing.Point(130, 192);
            this._txtB.Name = "_txtB";
            this._txtB.Size = new System.Drawing.Size(30, 20);
            this._txtB.TabIndex = 12;
            this._txtB.Text = "255";
            this._txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtB.TextChanged += new System.EventHandler(this.TxtB_TextChanged);
            // 
            // _txtA
            // 
            this._txtA.Location = new System.Drawing.Point(139, 16);
            this._txtA.Name = "_txtA";
            this._txtA.Size = new System.Drawing.Size(30, 20);
            this._txtA.TabIndex = 13;
            this._txtA.Text = "255";
            this._txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtA.TextChanged += new System.EventHandler(this.TxtA_TextChanged);
            // 
            // _Label1
            // 
            this._Label1.BackColor = System.Drawing.Color.Black;
            this._Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Label1.Location = new System.Drawing.Point(140, 20);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(20, 20);
            this._Label1.TabIndex = 14;
            this._Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // _Label2
            // 
            this._Label2.BackColor = System.Drawing.Color.Maroon;
            this._Label2.Location = new System.Drawing.Point(166, 20);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(20, 20);
            this._Label2.TabIndex = 15;
            this._Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // _Label3
            // 
            this._Label3.BackColor = System.Drawing.Color.Green;
            this._Label3.Location = new System.Drawing.Point(192, 20);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(20, 20);
            this._Label3.TabIndex = 16;
            this._Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // _Label4
            // 
            this._Label4.BackColor = System.Drawing.Color.Lime;
            this._Label4.Location = new System.Drawing.Point(270, 20);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(20, 20);
            this._Label4.TabIndex = 19;
            this._Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // _Label5
            // 
            this._Label5.BackColor = System.Drawing.Color.Red;
            this._Label5.Location = new System.Drawing.Point(244, 20);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(20, 20);
            this._Label5.TabIndex = 18;
            this._Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // _Label6
            // 
            this._Label6.BackColor = System.Drawing.Color.Navy;
            this._Label6.Location = new System.Drawing.Point(218, 20);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(20, 20);
            this._Label6.TabIndex = 17;
            this._Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // _Label7
            // 
            this._Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this._Label7.Location = new System.Drawing.Point(192, 49);
            this._Label7.Name = "_Label7";
            this._Label7.Size = new System.Drawing.Size(20, 20);
            this._Label7.TabIndex = 22;
            this._Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // _Label8
            // 
            this._Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this._Label8.Location = new System.Drawing.Point(166, 49);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(20, 20);
            this._Label8.TabIndex = 21;
            this._Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // _Label9
            // 
            this._Label9.BackColor = System.Drawing.Color.Blue;
            this._Label9.Location = new System.Drawing.Point(296, 20);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(20, 20);
            this._Label9.TabIndex = 20;
            this._Label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // _Label10
            // 
            this._Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._Label10.Location = new System.Drawing.Point(218, 79);
            this._Label10.Name = "_Label10";
            this._Label10.Size = new System.Drawing.Size(20, 20);
            this._Label10.TabIndex = 31;
            this._Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // _Label11
            // 
            this._Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Label11.Location = new System.Drawing.Point(192, 79);
            this._Label11.Name = "_Label11";
            this._Label11.Size = new System.Drawing.Size(20, 20);
            this._Label11.TabIndex = 30;
            this._Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // _Label12
            // 
            this._Label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._Label12.Location = new System.Drawing.Point(166, 79);
            this._Label12.Name = "_Label12";
            this._Label12.Size = new System.Drawing.Size(20, 20);
            this._Label12.TabIndex = 29;
            this._Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // _Label13
            // 
            this._Label13.BackColor = System.Drawing.Color.Fuchsia;
            this._Label13.Location = new System.Drawing.Point(139, 79);
            this._Label13.Name = "_Label13";
            this._Label13.Size = new System.Drawing.Size(20, 20);
            this._Label13.TabIndex = 28;
            this._Label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // _Label14
            // 
            this._Label14.BackColor = System.Drawing.Color.Yellow;
            this._Label14.Location = new System.Drawing.Point(348, 49);
            this._Label14.Name = "_Label14";
            this._Label14.Size = new System.Drawing.Size(20, 20);
            this._Label14.TabIndex = 27;
            this._Label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // _Label15
            // 
            this._Label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._Label15.Location = new System.Drawing.Point(322, 49);
            this._Label15.Name = "_Label15";
            this._Label15.Size = new System.Drawing.Size(20, 20);
            this._Label15.TabIndex = 26;
            this._Label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // _Label16
            // 
            this._Label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Label16.Location = new System.Drawing.Point(296, 49);
            this._Label16.Name = "_Label16";
            this._Label16.Size = new System.Drawing.Size(20, 20);
            this._Label16.TabIndex = 25;
            this._Label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // _Label17
            // 
            this._Label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this._Label17.Location = new System.Drawing.Point(244, 49);
            this._Label17.Name = "_Label17";
            this._Label17.Size = new System.Drawing.Size(20, 20);
            this._Label17.TabIndex = 24;
            this._Label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // _Label18
            // 
            this._Label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this._Label18.Location = new System.Drawing.Point(218, 49);
            this._Label18.Name = "_Label18";
            this._Label18.Size = new System.Drawing.Size(20, 20);
            this._Label18.TabIndex = 23;
            this._Label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // _Label19
            // 
            this._Label19.BackColor = System.Drawing.Color.Purple;
            this._Label19.Location = new System.Drawing.Point(348, 20);
            this._Label19.Name = "_Label19";
            this._Label19.Size = new System.Drawing.Size(20, 20);
            this._Label19.TabIndex = 40;
            this._Label19.Click += new System.EventHandler(this.Label19_Click);
            // 
            // _Label20
            // 
            this._Label20.BackColor = System.Drawing.Color.Olive;
            this._Label20.Location = new System.Drawing.Point(322, 20);
            this._Label20.Name = "_Label20";
            this._Label20.Size = new System.Drawing.Size(20, 20);
            this._Label20.TabIndex = 39;
            this._Label20.Click += new System.EventHandler(this.Label20_Click);
            // 
            // _Label21
            // 
            this._Label21.BackColor = System.Drawing.Color.Teal;
            this._Label21.Location = new System.Drawing.Point(139, 49);
            this._Label21.Name = "_Label21";
            this._Label21.Size = new System.Drawing.Size(20, 20);
            this._Label21.TabIndex = 38;
            this._Label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // _Label22
            // 
            this._Label22.BackColor = System.Drawing.Color.Gray;
            this._Label22.Location = new System.Drawing.Point(270, 49);
            this._Label22.Name = "_Label22";
            this._Label22.Size = new System.Drawing.Size(20, 20);
            this._Label22.TabIndex = 37;
            this._Label22.Click += new System.EventHandler(this.Label22_Click);
            // 
            // _Label23
            // 
            this._Label23.BackColor = System.Drawing.Color.White;
            this._Label23.Location = new System.Drawing.Point(348, 79);
            this._Label23.Name = "_Label23";
            this._Label23.Size = new System.Drawing.Size(20, 20);
            this._Label23.TabIndex = 36;
            this._Label23.Click += new System.EventHandler(this.Label23_Click);
            // 
            // _Label24
            // 
            this._Label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._Label24.Location = new System.Drawing.Point(322, 79);
            this._Label24.Name = "_Label24";
            this._Label24.Size = new System.Drawing.Size(20, 20);
            this._Label24.TabIndex = 35;
            this._Label24.Click += new System.EventHandler(this.Label24_Click);
            // 
            // _Label25
            // 
            this._Label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._Label25.Location = new System.Drawing.Point(296, 79);
            this._Label25.Name = "_Label25";
            this._Label25.Size = new System.Drawing.Size(20, 20);
            this._Label25.TabIndex = 34;
            this._Label25.Click += new System.EventHandler(this.Label25_Click);
            // 
            // _Label26
            // 
            this._Label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._Label26.Location = new System.Drawing.Point(270, 79);
            this._Label26.Name = "_Label26";
            this._Label26.Size = new System.Drawing.Size(20, 20);
            this._Label26.TabIndex = 33;
            this._Label26.Click += new System.EventHandler(this.Label26_Click);
            // 
            // _Label27
            // 
            this._Label27.BackColor = System.Drawing.Color.Cyan;
            this._Label27.Location = new System.Drawing.Point(244, 79);
            this._Label27.Name = "_Label27";
            this._Label27.Size = new System.Drawing.Size(20, 20);
            this._Label27.TabIndex = 32;
            this._Label27.Click += new System.EventHandler(this.Label27_Click);
            // 
            // Label28
            // 
            this.Label28.BackColor = System.Drawing.Color.Red;
            this.Label28.Location = new System.Drawing.Point(15, 115);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(108, 5);
            this.Label28.TabIndex = 41;
            this.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.Green;
            this.Label29.Location = new System.Drawing.Point(15, 153);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(108, 5);
            this.Label29.TabIndex = 42;
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label30
            // 
            this.Label30.BackColor = System.Drawing.Color.Blue;
            this.Label30.Location = new System.Drawing.Point(15, 187);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(108, 5);
            this.Label30.TabIndex = 42;
            this.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this._BarA);
            this.GroupBox1.Controls.Add(this._txtA);
            this.GroupBox1.Location = new System.Drawing.Point(183, 120);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(185, 46);
            this.GroupBox1.TabIndex = 44;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Set Transparency";
            // 
            // FrmTransparency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(387, 223);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label30);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.Label28);
            this.Controls.Add(this._Label19);
            this.Controls.Add(this._Label20);
            this.Controls.Add(this._Label21);
            this.Controls.Add(this._Label22);
            this.Controls.Add(this._Label23);
            this.Controls.Add(this._Label24);
            this.Controls.Add(this._Label25);
            this.Controls.Add(this._Label26);
            this.Controls.Add(this._Label27);
            this.Controls.Add(this._Label10);
            this.Controls.Add(this._Label11);
            this.Controls.Add(this._Label12);
            this.Controls.Add(this._Label13);
            this.Controls.Add(this._Label14);
            this.Controls.Add(this._Label15);
            this.Controls.Add(this._Label16);
            this.Controls.Add(this._Label17);
            this.Controls.Add(this._Label18);
            this.Controls.Add(this._Label7);
            this.Controls.Add(this._Label8);
            this.Controls.Add(this._Label9);
            this.Controls.Add(this._Label4);
            this.Controls.Add(this._Label5);
            this.Controls.Add(this._Label6);
            this.Controls.Add(this._Label3);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Label1);
            this.Controls.Add(this._txtB);
            this.Controls.Add(this._txtG);
            this.Controls.Add(this._txtR);
            this.Controls.Add(this._BarB);
            this.Controls.Add(this._BarG);
            this.Controls.Add(this._BarR);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransparency";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Color and Transparency";
            this.Load += new System.EventHandler(this.FrmTransparency_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTransparency_Paint);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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