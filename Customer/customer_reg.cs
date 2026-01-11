using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Customer
{
    public partial class customer_reg : Form
    {
        public customer_reg()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void customer_reg_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void _txtcustomer_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txtphone);
            
        }

        private void _txtphone_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.upkey(e, _txtcustomer);
            Genral_function.enterkey(e, _txtaddress);
        }

        private void _txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txtnic);
            Genral_function.upkey(e, _txtphone);

        }

        private void _txtnic_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _btnsave);
            Genral_function.enterkey(e, _btnup);
            Genral_function.upkey(e, _txtaddress);
        }
        private void clear()
        {
            _txtcustomer.Clear();
            _txtphone.Clear();
            _txtaddress.Clear();
            _txtphone.Clear();
            _txtnic.Clear();
            _txtcustomer.Focus();




        }
        private void fill()
        {
            DataTable dt = Connection_class.Selecte("SELECT[customer_name],[phone],[address],[nic] FROM[dbo].[customer_t]");
            _dgvcustomer.DataSource = dt;
            _dgvcustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
            if (_txtcustomer.Text.Trim() == ""){
                MessageBox.Show("Please Enter The Customer Name");
                return;



            }


            Connection_class.Execute("INSERT INTO[dbo].[customer_t]([customer_name],[phone],[address],[nic]) VALUES('"+_txtcustomer.Text+"', '"+_txtphone.Text+"', '"+_txtaddress.Text+"', '"+_txtnic.Text+"')");


            MessageBox.Show("Customer Regeisterd","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

            clear();
            fill();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtcustomer.Text = _dgvcustomer.CurrentRow.Cells[1].Value.ToString();
            _txtphone.Text = _dgvcustomer.CurrentRow.Cells[2].Value.ToString();
            _txtaddress.Text = _dgvcustomer.CurrentRow.Cells[3].Value.ToString();
            _txtnic.Text = _dgvcustomer.CurrentRow.Cells[4].Value.ToString();
            _btnsave.Visible = false;
            _btnup.Visible = true;


        }

        private void _btnup_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("UPDATE[dbo].[customer_t] SET[customer_name] = '"+_txtcustomer.Text+"',[phone] = '"+_txtphone.Text+"',[address] = '"+_txtaddress.Text+"',[nic] = '"+_txtnic.Text+"'WHERE customer_id = '"+_dgvcustomer.CurrentRow.Cells[0].Value.ToString()+"'");

            MessageBox.Show("Record Succesfully Updated","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clear();
            fill();
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Are You Soure To Delete The Selected Item", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Connection_class.Execute("DELETE FROM [dbo].[customer_t]WHERE customer_id='" + _dgvcustomer.CurrentRow.Cells[0].Value.ToString() + "'");

                    MessageBox.Show("Recoord Succesfully Deleted");
                    fill();
                }
            }
        }

        private void _txtserchout_TextChanged(object sender, EventArgs e)
        {
          try  {
                DataTable dt = Connection_class.Selecte("select* from Customer_t where concat([customer_name],[phone],[address],[nic]) like '%" + _txtserchout.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    _dgvcustomer.DataSource = dt;
                }

            } catch (Exception ex)
            {
                //MessageBox.Show(Exception ex);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _btnsave.Visible = true;
            _btnup.Visible = false;
            clear();
                
        }

        private void _dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
