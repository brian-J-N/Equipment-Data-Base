
namespace COMS_276_Program4
{
    partial class frmReport
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
            this.webReport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webReport
            // 
            this.webReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webReport.Location = new System.Drawing.Point(0, 0);
            this.webReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.webReport.Name = "webReport";
            this.webReport.Size = new System.Drawing.Size(282, 253);
            this.webReport.TabIndex = 0;
            this.webReport.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmReport
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.webReport);
            this.Name = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbReport;
        private System.Windows.Forms.WebBrowser webReport;
    }
}