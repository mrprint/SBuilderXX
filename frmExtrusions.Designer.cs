using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtrusions));
            this.txtProfileGuid = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtMaterialGuid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPylonGuid = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ckSuppress = new System.Windows.Forms.CheckBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtProbability = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.boxHeight = new System.Windows.Forms.GroupBox();
            this._cmdSetHeight = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.cmbComplexity = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.boxHeight.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProfileGuid
            // 
            this.txtProfileGuid.Location = new System.Drawing.Point(21, 32);
            this.txtProfileGuid.Name = "txtProfileGuid";
            this.txtProfileGuid.Size = new System.Drawing.Size(234, 20);
            this.txtProfileGuid.TabIndex = 97;
            this.txtProfileGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 13);
            this.Label1.TabIndex = 98;
            this.Label1.Text = "Extrusion Profile Guid";
            // 
            // txtMaterialGuid
            // 
            this.txtMaterialGuid.Location = new System.Drawing.Point(21, 70);
            this.txtMaterialGuid.Name = "txtMaterialGuid";
            this.txtMaterialGuid.Size = new System.Drawing.Size(234, 20);
            this.txtMaterialGuid.TabIndex = 97;
            this.txtMaterialGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 98;
            this.Label2.Text = "Material Guid";
            // 
            // txtPylonGuid
            // 
            this.txtPylonGuid.Location = new System.Drawing.Point(21, 109);
            this.txtPylonGuid.Name = "txtPylonGuid";
            this.txtPylonGuid.Size = new System.Drawing.Size(234, 20);
            this.txtPylonGuid.TabIndex = 97;
            this.txtPylonGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 93);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 13);
            this.Label3.TabIndex = 98;
            this.Label3.Text = "Pylon Guid";
            // 
            // ckSuppress
            // 
            this.ckSuppress.AutoSize = true;
            this.ckSuppress.Location = new System.Drawing.Point(279, 112);
            this.ckSuppress.Name = "ckSuppress";
            this.ckSuppress.Size = new System.Drawing.Size(111, 17);
            this.ckSuppress.TabIndex = 99;
            this.ckSuppress.Text = "Suppress Platform";
            this.ckSuppress.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(279, 32);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(29, 20);
            this.txtWidth.TabIndex = 100;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProbability
            // 
            this.txtProbability.Location = new System.Drawing.Point(279, 70);
            this.txtProbability.Name = "txtProbability";
            this.txtProbability.Size = new System.Drawing.Size(29, 20);
            this.txtProbability.TabIndex = 100;
            this.txtProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(314, 73);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 13);
            this.Label4.TabIndex = 98;
            this.Label4.Text = "Probability";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(314, 35);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 13);
            this.Label5.TabIndex = 98;
            this.Label5.Text = "Width";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(333, 146);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(57, 26);
            this._cmdCancel.TabIndex = 101;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(413, 146);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(57, 26);
            this._cmdOK.TabIndex = 101;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // boxHeight
            // 
            this.boxHeight.Controls.Add(this._cmdSetHeight);
            this.boxHeight.Controls.Add(this.txtHeight);
            this.boxHeight.Location = new System.Drawing.Point(406, 32);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(64, 97);
            this.boxHeight.TabIndex = 102;
            this.boxHeight.TabStop = false;
            this.boxHeight.Text = "Height";
            // 
            // _cmdSetHeight
            // 
            this._cmdSetHeight.Location = new System.Drawing.Point(17, 55);
            this._cmdSetHeight.Name = "_cmdSetHeight";
            this._cmdSetHeight.Size = new System.Drawing.Size(33, 24);
            this._cmdSetHeight.TabIndex = 94;
            this._cmdSetHeight.Text = "Set";
            this._cmdSetHeight.UseVisualStyleBackColor = true;
            this._cmdSetHeight.Click += new System.EventHandler(this.CmdSetHeight_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.AcceptsReturn = true;
            this.txtHeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHeight.Location = new System.Drawing.Point(17, 22);
            this.txtHeight.MaxLength = 0;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHeight.Size = new System.Drawing.Size(33, 20);
            this.txtHeight.TabIndex = 92;
            this.txtHeight.Text = "10";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbComplexity
            // 
            this.cmbComplexity.FormattingEnabled = true;
            this.cmbComplexity.Items.AddRange(new object[] {
            "Very Sparse",
            "Sparse",
            "Normal",
            "Dense",
            "Very Dense",
            "Extra Dense"});
            this.cmbComplexity.Location = new System.Drawing.Point(134, 151);
            this.cmbComplexity.Name = "cmbComplexity";
            this.cmbComplexity.Size = new System.Drawing.Size(121, 21);
            this.cmbComplexity.TabIndex = 104;
            this.cmbComplexity.Text = "Normal";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(39, 154);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(89, 13);
            this.Label6.TabIndex = 105;
            this.Label6.Text = "Image Complexity";
            // 
            // FrmExtrusions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 191);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cmbComplexity);
            this.Controls.Add(this.boxHeight);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.txtProbability);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.ckSuppress);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtMaterialGuid);
            this.Controls.Add(this.txtPylonGuid);
            this.Controls.Add(this.txtProfileGuid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExtrusions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Extrusion Bridges Properties";
            this.Load += new System.EventHandler(this.FrmExtrusions_Load);
            this.boxHeight.ResumeLayout(false);
            this.boxHeight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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