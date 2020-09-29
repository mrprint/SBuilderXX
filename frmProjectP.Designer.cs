using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmProjectP : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectP));
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            GroupBox1 = new GroupBox();
            lbPolys = new Label();
            lbLines = new Label();
            lbWaters = new Label();
            lbMaps = new Label();
            lbExcludes = new Label();
            lbLands = new Label();
            lbObjects = new Label();
            ckBGLFolder = new CheckBox();
            Label1 = new Label();
            txtName = new TextBox();
            Label7 = new Label();
            txtBGLFolder = new TextBox();
            _cmdBGL = new Button();
            _cmdBGL.Click += new EventHandler(CmdBGL_Click);
            TabPage2 = new TabPage();
            Label2 = new Label();
            _lbClassItem = new Label();
            _lbClassItem.Click += new EventHandler(LbClassItem_Click);
            _lbClassItem.MouseDown += new MouseEventHandler(LbClassItem_MouseDown);
            Label5 = new Label();
            Label6 = new Label();
            _lstClassItems = new ListBox();
            _lstClassItems.SelectedIndexChanged += new EventHandler(LstClassItems_SelectedIndexChanged);
            _cmdClassIndexDelete = new Button();
            _cmdClassIndexDelete.Click += new EventHandler(CmdClassIndexDelete_Click);
            _cmdClassIndexEdit = new Button();
            _cmdClassIndexEdit.Click += new EventHandler(CmdClassIndexEdit_Click);
            _cmdClassIndexAdd = new Button();
            _cmdClassIndexAdd.Click += new EventHandler(CmdClassIndexAdd_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            GroupBox1.SuspendLayout();
            TabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Location = new Point(12, 12);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(334, 247);
            TabControl1.TabIndex = 40;
            // 
            // TabPage1
            // 
            TabPage1.BackColor = Color.Transparent;
            TabPage1.Controls.Add(GroupBox1);
            TabPage1.Controls.Add(ckBGLFolder);
            TabPage1.Controls.Add(Label1);
            TabPage1.Controls.Add(txtName);
            TabPage1.Controls.Add(Label7);
            TabPage1.Controls.Add(txtBGLFolder);
            TabPage1.Controls.Add(_cmdBGL);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(326, 221);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "General";
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.Transparent;
            GroupBox1.Controls.Add(lbPolys);
            GroupBox1.Controls.Add(lbLines);
            GroupBox1.Controls.Add(lbWaters);
            GroupBox1.Controls.Add(lbMaps);
            GroupBox1.Controls.Add(lbExcludes);
            GroupBox1.Controls.Add(lbLands);
            GroupBox1.Controls.Add(lbObjects);
            GroupBox1.Location = new Point(15, 110);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(294, 95);
            GroupBox1.TabIndex = 58;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Existing Items";
            // 
            // lbPolys
            // 
            lbPolys.BackColor = Color.Transparent;
            lbPolys.Cursor = Cursors.Default;
            lbPolys.ForeColor = SystemColors.ControlText;
            lbPolys.Location = new Point(107, 25);
            lbPolys.Name = "lbPolys";
            lbPolys.RightToLeft = RightToLeft.No;
            lbPolys.Size = new Size(95, 15);
            lbPolys.TabIndex = 32;
            lbPolys.Text = "Polys = 1";
            lbPolys.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLines
            // 
            lbLines.BackColor = Color.Transparent;
            lbLines.Cursor = Cursors.Default;
            lbLines.ForeColor = SystemColors.ControlText;
            lbLines.Location = new Point(6, 25);
            lbLines.Name = "lbLines";
            lbLines.RightToLeft = RightToLeft.No;
            lbLines.Size = new Size(95, 15);
            lbLines.TabIndex = 34;
            lbLines.Text = "Lines = 1";
            lbLines.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbWaters
            // 
            lbWaters.BackColor = Color.Transparent;
            lbWaters.Cursor = Cursors.Default;
            lbWaters.ForeColor = SystemColors.ControlText;
            lbWaters.Location = new Point(107, 45);
            lbWaters.Name = "lbWaters";
            lbWaters.RightToLeft = RightToLeft.No;
            lbWaters.Size = new Size(95, 15);
            lbWaters.TabIndex = 35;
            lbWaters.Text = "Waters = 1";
            lbWaters.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbMaps
            // 
            lbMaps.BackColor = Color.Transparent;
            lbMaps.Cursor = Cursors.Default;
            lbMaps.ForeColor = SystemColors.ControlText;
            lbMaps.Location = new Point(6, 65);
            lbMaps.Name = "lbMaps";
            lbMaps.RightToLeft = RightToLeft.No;
            lbMaps.Size = new Size(95, 15);
            lbMaps.TabIndex = 38;
            lbMaps.Text = "Maps = 1";
            lbMaps.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbExcludes
            // 
            lbExcludes.BackColor = Color.Transparent;
            lbExcludes.Cursor = Cursors.Default;
            lbExcludes.ForeColor = SystemColors.ControlText;
            lbExcludes.Location = new Point(208, 25);
            lbExcludes.Name = "lbExcludes";
            lbExcludes.RightToLeft = RightToLeft.No;
            lbExcludes.Size = new Size(80, 15);
            lbExcludes.TabIndex = 39;
            lbExcludes.Text = "Excludes = 1";
            lbExcludes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbLands
            // 
            lbLands.BackColor = Color.Transparent;
            lbLands.Cursor = Cursors.Default;
            lbLands.ForeColor = SystemColors.ControlText;
            lbLands.Location = new Point(6, 45);
            lbLands.Name = "lbLands";
            lbLands.RightToLeft = RightToLeft.No;
            lbLands.Size = new Size(95, 15);
            lbLands.TabIndex = 36;
            lbLands.Text = "Lands = 1";
            lbLands.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbObjects
            // 
            lbObjects.BackColor = Color.Transparent;
            lbObjects.Cursor = Cursors.Default;
            lbObjects.ForeColor = SystemColors.ControlText;
            lbObjects.Location = new Point(107, 65);
            lbObjects.Name = "lbObjects";
            lbObjects.RightToLeft = RightToLeft.No;
            lbObjects.Size = new Size(95, 15);
            lbObjects.TabIndex = 33;
            lbObjects.Text = "Objects = 1";
            lbObjects.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ckBGLFolder
            // 
            ckBGLFolder.AutoSize = true;
            ckBGLFolder.BackColor = Color.Transparent;
            ckBGLFolder.CheckAlign = ContentAlignment.MiddleRight;
            ckBGLFolder.Location = new Point(125, 83);
            ckBGLFolder.Name = "ckBGLFolder";
            ckBGLFolder.Size = new Size(168, 17);
            ckBGLFolder.TabIndex = 57;
            ckBGLFolder.Text = "Use this folder in new Projects";
            ckBGLFolder.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = Color.Transparent;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(79, 19);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(76, 17);
            Label1.TabIndex = 53;
            Label1.Text = "Project Name :";
            Label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtName
            // 
            txtName.AcceptsReturn = true;
            txtName.BackColor = SystemColors.Window;
            txtName.Cursor = Cursors.IBeam;
            txtName.ForeColor = SystemColors.WindowText;
            txtName.Location = new Point(161, 19);
            txtName.MaxLength = 0;
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(139, 20);
            txtName.TabIndex = 54;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // Label7
            // 
            Label7.BackColor = Color.Transparent;
            Label7.Cursor = Cursors.Default;
            Label7.ForeColor = SystemColors.ControlText;
            Label7.Location = new Point(12, 36);
            Label7.Name = "Label7";
            Label7.RightToLeft = RightToLeft.No;
            Label7.Size = new Size(115, 16);
            Label7.TabIndex = 51;
            Label7.Text = "BGL Folder";
            // 
            // txtBGLFolder
            // 
            txtBGLFolder.AcceptsReturn = true;
            txtBGLFolder.BackColor = SystemColors.Window;
            txtBGLFolder.Cursor = Cursors.IBeam;
            txtBGLFolder.ForeColor = SystemColors.WindowText;
            txtBGLFolder.Location = new Point(15, 55);
            txtBGLFolder.MaxLength = 0;
            txtBGLFolder.Name = "txtBGLFolder";
            txtBGLFolder.RightToLeft = RightToLeft.No;
            txtBGLFolder.Size = new Size(240, 20);
            txtBGLFolder.TabIndex = 49;
            txtBGLFolder.TextAlign = HorizontalAlignment.Right;
            // 
            // cmdBGL
            // 
            _cmdBGL.BackColor = SystemColors.ButtonFace;
            _cmdBGL.Cursor = Cursors.Default;
            _cmdBGL.ForeColor = SystemColors.ControlText;
            _cmdBGL.Location = new Point(272, 55);
            _cmdBGL.Name = "_cmdBGL";
            _cmdBGL.RightToLeft = RightToLeft.No;
            _cmdBGL.Size = new Size(31, 22);
            _cmdBGL.TabIndex = 50;
            _cmdBGL.Text = "...";
            _cmdBGL.UseVisualStyleBackColor = false;
            // 
            // TabPage2
            // 
            TabPage2.BackColor = Color.Transparent;
            TabPage2.Controls.Add(Label2);
            TabPage2.Controls.Add(_lbClassItem);
            TabPage2.Controls.Add(Label5);
            TabPage2.Controls.Add(Label6);
            TabPage2.Controls.Add(_lstClassItems);
            TabPage2.Controls.Add(_cmdClassIndexDelete);
            TabPage2.Controls.Add(_cmdClassIndexEdit);
            TabPage2.Controls.Add(_cmdClassIndexAdd);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(326, 221);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Class Scenery";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.Location = new Point(6, 12);
            Label2.Name = "Label2";
            Label2.Size = new Size(314, 61);
            Label2.TabIndex = 78;
            Label2.Text = resources.GetString("Label2.Text");
            // 
            // lbClassItem
            // 
            _lbClassItem.BackColor = Color.White;
            _lbClassItem.BorderStyle = BorderStyle.Fixed3D;
            _lbClassItem.Cursor = Cursors.Default;
            _lbClassItem.ForeColor = SystemColors.ControlText;
            _lbClassItem.Location = new Point(15, 98);
            _lbClassItem.Name = "_lbClassItem";
            _lbClassItem.RightToLeft = RightToLeft.No;
            _lbClassItem.Size = new Size(210, 20);
            _lbClassItem.TabIndex = 74;
            _lbClassItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Cursor = Cursors.Default;
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(12, 82);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(178, 13);
            Label5.TabIndex = 73;
            Label5.Text = "Click to set Color (letf or right mouse)";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Transparent;
            Label6.Cursor = Cursors.Default;
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(12, 123);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(130, 13);
            Label6.TabIndex = 72;
            Label6.Text = "Land or Water Definitions:";
            // 
            // lstClassItems
            // 
            _lstClassItems.BackColor = SystemColors.Window;
            _lstClassItems.Cursor = Cursors.Default;
            _lstClassItems.ForeColor = SystemColors.WindowText;
            _lstClassItems.Location = new Point(15, 139);
            _lstClassItems.Name = "_lstClassItems";
            _lstClassItems.RightToLeft = RightToLeft.No;
            _lstClassItems.Size = new Size(210, 69);
            _lstClassItems.TabIndex = 71;
            // 
            // cmdClassIndexDelete
            // 
            _cmdClassIndexDelete.BackColor = SystemColors.Control;
            _cmdClassIndexDelete.Cursor = Cursors.Default;
            _cmdClassIndexDelete.ForeColor = SystemColors.ControlText;
            _cmdClassIndexDelete.Location = new Point(253, 98);
            _cmdClassIndexDelete.Name = "_cmdClassIndexDelete";
            _cmdClassIndexDelete.RightToLeft = RightToLeft.No;
            _cmdClassIndexDelete.Size = new Size(51, 25);
            _cmdClassIndexDelete.TabIndex = 76;
            _cmdClassIndexDelete.Text = "Delete";
            _cmdClassIndexDelete.UseVisualStyleBackColor = false;
            // 
            // cmdClassIndexEdit
            // 
            _cmdClassIndexEdit.BackColor = SystemColors.Control;
            _cmdClassIndexEdit.Cursor = Cursors.Default;
            _cmdClassIndexEdit.ForeColor = SystemColors.ControlText;
            _cmdClassIndexEdit.Location = new Point(253, 142);
            _cmdClassIndexEdit.Name = "_cmdClassIndexEdit";
            _cmdClassIndexEdit.RightToLeft = RightToLeft.No;
            _cmdClassIndexEdit.Size = new Size(51, 25);
            _cmdClassIndexEdit.TabIndex = 75;
            _cmdClassIndexEdit.Text = "Edit";
            _cmdClassIndexEdit.UseVisualStyleBackColor = false;
            // 
            // cmdClassIndexAdd
            // 
            _cmdClassIndexAdd.BackColor = SystemColors.Control;
            _cmdClassIndexAdd.Cursor = Cursors.Default;
            _cmdClassIndexAdd.ForeColor = SystemColors.ControlText;
            _cmdClassIndexAdd.Location = new Point(253, 183);
            _cmdClassIndexAdd.Name = "_cmdClassIndexAdd";
            _cmdClassIndexAdd.RightToLeft = RightToLeft.No;
            _cmdClassIndexAdd.Size = new Size(51, 25);
            _cmdClassIndexAdd.TabIndex = 77;
            _cmdClassIndexAdd.Text = "Add";
            _cmdClassIndexAdd.UseVisualStyleBackColor = false;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(269, 266);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(77, 24);
            _cmdOK.TabIndex = 58;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(164, 266);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(77, 25);
            _cmdCancel.TabIndex = 57;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // FrmProjectP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(357, 301);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(TabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProjectP";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Project Properties";
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            GroupBox1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            Load += new EventHandler(FrmProjectP_Load);
            ResumeLayout(false);
        }

        internal TabControl TabControl1;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal CheckBox ckBGLFolder;
        public Label Label1;
        public TextBox txtName;
        public Label Label7;
        public TextBox txtBGLFolder;
        private Button _cmdBGL;

        public Button cmdBGL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdBGL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdBGL != null)
                {
                    _cmdBGL.Click -= CmdBGL_Click;
                }

                _cmdBGL = value;
                if (_cmdBGL != null)
                {
                    _cmdBGL.Click += CmdBGL_Click;
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

        private Button _cmdClassIndexAdd;

        public Button cmdClassIndexAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClassIndexAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClassIndexAdd != null)
                {
                    _cmdClassIndexAdd.Click -= CmdClassIndexAdd_Click;
                }

                _cmdClassIndexAdd = value;
                if (_cmdClassIndexAdd != null)
                {
                    _cmdClassIndexAdd.Click += CmdClassIndexAdd_Click;
                }
            }
        }

        private Button _cmdClassIndexDelete;

        public Button cmdClassIndexDelete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClassIndexDelete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClassIndexDelete != null)
                {
                    _cmdClassIndexDelete.Click -= CmdClassIndexDelete_Click;
                }

                _cmdClassIndexDelete = value;
                if (_cmdClassIndexDelete != null)
                {
                    _cmdClassIndexDelete.Click += CmdClassIndexDelete_Click;
                }
            }
        }

        private Button _cmdClassIndexEdit;

        public Button cmdClassIndexEdit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClassIndexEdit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClassIndexEdit != null)
                {
                    _cmdClassIndexEdit.Click -= CmdClassIndexEdit_Click;
                }

                _cmdClassIndexEdit = value;
                if (_cmdClassIndexEdit != null)
                {
                    _cmdClassIndexEdit.Click += CmdClassIndexEdit_Click;
                }
            }
        }

        public Label Label5;
        private Label _lbClassItem;

        public Label lbClassItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbClassItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbClassItem != null)
                {
                    _lbClassItem.Click -= LbClassItem_Click;
                    _lbClassItem.MouseDown -= LbClassItem_MouseDown;
                }

                _lbClassItem = value;
                if (_lbClassItem != null)
                {
                    _lbClassItem.Click += LbClassItem_Click;
                    _lbClassItem.MouseDown += LbClassItem_MouseDown;
                }
            }
        }

        public Label Label6;
        private ListBox _lstClassItems;

        public ListBox lstClassItems
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstClassItems;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstClassItems != null)
                {
                    _lstClassItems.SelectedIndexChanged -= LstClassItems_SelectedIndexChanged;
                }

                _lstClassItems = value;
                if (_lstClassItems != null)
                {
                    _lstClassItems.SelectedIndexChanged += LstClassItems_SelectedIndexChanged;
                }
            }
        }

        internal Label Label2;
        internal GroupBox GroupBox1;
        public Label lbExcludes;
        public Label lbMaps;
        public Label lbLands;
        public Label lbWaters;
        public Label lbLines;
        public Label lbObjects;
        public Label lbPolys;
    }
}