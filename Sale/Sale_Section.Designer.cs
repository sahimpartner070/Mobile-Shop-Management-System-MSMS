namespace Mobile_shop_application.Sale
{
    partial class Sale_Section
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._dgv1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this._btnsave = new System.Windows.Forms.Button();
            this._time = new System.Windows.Forms.DateTimePicker();
            this._combo1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._itemlist = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtTotal_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txt_u_price = new System.Windows.Forms.TextBox();
            this._txt_qty = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtnamesearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._bill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._txtBlance = new System.Windows.Forms.TextBox();
            this._txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._txtPaid = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this._dgv1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(353, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 751);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            this.groupBox2.UseCompatibleTextRendering = true;
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
            this._dgv1.Location = new System.Drawing.Point(10, 28);
            this._dgv1.Name = "_dgv1";
            this._dgv1.RowHeadersVisible = false;
            this._dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgv1.RowTemplate.Height = 28;
            this._dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv1.Size = new System.Drawing.Size(860, 711);
            this._dgv1.TabIndex = 0;
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
            // _btnsave
            // 
            this._btnsave.Location = new System.Drawing.Point(65, 548);
            this._btnsave.Name = "_btnsave";
            this._btnsave.Size = new System.Drawing.Size(197, 55);
            this._btnsave.TabIndex = 2;
            this._btnsave.Text = "Save All Record";
            this._btnsave.UseVisualStyleBackColor = true;
            this._btnsave.Click += new System.EventHandler(this._btnsave_Click);
            // 
            // _time
            // 
            this._time.CustomFormat = "dd/MM/yyyy";
            this._time.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._time.Location = new System.Drawing.Point(17, 151);
            this._time.Name = "_time";
            this._time.Size = new System.Drawing.Size(309, 40);
            this._time.TabIndex = 1;
            this._time.ValueChanged += new System.EventHandler(this._time_ValueChanged);
            // 
            // _combo1
            // 
            this._combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._combo1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._combo1.FormattingEnabled = true;
            this._combo1.Location = new System.Drawing.Point(12, 79);
            this._combo1.Name = "_combo1";
            this._combo1.Size = new System.Drawing.Size(309, 40);
            this._combo1.TabIndex = 0;
            this._combo1.SelectedIndexChanged += new System.EventHandler(this._combo1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Customer:";
            // 
            // _itemlist
            // 
            this._itemlist.FormattingEnabled = true;
            this._itemlist.ItemHeight = 26;
            this._itemlist.Location = new System.Drawing.Point(5, 104);
            this._itemlist.Name = "_itemlist";
            this._itemlist.Size = new System.Drawing.Size(314, 290);
            this._itemlist.TabIndex = 1;
            this._itemlist.Click += new System.EventHandler(this._itemlist_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = " Quntity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total Price:";
            // 
            // _txtTotal_price
            // 
            this._txtTotal_price.Enabled = false;
            this._txtTotal_price.Location = new System.Drawing.Point(10, 592);
            this._txtTotal_price.Name = "_txtTotal_price";
            this._txtTotal_price.Size = new System.Drawing.Size(311, 35);
            this._txtTotal_price.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = " Unit Price:";
            // 
            // _txt_u_price
            // 
            this._txt_u_price.Location = new System.Drawing.Point(10, 512);
            this._txt_u_price.Name = "_txt_u_price";
            this._txt_u_price.Size = new System.Drawing.Size(311, 35);
            this._txt_u_price.TabIndex = 3;
            this._txt_u_price.TextChanged += new System.EventHandler(this._txt_u_price_TextChanged);
            // 
            // _txt_qty
            // 
            this._txt_qty.Location = new System.Drawing.Point(10, 433);
            this._txt_qty.Name = "_txt_qty";
            this._txt_qty.Size = new System.Drawing.Size(311, 35);
            this._txt_qty.TabIndex = 2;
            this._txt_qty.TextChanged += new System.EventHandler(this._txt_qty_TextChanged);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(36, 644);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 751);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Items";
            // 
            // _bill
            // 
            this._bill.Location = new System.Drawing.Point(65, 635);
            this._bill.Name = "_bill";
            this._bill.Size = new System.Drawing.Size(197, 55);
            this._bill.TabIndex = 25;
            this._bill.Text = "Print a Bill";
            this._bill.UseVisualStyleBackColor = true;
            this._bill.Click += new System.EventHandler(this._bill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox3.Controls.Add(this._bill);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this._btnsave);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._time);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this._combo1);
            this.groupBox3.Controls.Add(this._txtBlance);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._txtTotalAmount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this._txtPaid);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1235, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 751);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sale Items";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 26);
            this.label10.TabIndex = 15;
            this.label10.Text = "Balance:";
            // 
            // _txtBlance
            // 
            this._txtBlance.Enabled = false;
            this._txtBlance.Location = new System.Drawing.Point(17, 465);
            this._txtBlance.Multiline = true;
            this._txtBlance.Name = "_txtBlance";
            this._txtBlance.Size = new System.Drawing.Size(309, 42);
            this._txtBlance.TabIndex = 3;
            // 
            // _txtTotalAmount
            // 
            this._txtTotalAmount.Enabled = false;
            this._txtTotalAmount.Location = new System.Drawing.Point(17, 258);
            this._txtTotalAmount.Multiline = true;
            this._txtTotalAmount.Name = "_txtTotalAmount";
            this._txtTotalAmount.Size = new System.Drawing.Size(309, 42);
            this._txtTotalAmount.TabIndex = 2;
            this._txtTotalAmount.TextChanged += new System.EventHandler(this._txtTotalAmount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Paid Amount:";
            // 
            // _txtPaid
            // 
            this._txtPaid.Location = new System.Drawing.Point(17, 363);
            this._txtPaid.Multiline = true;
            this._txtPaid.Name = "_txtPaid";
            this._txtPaid.Size = new System.Drawing.Size(309, 42);
            this._txtPaid.TabIndex = 0;
            this._txtPaid.TextChanged += new System.EventHandler(this._txtPaid_TextChanged);
            // 
            // Sale_Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1611, 793);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sale_Section";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale_Section";
            this.Load += new System.EventHandler(this.Sale_Section_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _btnsave;
        private System.Windows.Forms.DateTimePicker _time;
        private System.Windows.Forms.DataGridView _dgv1;
        private System.Windows.Forms.ComboBox _combo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox _itemlist;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtTotal_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txt_u_price;
        private System.Windows.Forms.TextBox _txt_qty;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtnamesearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtBlance;
        private System.Windows.Forms.TextBox _txtTotalAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _txtPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _bill;
    }
}