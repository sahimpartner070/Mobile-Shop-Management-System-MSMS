using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.UserRegestration
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _btn_reg_Click(object sender, EventArgs e)
        {
            if (_txtuser.Text.Trim() == "") {

                MessageBox.Show("Please Enter a User Name");
                _txtuser.Focus();
                return;
                    }else if (_txtpassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a Password for User");
                _txtpassword.Focus();
                return;
            }
            else
            {
                Connection_class.Execute(@"
INSERT INTO[dbo].[user_t]
           ([user_name]
           ,[password]
           ,[User_type_id]
           ,[Email])
     VALUES
           ('" + _txtuser.Text + "', '" + _txtpassword.Text + "', '" + _combo1.SelectedValue + "', '" + _txtemail.Text + "')");
                MessageBox.Show("User Acount Registerd", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill();
                clear();
            }

        }

        private void user_Load(object sender, EventArgs e)
        {
            _combo1.DataSource = Connection_class.Selecte("SELECT [user_type_id] ,[user_type]FROM [dbo].[user_type_t]");
            _combo1.ValueMember = "user_type_id";
            _combo1.DisplayMember = "user_type";
            fill();
        }
        private void clear()
        {
            _txtuser.Clear();
            _txtpassword.Clear();
            _txtemail.Clear();
            _combo1.Text = "";

        }
        private void fill()
        {
            DataTable dt = Connection_class.Selecte(@"SELECT user_t.user_id, user_t.user_name, user_t.password, user_type_t.user_type, user_t.Email
FROM   user_t INNER JOIN
             user_type_t ON user_t.User_type_id = user_type_t.user_type_id");
            dgv_1.DataSource = dt;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtuser.Text = dgv_1.CurrentRow.Cells[1].Value.ToString();
            _txtpassword.Text = dgv_1.CurrentRow.Cells[2].Value.ToString();
            _combo1.Text = dgv_1.CurrentRow.Cells[3].Value.ToString();
            _txtemail.Text = dgv_1.CurrentRow.Cells[4].Value.ToString();
            _btn_reg.Visible = false;
            _btn_update.Visible = true;
            _txtpassword.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("UPDATE[dbo].[user_t] SET[user_name] = '"+_txtuser.Text+"',[password] = '"+_txtpassword.Text+"',[User_type_id] = '"+_combo1.SelectedValue.ToString()+"',[Email] = '"+_txtemail.Text+"' WHERE user_id = '"+dgv_1.CurrentRow.Cells[0].Value.ToString()+"'");

            MessageBox.Show("Rcord Updated","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            UserRegestration.user us = new UserRegestration.user();
            us.ShowDialog();
            //  fill();
            //clear();




        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Are You Soure To Delete The Selected Item", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Connection_class.Execute("DELETE FROM [dbo].[user_t]WHERE user_id='" + dgv_1.CurrentRow.Cells[0].Value.ToString() + "'");

                    MessageBox.Show("Recoord Succesfully Deleted");
                    fill();
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fill();
        }
    }
}
