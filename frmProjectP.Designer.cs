using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectP));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPolys = new System.Windows.Forms.Label();
            this.lbLines = new System.Windows.Forms.Label();
            this.lbWaters = new System.Windows.Forms.Label();
            this.lbMaps = new System.Windows.Forms.Label();
            this.lbExcludes = new System.Windows.Forms.Label();
            this.lbLands = new System.Windows.Forms.Label();
            this.lbObjects = new System.Windows.Forms.Label();
            this.ckBGLFolder = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtBGLFolder = new System.Windows.Forms.TextBox();
            this._cmdBGL = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Label2 = new System.Windows.Forms.Label();
            this._lbClassItem = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this._lstClassItems = new System.Windows.Forms.ListBox();
            this._cmdClassIndexDelete = new System.Windows.Forms.Button();
            this._cmdClassIndexEdit = new System.Windows.Forms.Button();
            this._cmdClassIndexAdd = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(334, 247);
            this.TabControl1.TabIndex = 40;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Transparent;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.ckBGLFolder);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.txtName);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.txtBGLFolder);
            this.TabPage1.Controls.Add(this._cmdBGL);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(326, 221);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.lbPolys);
            this.GroupBox1.Controls.Add(this.lbLines);
            this.GroupBox1.Controls.Add(this.lbWaters);
            this.GroupBox1.Controls.Add(this.lbMaps);
            this.GroupBox1.Controls.Add(this.lbExcludes);
            this.GroupBox1.Controls.Add(this.lbLands);
            this.GroupBox1.Controls.Add(this.lbObjects);
            this.GroupBox1.Location = new System.Drawing.Point(15, 110);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(294, 95);
            this.GroupBox1.TabIndex = 58;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Existing Items";
            // 
            // lbPolys
            // 
            this.lbPolys.BackColor = System.Drawing.Color.Transparent;
            this.lbPolys.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPolys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPolys.Location = new System.Drawing.Point(107, 25);
            this.lbPolys.Name = "lbPolys";
            this.lbPolys.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPolys.Size = new System.Drawing.Size(95, 15);
            this.lbPolys.TabIndex = 32;
            this.lbPolys.Text = "Polys = 1";
            this.lbPolys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLines
            // 
            this.lbLines.BackColor = System.Drawing.Color.Transparent;
            this.lbLines.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLines.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLines.Location = new System.Drawing.Point(6, 25);
            this.lbLines.Name = "lbLines";
            this.lbLines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLines.Size = new System.Drawing.Size(95, 15);
            this.lbLines.TabIndex = 34;
            this.lbLines.Text = "Lines = 1";
            this.lbLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbWaters
            // 
            this.lbWaters.BackColor = System.Drawing.Color.Transparent;
            this.lbWaters.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbWaters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbWaters.Location = new System.Drawing.Point(107, 45);
            this.lbWaters.Name = "lbWaters";
            this.lbWaters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbWaters.Size = new System.Drawing.Size(95, 15);
            this.lbWaters.TabIndex = 35;
            this.lbWaters.Text = "Waters = 1";
            this.lbWaters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMaps
            // 
            this.lbMaps.BackColor = System.Drawing.Color.Transparent;
            this.lbMaps.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMaps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMaps.Location = new System.Drawing.Point(6, 65);
            this.lbMaps.Name = "lbMaps";
            this.lbMaps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMaps.Size = new System.Drawing.Size(95, 15);
            this.lbMaps.TabIndex = 38;
            this.lbMaps.Text = "Maps = 1";
            this.lbMaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbExcludes
            // 
            this.lbExcludes.BackColor = System.Drawing.Color.Transparent;
            this.lbExcludes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbExcludes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbExcludes.Location = new System.Drawing.Point(208, 25);
            this.lbExcludes.Name = "lbExcludes";
            this.lbExcludes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbExcludes.Size = new System.Drawing.Size(80, 15);
            this.lbExcludes.TabIndex = 39;
            this.lbExcludes.Text = "Excludes = 1";
            this.lbExcludes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLands
            // 
            this.lbLands.BackColor = System.Drawing.Color.Transparent;
            this.lbLands.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbLands.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLands.Location = new System.Drawing.Point(6, 45);
            this.lbLands.Name = "lbLands";
            this.lbLands.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLands.Size = new System.Drawing.Size(95, 15);
            this.lbLands.TabIndex = 36;
            this.lbLands.Text = "Lands = 1";
            this.lbLands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbObjects
            // 
            this.lbObjects.BackColor = System.Drawing.Color.Transparent;
            this.lbObjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbObjects.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbObjects.Location = new System.Drawing.Point(107, 65);
            this.lbObjects.Name = "lbObjects";
            this.lbObjects.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbObjects.Size = new System.Drawing.Size(95, 15);
            this.lbObjects.TabIndex = 33;
            this.lbObjects.Text = "Objects = 1";
            this.lbObjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckBGLFolder
            // 
            this.ckBGLFolder.AutoSize = true;
            this.ckBGLFolder.BackColor = System.Drawing.Color.Transparent;
            this.ckBGLFolder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckBGLFolder.Location = new System.Drawing.Point(125, 83);
            this.ckBGLFolder.Name = "ckBGLFolder";
            this.ckBGLFolder.Size = new System.Drawing.Size(168, 17);
            this.ckBGLFolder.TabIndex = 57;
            this.ckBGLFolder.Text = "Use this folder in new Projects";
            this.ckBGLFolder.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(79, 19);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(76, 17);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Project Name :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(161, 19);
            this.txtName.MaxLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 54;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(12, 36);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(115, 16);
            this.Label7.TabIndex = 51;
            this.Label7.Text = "BGL Folder";
            // 
            // txtBGLFolder
            // 
            this.txtBGLFolder.AcceptsReturn = true;
            this.txtBGLFolder.BackColor = System.Drawing.SystemColors.Window;
            this.txtBGLFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBGLFolder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBGLFolder.Location = new System.Drawing.Point(15, 55);
            this.txtBGLFolder.MaxLength = 0;
            this.txtBGLFolder.Name = "txtBGLFolder";
            this.txtBGLFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBGLFolder.Size = new System.Drawing.Size(240, 20);
            this.txtBGLFolder.TabIndex = 49;
            this.txtBGLFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _cmdBGL
            // 
            this._cmdBGL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._cmdBGL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdBGL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdBGL.Location = new System.Drawing.Point(272, 55);
            this._cmdBGL.Name = "_cmdBGL";
            this._cmdBGL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdBGL.Size = new System.Drawing.Size(31, 22);
            this._cmdBGL.TabIndex = 50;
            this._cmdBGL.Text = "...";
            this._cmdBGL.UseVisualStyleBackColor = false;
            this._cmdBGL.Click += new System.EventHandler(this.CmdBGL_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.Transparent;
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this._lbClassItem);
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Controls.Add(this.Label6);
            this.TabPage2.Controls.Add(this._lstClassItems);
            this.TabPage2.Controls.Add(this._cmdClassIndexDelete);
            this.TabPage2.Controls.Add(this._cmdClassIndexEdit);
            this.TabPage2.Controls.Add(this._cmdClassIndexAdd);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(326, 221);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Class Scenery";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(6, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(314, 61);
            this.Label2.TabIndex = 78;
            this.Label2.Text = resources.GetString("Label2.Text");
            // 
            // _lbClassItem
            // 
            this._lbClassItem.BackColor = System.Drawing.Color.White;
            this._lbClassItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lbClassItem.Cursor = System.Windows.Forms.Cursors.Default;
            this._lbClassItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lbClassItem.Location = new System.Drawing.Point(15, 98);
            this._lbClassItem.Name = "_lbClassItem";
            this._lbClassItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lbClassItem.Size = new System.Drawing.Size(210, 20);
            this._lbClassItem.TabIndex = 74;
            this._lbClassItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbClassItem.Click += new System.EventHandler(this.LbClassItem_Click);
            this._lbClassItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LbClassItem_MouseDown);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(12, 82);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(178, 13);
            this.Label5.TabIndex = 73;
            this.Label5.Text = "Click to set Color (letf or right mouse)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(12, 123);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(130, 13);
            this.Label6.TabIndex = 72;
            this.Label6.Text = "Land or Water Definitions:";
            // 
            // _lstClassItems
            // 
            this._lstClassItems.BackColor = System.Drawing.SystemColors.Window;
            this._lstClassItems.Cursor = System.Windows.Forms.Cursors.Default;
            this._lstClassItems.ForeColor = System.Drawing.SystemColors.WindowText;
            this._lstClassItems.Location = new System.Drawing.Point(15, 139);
            this._lstClassItems.Name = "_lstClassItems";
            this._lstClassItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lstClassItems.Size = new System.Drawing.Size(210, 69);
            this._lstClassItems.TabIndex = 71;
            this._lstClassItems.SelectedIndexChanged += new System.EventHandler(this.LstClassItems_SelectedIndexChanged);
            // 
            // _cmdClassIndexDelete
            // 
            this._cmdClassIndexDelete.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClassIndexDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClassIndexDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClassIndexDelete.Location = new System.Drawing.Point(253, 98);
            this._cmdClassIndexDelete.Name = "_cmdClassIndexDelete";
            this._cmdClassIndexDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClassIndexDelete.Size = new System.Drawing.Size(51, 25);
            this._cmdClassIndexDelete.TabIndex = 76;
            this._cmdClassIndexDelete.Text = "Delete";
            this._cmdClassIndexDelete.UseVisualStyleBackColor = false;
            this._cmdClassIndexDelete.Click += new System.EventHandler(this.CmdClassIndexDelete_Click);
            // 
            // _cmdClassIndexEdit
            // 
            this._cmdClassIndexEdit.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClassIndexEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClassIndexEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClassIndexEdit.Location = new System.Drawing.Point(253, 142);
            this._cmdClassIndexEdit.Name = "_cmdClassIndexEdit";
            this._cmdClassIndexEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClassIndexEdit.Size = new System.Drawing.Size(51, 25);
            this._cmdClassIndexEdit.TabIndex = 75;
            this._cmdClassIndexEdit.Text = "Edit";
            this._cmdClassIndexEdit.UseVisualStyleBackColor = false;
            this._cmdClassIndexEdit.Click += new System.EventHandler(this.CmdClassIndexEdit_Click);
            // 
            // _cmdClassIndexAdd
            // 
            this._cmdClassIndexAdd.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClassIndexAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClassIndexAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClassIndexAdd.Location = new System.Drawing.Point(253, 183);
            this._cmdClassIndexAdd.Name = "_cmdClassIndexAdd";
            this._cmdClassIndexAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClassIndexAdd.Size = new System.Drawing.Size(51, 25);
            this._cmdClassIndexAdd.TabIndex = 77;
            this._cmdClassIndexAdd.Text = "Add";
            this._cmdClassIndexAdd.UseVisualStyleBackColor = false;
            this._cmdClassIndexAdd.Click += new System.EventHandler(this.CmdClassIndexAdd_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(269, 266);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(77, 24);
            this._cmdOK.TabIndex = 58;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(164, 266);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(77, 25);
            this._cmdCancel.TabIndex = 57;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // FrmProjectP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(357, 301);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjectP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Project Properties";
            this.Load += new System.EventHandler(this.FrmProjectP_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);

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