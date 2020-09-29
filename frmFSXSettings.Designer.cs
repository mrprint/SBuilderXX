using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    public partial class FrmFSXSettings : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFSXSettings));
            _cmdFSX = new Button();
            _cmdFSX.Click += new EventHandler(CmdFSX_Click);
            txtFSPath = new TextBox();
            Label1 = new Label();
            _cmdTerrain = new Button();
            _cmdTerrain.Click += new EventHandler(CmdTerrain_Click);
            txtTerrain = new TextBox();
            Label2 = new Label();
            _cmdBGLComp = new Button();
            _cmdBGLComp.Click += new EventHandler(CmdBGLComp_Click);
            txtBGLComp = new TextBox();
            Label4 = new Label();
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            Label3 = new Label();
            FolderBrowserDialog1 = new FolderBrowserDialog();
            _cmdPlugins = new Button();
            _cmdPlugins.Click += new EventHandler(CmdPlugins_Click);
            txtPlugins = new TextBox();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            txtNameOfSim = new TextBox();
            SuspendLayout();
            // 
            // cmdFSX
            // 
            _cmdFSX.Location = new Point(514, 33);
            _cmdFSX.Name = "_cmdFSX";
            _cmdFSX.Size = new Size(31, 23);
            _cmdFSX.TabIndex = 0;
            _cmdFSX.Text = "...";
            _cmdFSX.UseVisualStyleBackColor = true;
            // 
            // txtFSPath
            // 
            txtFSPath.BackColor = Color.White;
            txtFSPath.Location = new Point(22, 35);
            txtFSPath.Name = "txtFSPath";
            txtFSPath.ReadOnly = true;
            txtFSPath.Size = new Size(476, 20);
            txtFSPath.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(19, 19);
            Label1.Name = "Label1";
            Label1.Size = new Size(134, 13);
            Label1.TabIndex = 2;
            Label1.Text = "Full Path to Flight Simulator";
            // 
            // cmdTerrain
            // 
            _cmdTerrain.Location = new Point(460, 165);
            _cmdTerrain.Name = "_cmdTerrain";
            _cmdTerrain.Size = new Size(85, 23);
            _cmdTerrain.TabIndex = 0;
            _cmdTerrain.Text = "Copy From ...";
            _cmdTerrain.UseVisualStyleBackColor = true;
            // 
            // txtTerrain
            // 
            txtTerrain.BackColor = SystemColors.Control;
            txtTerrain.BorderStyle = BorderStyle.FixedSingle;
            txtTerrain.Location = new Point(22, 168);
            txtTerrain.Name = "txtTerrain";
            txtTerrain.ReadOnly = true;
            txtTerrain.Size = new Size(418, 20);
            txtTerrain.TabIndex = 1;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(19, 151);
            Label2.Name = "Label2";
            Label2.Size = new Size(238, 13);
            Label2.TabIndex = 2;
            Label2.Text = "Shp2Vec.exe, Resample.exe and ImageTool.exe";
            // 
            // cmdBGLComp
            // 
            _cmdBGLComp.Location = new Point(460, 206);
            _cmdBGLComp.Name = "_cmdBGLComp";
            _cmdBGLComp.Size = new Size(85, 23);
            _cmdBGLComp.TabIndex = 0;
            _cmdBGLComp.Text = "Copy From ...";
            _cmdBGLComp.UseVisualStyleBackColor = true;
            // 
            // txtBGLComp
            // 
            txtBGLComp.BackColor = SystemColors.Control;
            txtBGLComp.BorderStyle = BorderStyle.FixedSingle;
            txtBGLComp.Location = new Point(22, 208);
            txtBGLComp.Name = "txtBGLComp";
            txtBGLComp.ReadOnly = true;
            txtBGLComp.Size = new Size(418, 20);
            txtBGLComp.TabIndex = 1;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(19, 192);
            Label4.Name = "Label4";
            Label4.Size = new Size(154, 13);
            Label4.TabIndex = 2;
            Label4.Text = "BglComp.exe and BglComp.xsd";
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(460, 295);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(85, 24);
            _cmdOK.TabIndex = 3;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.Location = new Point(19, 295);
            Label3.Name = "Label3";
            Label3.Size = new Size(430, 36);
            Label3.TabIndex = 4;
            Label3.Text = "Paths shown in RED do not seem correct. If you press OK, without correcting this " + "situation, SBuilderX can not generate some BGL files.";
            // 
            // cmdPlugins
            // 
            _cmdPlugins.Location = new Point(460, 252);
            _cmdPlugins.Name = "_cmdPlugins";
            _cmdPlugins.Size = new Size(85, 23);
            _cmdPlugins.TabIndex = 0;
            _cmdPlugins.Text = "Copy From ...";
            _cmdPlugins.UseVisualStyleBackColor = true;
            // 
            // txtPlugins
            // 
            txtPlugins.BackColor = SystemColors.Control;
            txtPlugins.BorderStyle = BorderStyle.FixedSingle;
            txtPlugins.Location = new Point(22, 254);
            txtPlugins.Name = "txtPlugins";
            txtPlugins.ReadOnly = true;
            txtPlugins.Size = new Size(418, 20);
            txtPlugins.TabIndex = 1;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(19, 238);
            Label5.Name = "Label5";
            Label5.Size = new Size(354, 13);
            Label5.TabIndex = 2;
            Label5.Text = "XToMdl.exe, Managed_CrashTree.dll and Managed_Lookup_Keyword.dll";
            // 
            // Label6
            // 
            Label6.BorderStyle = BorderStyle.FixedSingle;
            Label6.Location = new Point(19, 92);
            Label6.Name = "Label6";
            Label6.Size = new Size(526, 2);
            Label6.TabIndex = 6;
            Label6.UseWaitCursor = true;
            // 
            // Label7
            // 
            Label7.Location = new Point(19, 111);
            Label7.Name = "Label7";
            Label7.Size = new Size(526, 40);
            Label7.TabIndex = 7;
            Label7.Text = resources.GetString("Label7.Text");
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(137, 64);
            Label8.Name = "Label8";
            Label8.Size = new Size(305, 13);
            Label8.TabIndex = 9;
            Label8.Text = "Name of the Simulator. For Microsoft FSX you should enter FSX";
            // 
            // txtNameOfSim
            // 
            txtNameOfSim.Location = new Point(22, 61);
            txtNameOfSim.Name = "txtNameOfSim";
            txtNameOfSim.Size = new Size(109, 20);
            txtNameOfSim.TabIndex = 10;
            // 
            // FrmFSXSettings
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 332);
            Controls.Add(txtNameOfSim);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label3);
            Controls.Add(_cmdOK);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(txtPlugins);
            Controls.Add(txtBGLComp);
            Controls.Add(_cmdPlugins);
            Controls.Add(txtTerrain);
            Controls.Add(_cmdBGLComp);
            Controls.Add(_cmdTerrain);
            Controls.Add(txtFSPath);
            Controls.Add(_cmdFSX);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFSXSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - FSX Settings";
            Load += new EventHandler(FrmFSXSettings_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _cmdFSX;

        internal Button cmdFSX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdFSX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdFSX != null)
                {
                    _cmdFSX.Click -= CmdFSX_Click;
                }

                _cmdFSX = value;
                if (_cmdFSX != null)
                {
                    _cmdFSX.Click += CmdFSX_Click;
                }
            }
        }

        internal TextBox txtFSPath;
        internal Label Label1;
        private Button _cmdTerrain;

        internal Button cmdTerrain
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTerrain;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTerrain != null)
                {
                    _cmdTerrain.Click -= CmdTerrain_Click;
                }

                _cmdTerrain = value;
                if (_cmdTerrain != null)
                {
                    _cmdTerrain.Click += CmdTerrain_Click;
                }
            }
        }

        internal TextBox txtTerrain;
        internal Label Label2;
        private Button _cmdBGLComp;

        internal Button cmdBGLComp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdBGLComp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdBGLComp != null)
                {
                    _cmdBGLComp.Click -= CmdBGLComp_Click;
                }

                _cmdBGLComp = value;
                if (_cmdBGLComp != null)
                {
                    _cmdBGLComp.Click += CmdBGLComp_Click;
                }
            }
        }

        internal TextBox txtBGLComp;
        internal Label Label4;
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

        internal Label Label3;
        internal FolderBrowserDialog FolderBrowserDialog1;
        private Button _cmdPlugins;

        internal Button cmdPlugins
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPlugins;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPlugins != null)
                {
                    _cmdPlugins.Click -= CmdPlugins_Click;
                }

                _cmdPlugins = value;
                if (_cmdPlugins != null)
                {
                    _cmdPlugins.Click += CmdPlugins_Click;
                }
            }
        }

        internal TextBox txtPlugins;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal TextBox txtNameOfSim;
    }
}