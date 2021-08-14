using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmFind : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFind));
            this._cmdAll = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.ckPTypes = new System.Windows.Forms.RadioButton();
            this.ckLTypes = new System.Windows.Forms.RadioButton();
            this.ckPolys = new System.Windows.Forms.RadioButton();
            this.ckLines = new System.Windows.Forms.RadioButton();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdNext = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdAll
            // 
            this._cmdAll.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAll.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAll.Location = new System.Drawing.Point(268, 87);
            this._cmdAll.Name = "_cmdAll";
            this._cmdAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAll.Size = new System.Drawing.Size(70, 25);
            this._cmdAll.TabIndex = 15;
            this._cmdAll.Text = "Find All";
            this._cmdAll.UseVisualStyleBackColor = false;
            this._cmdAll.Click += new System.EventHandler(this.CmdAll_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.ckPTypes);
            this.Frame1.Controls.Add(this.ckLTypes);
            this.Frame1.Controls.Add(this.ckPolys);
            this.Frame1.Controls.Add(this.ckLines);
            this.Frame1.Location = new System.Drawing.Point(19, 64);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(211, 87);
            this.Frame1.TabIndex = 13;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Where to Search";
            // 
            // ckPTypes
            // 
            this.ckPTypes.AutoSize = true;
            this.ckPTypes.BackColor = System.Drawing.SystemColors.Control;
            this.ckPTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckPTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckPTypes.Location = new System.Drawing.Point(116, 48);
            this.ckPTypes.Name = "ckPTypes";
            this.ckPTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckPTypes.Size = new System.Drawing.Size(75, 17);
            this.ckPTypes.TabIndex = 8;
            this.ckPTypes.TabStop = true;
            this.ckPTypes.Text = "Poly Guids";
            this.ckPTypes.UseVisualStyleBackColor = false;
            // 
            // ckLTypes
            // 
            this.ckLTypes.AutoSize = true;
            this.ckLTypes.BackColor = System.Drawing.SystemColors.Control;
            this.ckLTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckLTypes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckLTypes.Location = new System.Drawing.Point(116, 24);
            this.ckLTypes.Name = "ckLTypes";
            this.ckLTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckLTypes.Size = new System.Drawing.Size(75, 17);
            this.ckLTypes.TabIndex = 7;
            this.ckLTypes.TabStop = true;
            this.ckLTypes.Text = "Line Guids";
            this.ckLTypes.UseVisualStyleBackColor = false;
            // 
            // ckPolys
            // 
            this.ckPolys.AutoSize = true;
            this.ckPolys.BackColor = System.Drawing.SystemColors.Control;
            this.ckPolys.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckPolys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckPolys.Location = new System.Drawing.Point(18, 48);
            this.ckPolys.Name = "ckPolys";
            this.ckPolys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckPolys.Size = new System.Drawing.Size(81, 17);
            this.ckPolys.TabIndex = 5;
            this.ckPolys.TabStop = true;
            this.ckPolys.Text = "Poly Names";
            this.ckPolys.UseVisualStyleBackColor = false;
            // 
            // ckLines
            // 
            this.ckLines.AutoSize = true;
            this.ckLines.BackColor = System.Drawing.SystemColors.Control;
            this.ckLines.Checked = true;
            this.ckLines.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckLines.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckLines.Location = new System.Drawing.Point(18, 24);
            this.ckLines.Name = "ckLines";
            this.ckLines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckLines.Size = new System.Drawing.Size(81, 17);
            this.ckLines.TabIndex = 4;
            this.ckLines.TabStop = true;
            this.ckLines.Text = "Line Names";
            this.ckLines.UseVisualStyleBackColor = false;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(268, 126);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(70, 25);
            this._cmdCancel.TabIndex = 12;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdNext
            // 
            this._cmdNext.BackColor = System.Drawing.SystemColors.Control;
            this._cmdNext.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdNext.Location = new System.Drawing.Point(268, 48);
            this._cmdNext.Name = "_cmdNext";
            this._cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdNext.Size = new System.Drawing.Size(70, 25);
            this._cmdNext.TabIndex = 11;
            this._cmdNext.Text = "Find Next";
            this._cmdNext.UseVisualStyleBackColor = false;
            this._cmdNext.Click += new System.EventHandler(this.CmdNext_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(103, 12);
            this.txtName.MaxLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 10;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 15);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(85, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Text to Search:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 166);
            this.Controls.Add(this._cmdAll);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdNext);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Find Line or Poly";
            this.Load += new System.EventHandler(this.FrmFind_Load);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button _cmdAll;

        public Button cmdAll
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAll;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAll != null)
                {
                    _cmdAll.Click -= CmdAll_Click;
                }

                _cmdAll = value;
                if (_cmdAll != null)
                {
                    _cmdAll.Click += CmdAll_Click;
                }
            }
        }

        public RadioButton ckPTypes;
        public RadioButton ckLTypes;
        public RadioButton ckPolys;
        public RadioButton ckLines;
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

        private Button _cmdNext;

        public Button cmdNext
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdNext;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdNext != null)
                {
                    _cmdNext.Click -= CmdNext_Click;
                }

                _cmdNext = value;
                if (_cmdNext != null)
                {
                    _cmdNext.Click += CmdNext_Click;
                }
            }
        }

        public TextBox txtName;
        public Label Label1;
        internal GroupBox Frame1;
    }
}