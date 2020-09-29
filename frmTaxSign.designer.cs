using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaxSign));
            ToolTip1 = new ToolTip(components);
            _txtMessage = new TextBox();
            _txtMessage.KeyDown += new KeyEventHandler(TxtMessage_KeyDown);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            Frame2 = new GroupBox();
            _cmdINFO = new Button();
            _cmdINFO.Click += new EventHandler(CmdINFO_Click);
            _cmdRUN = new Button();
            _cmdRUN.Click += new EventHandler(CmdRUN_Click);
            _cmdDIR = new Button();
            _cmdDIR.Click += new EventHandler(CmdDIR_Click);
            _cmdLOC = new Button();
            _cmdLOC.Click += new EventHandler(CmdLOC_Click);
            Frame1 = new GroupBox();
            _cmdDIV = new Button();
            _cmdDIV.Click += new EventHandler(CmdDIV_Click);
            _cmdXX = new Button();
            _cmdXX.Click += new EventHandler(CmdXX_Click);
            _cmdHOLD = new Button();
            _cmdHOLD.Click += new EventHandler(CmdHOLD_Click);
            _cmdILS = new Button();
            _cmdILS.Click += new EventHandler(CmdILS_Click);
            _cmdDD = new Button();
            _cmdDD.Click += new EventHandler(CmdDD_Click);
            _cmdDL = new Button();
            _cmdDL.Click += new EventHandler(CmdDL_Click);
            _cmdLL = new Button();
            _cmdLL.Click += new EventHandler(CmdLL_Click);
            _cmdUL = new Button();
            _cmdUL.Click += new EventHandler(CmdUL_Click);
            _cmdDR = new Button();
            _cmdDR.Click += new EventHandler(CmdDR_Click);
            _cmdRR = new Button();
            _cmdRR.Click += new EventHandler(CmdRR_Click);
            _cmdUR = new Button();
            _cmdUR.Click += new EventHandler(CmdUR_Click);
            _cmdUP = new Button();
            _cmdUP.Click += new EventHandler(CmdUp_Click);
            Frame2.SuspendLayout();
            Frame1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMessage
            // 
            _txtMessage.AcceptsReturn = true;
            _txtMessage.BackColor = SystemColors.Window;
            _txtMessage.Cursor = Cursors.IBeam;
            _txtMessage.ForeColor = SystemColors.WindowText;
            _txtMessage.Location = new Point(204, 96);
            _txtMessage.MaxLength = 0;
            _txtMessage.Name = "_txtMessage";
            _txtMessage.RightToLeft = RightToLeft.No;
            _txtMessage.Size = new Size(133, 20);
            _txtMessage.TabIndex = 11;
            _txtMessage.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(282, 132);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(55, 25);
            _cmdOK.TabIndex = 10;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(204, 132);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(55, 25);
            _cmdCancel.TabIndex = 9;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // Frame2
            // 
            Frame2.BackColor = SystemColors.Control;
            Frame2.Controls.Add(_cmdINFO);
            Frame2.Controls.Add(_cmdRUN);
            Frame2.Controls.Add(_cmdDIR);
            Frame2.Controls.Add(_cmdLOC);
            Frame2.ForeColor = SystemColors.ActiveCaption;
            Frame2.Location = new Point(192, 18);
            Frame2.Name = "Frame2";
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new Size(157, 61);
            Frame2.TabIndex = 8;
            Frame2.TabStop = false;
            Frame2.Text = "Change Type";
            // 
            // cmdINFO
            // 
            _cmdINFO.BackColor = SystemColors.Control;
            _cmdINFO.Cursor = Cursors.Default;
            _cmdINFO.ForeColor = SystemColors.ControlText;
            _cmdINFO.Image = (Image)resources.GetObject("cmdINFO.Image");
            _cmdINFO.Location = new Point(120, 24);
            _cmdINFO.Name = "_cmdINFO";
            _cmdINFO.RightToLeft = RightToLeft.No;
            _cmdINFO.Size = new Size(25, 25);
            _cmdINFO.TabIndex = 20;
            _cmdINFO.TextAlign = ContentAlignment.BottomCenter;
            _cmdINFO.UseVisualStyleBackColor = false;
            // 
            // cmdRUN
            // 
            _cmdRUN.BackColor = SystemColors.Control;
            _cmdRUN.Cursor = Cursors.Default;
            _cmdRUN.ForeColor = SystemColors.ControlText;
            _cmdRUN.Image = (Image)resources.GetObject("cmdRUN.Image");
            _cmdRUN.Location = new Point(84, 24);
            _cmdRUN.Name = "_cmdRUN";
            _cmdRUN.RightToLeft = RightToLeft.No;
            _cmdRUN.Size = new Size(25, 25);
            _cmdRUN.TabIndex = 14;
            _cmdRUN.TextAlign = ContentAlignment.BottomCenter;
            _cmdRUN.UseVisualStyleBackColor = false;
            // 
            // cmdDIR
            // 
            _cmdDIR.BackColor = Color.White;
            _cmdDIR.Cursor = Cursors.Default;
            _cmdDIR.ForeColor = SystemColors.ControlText;
            _cmdDIR.Image = (Image)resources.GetObject("cmdDIR.Image");
            _cmdDIR.Location = new Point(48, 24);
            _cmdDIR.Name = "_cmdDIR";
            _cmdDIR.RightToLeft = RightToLeft.No;
            _cmdDIR.Size = new Size(25, 25);
            _cmdDIR.TabIndex = 13;
            _cmdDIR.TextAlign = ContentAlignment.BottomCenter;
            _cmdDIR.UseVisualStyleBackColor = false;
            // 
            // cmdLOC
            // 
            _cmdLOC.BackColor = Color.White;
            _cmdLOC.Cursor = Cursors.Default;
            _cmdLOC.ForeColor = SystemColors.ControlText;
            _cmdLOC.Image = (Image)resources.GetObject("cmdLOC.Image");
            _cmdLOC.Location = new Point(12, 24);
            _cmdLOC.Name = "_cmdLOC";
            _cmdLOC.RightToLeft = RightToLeft.No;
            _cmdLOC.Size = new Size(25, 25);
            _cmdLOC.TabIndex = 12;
            _cmdLOC.TextAlign = ContentAlignment.BottomCenter;
            _cmdLOC.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Control;
            Frame1.Controls.Add(_cmdDIV);
            Frame1.Controls.Add(_cmdXX);
            Frame1.Controls.Add(_cmdHOLD);
            Frame1.Controls.Add(_cmdILS);
            Frame1.Controls.Add(_cmdDD);
            Frame1.Controls.Add(_cmdDL);
            Frame1.Controls.Add(_cmdLL);
            Frame1.Controls.Add(_cmdUL);
            Frame1.Controls.Add(_cmdDR);
            Frame1.Controls.Add(_cmdRR);
            Frame1.Controls.Add(_cmdUR);
            Frame1.Controls.Add(_cmdUP);
            Frame1.ForeColor = SystemColors.ActiveCaption;
            Frame1.Location = new Point(12, 18);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(157, 139);
            Frame1.TabIndex = 0;
            Frame1.TabStop = false;
            Frame1.Text = "Special symbols";
            // 
            // cmdDIV
            // 
            _cmdDIV.BackColor = SystemColors.Control;
            _cmdDIV.Cursor = Cursors.Default;
            _cmdDIV.ForeColor = SystemColors.ControlText;
            _cmdDIV.Image = (Image)resources.GetObject("cmdDIV.Image");
            _cmdDIV.Location = new Point(120, 99);
            _cmdDIV.Name = "_cmdDIV";
            _cmdDIV.RightToLeft = RightToLeft.No;
            _cmdDIV.Size = new Size(25, 25);
            _cmdDIV.TabIndex = 19;
            _cmdDIV.TextAlign = ContentAlignment.BottomCenter;
            _cmdDIV.UseVisualStyleBackColor = false;
            // 
            // cmdXX
            // 
            _cmdXX.BackColor = SystemColors.Control;
            _cmdXX.Cursor = Cursors.Default;
            _cmdXX.ForeColor = SystemColors.ControlText;
            _cmdXX.Image = (Image)resources.GetObject("cmdXX.Image");
            _cmdXX.Location = new Point(12, 99);
            _cmdXX.Name = "_cmdXX";
            _cmdXX.RightToLeft = RightToLeft.No;
            _cmdXX.Size = new Size(25, 25);
            _cmdXX.TabIndex = 18;
            _cmdXX.TextAlign = ContentAlignment.BottomCenter;
            _cmdXX.UseVisualStyleBackColor = false;
            // 
            // cmdHOLD
            // 
            _cmdHOLD.BackColor = SystemColors.Control;
            _cmdHOLD.Cursor = Cursors.Default;
            _cmdHOLD.ForeColor = SystemColors.ControlText;
            _cmdHOLD.Image = (Image)resources.GetObject("cmdHOLD.Image");
            _cmdHOLD.Location = new Point(48, 99);
            _cmdHOLD.Name = "_cmdHOLD";
            _cmdHOLD.RightToLeft = RightToLeft.No;
            _cmdHOLD.Size = new Size(25, 25);
            _cmdHOLD.TabIndex = 17;
            _cmdHOLD.TextAlign = ContentAlignment.BottomCenter;
            _cmdHOLD.UseVisualStyleBackColor = false;
            // 
            // cmdILS
            // 
            _cmdILS.BackColor = SystemColors.Control;
            _cmdILS.Cursor = Cursors.Default;
            _cmdILS.ForeColor = SystemColors.ControlText;
            _cmdILS.Image = (Image)resources.GetObject("cmdILS.Image");
            _cmdILS.Location = new Point(84, 99);
            _cmdILS.Name = "_cmdILS";
            _cmdILS.RightToLeft = RightToLeft.No;
            _cmdILS.Size = new Size(25, 25);
            _cmdILS.TabIndex = 16;
            _cmdILS.TextAlign = ContentAlignment.BottomCenter;
            _cmdILS.UseVisualStyleBackColor = false;
            // 
            // cmdDD
            // 
            _cmdDD.BackColor = SystemColors.Control;
            _cmdDD.Cursor = Cursors.Default;
            _cmdDD.ForeColor = SystemColors.ControlText;
            _cmdDD.Image = (Image)resources.GetObject("cmdDD.Image");
            _cmdDD.Location = new Point(120, 60);
            _cmdDD.Name = "_cmdDD";
            _cmdDD.RightToLeft = RightToLeft.No;
            _cmdDD.Size = new Size(25, 25);
            _cmdDD.TabIndex = 15;
            _cmdDD.TextAlign = ContentAlignment.BottomCenter;
            _cmdDD.UseVisualStyleBackColor = false;
            // 
            // cmdDL
            // 
            _cmdDL.BackColor = SystemColors.Control;
            _cmdDL.Cursor = Cursors.Default;
            _cmdDL.ForeColor = SystemColors.ControlText;
            _cmdDL.Image = (Image)resources.GetObject("cmdDL.Image");
            _cmdDL.Location = new Point(12, 24);
            _cmdDL.Name = "_cmdDL";
            _cmdDL.RightToLeft = RightToLeft.No;
            _cmdDL.Size = new Size(25, 25);
            _cmdDL.TabIndex = 7;
            _cmdDL.TextAlign = ContentAlignment.BottomCenter;
            _cmdDL.UseVisualStyleBackColor = false;
            // 
            // cmdLL
            // 
            _cmdLL.BackColor = SystemColors.Control;
            _cmdLL.Cursor = Cursors.Default;
            _cmdLL.ForeColor = SystemColors.ControlText;
            _cmdLL.Image = (Image)resources.GetObject("cmdLL.Image");
            _cmdLL.Location = new Point(43, 24);
            _cmdLL.Name = "_cmdLL";
            _cmdLL.RightToLeft = RightToLeft.No;
            _cmdLL.Size = new Size(25, 25);
            _cmdLL.TabIndex = 6;
            _cmdLL.TextAlign = ContentAlignment.BottomCenter;
            _cmdLL.UseVisualStyleBackColor = false;
            // 
            // cmdUL
            // 
            _cmdUL.BackColor = SystemColors.Control;
            _cmdUL.Cursor = Cursors.Default;
            _cmdUL.ForeColor = SystemColors.ControlText;
            _cmdUL.Image = (Image)resources.GetObject("cmdUL.Image");
            _cmdUL.Location = new Point(84, 24);
            _cmdUL.Name = "_cmdUL";
            _cmdUL.RightToLeft = RightToLeft.No;
            _cmdUL.Size = new Size(25, 25);
            _cmdUL.TabIndex = 5;
            _cmdUL.TextAlign = ContentAlignment.BottomCenter;
            _cmdUL.UseVisualStyleBackColor = false;
            // 
            // cmdDR
            // 
            _cmdDR.BackColor = SystemColors.Control;
            _cmdDR.Cursor = Cursors.Default;
            _cmdDR.ForeColor = SystemColors.ControlText;
            _cmdDR.Image = (Image)resources.GetObject("cmdDR.Image");
            _cmdDR.Location = new Point(84, 60);
            _cmdDR.Name = "_cmdDR";
            _cmdDR.RightToLeft = RightToLeft.No;
            _cmdDR.Size = new Size(25, 25);
            _cmdDR.TabIndex = 4;
            _cmdDR.TextAlign = ContentAlignment.BottomCenter;
            _cmdDR.UseVisualStyleBackColor = false;
            // 
            // cmdRR
            // 
            _cmdRR.BackColor = SystemColors.Control;
            _cmdRR.Cursor = Cursors.Default;
            _cmdRR.ForeColor = SystemColors.ControlText;
            _cmdRR.Image = (Image)resources.GetObject("cmdRR.Image");
            _cmdRR.Location = new Point(48, 60);
            _cmdRR.Name = "_cmdRR";
            _cmdRR.RightToLeft = RightToLeft.No;
            _cmdRR.Size = new Size(25, 25);
            _cmdRR.TabIndex = 3;
            _cmdRR.TextAlign = ContentAlignment.BottomCenter;
            _cmdRR.UseVisualStyleBackColor = false;
            // 
            // cmdUR
            // 
            _cmdUR.BackColor = SystemColors.Control;
            _cmdUR.Cursor = Cursors.Default;
            _cmdUR.ForeColor = SystemColors.ControlText;
            _cmdUR.Image = (Image)resources.GetObject("cmdUR.Image");
            _cmdUR.Location = new Point(12, 60);
            _cmdUR.Name = "_cmdUR";
            _cmdUR.RightToLeft = RightToLeft.No;
            _cmdUR.Size = new Size(25, 25);
            _cmdUR.TabIndex = 2;
            _cmdUR.TextAlign = ContentAlignment.BottomCenter;
            _cmdUR.UseVisualStyleBackColor = false;
            // 
            // cmdUP
            // 
            _cmdUP.BackColor = SystemColors.Control;
            _cmdUP.Cursor = Cursors.Default;
            _cmdUP.ForeColor = SystemColors.ControlText;
            _cmdUP.Image = (Image)resources.GetObject("cmdUP.Image");
            _cmdUP.Location = new Point(120, 24);
            _cmdUP.Name = "_cmdUP";
            _cmdUP.RightToLeft = RightToLeft.No;
            _cmdUP.Size = new Size(25, 25);
            _cmdUP.TabIndex = 1;
            _cmdUP.TextAlign = ContentAlignment.BottomCenter;
            _cmdUP.UseVisualStyleBackColor = false;
            // 
            // frmTaxSign
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(364, 169);
            Controls.Add(_txtMessage);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(Frame2);
            Controls.Add(Frame1);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTaxSign";
            RightToLeft = RightToLeft.No;
            Text = "SBuilderX - Build Sign Message";
            Frame2.ResumeLayout(false);
            Frame1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}