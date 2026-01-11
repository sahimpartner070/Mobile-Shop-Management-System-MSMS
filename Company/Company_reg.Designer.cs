namespace Mobile_shop_application.Company
{
    partial class Company_reg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnupdate = new System.Windows.Forms.Button();
            this._saveb = new System.Windows.Forms.Button();
            this._txtaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtcompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnupdate);
            this.groupBox1.Controls.Add(this._saveb);
            this.groupBox1.Controls.Add(this._txtaddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtcompany);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 556);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Company Regestration";
            // 
            // _btnupdate
            // 
            this._btnupdate.Location = new System.Drawing.Point(17, 308);
            this._btnupdate.Name = "_btnupdate";
            this._btnupdate.Size = new System.Drawing.Size(222, 47);
            this._btnupdate.TabIndex = 5;
            this._btnupdate.Text = " Update";
            this._btnupdate.UseVisualStyleBackColor = true;
            this._btnupdate.Visible = false;
            this._btnupdate.Click += new System.EventHandler(this._btnupdate_Click);
            // 
            // _saveb
            // 
            this._saveb.Location = new System.Drawing.Point(23, 255);
            this._saveb.Name = "_saveb";
            this._saveb.Size = new System.Drawing.Size(222, 47);
            this._saveb.TabIndex = 4;
            this._saveb.Text = " Save";
            this._saveb.UseVisualStyleBackColor = true;
            this._saveb.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txtaddress
            // 
            this._txtaddress.Location = new System.Drawing.Point(17, 186);
            this._txtaddress.Name = "_txtaddress";
            this._txtaddress.Size = new System.Drawing.Size(238, 33);
            this._txtaddress.TabIndex = 3;
            this._txtaddress.Text = " ";
            this._txtaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this._txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtaddress_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = " Company Address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // _txtcompany
            // 
            this._txtcompany.Location = new System.Drawing.Point(17, 79);
            this._txtcompany.Name = "_txtcompany";
            this._txtcompany.Size = new System.Drawing.Size(238, 33);
            this._txtcompany.TabIndex = 1;
            this._txtcompany.Text = " ";
            this._txtcompany.TextChanged += new System.EventHandler(this._txtcompany_TextChanged);
            this._txtcompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtcompany_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " Company Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._dgv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(312, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 534);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Company Registration Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // _dgv
            // 
            this._dgv.AllowUserToAddRows = false;
            this._dgv.AllowUserToDeleteRows = false;
            this._dgv.BackgroundColor = System.Drawing.Color.White;
            this._dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv.ContextMenuStrip = this.contextMenuStrip1;
            this._dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dgv.Location = new System.Drawing.Point(3, 29);
            this._dgv.Name = "_dgv";
            this._dgv.ReadOnly = true;
            this._dgv.RowTemplate.Height = 28;
            this._dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv.Size = new System.Drawing.Size(790, 496);
            this._dgv.TabIndex = 0;
            this._dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv_CellContentClick);
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
            // Company_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Company_reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company_reg";
            this.Load += new System.EventHandler(this.Company_reg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtcompany;
        private System.Windows.Forms.Button _saveb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView _dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button _btnupdate;
    }
}