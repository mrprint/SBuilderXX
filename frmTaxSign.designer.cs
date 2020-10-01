using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmTaxSign
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public FrmTaxSign() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTip1;
        private TextBox _txtMessage;

        public TextBox txtMessage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtMessage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtMessage != null)
                {
                    _txtMessage.KeyDown -= TxtMessage_KeyDown;
                }

                _txtMessage = value;
                if (_txtMessage != null)
                {
                    _txtMessage.KeyDown += TxtMessage_KeyDown;
                }
            }
        }

        private Button _cmdOK;

        public Button cmdOK
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

        private Button _cmdINFO;

        public Button cmdINFO
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdINFO;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdINFO != null)
                {
                    _cmdINFO.Click -= CmdINFO_Click;
                }

                _cmdINFO = value;
                if (_cmdINFO != null)
                {
                    _cmdINFO.Click += CmdINFO_Click;
                }
            }
        }

        private Button _cmdRUN;

        public Button cmdRUN
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRUN;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRUN != null)
                {
                    _cmdRUN.Click -= CmdRUN_Click;
                }

                _cmdRUN = value;
                if (_cmdRUN != null)
                {
                    _cmdRUN.Click += CmdRUN_Click;
                }
            }
        }

        private Button _cmdDIR;

        public Button cmdDIR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDIR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDIR != null)
                {
                    _cmdDIR.Click -= CmdDIR_Click;
                }

                _cmdDIR = value;
                if (_cmdDIR != null)
                {
                    _cmdDIR.Click += CmdDIR_Click;
                }
            }
        }

        private Button _cmdLOC;

        public Button cmdLOC
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLOC;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLOC != null)
                {
                    _cmdLOC.Click -= CmdLOC_Click;
                }

                _cmdLOC = value;
                if (_cmdLOC != null)
                {
                    _cmdLOC.Click += CmdLOC_Click;
                }
            }
        }

        public GroupBox Frame2;
        private Button _cmdDIV;

        public Button cmdDIV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDIV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDIV != null)
                {
                    _cmdDIV.Click -= CmdDIV_Click;
                }

                _cmdDIV = value;
                if (_cmdDIV != null)
                {
                    _cmdDIV.Click += CmdDIV_Click;
                }
            }
        }

        private Button _cmdXX;

        public Button cmdXX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdXX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdXX != null)
                {
                    _cmdXX.Click -= CmdXX_Click;
                }

                _cmdXX = value;
                if (_cmdXX != null)
                {
                    _cmdXX.Click += CmdXX_Click;
                }
            }
        }

        private Button _cmdHOLD;

        public Button cmdHOLD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHOLD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHOLD != null)
                {
                    _cmdHOLD.Click -= CmdHOLD_Click;
                }

                _cmdHOLD = value;
                if (_cmdHOLD != null)
                {
                    _cmdHOLD.Click += CmdHOLD_Click;
                }
            }
        }

        private Button _cmdILS;

        public Button cmdILS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdILS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdILS != null)
                {
                    _cmdILS.Click -= CmdILS_Click;
                }

                _cmdILS = value;
                if (_cmdILS != null)
                {
                    _cmdILS.Click += CmdILS_Click;
                }
            }
        }

        private Button _cmdDD;

        public Button cmdDD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDD != null)
                {
                    _cmdDD.Click -= CmdDD_Click;
                }

                _cmdDD = value;
                if (_cmdDD != null)
                {
                    _cmdDD.Click += CmdDD_Click;
                }
            }
        }

        private Button _cmdDL;

        public Button cmdDL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDL != null)
                {
                    _cmdDL.Click -= CmdDL_Click;
                }

                _cmdDL = value;
                if (_cmdDL != null)
                {
                    _cmdDL.Click += CmdDL_Click;
                }
            }
        }

        private Button _cmdLL;

        public Button cmdLL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLL != null)
                {
                    _cmdLL.Click -= CmdLL_Click;
                }

                _cmdLL = value;
                if (_cmdLL != null)
                {
                    _cmdLL.Click += CmdLL_Click;
                }
            }
        }

        private Button _cmdUL;

        public Button cmdUL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUL != null)
                {
                    _cmdUL.Click -= CmdUL_Click;
                }

                _cmdUL = value;
                if (_cmdUL != null)
                {
                    _cmdUL.Click += CmdUL_Click;
                }
            }
        }

        private Button _cmdDR;

        public Button cmdDR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDR != null)
                {
                    _cmdDR.Click -= CmdDR_Click;
                }

                _cmdDR = value;
                if (_cmdDR != null)
                {
                    _cmdDR.Click += CmdDR_Click;
                }
            }
        }

        private Button _cmdRR;

        public Button cmdRR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRR != null)
                {
                    _cmdRR.Click -= CmdRR_Click;
                }

                _cmdRR = value;
                if (_cmdRR != null)
                {
                    _cmdRR.Click += CmdRR_Click;
                }
            }
        }

        private Button _cmdUR;

        public Button cmdUR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUR != null)
                {
                    _cmdUR.Click -= CmdUR_Click;
                }

                _cmdUR = value;
                if (_cmdUR != null)
                {
                    _cmdUR.Click += CmdUR_Click;
                }
            }
        }

        private Button _cmdUP;

        public Button cmdUP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUP != null)
                {
                    _cmdUP.Click -= CmdUp_Click;
                }

                _cmdUP = value;
                if (_cmdUP != null)
                {
                    _cmdUP.Click += CmdUp_Click;
                }
            }
        }

        public GroupBox Frame1;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaxSign));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._txtMessage = new System.Windows.Forms.TextBox();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this._cmdINFO = new System.Windows.Forms.Button();
            this._cmdRUN = new System.Windows.Forms.Button();
            this._cmdDIR = new System.Windows.Forms.Button();
            this._cmdLOC = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this._cmdDIV = new System.Windows.Forms.Button();
            this._cmdXX = new System.Windows.Forms.Button();
            this._cmdHOLD = new System.Windows.Forms.Button();
            this._cmdILS = new System.Windows.Forms.Button();
            this._cmdDD = new System.Windows.Forms.Button();
            this._cmdDL = new System.Windows.Forms.Button();
            this._cmdLL = new System.Windows.Forms.Button();
            this._cmdUL = new System.Windows.Forms.Button();
            this._cmdDR = new System.Windows.Forms.Button();
            this._cmdRR = new System.Windows.Forms.Button();
            this._cmdUR = new System.Windows.Forms.Button();
            this._cmdUP = new System.Windows.Forms.Button();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _txtMessage
            // 
            this._txtMessage.AcceptsReturn = true;
            this._txtMessage.BackColor = System.Drawing.SystemColors.Window;
            this._txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtMessage.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtMessage.Location = new System.Drawing.Point(204, 96);
            this._txtMessage.MaxLength = 0;
            this._txtMessage.Name = "_txtMessage";
            this._txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtMessage.Size = new System.Drawing.Size(133, 20);
            this._txtMessage.TabIndex = 11;
            this._txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMessage_KeyDown);
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(282, 132);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(55, 25);
            this._cmdOK.TabIndex = 10;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(204, 132);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(55, 25);
            this._cmdCancel.TabIndex = 9;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this._cmdINFO);
            this.Frame2.Controls.Add(this._cmdRUN);
            this.Frame2.Controls.Add(this._cmdDIR);
            this.Frame2.Controls.Add(this._cmdLOC);
            this.Frame2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Frame2.Location = new System.Drawing.Point(192, 18);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(157, 61);
            this.Frame2.TabIndex = 8;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Change Type";
            // 
            // _cmdINFO
            // 
            this._cmdINFO.BackColor = System.Drawing.SystemColors.Control;
            this._cmdINFO.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdINFO.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdINFO.Image = ((System.Drawing.Image)(resources.GetObject("_cmdINFO.Image")));
            this._cmdINFO.Location = new System.Drawing.Point(120, 24);
            this._cmdINFO.Name = "_cmdINFO";
            this._cmdINFO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdINFO.Size = new System.Drawing.Size(25, 25);
            this._cmdINFO.TabIndex = 20;
            this._cmdINFO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdINFO.UseVisualStyleBackColor = false;
            this._cmdINFO.Click += new System.EventHandler(this.CmdINFO_Click);
            // 
            // _cmdRUN
            // 
            this._cmdRUN.BackColor = System.Drawing.SystemColors.Control;
            this._cmdRUN.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdRUN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdRUN.Image = ((System.Drawing.Image)(resources.GetObject("_cmdRUN.Image")));
            this._cmdRUN.Location = new System.Drawing.Point(84, 24);
            this._cmdRUN.Name = "_cmdRUN";
            this._cmdRUN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdRUN.Size = new System.Drawing.Size(25, 25);
            this._cmdRUN.TabIndex = 14;
            this._cmdRUN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdRUN.UseVisualStyleBackColor = false;
            this._cmdRUN.Click += new System.EventHandler(this.CmdRUN_Click);
            // 
            // _cmdDIR
            // 
            this._cmdDIR.BackColor = System.Drawing.Color.White;
            this._cmdDIR.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDIR.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDIR.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDIR.Image")));
            this._cmdDIR.Location = new System.Drawing.Point(48, 24);
            this._cmdDIR.Name = "_cmdDIR";
            this._cmdDIR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDIR.Size = new System.Drawing.Size(25, 25);
            this._cmdDIR.TabIndex = 13;
            this._cmdDIR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDIR.UseVisualStyleBackColor = false;
            this._cmdDIR.Click += new System.EventHandler(this.CmdDIR_Click);
            // 
            // _cmdLOC
            // 
            this._cmdLOC.BackColor = System.Drawing.Color.White;
            this._cmdLOC.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLOC.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLOC.Image = ((System.Drawing.Image)(resources.GetObject("_cmdLOC.Image")));
            this._cmdLOC.Location = new System.Drawing.Point(12, 24);
            this._cmdLOC.Name = "_cmdLOC";
            this._cmdLOC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLOC.Size = new System.Drawing.Size(25, 25);
            this._cmdLOC.TabIndex = 12;
            this._cmdLOC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdLOC.UseVisualStyleBackColor = false;
            this._cmdLOC.Click += new System.EventHandler(this.CmdLOC_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this._cmdDIV);
            this.Frame1.Controls.Add(this._cmdXX);
            this.Frame1.Controls.Add(this._cmdHOLD);
            this.Frame1.Controls.Add(this._cmdILS);
            this.Frame1.Controls.Add(this._cmdDD);
            this.Frame1.Controls.Add(this._cmdDL);
            this.Frame1.Controls.Add(this._cmdLL);
            this.Frame1.Controls.Add(this._cmdUL);
            this.Frame1.Controls.Add(this._cmdDR);
            this.Frame1.Controls.Add(this._cmdRR);
            this.Frame1.Controls.Add(this._cmdUR);
            this.Frame1.Controls.Add(this._cmdUP);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Frame1.Location = new System.Drawing.Point(12, 18);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(157, 139);
            this.Frame1.TabIndex = 0;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Special symbols";
            // 
            // _cmdDIV
            // 
            this._cmdDIV.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDIV.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDIV.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDIV.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDIV.Image")));
            this._cmdDIV.Location = new System.Drawing.Point(120, 99);
            this._cmdDIV.Name = "_cmdDIV";
            this._cmdDIV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDIV.Size = new System.Drawing.Size(25, 25);
            this._cmdDIV.TabIndex = 19;
            this._cmdDIV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDIV.UseVisualStyleBackColor = false;
            this._cmdDIV.Click += new System.EventHandler(this.CmdDIV_Click);
            // 
            // _cmdXX
            // 
            this._cmdXX.BackColor = System.Drawing.SystemColors.Control;
            this._cmdXX.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdXX.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdXX.Image = ((System.Drawing.Image)(resources.GetObject("_cmdXX.Image")));
            this._cmdXX.Location = new System.Drawing.Point(12, 99);
            this._cmdXX.Name = "_cmdXX";
            this._cmdXX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdXX.Size = new System.Drawing.Size(25, 25);
            this._cmdXX.TabIndex = 18;
            this._cmdXX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdXX.UseVisualStyleBackColor = false;
            this._cmdXX.Click += new System.EventHandler(this.CmdXX_Click);
            // 
            // _cmdHOLD
            // 
            this._cmdHOLD.BackColor = System.Drawing.SystemColors.Control;
            this._cmdHOLD.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdHOLD.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdHOLD.Image = ((System.Drawing.Image)(resources.GetObject("_cmdHOLD.Image")));
            this._cmdHOLD.Location = new System.Drawing.Point(48, 99);
            this._cmdHOLD.Name = "_cmdHOLD";
            this._cmdHOLD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdHOLD.Size = new System.Drawing.Size(25, 25);
            this._cmdHOLD.TabIndex = 17;
            this._cmdHOLD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdHOLD.UseVisualStyleBackColor = false;
            this._cmdHOLD.Click += new System.EventHandler(this.CmdHOLD_Click);
            // 
            // _cmdILS
            // 
            this._cmdILS.BackColor = System.Drawing.SystemColors.Control;
            this._cmdILS.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdILS.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdILS.Image = ((System.Drawing.Image)(resources.GetObject("_cmdILS.Image")));
            this._cmdILS.Location = new System.Drawing.Point(84, 99);
            this._cmdILS.Name = "_cmdILS";
            this._cmdILS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdILS.Size = new System.Drawing.Size(25, 25);
            this._cmdILS.TabIndex = 16;
            this._cmdILS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdILS.UseVisualStyleBackColor = false;
            this._cmdILS.Click += new System.EventHandler(this.CmdILS_Click);
            // 
            // _cmdDD
            // 
            this._cmdDD.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDD.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDD.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDD.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDD.Image")));
            this._cmdDD.Location = new System.Drawing.Point(120, 60);
            this._cmdDD.Name = "_cmdDD";
            this._cmdDD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDD.Size = new System.Drawing.Size(25, 25);
            this._cmdDD.TabIndex = 15;
            this._cmdDD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDD.UseVisualStyleBackColor = false;
            this._cmdDD.Click += new System.EventHandler(this.CmdDD_Click);
            // 
            // _cmdDL
            // 
            this._cmdDL.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDL.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDL.Image")));
            this._cmdDL.Location = new System.Drawing.Point(12, 24);
            this._cmdDL.Name = "_cmdDL";
            this._cmdDL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDL.Size = new System.Drawing.Size(25, 25);
            this._cmdDL.TabIndex = 7;
            this._cmdDL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDL.UseVisualStyleBackColor = false;
            this._cmdDL.Click += new System.EventHandler(this.CmdDL_Click);
            // 
            // _cmdLL
            // 
            this._cmdLL.BackColor = System.Drawing.SystemColors.Control;
            this._cmdLL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLL.Image = ((System.Drawing.Image)(resources.GetObject("_cmdLL.Image")));
            this._cmdLL.Location = new System.Drawing.Point(43, 24);
            this._cmdLL.Name = "_cmdLL";
            this._cmdLL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLL.Size = new System.Drawing.Size(25, 25);
            this._cmdLL.TabIndex = 6;
            this._cmdLL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdLL.UseVisualStyleBackColor = false;
            this._cmdLL.Click += new System.EventHandler(this.CmdLL_Click);
            // 
            // _cmdUL
            // 
            this._cmdUL.BackColor = System.Drawing.SystemColors.Control;
            this._cmdUL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdUL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUL.Image = ((System.Drawing.Image)(resources.GetObject("_cmdUL.Image")));
            this._cmdUL.Location = new System.Drawing.Point(84, 24);
            this._cmdUL.Name = "_cmdUL";
            this._cmdUL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUL.Size = new System.Drawing.Size(25, 25);
            this._cmdUL.TabIndex = 5;
            this._cmdUL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUL.UseVisualStyleBackColor = false;
            this._cmdUL.Click += new System.EventHandler(this.CmdUL_Click);
            // 
            // _cmdDR
            // 
            this._cmdDR.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDR.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDR.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDR.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDR.Image")));
            this._cmdDR.Location = new System.Drawing.Point(84, 60);
            this._cmdDR.Name = "_cmdDR";
            this._cmdDR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDR.Size = new System.Drawing.Size(25, 25);
            this._cmdDR.TabIndex = 4;
            this._cmdDR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDR.UseVisualStyleBackColor = false;
            this._cmdDR.Click += new System.EventHandler(this.CmdDR_Click);
            // 
            // _cmdRR
            // 
            this._cmdRR.BackColor = System.Drawing.SystemColors.Control;
            this._cmdRR.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdRR.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdRR.Image = ((System.Drawing.Image)(resources.GetObject("_cmdRR.Image")));
            this._cmdRR.Location = new System.Drawing.Point(48, 60);
            this._cmdRR.Name = "_cmdRR";
            this._cmdRR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdRR.Size = new System.Drawing.Size(25, 25);
            this._cmdRR.TabIndex = 3;
            this._cmdRR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdRR.UseVisualStyleBackColor = false;
            this._cmdRR.Click += new System.EventHandler(this.CmdRR_Click);
            // 
            // _cmdUR
            // 
            this._cmdUR.BackColor = System.Drawing.SystemColors.Control;
            this._cmdUR.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdUR.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUR.Image = ((System.Drawing.Image)(resources.GetObject("_cmdUR.Image")));
            this._cmdUR.Location = new System.Drawing.Point(12, 60);
            this._cmdUR.Name = "_cmdUR";
            this._cmdUR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUR.Size = new System.Drawing.Size(25, 25);
            this._cmdUR.TabIndex = 2;
            this._cmdUR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUR.UseVisualStyleBackColor = false;
            this._cmdUR.Click += new System.EventHandler(this.CmdUR_Click);
            // 
            // _cmdUP
            // 
            this._cmdUP.BackColor = System.Drawing.SystemColors.Control;
            this._cmdUP.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdUP.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUP.Image = ((System.Drawing.Image)(resources.GetObject("_cmdUP.Image")));
            this._cmdUP.Location = new System.Drawing.Point(120, 24);
            this._cmdUP.Name = "_cmdUP";
            this._cmdUP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUP.Size = new System.Drawing.Size(25, 25);
            this._cmdUP.TabIndex = 1;
            this._cmdUP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUP.UseVisualStyleBackColor = false;
            this._cmdUP.Click += new System.EventHandler(this.CmdUp_Click);
            // 
            // FrmTaxSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 169);
            this.Controls.Add(this._txtMessage);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(3, 29);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTaxSign";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SBuilderXX - Build Sign Message";
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}