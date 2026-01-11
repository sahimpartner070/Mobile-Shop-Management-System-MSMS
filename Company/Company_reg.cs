using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace Mobile_shop_application.Company
{
    public partial class Company_reg : Form
    {
        public Company_reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Company_reg_Load(object sender, EventArgs e)
        {
            fill();
        }
        private void fill()
        {
           DataTable dt=Connection_class.Selecte(@"SELECT [company_id]as[ID]
         ,[company_name]as[NAME]
                ,[company_addres]as[Company]
             FROM[dbo].[company_t]");
            _dgv.DataSource = dt;
           _dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection_class.Execute(@"INSERT INTO[dbo].[company_t]
           ([company_name]
           ,[company_addres])
     VALUES
           ('" + _txtcompany.Text + "', '" + _txtaddress.Text + "')");

            MessageBox.Show("Company Saved","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fill();
            _txtcompany.Text = " ";
            _txtaddress.Text = " ";
            _txtcompany.Focus();
        }

        private void _dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // fill();
        }

        private void _txtcompany_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txtaddress);
            Genral_function.upkey(e, _txtcompany);
        }

        private void _txtaddress_KeyUp(object sender, KeyEventArgs e)
        {
           // Genral_function.enterkey(e, _txtcompany);
        }

        private void _txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _saveb);
            Genral_function.upkey(e, _txtcompany);
        }

        private void _txtcompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txtcompany.Text = _dgv.CurrentRow.Cells[1].Value.ToString();
            _txtaddress.Text = _dgv.CurrentRow.Cells[2].Value.ToString();
            _btnupdate.Visible = true;
            _saveb.Visible = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Soure To Delete The Selected Item","Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection_class.Execute("DELETE FROM [dbo].[company_t]WHERE company_id='"+_dgv.CurrentRow.Cells[0].Value.ToString() +"'");

                MessageBox.Show("Recoord Succesfully Deleted");
                fill();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void _btnupdate_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("UPDATE[dbo].[company_t]SET[company_name] = '"+_txtcompany.Text+"',[company_addres] = '"+_txtaddress.Text+"'WHERE company_id = '"+_dgv.CurrentRow.Cells[0].Value.ToString()+"'");

            MessageBox.Show("Record Succesfully Updated");

            fill();
            _txtcompany.Clear();
            _txtaddress.Clear();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _btnupdate.Visible = false;
            _saveb.Visible = true;
            _txtcompany.Clear();
            _txtaddress.Clear();
            fill();
            
        }
    }
   
        
       
        

    
}
