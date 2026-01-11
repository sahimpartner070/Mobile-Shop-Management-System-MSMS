using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;


namespace Mobile_shop_application.Item_registration
{
    
    public partial class item_Registration : Form
    {
        public object Categories { get; private set; }

        public item_Registration()
        {
            InitializeComponent();
        }

        private void item_Registration_Load(object sender, EventArgs e)
        {
         

            _combo1.DataSource = Connection_class.Selecte("SELECT [company_id],[company_name]FROM[dbo].[company_t]");
            _combo1.ValueMember = "company_id";
            _combo1.DisplayMember = "company_name";
            fill();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void b_save_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("INSERT INTO [dbo].[item_registration]([product_name],[company_id],[IME],[model],[Ram],[memory],[quntity],[purchas_price],[sale_price])VALUES('"+_txt_p_name.Text+"','"+_combo1.SelectedValue+"','"+_txt_ime.Text+"','"+_txt_model.Text+"','"+_txt_ram.Text+"','"+_txt_memory.Text+"','"+_txt_qty.Text+"','"+_txt_u_price.Text+"','"+_txt_s_price.Text+"')");

            MessageBox.Show("Yuor Data Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fill();
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void _dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fill()
        {
                      DataTable dt = Connection_class.Selecte("Select* From ItemREG");
            _dgv1.DataSource = dt;
            _dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        private void clear()
        {
            _txt_p_name.Clear();
            _combo1.SelectedIndex=-1;
            _txt_model.Clear();
            _txt_memory.Clear();
            _txt_ram.Clear();
            _txt_qty.Clear();
            _txt_s_price.Clear();
            _txt_u_price.Clear();
            _txt_ime.Clear();
            


         
            





        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _txt_p_name.Text = _dgv1.CurrentRow.Cells[0].Value.ToString();
            _combo1.Text = _dgv1.CurrentRow.Cells[1].Value.ToString();
            _txt_ime.Text = _dgv1.CurrentRow.Cells[2].Value.ToString();
            _txt_model.Text = _dgv1.CurrentRow.Cells[3].Value.ToString();
            _txt_ram.Text = _dgv1.CurrentRow.Cells[4].Value.ToString();
            _txt_memory.Text = _dgv1.CurrentRow.Cells[5].Value.ToString();
            _txt_qty.Text = _dgv1.CurrentRow.Cells[6].Value.ToString();
            _txt_u_price.Text = _dgv1.CurrentRow.Cells[7].Value.ToString();
            _txt_s_price.Text = _dgv1.CurrentRow.Cells[8].Value.ToString();
            _btnUp.Visible = true;
            _b_save.Visible = false;
            
            }

        private void _txtserching_TextChanged(object sender, EventArgs e)
        {
            try {
                DataTable dt = Connection_class.Selecte("select* from ItemREG where concat([product_name],[IME],[model],[Ram],[memory],[quntity],[purchas_price],[sale_price]) like '%" + _txtserching.Text+"%'");
                if (dt.Rows.Count > 0)
                {
                    
                    _dgv1.DataSource = dt; }

            } catch (Exception ex)
            {
                //MessageBox.Show(Exception ex);
            }
            {



            }
        }

        private void _txt_p_name_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _combo1);
          

        }

        private void _combo1_Enter(object sender, EventArgs e)
        {
            //Genral_function.enterkey(e,_txt_model);
        }

        private void _txt_model_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txt_ram);
            Genral_function.upkey(e, _combo1);
        }

        private void _combo1_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txt_model);
            Genral_function.upkey(e, _txt_p_name);

        }

        private void _combo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _txt_ram_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txt_memory);
            Genral_function.upkey(e, _txt_model);
        }

        private void _txt_memory_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e,_txt_qty);
            Genral_function.upkey(e, _txt_ram);

        }

        private void _txt_qty_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txt_u_price);
            Genral_function.upkey(e, _txt_memory);
        }

        private void _txt_u_price_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _txt_s_price);
            Genral_function.upkey(e, _txt_qty);

        }

        private void _txt_s_price_KeyDown(object sender, KeyEventArgs e)
        {
            Genral_function.enterkey(e, _b_save);

            Genral_function.upkey(e, _txt_u_price);



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Delete", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Connection_class.Execute("DELETE FROM [dbo].[item_registration] WHERE product_name='"+_dgv1.CurrentRow.Cells[0].Value.ToString()+"'");

                MessageBox.Show("Selected Recode Succesfully Deleted");
                fill();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _btnUp.Visible = false;
            _b_save.Visible = true;
            clear();
            
            fill();
        }

        private void _txt_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void _btnUp_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("UPDATE [dbo].[item_registration]SET [product_name] = '"+_txt_p_name.Text+"',[company_id] = '"+_combo1.SelectedValue+"',[model] ='"+_txt_model.Text+"',[Ram] = '"+_txt_ram.Text+"',[memory] = '"+_txt_memory.Text+"',[quntity] = '"+_txt_qty.Text+"',[purchas_price] = '"+_txt_u_price.Text+"',[sale_price] ='"+_txt_s_price.Text+"'WHERE product_name ='"+_dgv1.CurrentRow.Cells[0].Value.ToString()+"'");



            MessageBox.Show("Information Updated succesfull","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            _btnUp.Visible = false;
            _b_save.Visible = true;
            fill();
            clear();

                
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _txt_ram_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void _txt_memory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
      
    
        //Connection_class.Selecte()


     
}
