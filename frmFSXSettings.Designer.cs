using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFSXSettings));
            this._cmdFSX = new System.Windows.Forms.Button();
            this.txtFSPath = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this._cmdTerrain = new System.Windows.Forms.Button();
            this.txtTerrain = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this._cmdBGLComp = new System.Windows.Forms.Button();
            this.txtBGLComp = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this._cmdOK = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this._cmdPlugins = new System.Windows.Forms.Button();
            this.txtPlugins = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtNameOfSim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _cmdFSX
            // 
            this._cmdFSX.Location = new System.Drawing.Point(514, 33);
            this._cmdFSX.Name = "_cmdFSX";
            this._cmdFSX.Size = new System.Drawing.Size(31, 23);
            this._cmdFSX.TabIndex = 0;
            this._cmdFSX.Text = "...";
            this._cmdFSX.UseVisualStyleBackColor = true;
            this._cmdFSX.Click += new System.EventHandler(this.CmdFSX_Click);
            // 
            // txtFSPath
            // 
            this.txtFSPath.BackColor = System.Drawing.Color.White;
            this.txtFSPath.Location = new System.Drawing.Point(22, 35);
            this.txtFSPath.Name = "txtFSPath";
            this.txtFSPath.ReadOnly = true;
            this.txtFSPath.Size = new System.Drawing.Size(476, 20);
            this.txtFSPath.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(134, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Full Path to Flight Simulator";
            // 
            // _cmdTerrain
            // 
            this._cmdTerrain.Location = new System.Drawing.Point(460, 165);
            this._cmdTerrain.Name = "_cmdTerrain";
            this._cmdTerrain.Size = new System.Drawing.Size(85, 23);
            this._cmdTerrain.TabIndex = 0;
            this._cmdTerrain.Text = "Copy From ...";
            this._cmdTerrain.UseVisualStyleBackColor = true;
            this._cmdTerrain.Click += new System.EventHandler(this.CmdTerrain_Click);
            // 
            // txtTerrain
            // 
            this.txtTerrain.BackColor = System.Drawing.SystemColors.Control;
            this.txtTerrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerrain.Location = new System.Drawing.Point(22, 168);
            this.txtTerrain.Name = "txtTerrain";
            this.txtTerrain.ReadOnly = true;
            this.txtTerrain.Size = new System.Drawing.Size(418, 20);
            this.txtTerrain.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(19, 151);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(238, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Shp2Vec.exe, Resample.exe and ImageTool.exe";
            // 
            // _cmdBGLComp
            // 
            this._cmdBGLComp.Location = new System.Drawing.Point(460, 206);
            this._cmdBGLComp.Name = "_cmdBGLComp";
            this._cmdBGLComp.Size = new System.Drawing.Size(85, 23);
            this._cmdBGLComp.TabIndex = 0;
            this._cmdBGLComp.Text = "Copy From ...";
            this._cmdBGLComp.UseVisualStyleBackColor = true;
            this._cmdBGLComp.Click += new System.EventHandler(this.CmdBGLComp_Click);
            // 
            // txtBGLComp
            // 
            this.txtBGLComp.BackColor = System.Drawing.SystemColors.Control;
            this.txtBGLComp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBGLComp.Location = new System.Drawing.Point(22, 208);
            this.txtBGLComp.Name = "txtBGLComp";
            this.txtBGLComp.ReadOnly = true;
            this.txtBGLComp.Size = new System.Drawing.Size(418, 20);
            this.txtBGLComp.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(19, 192);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(154, 13);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "BglComp.exe and BglComp.xsd";
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(460, 295);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(85, 24);
            this._cmdOK.TabIndex = 3;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(19, 295);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(430, 36);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Paths shown in RED do not seem correct. If you press OK, without correcting this " +
    "situation, SBuilderXX can not generate some BGL files.";
            // 
            // _cmdPlugins
            // 
            this._cmdPlugins.Location = new System.Drawing.Point(460, 252);
            this._cmdPlugins.Name = "_cmdPlugins";
            this._cmdPlugins.Size = new System.Drawing.Size(85, 23);
            this._cmdPlugins.TabIndex = 0;
            this._cmdPlugins.Text = "Copy From ...";
            this._cmdPlugins.UseVisualStyleBackColor = true;
            this._cmdPlugins.Click += new System.EventHandler(this.CmdPlugins_Click);
            // 
            // txtPlugins
            // 
            this.txtPlugins.BackColor = System.Drawing.SystemColors.Control;
            this.txtPlugins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlugins.Location = new System.Drawing.Point(22, 254);
            this.txtPlugins.Name = "txtPlugins";
            this.txtPlugins.ReadOnly = true;
            this.txtPlugins.Size = new System.Drawing.Size(418, 20);
            this.txtPlugins.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(19, 238);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(354, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "XToMdl.exe, Managed_CrashTree.dll and Managed_Lookup_Keyword.dll";
            // 
            // Label6
            // 
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Location = new System.Drawing.Point(19, 92);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(526, 2);
            this.Label6.TabIndex = 6;
            this.Label6.UseWaitCursor = true;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(19, 111);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(526, 40);
            this.Label7.TabIndex = 7;
            this.Label7.Text = resources.GetString("Label7.Text");
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(137, 64);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(305, 13);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Name of the Simulator. For Microsoft FSX you should enter FSX";
            // 
            // txtNameOfSim
            // 
            this.txtNameOfSim.Location = new System.Drawing.Point(22, 61);
            this.txtNameOfSim.Name = "txtNameOfSim";
            this.txtNameOfSim.Size = new System.Drawing.Size(109, 20);
            this.txtNameOfSim.TabIndex = 10;
            // 
            // FrmFSXSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 332);
            this.Controls.Add(this.txtNameOfSim);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtPlugins);
            this.Controls.Add(this.txtBGLComp);
            this.Controls.Add(this._cmdPlugins);
            this.Controls.Add(this.txtTerrain);
            this.Controls.Add(this._cmdBGLComp);
            this.Controls.Add(this._cmdTerrain);
            this.Controls.Add(this.txtFSPath);
            this.Controls.Add(this._cmdFSX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFSXSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - FSX Settings";
            this.Load += new System.EventHandler(this.FrmFSXSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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