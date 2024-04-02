
namespace WeightBridgeMandya.clientui
{
    partial class Print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.rptViewerPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewerPrint
            // 
            this.rptViewerPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewerPrint.Location = new System.Drawing.Point(20, 60);
            this.rptViewerPrint.Name = "rptViewerPrint";
            this.rptViewerPrint.Size = new System.Drawing.Size(680, 482);
            this.rptViewerPrint.TabIndex = 0;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 562);
            this.Controls.Add(this.rptViewerPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Print";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Weightment Slip";
            this.Load += new System.EventHandler(this.Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewerPrint;
    }
}