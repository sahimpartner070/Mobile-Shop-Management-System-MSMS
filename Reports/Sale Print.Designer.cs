namespace Mobile_shop_application.Reports
{
    partial class Sale_Print
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
            this._crystal = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report1 = new Mobile_shop_application.Reports.Report();
            this.SuspendLayout();
            // 
            // _crystal
            // 
            this._crystal.ActiveViewIndex = 0;
            this._crystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._crystal.Cursor = System.Windows.Forms.Cursors.Default;
            this._crystal.Dock = System.Windows.Forms.DockStyle.Fill;
            this._crystal.Location = new System.Drawing.Point(0, 0);
            this._crystal.Name = "_crystal";
            this._crystal.ReportSource = this.Report1;
            this._crystal.Size = new System.Drawing.Size(1286, 735);
            this._crystal.TabIndex = 0;
            this._crystal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this._crystal.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Sale_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 735);
            this.Controls.Add(this._crystal);
            this.Name = "Sale_Print";
            this.Text = "Sale_Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_Print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer _crystal;
        private Report Report1;
    }
}