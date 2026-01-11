namespace Mobile_shop_application.UserRegestration
{
    partial class password_reset
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._label_id = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._combo_password = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtold = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._txtnew = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this._label_id);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._combo_password);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._txtold);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this._txtnew);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 473);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password Reset";
            // 
            // _label_id
            // 
            this._label_id.AutoSize = true;
            this._label_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._label_id.Location = new System.Drawing.Point(293, 50);
            this._label_id.Name = "_label_id";
            this._label_id.Size = new System.Drawing.Size(87, 26);
            this._label_id.TabIndex = 23;
            this._label_id.Text = "ID No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter Old Password :";
            // 
            // _combo_password
            // 
            this._combo_password.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._combo_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._combo_password.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._combo_password.FormattingEnabled = true;
            this._combo_password.Location = new System.Drawing.Point(79, 79);
            this._combo_password.Name = "_combo_password";
            this._combo_password.Size = new System.Drawing.Size(309, 40);
            this._combo_password.TabIndex = 0;
            this._combo_password.SelectedIndexChanged += new System.EventHandler(this._combo_password_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select User :";
            // 
            // _txtold
            // 
            this._txtold.Location = new System.Drawing.Point(84, 168);
            this._txtold.Multiline = true;
            this._txtold.Name = "_txtold";
            this._txtold.Size = new System.Drawing.Size(309, 42);
            this._txtold.TabIndex = 2;
            this._txtold.TextChanged += new System.EventHandler(this._txtold_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Enter New Password :";
            // 
            // _txtnew
            // 
            this._txtnew.Location = new System.Drawing.Point(84, 275);
            this._txtnew.Multiline = true;
            this._txtnew.Name = "_txtnew";
            this._txtnew.Size = new System.Drawing.Size(309, 42);
            this._txtnew.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(83, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 479);
            this.Controls.Add(this.groupBox3);
            this.Name = "password_reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "password_reset";
            this.Load += new System.EventHandler(this.password_reset_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _combo_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtold;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _txtnew;
        private System.Windows.Forms.Label _label_id;
        private System.Windows.Forms.Button button1;
    }
}