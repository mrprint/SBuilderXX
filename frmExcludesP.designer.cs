using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcludesP));
            txtSouth = new TextBox();
            txtEast = new TextBox();
            txtNorth = new TextBox();
            txtWest = new TextBox();
            ckWind = new CheckBox();
            ckTrigger = new CheckBox();
            ckTaxi = new CheckBox();
            ckLibrary = new CheckBox();
            ckGenBuilds = new CheckBox();
            ckEffects = new CheckBox();
            ckBeacons = new CheckBox();
            ckAll = new CheckBox();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            ckBridges = new CheckBox();
            SuspendLayout();
            // 
            // txtSouth
            // 
            txtSouth.AcceptsReturn = true;
            txtSouth.BackColor = SystemColors.Window;
            txtSouth.Cursor = Cursors.IBeam;
            txtSouth.ForeColor = SystemColors.WindowText;
            txtSouth.Location = new Point(182, 143);
            txtSouth.MaxLength = 0;
            txtSouth.Name = "txtSouth";
            txtSouth.RightToLeft = RightToLeft.No;
            txtSouth.Size = new Size(110, 20);
            txtSouth.TabIndex = 15;
            txtSouth.Text = "Text1";
            txtSouth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEast
            // 
            txtEast.AcceptsReturn = true;
            txtEast.BackColor = SystemColors.Window;
            txtEast.Cursor = Cursors.IBeam;
            txtEast.ForeColor = SystemColors.WindowText;
            txtEast.Location = new Point(182, 191);
            txtEast.MaxLength = 0;
            txtEast.Name = "txtEast";
            txtEast.RightToLeft = RightToLeft.No;
            txtEast.Size = new Size(110, 20);
            txtEast.TabIndex = 14;
            txtEast.Text = "Text1";
            txtEast.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNorth
            // 
            txtNorth.AcceptsReturn = true;
            txtNorth.BackColor = SystemColors.Window;
            txtNorth.Cursor = Cursors.IBeam;
            txtNorth.ForeColor = SystemColors.WindowText;
            txtNorth.Location = new Point(27, 40);
            txtNorth.MaxLength = 0;
            txtNorth.Name = "txtNorth";
            txtNorth.RightToLeft = RightToLeft.No;
            txtNorth.Size = new Size(110, 20);
            txtNorth.TabIndex = 11;
            txtNorth.Text = "Text1";
            txtNorth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWest
            // 
            txtWest.AcceptsReturn = true;
            txtWest.BackColor = SystemColors.Window;
            txtWest.Cursor = Cursors.IBeam;
            txtWest.ForeColor = SystemColors.WindowText;
            txtWest.Location = new Point(27, 88);
            txtWest.MaxLength = 0;
            txtWest.Name = "txtWest";
            txtWest.RightToLeft = RightToLeft.No;
            txtWest.Size = new Size(110, 20);
            txtWest.TabIndex = 10;
            txtWest.Text = "Text1";
            txtWest.TextAlign = HorizontalAlignment.Center;
            // 
            // ckWind
            // 
            ckWind.AutoSize = true;
            ckWind.BackColor = SystemColors.Control;
            ckWind.Cursor = Cursors.Default;
            ckWind.ForeColor = SystemColors.ControlText;
            ckWind.Location = new Point(182, 90);
            ckWind.Name = "ckWind";
            ckWind.RightToLeft = RightToLeft.No;
            ckWind.Size = new Size(113, 17);
            ckWind.TabIndex = 9;
            ckWind.Text = "Windsock Objects";
            ckWind.UseVisualStyleBackColor = false;
            // 
            // ckTrigger
            // 
            ckTrigger.AutoSize = true;
            ckTrigger.BackColor = SystemColors.Control;
            ckTrigger.Cursor = Cursors.Default;
            ckTrigger.ForeColor = SystemColors.ControlText;
            ckTrigger.Location = new Point(182, 64);
            ckTrigger.Name = "ckTrigger";
            ckTrigger.RightToLeft = RightToLeft.No;
            ckTrigger.Size = new Size(98, 17);
            ckTrigger.TabIndex = 8;
            ckTrigger.Text = "Trigger Objects";
            ckTrigger.UseVisualStyleBackColor = false;
            // 
            // ckTaxi
            // 
            ckTaxi.AutoSize = true;
            ckTaxi.BackColor = SystemColors.Control;
            ckTaxi.Cursor = Cursors.Default;
            ckTaxi.ForeColor = SystemColors.ControlText;
            ckTaxi.Location = new Point(182, 38);
            ckTaxi.Name = "ckTaxi";
            ckTaxi.RightToLeft = RightToLeft.No;
            ckTaxi.Size = new Size(125, 17);
            ckTaxi.TabIndex = 7;
            ckTaxi.Text = "TaxiwaySign Objects";
            ckTaxi.UseVisualStyleBackColor = false;
            // 
            // ckLibrary
            // 
            ckLibrary.AutoSize = true;
            ckLibrary.BackColor = SystemColors.Control;
            ckLibrary.Cursor = Cursors.Default;
            ckLibrary.ForeColor = SystemColors.ControlText;
            ckLibrary.Location = new Point(182, 12);
            ckLibrary.Name = "ckLibrary";
            ckLibrary.RightToLeft = RightToLeft.No;
            ckLibrary.Size = new Size(96, 17);
            ckLibrary.TabIndex = 6;
            ckLibrary.Text = "Library Objects";
            ckLibrary.UseVisualStyleBackColor = false;
            // 
            // ckGenBuilds
            // 
            ckGenBuilds.AutoSize = true;
            ckGenBuilds.BackColor = SystemColors.Control;
            ckGenBuilds.Cursor = Cursors.Default;
            ckGenBuilds.ForeColor = SystemColors.ControlText;
            ckGenBuilds.Location = new Point(30, 205);
            ckGenBuilds.Name = "ckGenBuilds";
            ckGenBuilds.RightToLeft = RightToLeft.No;
            ckGenBuilds.Size = new Size(108, 17);
            ckGenBuilds.TabIndex = 5;
            ckGenBuilds.Text = "Generic Buildings";
            ckGenBuilds.UseVisualStyleBackColor = false;
            // 
            // ckEffects
            // 
            ckEffects.AutoSize = true;
            ckEffects.BackColor = SystemColors.Control;
            ckEffects.Cursor = Cursors.Default;
            ckEffects.ForeColor = SystemColors.ControlText;
            ckEffects.Location = new Point(30, 179);
            ckEffects.Name = "ckEffects";
            ckEffects.RightToLeft = RightToLeft.No;
            ckEffects.Size = new Size(93, 17);
            ckEffects.TabIndex = 4;
            ckEffects.Text = "Effect Objects";
            ckEffects.UseVisualStyleBackColor = false;
            // 
            // ckBeacons
            // 
            ckBeacons.AutoSize = true;
            ckBeacons.BackColor = SystemColors.Control;
            ckBeacons.Cursor = Cursors.Default;
            ckBeacons.ForeColor = SystemColors.ControlText;
            ckBeacons.Location = new Point(30, 153);
            ckBeacons.Name = "ckBeacons";
            ckBeacons.RightToLeft = RightToLeft.No;
            ckBeacons.Size = new Size(102, 17);
            ckBeacons.TabIndex = 3;
            ckBeacons.Text = "Beacon Objects";
            ckBeacons.UseVisualStyleBackColor = false;
            // 
            // ckAll
            // 
            ckAll.AutoSize = true;
            ckAll.BackColor = SystemColors.Control;
            ckAll.Cursor = Cursors.Default;
            ckAll.ForeColor = SystemColors.ControlText;
            ckAll.Location = new Point(30, 127);
            ckAll.Name = "ckAll";
            ckAll.RightToLeft = RightToLeft.No;
            ckAll.Size = new Size(76, 17);
            ckAll.TabIndex = 2;
            ckAll.Text = "All Objects";
            ckAll.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(182, 233);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(49, 25);
            _cmdCancel.TabIndex = 1;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(243, 233);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(49, 25);
            _cmdOK.TabIndex = 0;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Control;
            Label4.Cursor = Cursors.Default;
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(182, 176);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(109, 22);
            Label4.TabIndex = 17;
            Label4.Text = "East Boundary :";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Control;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(182, 128);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(109, 22);
            Label3.TabIndex = 16;
            Label3.Text = "South Boundary :";
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(27, 73);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(112, 22);
            Label2.TabIndex = 13;
            Label2.Text = "West Boundary :";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(27, 22);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(106, 22);
            Label1.TabIndex = 12;
            Label1.Text = "North Boundary :";
            // 
            // ckBridges
            // 
            ckBridges.AutoSize = true;
            ckBridges.BackColor = SystemColors.Control;
            ckBridges.Cursor = Cursors.Default;
            ckBridges.ForeColor = SystemColors.ControlText;
            ckBridges.Location = new Point(30, 231);
            ckBridges.Name = "ckBridges";
            ckBridges.RightToLeft = RightToLeft.No;
            ckBridges.Size = new Size(107, 17);
            ckBridges.TabIndex = 18;
            ckBridges.Text = "Extrusion Bridges";
            ckBridges.UseVisualStyleBackColor = false;
            // 
            // frmExcludesP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(315, 273);
            Controls.Add(ckBridges);
            Controls.Add(txtSouth);
            Controls.Add(txtEast);
            Controls.Add(txtNorth);
            Controls.Add(txtWest);
            Controls.Add(ckWind);
            Controls.Add(ckTrigger);
            Controls.Add(ckTaxi);
            Controls.Add(ckLibrary);
            Controls.Add(ckGenBuilds);
            Controls.Add(ckEffects);
            Controls.Add(ckBeacons);
            Controls.Add(ckAll);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdOK);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExcludesP";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Exclusion Rectangle Properties";
            Load += new EventHandler(FrmExcludesP_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        public CheckBox ckBridges;
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}