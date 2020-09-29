using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    public partial class FrmExtrusions : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtrusions));
            txtProfileGuid = new TextBox();
            Label1 = new Label();
            txtMaterialGuid = new TextBox();
            Label2 = new Label();
            txtPylonGuid = new TextBox();
            Label3 = new Label();
            ckSuppress = new CheckBox();
            txtWidth = new TextBox();
            txtProbability = new TextBox();
            Label4 = new Label();
            Label5 = new Label();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            boxHeight = new GroupBox();
            _cmdSetHeight = new Button();
            _cmdSetHeight.Click += new EventHandler(CmdSetHeight_Click);
            txtHeight = new TextBox();
            cmbComplexity = new ComboBox();
            Label6 = new Label();
            boxHeight.SuspendLayout();
            SuspendLayout();
            // 
            // txtProfileGuid
            // 
            txtProfileGuid.Location = new Point(21, 32);
            txtProfileGuid.Name = "txtProfileGuid";
            txtProfileGuid.Size = new Size(234, 20);
            txtProfileGuid.TabIndex = 97;
            txtProfileGuid.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(18, 16);
            Label1.Name = "Label1";
            Label1.Size = new Size(107, 13);
            Label1.TabIndex = 98;
            Label1.Text = "Extrusion Profile Guid";
            // 
            // txtMaterialGuid
            // 
            txtMaterialGuid.Location = new Point(21, 70);
            txtMaterialGuid.Name = "txtMaterialGuid";
            txtMaterialGuid.Size = new Size(234, 20);
            txtMaterialGuid.TabIndex = 97;
            txtMaterialGuid.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(18, 54);
            Label2.Name = "Label2";
            Label2.Size = new Size(69, 13);
            Label2.TabIndex = 98;
            Label2.Text = "Material Guid";
            // 
            // txtPylonGuid
            // 
            txtPylonGuid.Location = new Point(21, 109);
            txtPylonGuid.Name = "txtPylonGuid";
            txtPylonGuid.Size = new Size(234, 20);
            txtPylonGuid.TabIndex = 97;
            txtPylonGuid.TextAlign = HorizontalAlignment.Center;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(18, 93);
            Label3.Name = "Label3";
            Label3.Size = new Size(58, 13);
            Label3.TabIndex = 98;
            Label3.Text = "Pylon Guid";
            // 
            // ckSuppress
            // 
            ckSuppress.AutoSize = true;
            ckSuppress.Location = new Point(279, 112);
            ckSuppress.Name = "ckSuppress";
            ckSuppress.Size = new Size(111, 17);
            ckSuppress.TabIndex = 99;
            ckSuppress.Text = "Suppress Platform";
            ckSuppress.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(279, 32);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(29, 20);
            txtWidth.TabIndex = 100;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProbability
            // 
            txtProbability.Location = new Point(279, 70);
            txtProbability.Name = "txtProbability";
            txtProbability.Size = new Size(29, 20);
            txtProbability.TabIndex = 100;
            txtProbability.TextAlign = HorizontalAlignment.Center;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(314, 73);
            Label4.Name = "Label4";
            Label4.Size = new Size(55, 13);
            Label4.TabIndex = 98;
            Label4.Text = "Probability";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(314, 35);
            Label5.Name = "Label5";
            Label5.Size = new Size(35, 13);
            Label5.TabIndex = 98;
            Label5.Text = "Width";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(333, 146);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(57, 26);
            _cmdCancel.TabIndex = 101;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(413, 146);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(57, 26);
            _cmdOK.TabIndex = 101;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // boxHeight
            // 
            boxHeight.Controls.Add(_cmdSetHeight);
            boxHeight.Controls.Add(txtHeight);
            boxHeight.Location = new Point(406, 32);
            boxHeight.Name = "boxHeight";
            boxHeight.Size = new Size(64, 97);
            boxHeight.TabIndex = 102;
            boxHeight.TabStop = false;
            boxHeight.Text = "Height";
            // 
            // cmdSetHeight
            // 
            _cmdSetHeight.Location = new Point(17, 55);
            _cmdSetHeight.Name = "_cmdSetHeight";
            _cmdSetHeight.Size = new Size(33, 24);
            _cmdSetHeight.TabIndex = 94;
            _cmdSetHeight.Text = "Set";
            _cmdSetHeight.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            txtHeight.AcceptsReturn = true;
            txtHeight.BackColor = SystemColors.Window;
            txtHeight.Cursor = Cursors.IBeam;
            txtHeight.ForeColor = SystemColors.WindowText;
            txtHeight.Location = new Point(17, 22);
            txtHeight.MaxLength = 0;
            txtHeight.Name = "txtHeight";
            txtHeight.RightToLeft = RightToLeft.No;
            txtHeight.Size = new Size(33, 20);
            txtHeight.TabIndex = 92;
            txtHeight.Text = "10";
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbComplexity
            // 
            cmbComplexity.FormattingEnabled = true;
            cmbComplexity.Items.AddRange(new object[] { "Very Sparse", "Sparse", "Normal", "Dense", "Very Dense", "Extra Dense" });
            cmbComplexity.Location = new Point(134, 151);
            cmbComplexity.Name = "cmbComplexity";
            cmbComplexity.Size = new Size(121, 21);
            cmbComplexity.TabIndex = 104;
            cmbComplexity.Text = "Normal";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(39, 154);
            Label6.Name = "Label6";
            Label6.Size = new Size(89, 13);
            Label6.TabIndex = 105;
            Label6.Text = "Image Complexity";
            // 
            // frmExtrusions
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 191);
            Controls.Add(Label6);
            Controls.Add(cmbComplexity);
            Controls.Add(boxHeight);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(txtProbability);
            Controls.Add(txtWidth);
            Controls.Add(ckSuppress);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label1);
            Controls.Add(txtMaterialGuid);
            Controls.Add(txtPylonGuid);
            Controls.Add(txtProfileGuid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExtrusions";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Extrusion Bridges Properties";
            boxHeight.ResumeLayout(false);
            boxHeight.PerformLayout();
            Load += new EventHandler(FrmExtrusions_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox txtProfileGuid;
        internal Label Label1;
        internal TextBox txtMaterialGuid;
        internal Label Label2;
        internal TextBox txtPylonGuid;
        internal Label Label3;
        internal CheckBox ckSuppress;
        internal TextBox txtWidth;
        internal TextBox txtProbability;
        internal Label Label4;
        internal Label Label5;
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

        internal GroupBox boxHeight;
        private Button _cmdSetHeight;

        internal Button cmdSetHeight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSetHeight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSetHeight != null)
                {
                    _cmdSetHeight.Click -= CmdSetHeight_Click;
                }

                _cmdSetHeight = value;
                if (_cmdSetHeight != null)
                {
                    _cmdSetHeight.Click += CmdSetHeight_Click;
                }
            }
        }

        public TextBox txtHeight;
        internal ComboBox cmbComplexity;
        internal Label Label6;
    }
}