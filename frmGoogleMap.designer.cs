using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoogleMap));
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.buttonSat = new System.Windows.Forms.RadioButton();
            this.buttonMap = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(205, 65);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(58, 25);
            this._cmdOK.TabIndex = 4;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(130, 65);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(58, 25);
            this._cmdCancel.TabIndex = 5;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // buttonSat
            // 
            this.buttonSat.AutoSize = true;
            this.buttonSat.Checked = true;
            this.buttonSat.Location = new System.Drawing.Point(17, 13);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(62, 17);
            this.buttonSat.TabIndex = 6;
            this.buttonSat.TabStop = true;
            this.buttonSat.Text = "Satellite";
            this.buttonSat.UseVisualStyleBackColor = true;
            // 
            // buttonMap
            // 
            this.buttonMap.AutoSize = true;
            this.buttonMap.Location = new System.Drawing.Point(17, 39);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(72, 17);
            this.buttonMap.TabIndex = 7;
            this.buttonMap.Text = "RoadMap";
            this.buttonMap.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(110, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(175, 44);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "An image of 1280 x 1280 pixels at the present SBuilderXX Zoom level will be added" +
    " to your workspace";
            // 
            // frmGoogleMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.buttonSat);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGoogleMap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Add Google Map";
            this.ResumeLayout(false);
            this.PerformLayout();

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