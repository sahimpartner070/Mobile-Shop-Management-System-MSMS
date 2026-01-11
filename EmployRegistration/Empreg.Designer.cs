namespace Mobile_shop_application.EmployRegistration
{
    partial class Empreg
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtserching = new System.Windows.Forms.TextBox();
            this._dgv1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnupdat = new System.Windows.Forms.Button();
            this._pictuer = new System.Windows.Forms.PictureBox();
            this._btnsave = new System.Windows.Forms.Button();
            this._pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtposition = new System.Windows.Forms.TextBox();
            this._txtsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtaddres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtphone2 = new System.Windows.Forms.TextBox();
            this._btnpic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._txtemp1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._txtserching);
            this.groupBox2.Controls.Add(this._dgv1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1587, 410);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registration Information";
            this.groupBox2.UseCompatibleTextRendering = true;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Serching Box:";
            // 
            // _txtserching
            // 
            this._txtserching.Location = new System.Drawing.Point(6, 65);
            this._txtserching.Name = "_txtserching";
            this._txtserching.Size = new System.Drawing.Size(329, 35);
            this._txtserching.TabIndex = 0;
            this._txtserching.TextChanged += new System.EventHandler(this._txtserching_TextChanged);
            // 
            // _dgv1
            // 
            this._dgv1.AllowUserToAddRows = false;
            this._dgv1.AllowUserToDeleteRows = false;
            this._dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgv1.BackgroundColor = System.Drawing.Color.White;
            this._dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgv1.ContextMenuStrip = this.contextMenuStrip1;
            this._dgv1.Location = new System.Drawing.Point(7, 106);
            this._dgv1.Name = "_dgv1";
            this._dgv1.ReadOnly = true;
            this._dgv1.RowHeadersVisible = false;
            this._dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this._dgv1.RowTemplate.Height = 28;
            this._dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgv1.Size = new System.Drawing.Size(1566, 298);
            this._dgv1.TabIndex = 1;
            this._dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv1_CellContentClick);
            this._dgv1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgv1_CellEnter);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._btnupdat);
            this.groupBox1.Controls.Add(this._pictuer);
            this.groupBox1.Controls.Add(this._btnsave);
            this.groupBox1.Controls.Add(this._pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtposition);
            this.groupBox1.Controls.Add(this._txtsalary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtaddres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._txtphone2);
            this.groupBox1.Controls.Add(this._btnpic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtemp1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1594, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employ Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // _btnupdat
            // 
            this._btnupdat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnupdat.BackColor = System.Drawing.Color.White;
            this._btnupdat.Location = new System.Drawing.Point(1413, 53);
            this._btnupdat.Name = "_btnupdat";
            this._btnupdat.Size = new System.Drawing.Size(172, 100);
            this._btnupdat.TabIndex = 6;
            this._btnupdat.Text = "Update";
            this._btnupdat.UseVisualStyleBackColor = false;
            this._btnupdat.Visible = false;
            this._btnupdat.Click += new System.EventHandler(this._btnupdat_Click);
            // 
            // _pictuer
            // 
            this._pictuer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pictuer.Location = new System.Drawing.Point(1152, 74);
            this._pictuer.Name = "_pictuer";
            this._pictuer.Size = new System.Drawing.Size(246, 169);
            this._pictuer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictuer.TabIndex = 22;
            this._pictuer.TabStop = false;
            // 
            // _btnsave
            // 
            this._btnsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnsave.Location = new System.Drawing.Point(1414, 86);
            this._btnsave.Name = "_btnsave";
            this._btnsave.Size = new System.Drawing.Size(172, 100);
            this._btnsave.TabIndex = 6;
            this._btnsave.Text = " Save";
            this._btnsave.UseVisualStyleBackColor = true;
            this._btnsave.Click += new System.EventHandler(this._btnsave_Click);
            // 
            // _pictureBox1
            // 
            this._pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pictureBox1.Location = new System.Drawing.Point(938, 76);
            this._pictureBox1.Name = "_pictureBox1";
            this._pictureBox1.Size = new System.Drawing.Size(185, 116);
            this._pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._pictureBox1.TabIndex = 20;
            this._pictureBox1.TabStop = false;
            this._pictureBox1.Click += new System.EventHandler(this._pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1156, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 26);
            this.label8.TabIndex = 21;
            this.label8.Text = "Employ Show Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(942, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Employ Picture:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Employ Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employ Position:";
            // 
            // _txtposition
            // 
            this._txtposition.Location = new System.Drawing.Point(315, 73);
            this._txtposition.Name = "_txtposition";
            this._txtposition.Size = new System.Drawing.Size(248, 35);
            this._txtposition.TabIndex = 2;
            // 
            // _txtsalary
            // 
            this._txtsalary.Location = new System.Drawing.Point(315, 156);
            this._txtsalary.Name = "_txtsalary";
            this._txtsalary.Size = new System.Drawing.Size(248, 35);
            this._txtsalary.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(619, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Employ Addres:";
            // 
            // _txtaddres
            // 
            this._txtaddres.Location = new System.Drawing.Point(619, 76);
            this._txtaddres.Multiline = true;
            this._txtaddres.Name = "_txtaddres";
            this._txtaddres.Size = new System.Drawing.Size(268, 115);
            this._txtaddres.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = " Phone Number:";
            // 
            // _txtphone2
            // 
            this._txtphone2.Location = new System.Drawing.Point(18, 156);
            this._txtphone2.Name = "_txtphone2";
            this._txtphone2.Size = new System.Drawing.Size(248, 35);
            this._txtphone2.TabIndex = 1;
            this._txtphone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtphone2_KeyPress);
            // 
            // _btnpic
            // 
            this._btnpic.Location = new System.Drawing.Point(938, 197);
            this._btnpic.Name = "_btnpic";
            this._btnpic.Size = new System.Drawing.Size(185, 47);
            this._btnpic.TabIndex = 5;
            this._btnpic.Text = "Browes....";
            this._btnpic.UseVisualStyleBackColor = true;
            this._btnpic.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employ Nmae:";
            // 
            // _txtemp1
            // 
            this._txtemp1.Location = new System.Drawing.Point(21, 75);
            this._txtemp1.Name = "_txtemp1";
            this._txtemp1.Size = new System.Drawing.Size(246, 35);
            this._txtemp1.TabIndex = 0;
            // 
            // Empreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1606, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Empreg";
            this.Text = "Empreg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Empreg_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgv1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtserching;
        private System.Windows.Forms.DataGridView _dgv1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtaddres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtphone2;
        private System.Windows.Forms.Button _btnpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtemp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtposition;
        private System.Windows.Forms.TextBox _txtsalary;
        private System.Windows.Forms.PictureBox _pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button _btnsave;
        private System.Windows.Forms.PictureBox _pictuer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button _btnupdat;
    }
}