using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application
 
{
    public partial class Log_in : Form
     
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _txtuser_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void _loginb_Click(object sender, EventArgs e)

        {
            

            // _txtpassword.Focus();

            if (_txtuser.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter User Name");
                _txtuser.Focus();
                return;
            }
           else if (_txtpassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Password");
                _txtpassword.Focus();
                return;


            }
            else
            {


                DataTable dt = Connection_class.Selecte("SELECT *FROM [dbo].[user_t] where  [user_name]='" + _txtuser.Text + "'and [password]='" + _txtpassword.Text + "'");
                if (dt.Rows.Count > 0)

                {
                        string un = dt.Rows[0]["user_name"].ToString();
                        string ut = dt.Rows[0]["user_type_id"].ToString();

               
                    this.Hide();
                    Main_form main = new Main_form(this);
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect User Name and Password", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _txtuser.Clear();
                    _txtpassword.Clear();
                    _txtuser.Focus();

                }
            

            }
        }
      

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void _txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

         }
}
