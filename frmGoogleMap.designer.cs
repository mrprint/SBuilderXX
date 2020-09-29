using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class frmGoogleMap : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoogleMap));
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            buttonSat = new RadioButton();
            buttonMap = new RadioButton();
            Label2 = new Label();
            SuspendLayout();
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(205, 65);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(58, 25);
            _cmdOK.TabIndex = 4;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(130, 65);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(58, 25);
            _cmdCancel.TabIndex = 5;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSat
            // 
            buttonSat.AutoSize = true;
            buttonSat.Checked = true;
            buttonSat.Location = new Point(17, 13);
            buttonSat.Name = "buttonSat";
            buttonSat.Size = new Size(62, 17);
            buttonSat.TabIndex = 6;
            buttonSat.TabStop = true;
            buttonSat.Text = "Satellite";
            buttonSat.UseVisualStyleBackColor = true;
            // 
            // buttonMap
            // 
            buttonMap.AutoSize = true;
            buttonMap.Location = new Point(17, 39);
            buttonMap.Name = "buttonMap";
            buttonMap.Size = new Size(72, 17);
            buttonMap.TabIndex = 7;
            buttonMap.Text = "RoadMap";
            buttonMap.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.Location = new Point(110, 12);
            Label2.Name = "Label2";
            Label2.Size = new Size(175, 44);
            Label2.TabIndex = 8;
            Label2.Text = "An image of 1280 x 1280 pixels at the present SBuilderX Zoom level will be added " + "to your workspace";
            // 
            // frmGoogleMap
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 107);
            Controls.Add(Label2);
            Controls.Add(buttonMap);
            Controls.Add(buttonSat);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGoogleMap";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Add Google Map";
            ResumeLayout(false);
            PerformLayout();
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

        internal RadioButton buttonSat;
        internal RadioButton buttonMap;
        internal Label Label2;
    }
}