namespace Mobile_shop_application
{
    partial class Log_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this._txtuser = new System.Windows.Forms.TextBox();
            this._txtpassword = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.Label();
            this._loginb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(100, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = " Please Enter Your Cridetionals first";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Font = new System.Drawing.Font("Brush Script MT", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labeluser.Location = new System.Drawing.Point(85, 0);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(208, 61);
            this.labeluser.TabIndex = 1;
            this.labeluser.Text = "User name";
            // 
            // _txtuser
            // 
            this._txtuser.BackColor = System.Drawing.SystemColors.Highlight;
            this._txtuser.Font = new System.Drawing.Font("Brush Script MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtuser.Location = new System.Drawing.Point(95, 61);
            this._txtuser.Multiline = true;
            this._txtuser.Name = "_txtuser";
            this._txtuser.Size = new System.Drawing.Size(311, 51);
            this._txtuser.TabIndex = 0;
            this._txtuser.Text = "admin";
            this._txtuser.UseSystemPasswordChar = true;
            this._txtuser.TextChanged += new System.EventHandler(this._txtuser_TextChanged);
            // 
            // _txtpassword
            // 
            this._txtpassword.BackColor = System.Drawing.SystemColors.Highlight;
            this._txtpassword.Font = new System.Drawing.Font("Brush Script MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtpassword.Location = new System.Drawing.Point(95, 240);
            this._txtpassword.Name = "_txtpassword";
            this._txtpassword.Size = new System.Drawing.Size(311, 47);
            this._txtpassword.TabIndex = 1;
            this._txtpassword.Text = "admin";
            this._txtpassword.UseSystemPasswordChar = true;
            this._txtpassword.TextChanged += new System.EventHandler(this._txtpassword_TextChanged);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.Transparent;
            this.d.Font = new System.Drawing.Font("Brush Script MT", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.d.Location = new System.Drawing.Point(74, 179);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(210, 61);
            this.d.TabIndex = 6;
            this.d.Text = " Password";
            // 
            // _loginb
            // 
            this._loginb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._loginb.BackColor = System.Drawing.SystemColors.Highlight;
            this._loginb.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this._loginb.FlatAppearance.BorderSize = 5;
            this._loginb.Font = new System.Drawing.Font("Brush Script MT", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loginb.ForeColor = System.Drawing.Color.Black;
            this._loginb.Location = new System.Drawing.Point(251, 162);
            this._loginb.Name = "_loginb";
            this._loginb.Size = new System.Drawing.Size(159, 132);
            this._loginb.TabIndex = 0;
            this._loginb.Text = "To Activat System Click Here";
            this._loginb.UseVisualStyleBackColor = false;
            this._loginb.Click += new System.EventHandler(this._loginb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labeluser);
            this.panel1.Controls.Add(this._txtuser);
            this.panel1.Controls.Add(this._txtpassword);
            this.panel1.Controls.Add(this.d);
            this.panel1.Location = new System.Drawing.Point(450, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 339);
            this.panel1.TabIndex = 9;
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mobile_shop_application.Properties.Resources.Mobile1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 529);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._loginb);
            this.Controls.Add(this.label1);
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Log_in_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Button _loginb;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox _txtuser;
        public System.Windows.Forms.TextBox _txtpassword;
    }
}