using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArcGisMap));
            this.Label2 = new System.Windows.Forms.Label();
            this.buttonMap = new System.Windows.Forms.RadioButton();
            this.buttonSat = new System.Windows.Forms.RadioButton();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.buttonTopo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(110, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(175, 44);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "An image of 4096 x 4096 pixels at the present SBuilderXX Zoom level will be added" +
    " to your workspace";
            // 
            // buttonMap
            // 
            this.buttonMap.AutoSize = true;
            this.buttonMap.Location = new System.Drawing.Point(17, 36);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(72, 17);
            this.buttonMap.TabIndex = 12;
            this.buttonMap.Text = "RoadMap";
            this.buttonMap.UseVisualStyleBackColor = true;
            // 
            // buttonSat
            // 
            this.buttonSat.AutoSize = true;
            this.buttonSat.Checked = true;
            this.buttonSat.Location = new System.Drawing.Point(17, 13);
            this.buttonSat.Name = "buttonSat";
            this.buttonSat.Size = new System.Drawing.Size(62, 17);
            this.buttonSat.TabIndex = 11;
            this.buttonSat.TabStop = true;
            this.buttonSat.Text = "Satellite";
            this.buttonSat.UseVisualStyleBackColor = true;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(130, 65);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(58, 25);
            this._cmdCancel.TabIndex = 10;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(205, 65);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(58, 25);
            this._cmdOK.TabIndex = 9;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // buttonTopo
            // 
            this.buttonTopo.AutoSize = true;
            this.buttonTopo.Location = new System.Drawing.Point(17, 59);
            this.buttonTopo.Name = "buttonTopo";
            this.buttonTopo.Size = new System.Drawing.Size(74, 17);
            this.buttonTopo.TabIndex = 12;
            this.buttonTopo.Text = "Topo Map";
            this.buttonTopo.UseVisualStyleBackColor = true;
            // 
            // frmArcGisMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.buttonTopo);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.buttonSat);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArcGisMap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Add ArcGis Map";
            this.ResumeLayout(false);
            this.PerformLayout();

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