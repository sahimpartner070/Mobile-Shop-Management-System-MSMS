using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Expencess
{
    public partial class Expencess_1 : Form
    {
        public Expencess_1()
        {
            InitializeComponent();
        }

        private void Expencess_1_Load(object sender, EventArgs e)
        {
            fill();

            _comb_type.DataSource = Connection_class.Selecte(@"
SELECT[Expence_type_id]
      ,[Expence_type_Name]
  FROM[dbo].[Expence_type]");
            _comb_type.ValueMember = "Expence_type_id";
            _comb_type.DisplayMember = "Expence_type_Name";
            _combo_man.DataSource = Connection_class.Selecte(@"SELECT [Emp_id]
      ,[Emp_name]
  FROM[dbo].[Employ_TB]");
            _combo_man.ValueMember = "Emp_id";
            _combo_man.DisplayMember = "Emp_name";
            _txt_amount.Text = "0";

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void _txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (_combo_man.Visible == true)
            {
                Connection_class.Execute(@"INSERT INTO [dbo].[Expences]
           ([Expence_type_id]
           ,[Expence_amount]
           ,[Expence_Date]
           ,[Expance_description]
           ,[Emp_id])
     VALUES
           ('" + _comb_type.SelectedValue + "','" + _txt_amount.Text + "','" + _date.Value.ToString() + "','" + _txt_Descrition.Text + "','" + _combo_man.SelectedValue + "')");


            }
            else
            {
                Connection_class.Execute(@"INSERT INTO [dbo].[Expences]
           ([Expence_type_id]
           ,[Expence_amount]
           ,[Expence_Date]
           ,[Expance_description])
     VALUES
           ('" + _comb_type.SelectedValue + "','" + _txt_amount.Text + "','" + _date.Value.ToString() + "','" + _txt_Descrition.Text + "')");

            }

            MessageBox.Show("Data hase been save");
            clear();
            fill();

        }
        private void fill()
        {
            DataTable dt = Connection_class.Selecte("select*from Expenceview;");
            _dgv_view.DataSource = dt;
            _dgv_view.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            _dgv_view.Columns[5].Visible = false;
        }
        private void clear()
        {
            _combo_man.Text = "";
            _comb_type.Text = "";
            _date.Text = "";
            _txt_amount.Clear();
            _txt_Descrition.Clear();


        }
        /*  private void fill()
          {
              DataTable dt = Connection_class.Selecte(@"SELECT [Expence_id]
        ,[Expence_type_id]
        ,[Expence_amount]
        ,[Expence_Date]
        ,[Expance_description]
        ,[Expencer_mane]
    FROM[dbo].[Expences]");
              _dgvexpence.DataSource = dt;
              _dgvexpence.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

          }*/

        private void _dgvexpence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _comb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_comb_type.Text == "Sallary")
                {
                    _combo_man.Visible = true;
                    _label_emp.Visible = true;

                }
                else if (_comb_type.Text != "sallary")


                {
                    _combo_man.Visible = false;
                    _label_emp.Visible = false;

                }


            }
            catch (Exception)
            {


            }
        }

        private void _combo_man_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = Connection_class.Selecte(@"SELECT[Emp_id]
                ,[Emp_name]
                ,[Phone]
                ,[Address]
                ,[Position]
                ,[Salary]
                ,[Emp_pic]
            FROM[dbo].[Employ_TB]Where Emp_id='" + _combo_man.SelectedValue + "'");
              if(dt.Rows.Count>0)
                {
                    _txt_amount.Text = dt.Rows[0]["Salary"].ToString();
                }
                else
                {
                    _txt_amount.Text = "0";
                }
                
            }
            catch (Exception)
            {

              
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Do You Want To Delete", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Connection_class.Execute("DELETE FROM [dbo].[Expences]WHERE Expence_id = '" + _dgv_view.CurrentRow.Cells[5].Value.ToString() + "'");

                    MessageBox.Show("Selected Recode Succesfully Deleted");
                    fill();
                } }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _comb_type.Text = _dgv_view.CurrentRow.Cells[0].Value.ToString();
                _txt_amount.Text = _dgv_view.CurrentRow.Cells[1].Value.ToString();
                _date.Text = _dgv_view.CurrentRow.Cells[2].Value.ToString();
                _txt_Descrition.Text = _dgv_view.CurrentRow.Cells[3].Value.ToString();
               _combo_man.Text = _dgv_view.CurrentRow.Cells[4].Value.ToString();
                _btn_update.Visible = true;
                _b_save.Visible = false;
               
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void _btn_update_Click(object sender, EventArgs e)
        {


           Connection_class.Execute("UPDATE[dbo].[Expences] SET[Emp_id] = < Emp_id> ,[Expence_type_id] = '"+_comb_type.SelectedValue+"',[Expence_amount] = '"+_txt_amount.Text+"',[Expence_Date] = '"+_date+"',[Expance_description] = '"+_txt_Descrition.Text+"' WHERE Expence_type_id = '"+_dgvexpence.CurrentRow.Cells[1].Value.ToString()+"'");


            MessageBox.Show("Information Updated succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fill();
            clear();
        }
    }
    
}

