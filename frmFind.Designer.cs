using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFind));
            _cmdAll = new Button();
            _cmdAll.Click += new EventHandler(CmdAll_Click);
            Frame1 = new GroupBox();
            ckPTypes = new RadioButton();
            ckLTypes = new RadioButton();
            ckPolys = new RadioButton();
            ckLines = new RadioButton();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdNext = new Button();
            _cmdNext.Click += new EventHandler(CmdNext_Click);
            txtName = new TextBox();
            Label1 = new Label();
            Frame1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdAll
            // 
            _cmdAll.BackColor = SystemColors.Control;
            _cmdAll.Cursor = Cursors.Default;
            _cmdAll.ForeColor = SystemColors.ControlText;
            _cmdAll.Location = new Point(268, 87);
            _cmdAll.Name = "_cmdAll";
            _cmdAll.RightToLeft = RightToLeft.No;
            _cmdAll.Size = new Size(70, 25);
            _cmdAll.TabIndex = 15;
            _cmdAll.Text = "Find All";
            _cmdAll.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Control;
            Frame1.Controls.Add(ckPTypes);
            Frame1.Controls.Add(ckLTypes);
            Frame1.Controls.Add(ckPolys);
            Frame1.Controls.Add(ckLines);
            Frame1.Location = new Point(19, 64);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(211, 87);
            Frame1.TabIndex = 13;
            Frame1.TabStop = false;
            Frame1.Text = "Where to Search";
            // 
            // ckPTypes
            // 
            ckPTypes.AutoSize = true;
            ckPTypes.BackColor = SystemColors.Control;
            ckPTypes.Cursor = Cursors.Default;
            ckPTypes.ForeColor = SystemColors.ControlText;
            ckPTypes.Location = new Point(116, 48);
            ckPTypes.Name = "ckPTypes";
            ckPTypes.RightToLeft = RightToLeft.No;
            ckPTypes.Size = new Size(75, 17);
            ckPTypes.TabIndex = 8;
            ckPTypes.TabStop = true;
            ckPTypes.Text = "Poly Guids";
            ckPTypes.UseVisualStyleBackColor = false;
            // 
            // ckLTypes
            // 
            ckLTypes.AutoSize = true;
            ckLTypes.BackColor = SystemColors.Control;
            ckLTypes.Cursor = Cursors.Default;
            ckLTypes.ForeColor = SystemColors.ControlText;
            ckLTypes.Location = new Point(116, 24);
            ckLTypes.Name = "ckLTypes";
            ckLTypes.RightToLeft = RightToLeft.No;
            ckLTypes.Size = new Size(75, 17);
            ckLTypes.TabIndex = 7;
            ckLTypes.TabStop = true;
            ckLTypes.Text = "Line Guids";
            ckLTypes.UseVisualStyleBackColor = false;
            // 
            // ckPolys
            // 
            ckPolys.AutoSize = true;
            ckPolys.BackColor = SystemColors.Control;
            ckPolys.Cursor = Cursors.Default;
            ckPolys.ForeColor = SystemColors.ControlText;
            ckPolys.Location = new Point(18, 48);
            ckPolys.Name = "ckPolys";
            ckPolys.RightToLeft = RightToLeft.No;
            ckPolys.Size = new Size(81, 17);
            ckPolys.TabIndex = 5;
            ckPolys.TabStop = true;
            ckPolys.Text = "Poly Names";
            ckPolys.UseVisualStyleBackColor = false;
            // 
            // ckLines
            // 
            ckLines.AutoSize = true;
            ckLines.BackColor = SystemColors.Control;
            ckLines.Checked = true;
            ckLines.Cursor = Cursors.Default;
            ckLines.ForeColor = SystemColors.ControlText;
            ckLines.Location = new Point(18, 24);
            ckLines.Name = "ckLines";
            ckLines.RightToLeft = RightToLeft.No;
            ckLines.Size = new Size(81, 17);
            ckLines.TabIndex = 4;
            ckLines.TabStop = true;
            ckLines.Text = "Line Names";
            ckLines.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(268, 126);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(70, 25);
            _cmdCancel.TabIndex = 12;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdNext
            // 
            _cmdNext.BackColor = SystemColors.Control;
            _cmdNext.Cursor = Cursors.Default;
            _cmdNext.ForeColor = SystemColors.ControlText;
            _cmdNext.Location = new Point(268, 48);
            _cmdNext.Name = "_cmdNext";
            _cmdNext.RightToLeft = RightToLeft.No;
            _cmdNext.Size = new Size(70, 25);
            _cmdNext.TabIndex = 11;
            _cmdNext.Text = "Find Next";
            _cmdNext.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.AcceptsReturn = true;
            txtName.BackColor = SystemColors.Window;
            txtName.Cursor = Cursors.IBeam;
            txtName.Location = new Point(103, 12);
            txtName.MaxLength = 0;
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(235, 20);
            txtName.TabIndex = 10;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(16, 15);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(85, 16);
            Label1.TabIndex = 14;
            Label1.Text = "Text to Search:";
            Label1.TextAlign = ContentAlignment.TopRight;
            // 
            // frmFind
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 166);
            Controls.Add(_cmdAll);
            Controls.Add(Frame1);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdNext);
            Controls.Add(txtName);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmFind";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Find Line or Poly";
            Frame1.ResumeLayout(false);
            Frame1.PerformLayout();
            Load += new EventHandler(FrmFind_Load);
            ResumeLayout(false);
            PerformLayout();
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