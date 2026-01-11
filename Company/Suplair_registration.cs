using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Company
{
    public partial class Suplair_registration : Form
    {
        public Suplair_registration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
            Connection_class.Execute(@"INSERT INTO [dbo].[suplier_t]
           ([suplier_name]
           ,[nic]
           ,[phone]
           ,[addres])
     VALUES
           ('" + _txtname1.Text + "', '" + _txtnic2.Text + "', '" + _txtphone3.Text + "', '" + _txtadress4.Text + "')");

            MessageBox.Show("Your Data Saved ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            fill();


        }
        private void fill() {

            DataTable dt = Connection_class.Selecte(@"SELECT [suplier_id]
      ,[suplier_name]
      ,[nic]
      ,[phone]
      ,[addres]
  FROM[dbo].[suplier_t]");
            _dgv1.DataSource = dt;
           // _dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void clear()
        {
            _txtname1.Clear();
            _txtnic2.Clear();
            _txtphone3.Clear();
            _txtadress4.Clear();
         
        }

        private void Suplair_registration_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = Connection_class.Selecte("select* from suplier_t where concat([suplier_name],[phone],[addres],[nic]) like '%" + _txtserching.Text + "%'");
                if (dt.Rows.Count > 0)
                {
                    _dgv1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(Exception ex);
            }
        }

        private void _btnupdate_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("UPDATE [dbo].[suplier_t] SET [suplier_name] = '"+_txtname1.Text+"' ,[nic] = '"+_txtnic2.Text+"' ,[phone] = '"+_txtphone3.Text+"' ,[addres] = '"+_txtadress4.Text+"' WHERE [suplier_id]='"+_dgv1.CurrentRow.Cells[0].Value.ToString()+"'");

            MessageBox.Show("Data Updated Succesfull","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clear();
            fill();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtname1.Text = _dgv1.CurrentRow.Cells[1].Value.ToString();
            _txtnic2.Text = _dgv1.CurrentRow.Cells[2].Value.ToString();
            _txtphone3.Text = _dgv1.CurrentRow.Cells[3].Value.ToString();
            _txtadress4.Text = _dgv1.CurrentRow.Cells[4].Value.ToString();
            _btnsave.Visible = false;
            _btnupdate.Visible = true;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Soure To Delete The Selected Item", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection_class.Execute("DELETE FROM [dbo].[suplier_t]WHERE suplier_id='" + _dgv1.CurrentRow.Cells[0].Value.ToString() + "'");

                MessageBox.Show("Recoord Succesfully Deleted");
                fill();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _btnsave.Visible = true;
            _btnupdate.Visible = false;
            clear();
            fill();
        }
    }
}
