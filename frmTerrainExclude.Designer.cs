using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerrainExclude));
            this._List = new System.Windows.Forms.ListBox();
            this._cmdDetail = new System.Windows.Forms.Button();
            this._Cancel_Button = new System.Windows.Forms.Button();
            this._OK_Button = new System.Windows.Forms.Button();
            this.lbTex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _List
            // 
            this._List.FormattingEnabled = true;
            this._List.Location = new System.Drawing.Point(10, 42);
            this._List.Name = "_List";
            this._List.Size = new System.Drawing.Size(265, 82);
            this._List.TabIndex = 0;
            this._List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // _cmdDetail
            // 
            this._cmdDetail.Location = new System.Drawing.Point(294, 12);
            this._cmdDetail.Name = "_cmdDetail";
            this._cmdDetail.Size = new System.Drawing.Size(75, 25);
            this._cmdDetail.TabIndex = 25;
            this._cmdDetail.Text = "Info";
            this._cmdDetail.UseVisualStyleBackColor = true;
            this._cmdDetail.Click += new System.EventHandler(this.CmdDetail_Click);
            // 
            // _Cancel_Button
            // 
            this._Cancel_Button.Location = new System.Drawing.Point(294, 54);
            this._Cancel_Button.Name = "_Cancel_Button";
            this._Cancel_Button.Size = new System.Drawing.Size(75, 25);
            this._Cancel_Button.TabIndex = 24;
            this._Cancel_Button.Text = "Cancel";
            this._Cancel_Button.UseVisualStyleBackColor = true;
            this._Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // _OK_Button
            // 
            this._OK_Button.Location = new System.Drawing.Point(294, 99);
            this._OK_Button.Name = "_OK_Button";
            this._OK_Button.Size = new System.Drawing.Size(75, 25);
            this._OK_Button.TabIndex = 23;
            this._OK_Button.Text = "OK";
            this._OK_Button.UseVisualStyleBackColor = true;
            this._OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // lbTex
            // 
            this.lbTex.BackColor = System.Drawing.SystemColors.Control;
            this.lbTex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTex.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTex.Location = new System.Drawing.Point(12, 9);
            this.lbTex.Name = "lbTex";
            this.lbTex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTex.Size = new System.Drawing.Size(263, 19);
            this.lbTex.TabIndex = 26;
            this.lbTex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmTerrainExclude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 141);
            this.Controls.Add(this.lbTex);
            this.Controls.Add(this._cmdDetail);
            this.Controls.Add(this._Cancel_Button);
            this.Controls.Add(this._OK_Button);
            this.Controls.Add(this._List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTerrainExclude";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Terrain Type to Exclude";
            this.Load += new System.EventHandler(this.FrmTerrainExclude_Load);
            this.ResumeLayout(false);

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