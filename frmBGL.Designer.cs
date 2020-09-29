using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBGL));
            ckStartFSX = new CheckBox();
            ckCopyBGLs = new CheckBox();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdCompile = new Button();
            _cmdCompile.Click += new EventHandler(CmdCompile_Click);
            GroupBox1 = new GroupBox();
            _ckLinesOfObjects = new CheckBox();
            _ckLinesOfObjects.CheckedChanged += new EventHandler(CkLinesOfObjects_CheckedChanged);
            _ckTexPolys = new CheckBox();
            _ckTexPolys.CheckedChanged += new EventHandler(CkTexPolys_CheckedChanged);
            _ckExcludes = new CheckBox();
            _ckExcludes.CheckedChanged += new EventHandler(CkExcludes_CheckedChanged);
            _ckObjects = new CheckBox();
            _ckObjects.CheckedChanged += new EventHandler(CkObjects_CheckedChanged);
            _ckExtrusions = new CheckBox();
            _ckExtrusions.CheckedChanged += new EventHandler(CkPhoto_CheckedChanged);
            _ckTexLines = new CheckBox();
            _ckTexLines.CheckedChanged += new EventHandler(CkPhoto_CheckedChanged);
            _ckPhoto = new CheckBox();
            _ckPhoto.CheckedChanged += new EventHandler(CkPhoto_CheckedChanged);
            lbNoSelection = new Label();
            _ckWater = new CheckBox();
            _ckWater.CheckedChanged += new EventHandler(CkWater_CheckedChanged);
            _ckLand = new CheckBox();
            _ckLand.CheckedChanged += new EventHandler(CkLand_CheckedChanged);
            _ckVector = new CheckBox();
            _ckVector.CheckedChanged += new EventHandler(CkVector_CheckedChanged);
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ckStartFSX
            // 
            ckStartFSX.AutoSize = true;
            ckStartFSX.BackColor = SystemColors.Control;
            ckStartFSX.CheckAlign = ContentAlignment.MiddleRight;
            ckStartFSX.Cursor = Cursors.Default;
            ckStartFSX.ForeColor = SystemColors.ControlText;
            ckStartFSX.Location = new Point(280, 35);
            ckStartFSX.Name = "ckStartFSX";
            ckStartFSX.RightToLeft = RightToLeft.Yes;
            ckStartFSX.Size = new Size(71, 17);
            ckStartFSX.TabIndex = 23;
            ckStartFSX.Text = "Start FSX";
            ckStartFSX.UseVisualStyleBackColor = false;
            // 
            // ckCopyBGLs
            // 
            ckCopyBGLs.BackColor = SystemColors.Control;
            ckCopyBGLs.Cursor = Cursors.Default;
            ckCopyBGLs.Enabled = false;
            ckCopyBGLs.ForeColor = SystemColors.ControlText;
            ckCopyBGLs.Location = new Point(280, 58);
            ckCopyBGLs.Name = "ckCopyBGLs";
            ckCopyBGLs.RightToLeft = RightToLeft.No;
            ckCopyBGLs.Size = new Size(97, 34);
            ckCopyBGLs.TabIndex = 22;
            ckCopyBGLs.Text = "Copy BGL files to BGL folder";
            ckCopyBGLs.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(300, 135);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(64, 25);
            _cmdCancel.TabIndex = 21;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdCompile
            // 
            _cmdCompile.BackColor = SystemColors.Control;
            _cmdCompile.Cursor = Cursors.Default;
            _cmdCompile.ForeColor = SystemColors.ControlText;
            _cmdCompile.Location = new Point(300, 181);
            _cmdCompile.Name = "_cmdCompile";
            _cmdCompile.RightToLeft = RightToLeft.No;
            _cmdCompile.Size = new Size(64, 25);
            _cmdCompile.TabIndex = 20;
            _cmdCompile.Text = "Compile";
            _cmdCompile.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_ckLinesOfObjects);
            GroupBox1.Controls.Add(_ckTexPolys);
            GroupBox1.Controls.Add(_ckExcludes);
            GroupBox1.Controls.Add(_ckObjects);
            GroupBox1.Controls.Add(_ckExtrusions);
            GroupBox1.Controls.Add(_ckTexLines);
            GroupBox1.Controls.Add(_ckPhoto);
            GroupBox1.Controls.Add(lbNoSelection);
            GroupBox1.Controls.Add(_ckWater);
            GroupBox1.Controls.Add(_ckLand);
            GroupBox1.Controls.Add(_ckVector);
            GroupBox1.Location = new Point(16, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(247, 216);
            GroupBox1.TabIndex = 24;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Select Type of Scenery";
            // 
            // ckLinesOfObjects
            // 
            _ckLinesOfObjects.AutoSize = true;
            _ckLinesOfObjects.Location = new Point(132, 103);
            _ckLinesOfObjects.Name = "_ckLinesOfObjects";
            _ckLinesOfObjects.Size = new Size(102, 17);
            _ckLinesOfObjects.TabIndex = 8;
            _ckLinesOfObjects.Text = "Lines of Objects";
            _ckLinesOfObjects.UseVisualStyleBackColor = true;
            // 
            // ckTexPolys
            // 
            _ckTexPolys.AutoSize = true;
            _ckTexPolys.Enabled = false;
            _ckTexPolys.Location = new Point(132, 28);
            _ckTexPolys.Name = "_ckTexPolys";
            _ckTexPolys.Size = new Size(96, 17);
            _ckTexPolys.TabIndex = 7;
            _ckTexPolys.Text = "Textured Polys";
            _ckTexPolys.UseVisualStyleBackColor = true;
            // 
            // ckExcludes
            // 
            _ckExcludes.Enabled = false;
            _ckExcludes.Location = new Point(16, 122);
            _ckExcludes.Name = "_ckExcludes";
            _ckExcludes.Size = new Size(108, 34);
            _ckExcludes.TabIndex = 6;
            _ckExcludes.Text = "Exclusion Rectangles";
            _ckExcludes.UseVisualStyleBackColor = true;
            // 
            // ckObjects
            // 
            _ckObjects.AutoSize = true;
            _ckObjects.Enabled = false;
            _ckObjects.Location = new Point(132, 131);
            _ckObjects.Name = "_ckObjects";
            _ckObjects.Size = new Size(62, 17);
            _ckObjects.TabIndex = 5;
            _ckObjects.Text = "Objects";
            _ckObjects.UseVisualStyleBackColor = true;
            // 
            // ckExtrusions
            // 
            _ckExtrusions.AutoSize = true;
            _ckExtrusions.Enabled = false;
            _ckExtrusions.Location = new Point(132, 78);
            _ckExtrusions.Name = "_ckExtrusions";
            _ckExtrusions.Size = new Size(107, 17);
            _ckExtrusions.TabIndex = 4;
            _ckExtrusions.Text = "Extrusion Bridges";
            _ckExtrusions.UseVisualStyleBackColor = true;
            // 
            // ckTexLines
            // 
            _ckTexLines.AutoSize = true;
            _ckTexLines.Enabled = false;
            _ckTexLines.Location = new Point(132, 53);
            _ckTexLines.Name = "_ckTexLines";
            _ckTexLines.Size = new Size(96, 17);
            _ckTexLines.TabIndex = 4;
            _ckTexLines.Text = "Textured Lines";
            _ckTexLines.UseVisualStyleBackColor = true;
            // 
            // ckPhoto
            // 
            _ckPhoto.AutoSize = true;
            _ckPhoto.Enabled = false;
            _ckPhoto.Location = new Point(16, 103);
            _ckPhoto.Name = "_ckPhoto";
            _ckPhoto.Size = new Size(96, 17);
            _ckPhoto.TabIndex = 4;
            _ckPhoto.Text = "Photo Scenery";
            _ckPhoto.UseVisualStyleBackColor = true;
            // 
            // lbNoSelection
            // 
            lbNoSelection.Location = new Point(13, 163);
            lbNoSelection.Name = "lbNoSelection";
            lbNoSelection.Size = new Size(227, 42);
            lbNoSelection.TabIndex = 3;
            lbNoSelection.Text = "There is nothing to compile because no items have been selected! Go back and sele" + "ct the items to compile!";
            // 
            // ckWater
            // 
            _ckWater.AutoSize = true;
            _ckWater.Enabled = false;
            _ckWater.Location = new Point(16, 78);
            _ckWater.Name = "_ckWater";
            _ckWater.Size = new Size(83, 17);
            _ckWater.TabIndex = 2;
            _ckWater.Text = "Water Class";
            _ckWater.UseVisualStyleBackColor = true;
            // 
            // ckLand
            // 
            _ckLand.AutoSize = true;
            _ckLand.Enabled = false;
            _ckLand.Location = new Point(16, 53);
            _ckLand.Name = "_ckLand";
            _ckLand.Size = new Size(78, 17);
            _ckLand.TabIndex = 1;
            _ckLand.Text = "Land Class";
            _ckLand.UseVisualStyleBackColor = true;
            // 
            // ckVector
            // 
            _ckVector.AutoSize = true;
            _ckVector.Enabled = false;
            _ckVector.Location = new Point(16, 28);
            _ckVector.Name = "_ckVector";
            _ckVector.Size = new Size(93, 17);
            _ckVector.TabIndex = 0;
            _ckVector.Text = "Terrain Vector";
            _ckVector.UseVisualStyleBackColor = true;
            // 
            // frmBGL
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 247);
            Controls.Add(GroupBox1);
            Controls.Add(ckStartFSX);
            Controls.Add(ckCopyBGLs);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdCompile);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBGL";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - BGL Compilation";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(FrmBGL_Load);
            ResumeLayout(false);
            PerformLayout();
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