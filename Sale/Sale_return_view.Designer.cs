namespace Mobile_shop_application.Sale
{
    partial class Sale_return_view
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
            this._dgv1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dgv1
            // 
            this._dgv1.AllowUserToAddRows = false;
            this._dgv1.AllowUserToDeleteRows = false;
            this._dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._dgv1.BackgroundColor = System.Drawing.Color.White;
            this._dgv1.CausesValidation = false;
            this._dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dgv1.Location = new System.Drawing.Point(0, 0);
            this._dgv1.Name = "_dgv1";
            this._dgv1.ReadOnly = true;
            this._dgv1.RowHeadersVisible = false;
            this._dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgv1.RowTemplate.Height = 28;
            this._dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv1.Size = new System.Drawing.Size(1689, 675);
            this._dgv1.TabIndex = 1;
            // 
            // Sale_return_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1689, 675);
            this.Controls.Add(this._dgv1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sale_return_view";
            this.Text = "Sale_return_view";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_return_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgv1;
    }
}