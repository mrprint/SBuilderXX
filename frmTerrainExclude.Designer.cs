using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmTerrainExclude : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerrainExclude));
            _List = new ListBox();
            _List.SelectedIndexChanged += new EventHandler(List_SelectedIndexChanged);
            _cmdDetail = new Button();
            _cmdDetail.Click += new EventHandler(CmdDetail_Click);
            _Cancel_Button = new Button();
            _Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
            _OK_Button = new Button();
            _OK_Button.Click += new EventHandler(OK_Button_Click);
            lbTex = new Label();
            SuspendLayout();
            // 
            // List
            // 
            _List.FormattingEnabled = true;
            _List.Location = new Point(10, 42);
            _List.Name = "_List";
            _List.Size = new Size(265, 82);
            _List.TabIndex = 0;
            // 
            // cmdDetail
            // 
            _cmdDetail.Location = new Point(294, 12);
            _cmdDetail.Name = "_cmdDetail";
            _cmdDetail.Size = new Size(75, 25);
            _cmdDetail.TabIndex = 25;
            _cmdDetail.Text = "Info";
            _cmdDetail.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            _Cancel_Button.Location = new Point(294, 54);
            _Cancel_Button.Name = "_Cancel_Button";
            _Cancel_Button.Size = new Size(75, 25);
            _Cancel_Button.TabIndex = 24;
            _Cancel_Button.Text = "Cancel";
            _Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // OK_Button
            // 
            _OK_Button.Location = new Point(294, 99);
            _OK_Button.Name = "_OK_Button";
            _OK_Button.Size = new Size(75, 25);
            _OK_Button.TabIndex = 23;
            _OK_Button.Text = "OK";
            _OK_Button.UseVisualStyleBackColor = true;
            // 
            // lbTex
            // 
            lbTex.BackColor = SystemColors.Control;
            lbTex.BorderStyle = BorderStyle.Fixed3D;
            lbTex.Cursor = Cursors.Default;
            lbTex.ForeColor = SystemColors.ControlText;
            lbTex.Location = new Point(12, 9);
            lbTex.Name = "lbTex";
            lbTex.RightToLeft = RightToLeft.No;
            lbTex.Size = new Size(263, 19);
            lbTex.TabIndex = 26;
            lbTex.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmTerrainExclude
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 141);
            Controls.Add(lbTex);
            Controls.Add(_cmdDetail);
            Controls.Add(_Cancel_Button);
            Controls.Add(_OK_Button);
            Controls.Add(_List);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTerrainExclude";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Terrain Type to Exclude";
            Load += new EventHandler(FrmTerrainExclude_Load);
            ResumeLayout(false);
        }

        private ListBox _List;

        internal ListBox List
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _List;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_List != null)
                {
                    _List.SelectedIndexChanged -= List_SelectedIndexChanged;
                }

                _List = value;
                if (_List != null)
                {
                    _List.SelectedIndexChanged += List_SelectedIndexChanged;
                }
            }
        }

        private Button _cmdDetail;

        internal Button cmdDetail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDetail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDetail != null)
                {
                    _cmdDetail.Click -= CmdDetail_Click;
                }

                _cmdDetail = value;
                if (_cmdDetail != null)
                {
                    _cmdDetail.Click += CmdDetail_Click;
                }
            }
        }

        private Button _Cancel_Button;

        internal Button Cancel_Button
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Cancel_Button;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Cancel_Button != null)
                {
                    _Cancel_Button.Click -= Cancel_Button_Click;
                }

                _Cancel_Button = value;
                if (_Cancel_Button != null)
                {
                    _Cancel_Button.Click += Cancel_Button_Click;
                }
            }
        }

        private Button _OK_Button;

        internal Button OK_Button
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OK_Button;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OK_Button != null)
                {
                    _OK_Button.Click -= OK_Button_Click;
                }

                _OK_Button = value;
                if (_OK_Button != null)
                {
                    _OK_Button.Click += OK_Button_Click;
                }
            }
        }

        public Label lbTex;
    }
}