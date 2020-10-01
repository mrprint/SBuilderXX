using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmCalibrate : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalibrate));
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this._cmdLL2 = new System.Windows.Forms.Button();
            this.txtLon2 = new System.Windows.Forms.TextBox();
            this.txtLat2 = new System.Windows.Forms.TextBox();
            this.txtPX2 = new System.Windows.Forms.TextBox();
            this.txtPY2 = new System.Windows.Forms.TextBox();
            this._cmdPP2 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this._cmdCalibrate = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdHelp = new System.Windows.Forms.Button();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.optLat = new System.Windows.Forms.RadioButton();
            this.optLon = new System.Windows.Forms.RadioButton();
            this.optLatLon = new System.Windows.Forms.RadioButton();
            this.Frame4 = new System.Windows.Forms.GroupBox();
            this._cmdPP1 = new System.Windows.Forms.Button();
            this.txtPY1 = new System.Windows.Forms.TextBox();
            this.txtPX1 = new System.Windows.Forms.TextBox();
            this.txtLat1 = new System.Windows.Forms.TextBox();
            this.txtLon1 = new System.Windows.Forms.TextBox();
            this._cmdLL1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Frame1.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.Frame4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this._cmdLL2);
            this.Frame1.Controls.Add(this.txtLon2);
            this.Frame1.Controls.Add(this.txtLat2);
            this.Frame1.Controls.Add(this.txtPX2);
            this.Frame1.Controls.Add(this.txtPY2);
            this.Frame1.Controls.Add(this._cmdPP2);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.Label5);
            this.Frame1.Controls.Add(this.Label4);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 141);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(319, 118);
            this.Frame1.TabIndex = 24;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Lat/Lon and Pixel X/Y of Point P2";
            // 
            // _cmdLL2
            // 
            this._cmdLL2.BackColor = System.Drawing.SystemColors.Control;
            this._cmdLL2.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLL2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLL2.Location = new System.Drawing.Point(15, 54);
            this._cmdLL2.Name = "_cmdLL2";
            this._cmdLL2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLL2.Size = new System.Drawing.Size(52, 25);
            this._cmdLL2.TabIndex = 24;
            this._cmdLL2.Text = "Change";
            this._cmdLL2.UseVisualStyleBackColor = false;
            this._cmdLL2.Click += new System.EventHandler(this.CmdLL2_Click);
            // 
            // txtLon2
            // 
            this.txtLon2.AcceptsReturn = true;
            this.txtLon2.BackColor = System.Drawing.SystemColors.Window;
            this.txtLon2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLon2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLon2.Location = new System.Drawing.Point(75, 81);
            this.txtLon2.MaxLength = 0;
            this.txtLon2.Name = "txtLon2";
            this.txtLon2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLon2.Size = new System.Drawing.Size(103, 20);
            this.txtLon2.TabIndex = 23;
            this.txtLon2.Text = "W001:00:00.0000";
            this.txtLon2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLat2
            // 
            this.txtLat2.AcceptsReturn = true;
            this.txtLat2.BackColor = System.Drawing.SystemColors.Window;
            this.txtLat2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLat2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLat2.Location = new System.Drawing.Point(75, 36);
            this.txtLat2.MaxLength = 0;
            this.txtLat2.Name = "txtLat2";
            this.txtLat2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLat2.Size = new System.Drawing.Size(103, 20);
            this.txtLat2.TabIndex = 22;
            this.txtLat2.Text = "N01:00:00.0000";
            this.txtLat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPX2
            // 
            this.txtPX2.AcceptsReturn = true;
            this.txtPX2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPX2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPX2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPX2.Location = new System.Drawing.Point(189, 36);
            this.txtPX2.MaxLength = 0;
            this.txtPX2.Name = "txtPX2";
            this.txtPX2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPX2.Size = new System.Drawing.Size(46, 20);
            this.txtPX2.TabIndex = 21;
            this.txtPX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPY2
            // 
            this.txtPY2.AcceptsReturn = true;
            this.txtPY2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPY2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPY2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPY2.Location = new System.Drawing.Point(189, 81);
            this.txtPY2.MaxLength = 0;
            this.txtPY2.Name = "txtPY2";
            this.txtPY2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPY2.Size = new System.Drawing.Size(46, 20);
            this.txtPY2.TabIndex = 20;
            this.txtPY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdPP2
            // 
            this._cmdPP2.BackColor = System.Drawing.SystemColors.Control;
            this._cmdPP2.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdPP2.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdPP2.Location = new System.Drawing.Point(243, 54);
            this._cmdPP2.Name = "_cmdPP2";
            this._cmdPP2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdPP2.Size = new System.Drawing.Size(55, 25);
            this._cmdPP2.TabIndex = 19;
            this._cmdPP2.Text = "Change";
            this._cmdPP2.UseVisualStyleBackColor = false;
            this._cmdPP2.Click += new System.EventHandler(this.CmdPP2_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(75, 21);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(52, 13);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "Latitude :";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(75, 66);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(58, 13);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Longitude :";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(189, 21);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(46, 16);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Pixel X";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(189, 66);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(52, 19);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Pixel Y";
            // 
            // _cmdCalibrate
            // 
            this._cmdCalibrate.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalibrate.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalibrate.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalibrate.Location = new System.Drawing.Point(369, 234);
            this._cmdCalibrate.Name = "_cmdCalibrate";
            this._cmdCalibrate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalibrate.Size = new System.Drawing.Size(79, 25);
            this._cmdCalibrate.TabIndex = 23;
            this._cmdCalibrate.Text = "Calibrate";
            this._cmdCalibrate.UseVisualStyleBackColor = false;
            this._cmdCalibrate.Click += new System.EventHandler(this.CmdCalibrate_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(369, 195);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(79, 25);
            this._cmdCancel.TabIndex = 22;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdHelp
            // 
            this._cmdHelp.BackColor = System.Drawing.SystemColors.Control;
            this._cmdHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdHelp.Location = new System.Drawing.Point(369, 156);
            this._cmdHelp.Name = "_cmdHelp";
            this._cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdHelp.Size = new System.Drawing.Size(79, 25);
            this._cmdHelp.TabIndex = 21;
            this._cmdHelp.Text = "Help";
            this._cmdHelp.UseVisualStyleBackColor = false;
            this._cmdHelp.Click += new System.EventHandler(this.CmdHelp_Click);
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.SystemColors.Control;
            this.Frame3.Controls.Add(this.optLat);
            this.Frame3.Controls.Add(this.optLon);
            this.Frame3.Controls.Add(this.optLatLon);
            this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame3.Location = new System.Drawing.Point(348, 12);
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(112, 106);
            this.Frame3.TabIndex = 20;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "How to Calibrate";
            // 
            // optLat
            // 
            this.optLat.BackColor = System.Drawing.SystemColors.Control;
            this.optLat.Cursor = System.Windows.Forms.Cursors.Default;
            this.optLat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optLat.Location = new System.Drawing.Point(9, 21);
            this.optLat.Name = "optLat";
            this.optLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optLat.Size = new System.Drawing.Size(88, 30);
            this.optLat.TabIndex = 14;
            this.optLat.TabStop = true;
            this.optLat.Text = "Use Latitude";
            this.optLat.UseVisualStyleBackColor = false;
            // 
            // optLon
            // 
            this.optLon.BackColor = System.Drawing.SystemColors.Control;
            this.optLon.Cursor = System.Windows.Forms.Cursors.Default;
            this.optLon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optLon.Location = new System.Drawing.Point(9, 48);
            this.optLon.Name = "optLon";
            this.optLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optLon.Size = new System.Drawing.Size(97, 21);
            this.optLon.TabIndex = 13;
            this.optLon.TabStop = true;
            this.optLon.Text = "Use Longitude";
            this.optLon.UseVisualStyleBackColor = false;
            // 
            // optLatLon
            // 
            this.optLatLon.BackColor = System.Drawing.SystemColors.Control;
            this.optLatLon.Checked = true;
            this.optLatLon.Cursor = System.Windows.Forms.Cursors.Default;
            this.optLatLon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optLatLon.Location = new System.Drawing.Point(9, 75);
            this.optLatLon.Name = "optLatLon";
            this.optLatLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optLatLon.Size = new System.Drawing.Size(83, 17);
            this.optLatLon.TabIndex = 12;
            this.optLatLon.TabStop = true;
            this.optLatLon.Text = "Use Both";
            this.optLatLon.UseVisualStyleBackColor = false;
            // 
            // Frame4
            // 
            this.Frame4.BackColor = System.Drawing.SystemColors.Control;
            this.Frame4.Controls.Add(this._cmdPP1);
            this.Frame4.Controls.Add(this.txtPY1);
            this.Frame4.Controls.Add(this.txtPX1);
            this.Frame4.Controls.Add(this.txtLat1);
            this.Frame4.Controls.Add(this.txtLon1);
            this.Frame4.Controls.Add(this._cmdLL1);
            this.Frame4.Controls.Add(this.Label2);
            this.Frame4.Controls.Add(this.Label1);
            this.Frame4.Controls.Add(this.Label20);
            this.Frame4.Controls.Add(this.Label19);
            this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame4.Location = new System.Drawing.Point(12, 12);
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame4.Size = new System.Drawing.Size(319, 118);
            this.Frame4.TabIndex = 19;
            this.Frame4.TabStop = false;
            this.Frame4.Text = "Lat/Lon and Pixel X/Y of Point P1";
            // 
            // _cmdPP1
            // 
            this._cmdPP1.BackColor = System.Drawing.SystemColors.Control;
            this._cmdPP1.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdPP1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdPP1.Location = new System.Drawing.Point(243, 54);
            this._cmdPP1.Name = "_cmdPP1";
            this._cmdPP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdPP1.Size = new System.Drawing.Size(55, 25);
            this._cmdPP1.TabIndex = 8;
            this._cmdPP1.Text = "Change";
            this._cmdPP1.UseVisualStyleBackColor = false;
            this._cmdPP1.Click += new System.EventHandler(this.CmdPP1_Click);
            // 
            // txtPY1
            // 
            this.txtPY1.AcceptsReturn = true;
            this.txtPY1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPY1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPY1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPY1.Location = new System.Drawing.Point(189, 81);
            this.txtPY1.MaxLength = 0;
            this.txtPY1.Name = "txtPY1";
            this.txtPY1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPY1.Size = new System.Drawing.Size(46, 20);
            this.txtPY1.TabIndex = 7;
            this.txtPY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPX1
            // 
            this.txtPX1.AcceptsReturn = true;
            this.txtPX1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPX1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPX1.Location = new System.Drawing.Point(189, 36);
            this.txtPX1.MaxLength = 0;
            this.txtPX1.Name = "txtPX1";
            this.txtPX1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPX1.Size = new System.Drawing.Size(46, 20);
            this.txtPX1.TabIndex = 6;
            this.txtPX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLat1
            // 
            this.txtLat1.AcceptsReturn = true;
            this.txtLat1.BackColor = System.Drawing.SystemColors.Window;
            this.txtLat1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLat1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLat1.Location = new System.Drawing.Point(75, 36);
            this.txtLat1.MaxLength = 0;
            this.txtLat1.Name = "txtLat1";
            this.txtLat1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLat1.Size = new System.Drawing.Size(103, 20);
            this.txtLat1.TabIndex = 3;
            this.txtLat1.Text = "N01:00:00.0000";
            this.txtLat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLon1
            // 
            this.txtLon1.AcceptsReturn = true;
            this.txtLon1.BackColor = System.Drawing.SystemColors.Window;
            this.txtLon1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLon1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLon1.Location = new System.Drawing.Point(75, 81);
            this.txtLon1.MaxLength = 0;
            this.txtLon1.Name = "txtLon1";
            this.txtLon1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLon1.Size = new System.Drawing.Size(103, 20);
            this.txtLon1.TabIndex = 2;
            this.txtLon1.Text = "W001:00:00.0000";
            this.txtLon1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdLL1
            // 
            this._cmdLL1.BackColor = System.Drawing.SystemColors.Control;
            this._cmdLL1.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLL1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLL1.Location = new System.Drawing.Point(15, 54);
            this._cmdLL1.Name = "_cmdLL1";
            this._cmdLL1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLL1.Size = new System.Drawing.Size(52, 25);
            this._cmdLL1.TabIndex = 1;
            this._cmdLL1.Text = "Change";
            this._cmdLL1.UseVisualStyleBackColor = false;
            this._cmdLL1.Click += new System.EventHandler(this.CmdLL1_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(189, 66);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(52, 19);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Pixel Y";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(189, 21);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(46, 16);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Pixel X";
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.SystemColors.Control;
            this.Label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label20.Location = new System.Drawing.Point(75, 66);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(58, 13);
            this.Label20.TabIndex = 5;
            this.Label20.Text = "Longitude :";
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.SystemColors.Control;
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label19.Location = new System.Drawing.Point(75, 21);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(52, 13);
            this.Label19.TabIndex = 4;
            this.Label19.Text = "Latitude :";
            // 
            // FrmCalibrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 277);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this._cmdCalibrate);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdHelp);
            this.Controls.Add(this.Frame3);
            this.Controls.Add(this.Frame4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalibrate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBuilderXX - Map Calibration";
            this.Load += new System.EventHandler(this.FrmCalibrate_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame3.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.Frame4.PerformLayout();
            this.ResumeLayout(false);

        }

        public GroupBox Frame1;
        private Button _cmdLL2;

        public Button cmdLL2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLL2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLL2 != null)
                {
                    _cmdLL2.Click -= CmdLL2_Click;
                }

                _cmdLL2 = value;
                if (_cmdLL2 != null)
                {
                    _cmdLL2.Click += CmdLL2_Click;
                }
            }
        }

        public TextBox txtLon2;
        public TextBox txtLat2;
        public TextBox txtPX2;
        public TextBox txtPY2;
        private Button _cmdPP2;

        public Button cmdPP2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPP2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPP2 != null)
                {
                    _cmdPP2.Click -= CmdPP2_Click;
                }

                _cmdPP2 = value;
                if (_cmdPP2 != null)
                {
                    _cmdPP2.Click += CmdPP2_Click;
                }
            }
        }

        public Label Label6;
        public Label Label5;
        public Label Label4;
        public Label Label3;
        private Button _cmdCalibrate;

        public Button cmdCalibrate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalibrate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalibrate != null)
                {
                    _cmdCalibrate.Click -= CmdCalibrate_Click;
                }

                _cmdCalibrate = value;
                if (_cmdCalibrate != null)
                {
                    _cmdCalibrate.Click += CmdCalibrate_Click;
                }
            }
        }

        private Button _cmdCancel;

        public Button cmdCancel
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

        private Button _cmdHelp;

        public Button cmdHelp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHelp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHelp != null)
                {
                    _cmdHelp.Click -= CmdHelp_Click;
                }

                _cmdHelp = value;
                if (_cmdHelp != null)
                {
                    _cmdHelp.Click += CmdHelp_Click;
                }
            }
        }

        public GroupBox Frame3;
        public RadioButton optLat;
        public RadioButton optLon;
        public RadioButton optLatLon;
        public GroupBox Frame4;
        private Button _cmdPP1;

        public Button cmdPP1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPP1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPP1 != null)
                {
                    _cmdPP1.Click -= CmdPP1_Click;
                }

                _cmdPP1 = value;
                if (_cmdPP1 != null)
                {
                    _cmdPP1.Click += CmdPP1_Click;
                }
            }
        }

        public TextBox txtPY1;
        public TextBox txtPX1;
        public TextBox txtLat1;
        public TextBox txtLon1;
        private Button _cmdLL1;

        public Button cmdLL1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLL1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLL1 != null)
                {
                    _cmdLL1.Click -= CmdLL1_Click;
                }

                _cmdLL1 = value;
                if (_cmdLL1 != null)
                {
                    _cmdLL1.Click += CmdLL1_Click;
                }
            }
        }

        public Label Label2;
        public Label Label1;
        public Label Label20;
        public Label Label19;
    }
}