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
    public partial class password_reset : Form
    {
        public password_reset()
        {
            InitializeComponent();
        }

        private void password_reset_Load(object sender, EventArgs e)
        {
            _combo_password.DataSource = Connection_class.Selecte(@"SELECT [user_id]
      ,[user_name]
      ,[password]
     
  FROM[dbo].[user_t]");
            _combo_password.ValueMember = "user_id";
            _combo_password.DisplayMember = "user_name";
            
        }

        private void _combo_password_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_id = Connection_class.Selecte("SELECT [user_id],[password]FROM[dbo].[user_t]WHERE user_id = '" + _combo_password.SelectedValue + "'");

               
                if (dt_id.Rows.Count > 0)
                {
                    _label_id.Text = dt_id.Rows[0]["user_id"].ToString();
                   // _txtold.Text = dt_id.Rows[0]["password"].ToString();
                }
            }
            catch
            {

            }
        }

        private void _txtold_TextChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            _txtnew.Clear();
            _txtold.Clear();
          //  _combo_password.Text = "";


        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Connection_class.Selecte("SELECT *FROM [dbo].[user_t] where  [user_id]='"+_label_id.Text+"' and [password]='"+_txtold.Text+"'");
            if(dt.Rows.Count>0)
            {

                Connection_class.Execute("UPDATE[dbo].[user_t]SET[password] = '" + _txtnew.Text + "' WHERE [user_id] = '" + _label_id.Text + "'");

                MessageBox.Show("Password Updated Succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                this.Close();

            }
            else
            {
               
                MessageBox.Show("Please First Enter The Correct Old Password", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }
    }
    }

