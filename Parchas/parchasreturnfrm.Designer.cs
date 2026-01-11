namespace Mobile_shop_application.Parchas
{
    partial class parchasreturnfrm
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
            this._btnsavedinformation = new System.Windows.Forms.Button();
            this._itemlist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtTotal_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txt_u_price = new System.Windows.Forms.TextBox();
            this._txt_qty = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtnamesearch = new System.Windows.Forms.TextBox();
            this._btnsave = new System.Windows.Forms.Button();
            this._time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this._combo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtHT = new System.Windows.Forms.TextBox();
            this._dgv1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnsavedinformation
            // 
            this._btnsavedinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._btnsavedinformation.Location = new System.Drawing.Point(666, 728);
            this._btnsavedinformation.Name = "_btnsavedinformation";
            this._btnsavedinformation.Size = new System.Drawing.Size(72, 42);
            this._btnsavedinformation.TabIndex = 24;
            this._btnsavedinformation.Text = "View";
            this._btnsavedinformation.UseVisualStyleBackColor = false;
            this._btnsavedinformation.Visible = false;
            this._btnsavedinformation.Click += new System.EventHandler(this._btnsavedinformation_Click);
            // 
            // _itemlist
            // 
            this._itemlist.FormattingEnabled = true;
            this._itemlist.ItemHeight = 26;
            this._itemlist.Location = new System.Drawing.Point(5, 101);
            this._itemlist.Name = "_itemlist";
            this._itemlist.Size = new System.Drawing.Size(314, 368);
            this._itemlist.TabIndex = 1;
            this._itemlist.Click += new System.EventHandler(this._itemlist_Click);
            this._itemlist.SelectedIndexChanged += new System.EventHandler(this._itemlist_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this._itemlist);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._txtTotal_price);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._txt_u_price);
            this.groupBox1.Controls.Add(this._txt_qty);
            this.groupBox1.Controls.Add(this.b_save);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtnamesearch);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 808);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchas Items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = " Quntity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Price:";
            // 
            // _txtTotal_price
            // 
            this._txtTotal_price.Location = new System.Drawing.Point(10, 663);
            this._txtTotal_price.Name = "_txtTotal_price";
            this._txtTotal_price.Size = new System.Drawing.Size(311, 35);
            this._txtTotal_price.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = " Unit Price:";
            // 
            // _txt_u_price
            // 
            this._txt_u_price.Location = new System.Drawing.Point(10, 583);
            this._txt_u_price.Name = "_txt_u_price";
            this._txt_u_price.Size = new System.Drawing.Size(311, 35);
            this._txt_u_price.TabIndex = 3;
            this._txt_u_price.TextChanged += new System.EventHandler(this._txt_u_price_TextChanged);
            // 
            // _txt_qty
            // 
            this._txt_qty.Location = new System.Drawing.Point(10, 504);
            this._txt_qty.Name = "_txt_qty";
            this._txt_qty.Size = new System.Drawing.Size(311, 35);
            this._txt_qty.TabIndex = 2;
            this._txt_qty.TextChanged += new System.EventHandler(this._txt_qty_TextChanged);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(15, 715);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(225, 55);
            this.b_save.TabIndex = 5;
            this.b_save.Text = " Add";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // _txtnamesearch
            // 
            this._txtnamesearch.Location = new System.Drawing.Point(4, 64);
            this._txtnamesearch.Name = "_txtnamesearch";
            this._txtnamesearch.Size = new System.Drawing.Size(317, 35);
            this._txtnamesearch.TabIndex = 0;
            this._txtnamesearch.TextChanged += new System.EventHandler(this._txtnamesearch_TextChanged);
            // 
            // _btnsave
            // 
            this._btnsave.Location = new System.Drawing.Point(759, 727);
            this._btnsave.Name = "_btnsave";
            this._btnsave.Size = new System.Drawing.Size(185, 42);
            this._btnsave.TabIndex = 2;
            this._btnsave.Text = "Save All Record";
            this._btnsave.UseVisualStyleBackColor = true;
            this._btnsave.Click += new System.EventHandler(this._btnsave_Click);
            // 
            // _time
            // 
            this._time.CustomFormat = "dd/MM/yyyy";
            this._time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._time.Location = new System.Drawing.Point(307, 750);
            this._time.Name = "_time";
            this._time.Size = new System.Drawing.Size(304, 35);
            this._time.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 719);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date:";
            // 
            // _combo1
            // 
            this._combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._combo1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._combo1.FormattingEnabled = true;
            this._combo1.Location = new System.Drawing.Point(5, 757);
            this._combo1.Name = "_combo1";
            this._combo1.Size = new System.Drawing.Size(246, 27);
            this._combo1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Selecte Suplier:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1022, 738);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hol Total:";
            // 
            // _txtHT
            // 
            this._txtHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._txtHT.Location = new System.Drawing.Point(1022, 767);
            this._txtHT.Name = "_txtHT";
            this._txtHT.Size = new System.Drawing.Size(276, 35);
            this._txtHT.TabIndex = 19;
            // 
            // _dgv1
            // 
            this._dgv1.AllowUserToAddRows = false;
            this._dgv1.AllowUserToDeleteRows = false;
            this._dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgv1.BackgroundColor = System.Drawing.Color.White;
            this._dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv1.Location = new System.Drawing.Point(6, 30);
            this._dgv1.Name = "_dgv1";
            this._dgv1.RowHeadersVisible = false;
            this._dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgv1.RowTemplate.Height = 28;
            this._dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv1.Size = new System.Drawing.Size(1288, 646);
            this._dgv1.TabIndex = 0;
            this._dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv1_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._btnsavedinformation);
            this.groupBox2.Controls.Add(this._btnsave);
            this.groupBox2.Controls.Add(this._time);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this._combo1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._txtHT);
            this.groupBox2.Controls.Add(this._dgv1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(346, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1300, 808);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // parchasreturnfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 832);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "parchasreturnfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parchasreturnfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.parchasreturnfrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnsavedinformation;
        private System.Windows.Forms.ListBox _itemlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtTotal_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txt_u_price;
        private System.Windows.Forms.TextBox _txt_qty;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtnamesearch;
        private System.Windows.Forms.Button _btnsave;
        private System.Windows.Forms.DateTimePicker _time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _combo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtHT;
        private System.Windows.Forms.DataGridView _dgv1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}