using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmBGL : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBGL));
            this.ckStartFSX = new System.Windows.Forms.CheckBox();
            this.ckCopyBGLs = new System.Windows.Forms.CheckBox();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdCompile = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._ckLinesOfObjects = new System.Windows.Forms.CheckBox();
            this._ckTexPolys = new System.Windows.Forms.CheckBox();
            this._ckExcludes = new System.Windows.Forms.CheckBox();
            this._ckObjects = new System.Windows.Forms.CheckBox();
            this._ckExtrusions = new System.Windows.Forms.CheckBox();
            this._ckTexLines = new System.Windows.Forms.CheckBox();
            this._ckPhoto = new System.Windows.Forms.CheckBox();
            this.lbNoSelection = new System.Windows.Forms.Label();
            this._ckWater = new System.Windows.Forms.CheckBox();
            this._ckLand = new System.Windows.Forms.CheckBox();
            this._ckVector = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckStartFSX
            // 
            this.ckStartFSX.AutoSize = true;
            this.ckStartFSX.BackColor = System.Drawing.SystemColors.Control;
            this.ckStartFSX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckStartFSX.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckStartFSX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckStartFSX.Location = new System.Drawing.Point(280, 35);
            this.ckStartFSX.Name = "ckStartFSX";
            this.ckStartFSX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckStartFSX.Size = new System.Drawing.Size(71, 17);
            this.ckStartFSX.TabIndex = 23;
            this.ckStartFSX.Text = "Start FSX";
            this.ckStartFSX.UseVisualStyleBackColor = false;
            // 
            // ckCopyBGLs
            // 
            this.ckCopyBGLs.BackColor = System.Drawing.SystemColors.Control;
            this.ckCopyBGLs.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckCopyBGLs.Enabled = false;
            this.ckCopyBGLs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckCopyBGLs.Location = new System.Drawing.Point(280, 58);
            this.ckCopyBGLs.Name = "ckCopyBGLs";
            this.ckCopyBGLs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckCopyBGLs.Size = new System.Drawing.Size(97, 34);
            this.ckCopyBGLs.TabIndex = 22;
            this.ckCopyBGLs.Text = "Copy BGL files to BGL folder";
            this.ckCopyBGLs.UseVisualStyleBackColor = false;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(300, 135);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(64, 25);
            this._cmdCancel.TabIndex = 21;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdCompile
            // 
            this._cmdCompile.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCompile.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCompile.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCompile.Location = new System.Drawing.Point(300, 181);
            this._cmdCompile.Name = "_cmdCompile";
            this._cmdCompile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCompile.Size = new System.Drawing.Size(64, 25);
            this._cmdCompile.TabIndex = 20;
            this._cmdCompile.Text = "Compile";
            this._cmdCompile.UseVisualStyleBackColor = false;
            this._cmdCompile.Click += new System.EventHandler(this.CmdCompile_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this._ckLinesOfObjects);
            this.GroupBox1.Controls.Add(this._ckTexPolys);
            this.GroupBox1.Controls.Add(this._ckExcludes);
            this.GroupBox1.Controls.Add(this._ckObjects);
            this.GroupBox1.Controls.Add(this._ckExtrusions);
            this.GroupBox1.Controls.Add(this._ckTexLines);
            this.GroupBox1.Controls.Add(this._ckPhoto);
            this.GroupBox1.Controls.Add(this.lbNoSelection);
            this.GroupBox1.Controls.Add(this._ckWater);
            this.GroupBox1.Controls.Add(this._ckLand);
            this.GroupBox1.Controls.Add(this._ckVector);
            this.GroupBox1.Location = new System.Drawing.Point(16, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(247, 216);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select Type of Scenery";
            // 
            // _ckLinesOfObjects
            // 
            this._ckLinesOfObjects.AutoSize = true;
            this._ckLinesOfObjects.Location = new System.Drawing.Point(132, 103);
            this._ckLinesOfObjects.Name = "_ckLinesOfObjects";
            this._ckLinesOfObjects.Size = new System.Drawing.Size(102, 17);
            this._ckLinesOfObjects.TabIndex = 8;
            this._ckLinesOfObjects.Text = "Lines of Objects";
            this._ckLinesOfObjects.UseVisualStyleBackColor = true;
            this._ckLinesOfObjects.CheckedChanged += new System.EventHandler(this.CkLinesOfObjects_CheckedChanged);
            // 
            // _ckTexPolys
            // 
            this._ckTexPolys.AutoSize = true;
            this._ckTexPolys.Enabled = false;
            this._ckTexPolys.Location = new System.Drawing.Point(132, 28);
            this._ckTexPolys.Name = "_ckTexPolys";
            this._ckTexPolys.Size = new System.Drawing.Size(96, 17);
            this._ckTexPolys.TabIndex = 7;
            this._ckTexPolys.Text = "Textured Polys";
            this._ckTexPolys.UseVisualStyleBackColor = true;
            this._ckTexPolys.CheckedChanged += new System.EventHandler(this.CkTexPolys_CheckedChanged);
            // 
            // _ckExcludes
            // 
            this._ckExcludes.Enabled = false;
            this._ckExcludes.Location = new System.Drawing.Point(16, 122);
            this._ckExcludes.Name = "_ckExcludes";
            this._ckExcludes.Size = new System.Drawing.Size(108, 34);
            this._ckExcludes.TabIndex = 6;
            this._ckExcludes.Text = "Exclusion Rectangles";
            this._ckExcludes.UseVisualStyleBackColor = true;
            this._ckExcludes.CheckedChanged += new System.EventHandler(this.CkExcludes_CheckedChanged);
            // 
            // _ckObjects
            // 
            this._ckObjects.AutoSize = true;
            this._ckObjects.Enabled = false;
            this._ckObjects.Location = new System.Drawing.Point(132, 131);
            this._ckObjects.Name = "_ckObjects";
            this._ckObjects.Size = new System.Drawing.Size(62, 17);
            this._ckObjects.TabIndex = 5;
            this._ckObjects.Text = "Objects";
            this._ckObjects.UseVisualStyleBackColor = true;
            this._ckObjects.CheckedChanged += new System.EventHandler(this.CkObjects_CheckedChanged);
            // 
            // _ckExtrusions
            // 
            this._ckExtrusions.AutoSize = true;
            this._ckExtrusions.Enabled = false;
            this._ckExtrusions.Location = new System.Drawing.Point(132, 78);
            this._ckExtrusions.Name = "_ckExtrusions";
            this._ckExtrusions.Size = new System.Drawing.Size(107, 17);
            this._ckExtrusions.TabIndex = 4;
            this._ckExtrusions.Text = "Extrusion Bridges";
            this._ckExtrusions.UseVisualStyleBackColor = true;
            this._ckExtrusions.CheckedChanged += new System.EventHandler(this.CkPhoto_CheckedChanged);
            // 
            // _ckTexLines
            // 
            this._ckTexLines.AutoSize = true;
            this._ckTexLines.Enabled = false;
            this._ckTexLines.Location = new System.Drawing.Point(132, 53);
            this._ckTexLines.Name = "_ckTexLines";
            this._ckTexLines.Size = new System.Drawing.Size(96, 17);
            this._ckTexLines.TabIndex = 4;
            this._ckTexLines.Text = "Textured Lines";
            this._ckTexLines.UseVisualStyleBackColor = true;
            this._ckTexLines.CheckedChanged += new System.EventHandler(this.CkPhoto_CheckedChanged);
            // 
            // _ckPhoto
            // 
            this._ckPhoto.AutoSize = true;
            this._ckPhoto.Enabled = false;
            this._ckPhoto.Location = new System.Drawing.Point(16, 103);
            this._ckPhoto.Name = "_ckPhoto";
            this._ckPhoto.Size = new System.Drawing.Size(96, 17);
            this._ckPhoto.TabIndex = 4;
            this._ckPhoto.Text = "Photo Scenery";
            this._ckPhoto.UseVisualStyleBackColor = true;
            this._ckPhoto.CheckedChanged += new System.EventHandler(this.CkPhoto_CheckedChanged);
            // 
            // lbNoSelection
            // 
            this.lbNoSelection.Location = new System.Drawing.Point(13, 163);
            this.lbNoSelection.Name = "lbNoSelection";
            this.lbNoSelection.Size = new System.Drawing.Size(227, 42);
            this.lbNoSelection.TabIndex = 3;
            this.lbNoSelection.Text = "There is nothing to compile because no items have been selected! Go back and sele" +
    "ct the items to compile!";
            // 
            // _ckWater
            // 
            this._ckWater.AutoSize = true;
            this._ckWater.Enabled = false;
            this._ckWater.Location = new System.Drawing.Point(16, 78);
            this._ckWater.Name = "_ckWater";
            this._ckWater.Size = new System.Drawing.Size(83, 17);
            this._ckWater.TabIndex = 2;
            this._ckWater.Text = "Water Class";
            this._ckWater.UseVisualStyleBackColor = true;
            this._ckWater.CheckedChanged += new System.EventHandler(this.CkWater_CheckedChanged);
            // 
            // _ckLand
            // 
            this._ckLand.AutoSize = true;
            this._ckLand.Enabled = false;
            this._ckLand.Location = new System.Drawing.Point(16, 53);
            this._ckLand.Name = "_ckLand";
            this._ckLand.Size = new System.Drawing.Size(78, 17);
            this._ckLand.TabIndex = 1;
            this._ckLand.Text = "Land Class";
            this._ckLand.UseVisualStyleBackColor = true;
            this._ckLand.CheckedChanged += new System.EventHandler(this.CkLand_CheckedChanged);
            // 
            // _ckVector
            // 
            this._ckVector.AutoSize = true;
            this._ckVector.Enabled = false;
            this._ckVector.Location = new System.Drawing.Point(16, 28);
            this._ckVector.Name = "_ckVector";
            this._ckVector.Size = new System.Drawing.Size(93, 17);
            this._ckVector.TabIndex = 0;
            this._ckVector.Text = "Terrain Vector";
            this._ckVector.UseVisualStyleBackColor = true;
            this._ckVector.CheckedChanged += new System.EventHandler(this.CkVector_CheckedChanged);
            // 
            // FrmBGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 247);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ckStartFSX);
            this.Controls.Add(this.ckCopyBGLs);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdCompile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBGL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - BGL Compilation";
            this.Load += new System.EventHandler(this.FrmBGL_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public CheckBox ckStartFSX;
        public CheckBox ckCopyBGLs;
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

        private Button _cmdCompile;

        public Button cmdCompile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCompile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCompile != null)
                {
                    _cmdCompile.Click -= CmdCompile_Click;
                }

                _cmdCompile = value;
                if (_cmdCompile != null)
                {
                    _cmdCompile.Click += CmdCompile_Click;
                }
            }
        }

        internal GroupBox GroupBox1;
        private CheckBox _ckVector;

        internal CheckBox ckVector
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckVector;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckVector != null)
                {
                    _ckVector.CheckedChanged -= CkVector_CheckedChanged;
                }

                _ckVector = value;
                if (_ckVector != null)
                {
                    _ckVector.CheckedChanged += CkVector_CheckedChanged;
                }
            }
        }

        private CheckBox _ckWater;

        internal CheckBox ckWater
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckWater;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckWater != null)
                {
                    _ckWater.CheckedChanged -= CkWater_CheckedChanged;
                }

                _ckWater = value;
                if (_ckWater != null)
                {
                    _ckWater.CheckedChanged += CkWater_CheckedChanged;
                }
            }
        }

        private CheckBox _ckLand;

        internal CheckBox ckLand
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckLand;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckLand != null)
                {
                    _ckLand.CheckedChanged -= CkLand_CheckedChanged;
                }

                _ckLand = value;
                if (_ckLand != null)
                {
                    _ckLand.CheckedChanged += CkLand_CheckedChanged;
                }
            }
        }

        internal Label lbNoSelection;
        private CheckBox _ckPhoto;

        internal CheckBox ckPhoto
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckPhoto;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckPhoto != null)
                {
                    _ckPhoto.CheckedChanged -= CkPhoto_CheckedChanged;
                }

                _ckPhoto = value;
                if (_ckPhoto != null)
                {
                    _ckPhoto.CheckedChanged += CkPhoto_CheckedChanged;
                }
            }
        }

        private CheckBox _ckObjects;

        internal CheckBox ckObjects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckObjects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckObjects != null)
                {
                    _ckObjects.CheckedChanged -= CkObjects_CheckedChanged;
                }

                _ckObjects = value;
                if (_ckObjects != null)
                {
                    _ckObjects.CheckedChanged += CkObjects_CheckedChanged;
                }
            }
        }

        private CheckBox _ckExcludes;

        internal CheckBox ckExcludes
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckExcludes;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckExcludes != null)
                {
                    _ckExcludes.CheckedChanged -= CkExcludes_CheckedChanged;
                }

                _ckExcludes = value;
                if (_ckExcludes != null)
                {
                    _ckExcludes.CheckedChanged += CkExcludes_CheckedChanged;
                }
            }
        }

        private CheckBox _ckTexPolys;

        internal CheckBox ckTexPolys
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckTexPolys;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckTexPolys != null)
                {
                    _ckTexPolys.CheckedChanged -= CkTexPolys_CheckedChanged;
                }

                _ckTexPolys = value;
                if (_ckTexPolys != null)
                {
                    _ckTexPolys.CheckedChanged += CkTexPolys_CheckedChanged;
                }
            }
        }

        private CheckBox _ckTexLines;

        internal CheckBox ckTexLines
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckTexLines;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckTexLines != null)
                {
                    _ckTexLines.CheckedChanged -= CkPhoto_CheckedChanged;
                }

                _ckTexLines = value;
                if (_ckTexLines != null)
                {
                    _ckTexLines.CheckedChanged += CkPhoto_CheckedChanged;
                }
            }
        }

        private CheckBox _ckExtrusions;

        internal CheckBox ckExtrusions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckExtrusions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckExtrusions != null)
                {
                    _ckExtrusions.CheckedChanged -= CkPhoto_CheckedChanged;
                }

                _ckExtrusions = value;
                if (_ckExtrusions != null)
                {
                    _ckExtrusions.CheckedChanged += CkPhoto_CheckedChanged;
                }
            }
        }

        private CheckBox _ckLinesOfObjects;

        internal CheckBox ckLinesOfObjects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckLinesOfObjects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckLinesOfObjects != null)
                {
                    _ckLinesOfObjects.CheckedChanged -= CkLinesOfObjects_CheckedChanged;
                }

                _ckLinesOfObjects = value;
                if (_ckLinesOfObjects != null)
                {
                    _ckLinesOfObjects.CheckedChanged += CkLinesOfObjects_CheckedChanged;
                }
            }
        }
    }
}