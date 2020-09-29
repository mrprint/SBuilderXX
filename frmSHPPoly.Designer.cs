﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmSHPPoly : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSHPPoly));
            cmdHelp = new Button();
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            GroupBox4 = new GroupBox();
            Label7 = new Label();
            Label6 = new Label();
            _txtGUID = new TextBox();
            _txtGUID.Click += new EventHandler(TxtGUID_Click);
            _cmbGUID = new ComboBox();
            _cmbGUID.SelectedIndexChanged += new EventHandler(CmbGUID_SelectedIndexChanged);
            GroupBox3 = new GroupBox();
            Label9 = new Label();
            Label8 = new Label();
            _lbColor = new Label();
            _lbColor.Click += new EventHandler(LbColor_Click);
            Label2 = new Label();
            Label3 = new Label();
            txtAltitude = new TextBox();
            _cmbAltitude = new ComboBox();
            _cmbAltitude.SelectedIndexChanged += new EventHandler(CmbAltitude_SelectedIndexChanged);
            _cmbColor = new ComboBox();
            _cmbColor.SelectedIndexChanged += new EventHandler(CmbColor_SelectedIndexChanged);
            GroupBox1 = new GroupBox();
            Label1 = new Label();
            txtName = new TextBox();
            _cmbName = new ComboBox();
            _cmbName.SelectedIndexChanged += new EventHandler(CmbName_SelectedIndexChanged);
            GroupBox4.SuspendLayout();
            GroupBox3.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdHelp
            // 
            cmdHelp.Location = new Point(344, 163);
            cmdHelp.Name = "cmdHelp";
            cmdHelp.Size = new Size(65, 26);
            cmdHelp.TabIndex = 17;
            cmdHelp.Text = "Help";
            cmdHelp.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(511, 163);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(65, 26);
            _cmdOK.TabIndex = 16;
            _cmdOK.Text = "Continue";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(429, 163);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(65, 26);
            _cmdCancel.TabIndex = 15;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            GroupBox4.Controls.Add(Label7);
            GroupBox4.Controls.Add(Label6);
            GroupBox4.Controls.Add(_txtGUID);
            GroupBox4.Controls.Add(_cmbGUID);
            GroupBox4.Location = new Point(12, 119);
            GroupBox4.Name = "GroupBox4";
            GroupBox4.Size = new Size(269, 97);
            GroupBox4.TabIndex = 14;
            GroupBox4.TabStop = false;
            GroupBox4.Text = "GUID of Imported Polys";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(11, 18);
            Label7.Name = "Label7";
            Label7.Size = new Size(148, 13);
            Label7.TabIndex = 8;
            Label7.Text = "Click to set the GUID (or type)";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(46, 66);
            Label6.Name = "Label6";
            Label6.Size = new Size(91, 13);
            Label6.TabIndex = 7;
            Label6.Text = "Get from this Field";
            // 
            // txtGUID
            // 
            _txtGUID.BackColor = Color.White;
            _txtGUID.Location = new Point(14, 34);
            _txtGUID.Name = "_txtGUID";
            _txtGUID.ReadOnly = true;
            _txtGUID.Size = new Size(239, 20);
            _txtGUID.TabIndex = 6;
            _txtGUID.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGUID
            // 
            _cmbGUID.FormattingEnabled = true;
            _cmbGUID.Items.AddRange(new object[] { "Use GUID above" });
            _cmbGUID.Location = new Point(143, 63);
            _cmbGUID.Name = "_cmbGUID";
            _cmbGUID.Size = new Size(110, 21);
            _cmbGUID.TabIndex = 5;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(Label9);
            GroupBox3.Controls.Add(Label8);
            GroupBox3.Controls.Add(_lbColor);
            GroupBox3.Controls.Add(Label2);
            GroupBox3.Controls.Add(Label3);
            GroupBox3.Controls.Add(txtAltitude);
            GroupBox3.Controls.Add(_cmbAltitude);
            GroupBox3.Controls.Add(_cmbColor);
            GroupBox3.Location = new Point(304, 12);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(298, 122);
            GroupBox3.TabIndex = 13;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Altitude and Color of Imported Polys";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(95, 26);
            Label9.Name = "Label9";
            Label9.Size = new Size(55, 13);
            Label9.TabIndex = 17;
            Label9.Text = "Use these";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(166, 26);
            Label8.Name = "Label8";
            Label8.Size = new Size(106, 13);
            Label8.TabIndex = 16;
            Label8.Text = "Get from these Fields";
            // 
            // lbColor
            // 
            _lbColor.BorderStyle = BorderStyle.Fixed3D;
            _lbColor.FlatStyle = FlatStyle.Popup;
            _lbColor.Location = new Point(128, 80);
            _lbColor.Name = "_lbColor";
            _lbColor.Size = new Size(20, 21);
            _lbColor.TabIndex = 15;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(6, 84);
            Label2.Name = "Label2";
            Label2.Size = new Size(113, 13);
            Label2.TabIndex = 7;
            Label2.Text = "Color (click to change)";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(10, 48);
            Label3.Name = "Label3";
            Label3.Size = new Size(82, 13);
            Label3.TabIndex = 9;
            Label3.Text = "Altitude (meters)";
            // 
            // txtAltitude
            // 
            txtAltitude.Location = new Point(98, 44);
            txtAltitude.Name = "txtAltitude";
            txtAltitude.Size = new Size(52, 20);
            txtAltitude.TabIndex = 12;
            txtAltitude.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbAltitude
            // 
            _cmbAltitude.FormattingEnabled = true;
            _cmbAltitude.Items.AddRange(new object[] { "Value on the left" });
            _cmbAltitude.Location = new Point(169, 43);
            _cmbAltitude.Name = "_cmbAltitude";
            _cmbAltitude.Size = new Size(111, 21);
            _cmbAltitude.TabIndex = 11;
            // 
            // cmbColor
            // 
            _cmbColor.FormattingEnabled = true;
            _cmbColor.Items.AddRange(new object[] { "Color on the left" });
            _cmbColor.Location = new Point(167, 80);
            _cmbColor.Name = "_cmbColor";
            _cmbColor.Size = new Size(111, 21);
            _cmbColor.TabIndex = 8;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(txtName);
            GroupBox1.Controls.Add(_cmbName);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(269, 82);
            GroupBox1.TabIndex = 12;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Name or Label of Imported Polys";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(46, 51);
            Label1.Name = "Label1";
            Label1.Size = new Size(91, 13);
            Label1.TabIndex = 7;
            Label1.Text = "Get from this Field";
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 20);
            txtName.TabIndex = 6;
            txtName.Text = "Polygon imported from a shape file";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbName
            // 
            _cmbName.FormattingEnabled = true;
            _cmbName.Items.AddRange(new object[] { "Use text above" });
            _cmbName.Location = new Point(143, 48);
            _cmbName.Name = "_cmbName";
            _cmbName.Size = new Size(110, 21);
            _cmbName.TabIndex = 5;
            // 
            // frmSHPPoly
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 232);
            Controls.Add(cmdHelp);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(GroupBox4);
            Controls.Add(GroupBox3);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSHPPoly";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Appending a Polygon ShapeFile";
            GroupBox4.ResumeLayout(false);
            GroupBox4.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            FormClosing += new FormClosingEventHandler(FrmSHPPoly_FormClosing);
            Load += new EventHandler(FrmSHPPoly_Load);
            ResumeLayout(false);
        }

        internal Button cmdHelp;
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

        internal GroupBox GroupBox4;
        internal Label Label7;
        internal Label Label6;
        private TextBox _txtGUID;

        internal TextBox txtGUID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtGUID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtGUID != null)
                {
                    _txtGUID.Click -= TxtGUID_Click;
                }

                _txtGUID = value;
                if (_txtGUID != null)
                {
                    _txtGUID.Click += TxtGUID_Click;
                }
            }
        }

        private ComboBox _cmbGUID;

        internal ComboBox cmbGUID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbGUID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbGUID != null)
                {
                    _cmbGUID.SelectedIndexChanged -= CmbGUID_SelectedIndexChanged;
                }

                _cmbGUID = value;
                if (_cmbGUID != null)
                {
                    _cmbGUID.SelectedIndexChanged += CmbGUID_SelectedIndexChanged;
                }
            }
        }

        internal GroupBox GroupBox3;
        internal Label Label9;
        internal Label Label8;
        private Label _lbColor;

        internal Label lbColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbColor != null)
                {
                    _lbColor.Click -= LbColor_Click;
                }

                _lbColor = value;
                if (_lbColor != null)
                {
                    _lbColor.Click += LbColor_Click;
                }
            }
        }

        internal Label Label2;
        internal Label Label3;
        internal TextBox txtAltitude;
        private ComboBox _cmbAltitude;

        internal ComboBox cmbAltitude
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbAltitude;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbAltitude != null)
                {
                    _cmbAltitude.SelectedIndexChanged -= CmbAltitude_SelectedIndexChanged;
                }

                _cmbAltitude = value;
                if (_cmbAltitude != null)
                {
                    _cmbAltitude.SelectedIndexChanged += CmbAltitude_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cmbColor;

        internal ComboBox cmbColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbColor != null)
                {
                    _cmbColor.SelectedIndexChanged -= CmbColor_SelectedIndexChanged;
                }

                _cmbColor = value;
                if (_cmbColor != null)
                {
                    _cmbColor.SelectedIndexChanged += CmbColor_SelectedIndexChanged;
                }
            }
        }

        internal GroupBox GroupBox1;
        internal Label Label1;
        internal TextBox txtName;
        private ComboBox _cmbName;

        internal ComboBox cmbName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbName != null)
                {
                    _cmbName.SelectedIndexChanged -= CmbName_SelectedIndexChanged;
                }

                _cmbName = value;
                if (_cmbName != null)
                {
                    _cmbName.SelectedIndexChanged += CmbName_SelectedIndexChanged;
                }
            }
        }
    }
}