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
    public partial class Main_form : Form
    {
        Log_in frm;
        public Main_form(Log_in fr)
        {

                InitializeComponent();
            this.frm = fr;
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            string type = "";
            DataTable dt = Connection_class.Selecte(@"SELECT  user_type_t.user_type FROM   user_t INNER JOIN
             user_type_t ON user_t.user_type_id = user_type_t.user_type_id
             where user_t.user_name = N'" + frm._txtuser.Text + "' and user_t.password = N'" + frm._txtpassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
                type = dt.Rows[0][0].ToString();
            }

            if (type== "Admin")
            {
               // MessageBox.Show("you are loge in  as adminstrator");
                SplashForm sp = new SplashForm();
                sp.ShowDialog();
            }
            else if (type== "Local")
            {
                MessageBox.Show("You are Loged in as Locale Your Administrator Ristracted some Events Which you can not do.Contact your adminstrator for mor information");


                ristraction();

            }
        }
        private void ristraction()
        {
            _employ.Enabled = false;
            _company.Enabled = false;
            _suplier.Enabled = false;
            _listofsale.Enabled = false;
            _list_of_sale_return.Enabled = false;
            _parchaslist.Enabled = false;
            _parchas_return_list.Enabled = false;
            _user.Enabled = false;
            _password.Enabled = false;
            _expence.Enabled = false;
            _expencs_type.Enabled = false;


        }
        private void Contex_manu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Registration_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void itemRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration_form reg = new Registration_form();
            reg.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void employeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployRegistration.Empreg er = new EmployRegistration.Empreg();
            er.ShowDialog();
        }

        private void itemRegistrationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Item_registration.item_Registration item = new Item_registration.item_Registration();
            item.ShowDialog();
           
        }

        private void companyRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company.Company_reg creg = new Company.Company_reg();
            creg.ShowDialog();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void passwordResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UserRegestration.password_reset ps = new UserRegestration.password_reset();
                ps.ShowDialog();

            }
            catch
            {

            }
        }

        private void userRegestrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegestration.user ur = new UserRegestration.user();
            ur.ShowDialog();

        }

        private void custToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer.customer_reg creg = new Customer.customer_reg();
            creg.ShowDialog();
        }

        private void newPurcheaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parchas.parchasfrm pfrm = new Parchas.parchasfrm();
            pfrm.ShowDialog();
        }

        private void returnPurcheaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parchas.parchasreturnfrm prfrm = new Parchas.parchasreturnfrm();
            prfrm.ShowDialog();
        }

        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_Section ss = new Sale.Sale_Section();
            ss.ShowDialog();

        }

        private void returnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_Return sr = new Sale.Sale_Return();
            sr.ShowDialog();
        }

        private void parchasListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parchas.Parchasview pv = new Parchas.Parchasview();
            pv.ShowDialog();

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void parchasReturnListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Parchas.ParchasRview prv = new Parchas.ParchasRview();
            prv.ShowDialog();
        }

        private void suplairRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company.Suplair_registration sr = new Company.Suplair_registration();
            sr.ShowDialog();
        }

        private void saleListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_view sv = new Sale.Sale_view();
            sv.ShowDialog();
        }

        private void listOfReturnSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale.Sale_return_view sr = new Sale.Sale_return_view();
            sr.ShowDialog();
        }

        private void toolStripSplitButton5_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Backup.Restore re = new Backup.Restore();
            re.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Backup.Backup_and_Restore bc = new Backup.Backup_and_Restore();
            bc.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSplitButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton6_ButtonClick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dailyExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expencess.Expencess_1 EX = new Expencess.Expencess_1();
            EX.ShowDialog();
        }

        private void newExpencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expencess.New_Expences nx = new Expencess.New_Expences();
            nx.ShowDialog();
        }
    }
}
