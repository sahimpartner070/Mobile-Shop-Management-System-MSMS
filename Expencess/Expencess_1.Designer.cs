namespace Mobile_shop_application.Expencess
{
    partial class Expencess_1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._b_save = new System.Windows.Forms.Button();
            this._txt_Descrition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btn_update = new System.Windows.Forms.Button();
            this._date = new System.Windows.Forms.DateTimePicker();
            this._combo_man = new System.Windows.Forms.ComboBox();
            this._comb_type = new System.Windows.Forms.ComboBox();
            this._label_emp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._dgvexpence = new System.Windows.Forms.DataGridView();
            this._dgv_view = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvexpence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgv_view)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expence Type:";
            // 
            // _txt_amount
            // 
            this._txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txt_amount.Location = new System.Drawing.Point(2, 198);
            this._txt_amount.Multiline = true;
            this._txt_amount.Name = "_txt_amount";
            this._txt_amount.Size = new System.Drawing.Size(317, 44);
            this._txt_amount.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expence Amount:";
            // 
            // _b_save
            // 
            this._b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._b_save.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._b_save.Location = new System.Drawing.Point(36, 605);
            this._b_save.Name = "_b_save";
            this._b_save.Size = new System.Drawing.Size(225, 55);
            this._b_save.TabIndex = 5;
            this._b_save.Text = "Save";
            this._b_save.UseVisualStyleBackColor = false;
            this._b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // _txt_Descrition
            // 
            this._txt_Descrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txt_Descrition.Location = new System.Drawing.Point(0, 494);
            this._txt_Descrition.Multiline = true;
            this._txt_Descrition.Name = "_txt_Descrition";
            this._txt_Descrition.Size = new System.Drawing.Size(315, 102);
            this._txt_Descrition.TabIndex = 2;
            this._txt_Descrition.TextChanged += new System.EventHandler(this._txt_qty_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Expence Descritions:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this._b_save);
            this.groupBox1.Controls.Add(this._btn_update);
            this.groupBox1.Controls.Add(this._date);
            this.groupBox1.Controls.Add(this._combo_man);
            this.groupBox1.Controls.Add(this._comb_type);
            this.groupBox1.Controls.Add(this._label_emp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this._txt_Descrition);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txt_amount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 682);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expencess";
            // 
            // _btn_update
            // 
            this._btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._btn_update.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btn_update.Location = new System.Drawing.Point(36, 610);
            this._btn_update.Name = "_btn_update";
            this._btn_update.Size = new System.Drawing.Size(225, 55);
            this._btn_update.TabIndex = 26;
            this._btn_update.Text = "Update";
            this._btn_update.UseVisualStyleBackColor = false;
            this._btn_update.Click += new System.EventHandler(this._btn_update_Click);
            // 
            // _date
            // 
            this._date.CustomFormat = "dd/MM/yyyy";
            this._date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._date.Location = new System.Drawing.Point(1, 292);
            this._date.Name = "_date";
            this._date.Size = new System.Drawing.Size(314, 35);
            this._date.TabIndex = 25;
            // 
            // _combo_man
            // 
            this._combo_man.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._combo_man.FormattingEnabled = true;
            this._combo_man.Location = new System.Drawing.Point(0, 395);
            this._combo_man.Name = "_combo_man";
            this._combo_man.Size = new System.Drawing.Size(321, 37);
            this._combo_man.TabIndex = 24;
            this._combo_man.SelectedIndexChanged += new System.EventHandler(this._combo_man_SelectedIndexChanged);
            // 
            // _comb_type
            // 
            this._comb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comb_type.FormattingEnabled = true;
            this._comb_type.Location = new System.Drawing.Point(0, 99);
            this._comb_type.Name = "_comb_type";
            this._comb_type.Size = new System.Drawing.Size(321, 37);
            this._comb_type.TabIndex = 23;
            this._comb_type.SelectedIndexChanged += new System.EventHandler(this._comb_type_SelectedIndexChanged);
            // 
            // _label_emp
            // 
            this._label_emp.AutoSize = true;
            this._label_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label_emp.Location = new System.Drawing.Point(0, 361);
            this._label_emp.Name = "_label_emp";
            this._label_emp.Size = new System.Drawing.Size(219, 32);
            this._label_emp.TabIndex = 22;
            this._label_emp.Text = "Slecte Employ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Expence Date:";
            // 
            // _dgvexpence
            // 
            this._dgvexpence.AllowUserToAddRows = false;
            this._dgvexpence.AllowUserToDeleteRows = false;
            this._dgvexpence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvexpence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvexpence.BackgroundColor = System.Drawing.Color.White;
            this._dgvexpence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvexpence.Location = new System.Drawing.Point(343, -3);
            this._dgvexpence.Name = "_dgvexpence";
            this._dgvexpence.RowHeadersVisible = false;
            this._dgvexpence.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgvexpence.RowTemplate.Height = 28;
            this._dgvexpence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvexpence.Size = new System.Drawing.Size(1046, 711);
            this._dgvexpence.TabIndex = 8;
            this._dgvexpence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvexpence_CellContentClick);
            // 
            // _dgv_view
            // 
            this._dgv_view.AllowUserToAddRows = false;
            this._dgv_view.AllowUserToDeleteRows = false;
            this._dgv_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgv_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgv_view.BackgroundColor = System.Drawing.Color.White;
            this._dgv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv_view.ContextMenuStrip = this.contextMenuStrip1;
            this._dgv_view.Location = new System.Drawing.Point(345, -3);
            this._dgv_view.Name = "_dgv_view";
            this._dgv_view.RowHeadersVisible = false;
            this._dgv_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgv_view.RowTemplate.Height = 28;
            this._dgv_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv_view.Size = new System.Drawing.Size(1044, 682);
            this._dgv_view.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 94);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.updateToolStripMenuItem.Text = "Refresh";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Expencess_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 684);
            this.Controls.Add(this._dgv_view);
            this.Controls.Add(this._dgvexpence);
            this.Controls.Add(this.groupBox1);
            this.Name = "Expencess_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expencess_1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Expencess_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvexpence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgv_view)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _b_save;
        private System.Windows.Forms.TextBox _txt_Descrition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _label_emp;
        private System.Windows.Forms.ComboBox _combo_man;
        private System.Windows.Forms.ComboBox _comb_type;
        private System.Windows.Forms.DateTimePicker _date;
        private System.Windows.Forms.DataGridView _dgvexpence;
        private System.Windows.Forms.DataGridView _dgv_view;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button _btn_update;
    }
}