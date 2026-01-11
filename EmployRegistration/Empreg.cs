using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.EmployRegistration
{
    public partial class Empreg : Form
    {
        SqlCommand cmd = new SqlCommand();
        public Empreg()
        {
            InitializeComponent();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == DialogResult.OK)
            {
                _pictureBox1.ImageLocation = opn.FileName;


            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void _dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }private void fill()
        {
            DataTable dt = Connection_class.Selecte(@"SELECT [Emp_id]
      ,[Emp_name]
      ,[phone]
      ,[Address]
      ,[Position]
      ,[Salary]
  FROM[dbo].[Employ_TB]");
            _dgv1.DataSource = dt;

        }

        private void Empreg_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void _pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = (@"INSERT INTO [dbo].[Employ_TB]
           ([Emp_name]
           ,[Phone]
           ,[Address]
           ,[Position]
           ,[Emp_pic]
           ,[Salary])
     VALUES
           ('" + _txtemp1.Text + "', '" + _txtphone2.Text + "', '" + _txtaddres.Text + "', '" + _txtposition.Text + "', @pic, '" + _txtsalary.Text + "')");

                cmd = new SqlCommand(sql, Connection_class.don_con());
                MemoryStream ms = new MemoryStream();
                _pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = ms.ToArray();
                cmd.Parameters.AddWithValue("@pic", img);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill();
                clear();
            }catch(Exception px)
            {
               // MessageBox.Show(px);
            }

        }
        private void clear()
        {
            _txtemp1.Clear();
            _txtphone2.Clear();
            _txtposition.Clear();
            _txtsalary.Clear();
            _txtaddres.Clear();
            _pictureBox1.ImageLocation = null;


        }

        private void _dgv1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = Connection_class.Selecte("SELECT [Emp_pic] FROM [dbo].[Employ_TB] where [Emp_id]='"+_dgv1.CurrentRow.Cells[0].Value.ToString()+"'");
            if (dt.Rows.Count > 0)
            {
                byte[] img = new byte[0];
                img = (byte[])dt.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                _pictuer.Image = Image.FromStream(ms);



            }
        }

        private void _txtphone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {

                e.Handled = true;

}
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtemp1.Text = _dgv1.CurrentRow.Cells[1].Value.ToString();
            _txtphone2.Text = _dgv1.CurrentRow.Cells[2].Value.ToString();
            _txtaddres.Text = _dgv1.CurrentRow.Cells[3].Value.ToString();
            _txtposition.Text = _dgv1.CurrentRow.Cells[4].Value.ToString();
            _txtsalary.Text = _dgv1.CurrentRow.Cells[5].Value.ToString();
            _btnsave.Visible = false;
            _btnupdat.Visible = true;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Soure To Delete The Selected Item", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Connection_class.Execute("DELETE FROM [dbo].[Employ_TB]WHERE Emp_id='" + _dgv1.CurrentRow.Cells[0].Value.ToString() + "'");

                MessageBox.Show("Your Record Succefully Deleted");
                fill();
            }
        }

        private void _btnupdat_Click(object sender, EventArgs e)
        {
           string sql=("UPDATE [dbo].[Employ_TB] SET [Emp_name] = '"+_txtemp1.Text+"' ,[phone] = '"+_txtphone2.Text+"',[Address] = '"+_txtaddres.Text+"',[Position] = '"+_txtposition.Text+ "',[Emp_pic] = @pic,[Salary] = '" + _txtsalary.Text+"' WHERE Emp_id='"+_dgv1.CurrentRow.Cells[0].Value.ToString()+"'");
            cmd = new SqlCommand(sql, Connection_class.don_con());
            MemoryStream ms = new MemoryStream();
            _pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = ms.ToArray();
            cmd.Parameters.AddWithValue("@pic", img);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Succefully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fill();
            clear();

        }

        private void _txtserching_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Connection_class.Selecte(@"SELECT [Emp_id]
      ,[Emp_name]
      ,[Phone]
      ,[Address]
      ,[Position]
      ,[Salary]
  FROM[dbo].[Employ_TB] where concat([Emp_name],[Phone],[Address],[Position],[Salary]) like '%" + _txtserching.Text + "%'");

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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _btnsave.Visible = true;
            _btnupdat.Visible = false;
            clear();
            fill();
        }
    }
}
