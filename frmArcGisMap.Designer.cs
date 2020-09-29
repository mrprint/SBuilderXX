using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    public partial class frmArcGisMap : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArcGisMap));
            Label2 = new Label();
            buttonMap = new RadioButton();
            buttonSat = new RadioButton();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(cmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(cmdOK_Click);
            buttonTopo = new RadioButton();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.Location = new Point(110, 12);
            Label2.Name = "Label2";
            Label2.Size = new Size(175, 44);
            Label2.TabIndex = 13;
            Label2.Text = "An image of 4096 x 4096 pixels at the present SBuilderX Zoom level will be added " + "to your workspace";
            // 
            // buttonMap
            // 
            buttonMap.AutoSize = true;
            buttonMap.Location = new Point(17, 36);
            buttonMap.Name = "buttonMap";
            buttonMap.Size = new Size(72, 17);
            buttonMap.TabIndex = 12;
            buttonMap.Text = "RoadMap";
            buttonMap.UseVisualStyleBackColor = true;
            // 
            // buttonSat
            // 
            buttonSat.AutoSize = true;
            buttonSat.Checked = true;
            buttonSat.Location = new Point(17, 13);
            buttonSat.Name = "buttonSat";
            buttonSat.Size = new Size(62, 17);
            buttonSat.TabIndex = 11;
            buttonSat.TabStop = true;
            buttonSat.Text = "Satellite";
            buttonSat.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(130, 65);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(58, 25);
            _cmdCancel.TabIndex = 10;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(205, 65);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(58, 25);
            _cmdOK.TabIndex = 9;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // buttonTopo
            // 
            buttonTopo.AutoSize = true;
            buttonTopo.Location = new Point(17, 59);
            buttonTopo.Name = "buttonTopo";
            buttonTopo.Size = new Size(74, 17);
            buttonTopo.TabIndex = 12;
            buttonTopo.Text = "Topo Map";
            buttonTopo.UseVisualStyleBackColor = true;
            // 
            // frmArcGisMap
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 107);
            Controls.Add(Label2);
            Controls.Add(buttonTopo);
            Controls.Add(buttonMap);
            Controls.Add(buttonSat);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmArcGisMap";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Add ArcGis Map";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
        internal RadioButton buttonMap;
        internal RadioButton buttonSat;
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
                    _cmdCancel.Click -= cmdCancel_Click;
                }

                _cmdCancel = value;
                if (_cmdCancel != null)
                {
                    _cmdCancel.Click += cmdCancel_Click;
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
                    _cmdOK.Click -= cmdOK_Click;
                }

                _cmdOK = value;
                if (_cmdOK != null)
                {
                    _cmdOK.Click += cmdOK_Click;
                }
            }
        }

        internal RadioButton buttonTopo;
    }
}