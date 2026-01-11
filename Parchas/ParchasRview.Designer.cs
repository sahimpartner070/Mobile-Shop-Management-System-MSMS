namespace Mobile_shop_application.Parchas
{
    partial class ParchasRview
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
            this._dgv1.BackgroundColor = System.Drawing.Color.White;
            this._dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgv1.Location = new System.Drawing.Point(0, 0);
            this._dgv1.Name = "_dgv1";
            this._dgv1.ReadOnly = true;
            this._dgv1.RowHeadersVisible = false;
            this._dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgv1.RowTemplate.Height = 28;
            this._dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv1.Size = new System.Drawing.Size(1271, 579);
            this._dgv1.TabIndex = 2;
            this._dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv1_CellContentClick);
            // 
            // ParchasRview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 579);
            this.Controls.Add(this._dgv1);
            this.Name = "ParchasRview";
            this.Text = "Parchas Return List view";
            this.Load += new System.EventHandler(this.ParchasRview_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgv1;
    }
}