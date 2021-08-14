using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmExcludesP
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FrmExcludesP() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public TextBox txtSouth;
        public TextBox txtEast;
        public TextBox txtNorth;
        public TextBox txtWest;
        public CheckBox ckWind;
        public CheckBox ckTrigger;
        public CheckBox ckTaxi;
        public CheckBox ckLibrary;
        public CheckBox ckGenBuilds;
        public CheckBox ckEffects;
        public CheckBox ckBeacons;
        public CheckBox ckAll;
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

        private Button _cmdOK;

        public Button cmdOK
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

        public Label Label4;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcludesP));
            this.txtSouth = new System.Windows.Forms.TextBox();
            this.txtEast = new System.Windows.Forms.TextBox();
            this.txtNorth = new System.Windows.Forms.TextBox();
            this.txtWest = new System.Windows.Forms.TextBox();
            this.ckWind = new System.Windows.Forms.CheckBox();
            this.ckTrigger = new System.Windows.Forms.CheckBox();
            this.ckTaxi = new System.Windows.Forms.CheckBox();
            this.ckLibrary = new System.Windows.Forms.CheckBox();
            this.ckGenBuilds = new System.Windows.Forms.CheckBox();
            this.ckEffects = new System.Windows.Forms.CheckBox();
            this.ckBeacons = new System.Windows.Forms.CheckBox();
            this.ckAll = new System.Windows.Forms.CheckBox();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ckBridges = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtSouth
            // 
            this.txtSouth.AcceptsReturn = true;
            this.txtSouth.BackColor = System.Drawing.SystemColors.Window;
            this.txtSouth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSouth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSouth.Location = new System.Drawing.Point(182, 143);
            this.txtSouth.MaxLength = 0;
            this.txtSouth.Name = "txtSouth";
            this.txtSouth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSouth.Size = new System.Drawing.Size(110, 20);
            this.txtSouth.TabIndex = 15;
            this.txtSouth.Text = "Text1";
            this.txtSouth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEast
            // 
            this.txtEast.AcceptsReturn = true;
            this.txtEast.BackColor = System.Drawing.SystemColors.Window;
            this.txtEast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEast.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEast.Location = new System.Drawing.Point(182, 191);
            this.txtEast.MaxLength = 0;
            this.txtEast.Name = "txtEast";
            this.txtEast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEast.Size = new System.Drawing.Size(110, 20);
            this.txtEast.TabIndex = 14;
            this.txtEast.Text = "Text1";
            this.txtEast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNorth
            // 
            this.txtNorth.AcceptsReturn = true;
            this.txtNorth.BackColor = System.Drawing.SystemColors.Window;
            this.txtNorth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNorth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNorth.Location = new System.Drawing.Point(27, 40);
            this.txtNorth.MaxLength = 0;
            this.txtNorth.Name = "txtNorth";
            this.txtNorth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNorth.Size = new System.Drawing.Size(110, 20);
            this.txtNorth.TabIndex = 11;
            this.txtNorth.Text = "Text1";
            this.txtNorth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWest
            // 
            this.txtWest.AcceptsReturn = true;
            this.txtWest.BackColor = System.Drawing.SystemColors.Window;
            this.txtWest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWest.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWest.Location = new System.Drawing.Point(27, 88);
            this.txtWest.MaxLength = 0;
            this.txtWest.Name = "txtWest";
            this.txtWest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWest.Size = new System.Drawing.Size(110, 20);
            this.txtWest.TabIndex = 10;
            this.txtWest.Text = "Text1";
            this.txtWest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckWind
            // 
            this.ckWind.AutoSize = true;
            this.ckWind.BackColor = System.Drawing.SystemColors.Control;
            this.ckWind.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckWind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckWind.Location = new System.Drawing.Point(182, 90);
            this.ckWind.Name = "ckWind";
            this.ckWind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckWind.Size = new System.Drawing.Size(113, 17);
            this.ckWind.TabIndex = 9;
            this.ckWind.Text = "Windsock Objects";
            this.ckWind.UseVisualStyleBackColor = false;
            // 
            // ckTrigger
            // 
            this.ckTrigger.AutoSize = true;
            this.ckTrigger.BackColor = System.Drawing.SystemColors.Control;
            this.ckTrigger.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckTrigger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckTrigger.Location = new System.Drawing.Point(182, 64);
            this.ckTrigger.Name = "ckTrigger";
            this.ckTrigger.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckTrigger.Size = new System.Drawing.Size(98, 17);
            this.ckTrigger.TabIndex = 8;
            this.ckTrigger.Text = "Trigger Objects";
            this.ckTrigger.UseVisualStyleBackColor = false;
            // 
            // ckTaxi
            // 
            this.ckTaxi.AutoSize = true;
            this.ckTaxi.BackColor = System.Drawing.SystemColors.Control;
            this.ckTaxi.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckTaxi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckTaxi.Location = new System.Drawing.Point(182, 38);
            this.ckTaxi.Name = "ckTaxi";
            this.ckTaxi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckTaxi.Size = new System.Drawing.Size(125, 17);
            this.ckTaxi.TabIndex = 7;
            this.ckTaxi.Text = "TaxiwaySign Objects";
            this.ckTaxi.UseVisualStyleBackColor = false;
            // 
            // ckLibrary
            // 
            this.ckLibrary.AutoSize = true;
            this.ckLibrary.BackColor = System.Drawing.SystemColors.Control;
            this.ckLibrary.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckLibrary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckLibrary.Location = new System.Drawing.Point(182, 12);
            this.ckLibrary.Name = "ckLibrary";
            this.ckLibrary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckLibrary.Size = new System.Drawing.Size(96, 17);
            this.ckLibrary.TabIndex = 6;
            this.ckLibrary.Text = "Library Objects";
            this.ckLibrary.UseVisualStyleBackColor = false;
            // 
            // ckGenBuilds
            // 
            this.ckGenBuilds.AutoSize = true;
            this.ckGenBuilds.BackColor = System.Drawing.SystemColors.Control;
            this.ckGenBuilds.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckGenBuilds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckGenBuilds.Location = new System.Drawing.Point(30, 205);
            this.ckGenBuilds.Name = "ckGenBuilds";
            this.ckGenBuilds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckGenBuilds.Size = new System.Drawing.Size(108, 17);
            this.ckGenBuilds.TabIndex = 5;
            this.ckGenBuilds.Text = "Generic Buildings";
            this.ckGenBuilds.UseVisualStyleBackColor = false;
            // 
            // ckEffects
            // 
            this.ckEffects.AutoSize = true;
            this.ckEffects.BackColor = System.Drawing.SystemColors.Control;
            this.ckEffects.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckEffects.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckEffects.Location = new System.Drawing.Point(30, 179);
            this.ckEffects.Name = "ckEffects";
            this.ckEffects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckEffects.Size = new System.Drawing.Size(93, 17);
            this.ckEffects.TabIndex = 4;
            this.ckEffects.Text = "Effect Objects";
            this.ckEffects.UseVisualStyleBackColor = false;
            // 
            // ckBeacons
            // 
            this.ckBeacons.AutoSize = true;
            this.ckBeacons.BackColor = System.Drawing.SystemColors.Control;
            this.ckBeacons.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckBeacons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckBeacons.Location = new System.Drawing.Point(30, 153);
            this.ckBeacons.Name = "ckBeacons";
            this.ckBeacons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckBeacons.Size = new System.Drawing.Size(102, 17);
            this.ckBeacons.TabIndex = 3;
            this.ckBeacons.Text = "Beacon Objects";
            this.ckBeacons.UseVisualStyleBackColor = false;
            // 
            // ckAll
            // 
            this.ckAll.AutoSize = true;
            this.ckAll.BackColor = System.Drawing.SystemColors.Control;
            this.ckAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckAll.Location = new System.Drawing.Point(30, 127);
            this.ckAll.Name = "ckAll";
            this.ckAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckAll.Size = new System.Drawing.Size(76, 17);
            this.ckAll.TabIndex = 2;
            this.ckAll.Text = "All Objects";
            this.ckAll.UseVisualStyleBackColor = false;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(182, 233);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(49, 25);
            this._cmdCancel.TabIndex = 1;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(243, 233);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(49, 25);
            this._cmdOK.TabIndex = 0;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(182, 176);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(109, 22);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "East Boundary :";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(182, 128);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(109, 22);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "South Boundary :";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(27, 73);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(112, 22);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "West Boundary :";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(27, 22);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(106, 22);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "North Boundary :";
            // 
            // ckBridges
            // 
            this.ckBridges.AutoSize = true;
            this.ckBridges.BackColor = System.Drawing.SystemColors.Control;
            this.ckBridges.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckBridges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckBridges.Location = new System.Drawing.Point(30, 231);
            this.ckBridges.Name = "ckBridges";
            this.ckBridges.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckBridges.Size = new System.Drawing.Size(107, 17);
            this.ckBridges.TabIndex = 18;
            this.ckBridges.Text = "Extrusion Bridges";
            this.ckBridges.UseVisualStyleBackColor = false;
            // 
            // FrmExcludesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(315, 273);
            this.Controls.Add(this.ckBridges);
            this.Controls.Add(this.txtSouth);
            this.Controls.Add(this.txtEast);
            this.Controls.Add(this.txtNorth);
            this.Controls.Add(this.txtWest);
            this.Controls.Add(this.ckWind);
            this.Controls.Add(this.ckTrigger);
            this.Controls.Add(this.ckTaxi);
            this.Controls.Add(this.ckLibrary);
            this.Controls.Add(this.ckGenBuilds);
            this.Controls.Add(this.ckEffects);
            this.Controls.Add(this.ckBeacons);
            this.Controls.Add(this.ckAll);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(3, 29);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExcludesP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Exclusion Rectangle Properties";
            this.Load += new System.EventHandler(this.FrmExcludesP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public CheckBox ckBridges;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}