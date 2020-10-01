using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSHPPoly));
            this.cmdHelp = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this._txtGUID = new System.Windows.Forms.TextBox();
            this._cmbGUID = new System.Windows.Forms.ComboBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this._lbColor = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this._cmbAltitude = new System.Windows.Forms.ComboBox();
            this._cmbColor = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this._cmbName = new System.Windows.Forms.ComboBox();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdHelp
            // 
            this.cmdHelp.Location = new System.Drawing.Point(344, 163);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(65, 26);
            this.cmdHelp.TabIndex = 17;
            this.cmdHelp.Text = "Help";
            this.cmdHelp.UseVisualStyleBackColor = true;
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(511, 163);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(65, 26);
            this._cmdOK.TabIndex = 16;
            this._cmdOK.Text = "Continue";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(429, 163);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(65, 26);
            this._cmdCancel.TabIndex = 15;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this._txtGUID);
            this.GroupBox4.Controls.Add(this._cmbGUID);
            this.GroupBox4.Location = new System.Drawing.Point(12, 119);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(269, 97);
            this.GroupBox4.TabIndex = 14;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "GUID of Imported Polys";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(11, 18);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(148, 13);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Click to set the GUID (or type)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(46, 66);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(91, 13);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Get from this Field";
            // 
            // _txtGUID
            // 
            this._txtGUID.BackColor = System.Drawing.Color.White;
            this._txtGUID.Location = new System.Drawing.Point(14, 34);
            this._txtGUID.Name = "_txtGUID";
            this._txtGUID.ReadOnly = true;
            this._txtGUID.Size = new System.Drawing.Size(239, 20);
            this._txtGUID.TabIndex = 6;
            this._txtGUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtGUID.Click += new System.EventHandler(this.TxtGUID_Click);
            // 
            // _cmbGUID
            // 
            this._cmbGUID.FormattingEnabled = true;
            this._cmbGUID.Items.AddRange(new object[] {
            "Use GUID above"});
            this._cmbGUID.Location = new System.Drawing.Point(143, 63);
            this._cmbGUID.Name = "_cmbGUID";
            this._cmbGUID.Size = new System.Drawing.Size(110, 21);
            this._cmbGUID.TabIndex = 5;
            this._cmbGUID.SelectedIndexChanged += new System.EventHandler(this.CmbGUID_SelectedIndexChanged);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this._lbColor);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.txtAltitude);
            this.GroupBox3.Controls.Add(this._cmbAltitude);
            this.GroupBox3.Controls.Add(this._cmbColor);
            this.GroupBox3.Location = new System.Drawing.Point(304, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(298, 122);
            this.GroupBox3.TabIndex = 13;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Altitude and Color of Imported Polys";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(95, 26);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(55, 13);
            this.Label9.TabIndex = 17;
            this.Label9.Text = "Use these";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(166, 26);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(106, 13);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Get from these Fields";
            // 
            // _lbColor
            // 
            this._lbColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lbColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._lbColor.Location = new System.Drawing.Point(128, 80);
            this._lbColor.Name = "_lbColor";
            this._lbColor.Size = new System.Drawing.Size(20, 21);
            this._lbColor.TabIndex = 15;
            this._lbColor.Click += new System.EventHandler(this.LbColor_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(113, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Color (click to change)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Altitude (meters)";
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(98, 44);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(52, 20);
            this.txtAltitude.TabIndex = 12;
            this.txtAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmbAltitude
            // 
            this._cmbAltitude.FormattingEnabled = true;
            this._cmbAltitude.Items.AddRange(new object[] {
            "Value on the left"});
            this._cmbAltitude.Location = new System.Drawing.Point(169, 43);
            this._cmbAltitude.Name = "_cmbAltitude";
            this._cmbAltitude.Size = new System.Drawing.Size(111, 21);
            this._cmbAltitude.TabIndex = 11;
            this._cmbAltitude.SelectedIndexChanged += new System.EventHandler(this.CmbAltitude_SelectedIndexChanged);
            // 
            // _cmbColor
            // 
            this._cmbColor.FormattingEnabled = true;
            this._cmbColor.Items.AddRange(new object[] {
            "Color on the left"});
            this._cmbColor.Location = new System.Drawing.Point(167, 80);
            this._cmbColor.Name = "_cmbColor";
            this._cmbColor.Size = new System.Drawing.Size(111, 21);
            this._cmbColor.TabIndex = 8;
            this._cmbColor.SelectedIndexChanged += new System.EventHandler(this.CmbColor_SelectedIndexChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtName);
            this.GroupBox1.Controls.Add(this._cmbName);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(269, 82);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Name or Label of Imported Polys";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(46, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Get from this Field";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "Polygon imported from a shape file";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmbName
            // 
            this._cmbName.FormattingEnabled = true;
            this._cmbName.Items.AddRange(new object[] {
            "Use text above"});
            this._cmbName.Location = new System.Drawing.Point(143, 48);
            this._cmbName.Name = "_cmbName";
            this._cmbName.Size = new System.Drawing.Size(110, 21);
            this._cmbName.TabIndex = 5;
            this._cmbName.SelectedIndexChanged += new System.EventHandler(this.CmbName_SelectedIndexChanged);
            // 
            // FrmSHPPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 232);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSHPPoly";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Appending a Polygon ShapeFile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSHPPoly_FormClosing);
            this.Load += new System.EventHandler(this.FrmSHPPoly_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

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