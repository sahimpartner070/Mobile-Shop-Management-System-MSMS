namespace Mobile_shop_application.Customer
{
    partial class customer_reg
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
            this._dgvcustomer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnup = new System.Windows.Forms.Button();
            this._btnsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._txtnic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtcustomer = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._txtserchout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgvcustomer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _dgvcustomer
            // 
            this._dgvcustomer.BackgroundColor = System.Drawing.Color.White;
            this._dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvcustomer.ContextMenuStrip = this.contextMenuStrip1;
            this._dgvcustomer.Location = new System.Drawing.Point(6, 27);
            this._dgvcustomer.Name = "_dgvcustomer";
            this._dgvcustomer.RowTemplate.Height = 28;
            this._dgvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvcustomer.Size = new System.Drawing.Size(855, 557);
            this._dgvcustomer.TabIndex = 0;
            this._dgvcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvcustomer_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 94);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._dgvcustomer);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(409, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 597);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnup);
            this.groupBox2.Controls.Add(this._btnsave);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this._txtnic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this._txtaddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._txtphone);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._txtcustomer);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 694);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Regestration";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // _btnup
            // 
            this._btnup.Location = new System.Drawing.Point(31, 522);
            this._btnup.Name = "_btnup";
            this._btnup.Size = new System.Drawing.Size(255, 49);
            this._btnup.TabIndex = 4;
            this._btnup.Text = "Update";
            this._btnup.UseVisualStyleBackColor = true;
            this._btnup.Visible = false;
            this._btnup.Click += new System.EventHandler(this._btnup_Click);
            // 
            // _btnsave
            // 
            this._btnsave.Location = new System.Drawing.Point(31, 522);
            this._btnsave.Name = "_btnsave";
            this._btnsave.Size = new System.Drawing.Size(255, 49);
            this._btnsave.TabIndex = 8;
            this._btnsave.Text = " Save";
            this._btnsave.UseVisualStyleBackColor = true;
            this._btnsave.Click += new System.EventHandler(this._btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer NIC Number:";
            // 
            // _txtnic
            // 
            this._txtnic.Location = new System.Drawing.Point(31, 276);
            this._txtnic.Name = "_txtnic";
            this._txtnic.Size = new System.Drawing.Size(301, 40);
            this._txtnic.TabIndex = 2;
            this._txtnic.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtnic_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer Adderss:";
            // 
            // _txtaddress
            // 
            this._txtaddress.Location = new System.Drawing.Point(31, 383);
            this._txtaddress.Multiline = true;
            this._txtaddress.Name = "_txtaddress";
            this._txtaddress.Size = new System.Drawing.Size(301, 100);
            this._txtaddress.TabIndex = 3;
            this._txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtaddress_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Phone:";
            // 
            // _txtphone
            // 
            this._txtphone.Location = new System.Drawing.Point(31, 171);
            this._txtphone.Name = "_txtphone";
            this._txtphone.Size = new System.Drawing.Size(301, 40);
            this._txtphone.TabIndex = 1;
            this._txtphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtphone_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // _txtcustomer
            // 
            this._txtcustomer.Location = new System.Drawing.Point(31, 77);
            this._txtcustomer.Name = "_txtcustomer";
            this._txtcustomer.Size = new System.Drawing.Size(301, 40);
            this._txtcustomer.TabIndex = 0;
            this._txtcustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtcustomer_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._txtserchout);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(413, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 71);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Customer Here";
            // 
            // _txtserchout
            // 
            this._txtserchout.Location = new System.Drawing.Point(20, 28);
            this._txtserchout.Name = "_txtserchout";
            this._txtserchout.Size = new System.Drawing.Size(389, 35);
            this._txtserchout.TabIndex = 10;
            this._txtserchout.TextChanged += new System.EventHandler(this._txtserchout_TextChanged);
            // 
            // customer_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1318, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "customer_reg";
            this.Load += new System.EventHandler(this.customer_reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvcustomer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dgvcustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtcustomer;
        private System.Windows.Forms.Button _btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtaddress;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button _btnup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtserchout;
    }
}