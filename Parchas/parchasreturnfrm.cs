using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Parchas
{
    public partial class parchasreturnfrm : Form
    {
        public parchasreturnfrm()
        {
            InitializeComponent();
        }

        private void _dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
            string Purchas_id = "0";
            Connection_class.Execute("INSERT INTO [dbo].[Parchas_R_TB]([purchas_date],[suplair_id],[total])VALUES('" + _time.Value.ToString() + "', '" + _combo1.SelectedValue + "', '" + _txtHT.Text + "')");

            DataTable dt_id = Connection_class.Selecte("SELECT max([purchas_id])FROM [dbo].[purchas_t]");
            if (dt_id.Rows.Count > 0)
            {
                Purchas_id = dt_id.Rows[0][0].ToString();


            }
            foreach (DataGridViewRow dr in _dgv1.Rows)
            {
                string product_id = dr.Cells[0].Value.ToString();

                string qty = dr.Cells[2].Value.ToString();
                string unitprice = dr.Cells[3].Value.ToString();
                string total = dr.Cells[4].Value.ToString();

                Connection_class.Execute("INSERT INTO[dbo].[Parchasreturn_detail_t]([purchasreturn_id],[purchas_date],[product_id],[quntity],[unit_price],[total])VALUES('" + Purchas_id + "', '" + _time.Value.ToString() + "', '" + product_id + "', '" + qty + "', '" + unitprice + "', '" + total + "')");

                //code to update the stok

                Connection_class.Execute("UPDATE [dbo].[item_registration]SET[quntity]=[quntity]-'" + qty + "' WHERE product_id ='" + product_id + "'");
            }
            MessageBox.Show("Record Inserted Succesfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _btnsavedinformation.Visible = true;
            
        
    }

        private void _btnsavedinformation_Click(object sender, EventArgs e)
        {
            Parchas.Parchasview prv = new Parchas.Parchasview();
            prv.ShowDialog();
        }

        private void _itemlist_Click(object sender, EventArgs e)
        {
            _txtnamesearch.Text = _itemlist.Text;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(_dgv1);
                dr.Cells[0].Value = _itemlist.SelectedValue;
                dr.Cells[1].Value = _txtnamesearch.Text;
                dr.Cells[2].Value = _txt_qty.Text;
                dr.Cells[3].Value = _txt_u_price.Text;
                dr.Cells[4].Value = _txtTotal_price.Text;
                _dgv1.Rows.Add(dr);

                  Sum();

                _txt_u_price.Clear();
                _txt_qty.Clear();
                _txtTotal_price.Clear();

            }
        }
        private void toltal()
        {
            try
            {

                _txtTotal_price.Text = (Convert.ToDecimal(_txt_qty.Text) * Convert.ToDecimal(_txt_u_price.Text)).ToString();


            }
            catch (Exception)
            {

            }

        }

        private void parchasreturnfrm_Load(object sender, EventArgs e)
        {

            _itemlist.ClearSelected();
            _dgv1.Columns.Add("colid", "Product ID");
            _dgv1.Columns.Add("colname", "Product Name");
            _dgv1.Columns.Add("colqty", "Product Quntity");
            _dgv1.Columns.Add("colup", "Product Unit Price");
            _dgv1.Columns.Add("coltp", "Product Total Price");



            _itemlist.DataSource = Connection_class.Selecte("SELECT [product_id],[product_name]FROM [dbo].[item_registration]");
            _itemlist.ValueMember = "product_id";
            _itemlist.DisplayMember = "product_name";
            //Code for Suplier Addition

            _combo1.DataSource = Connection_class.Selecte("SELECT [suplier_id],[suplier_name]FROM[dbo].[suplier_t]");

            _combo1.ValueMember = "suplier_id";
            _combo1.DisplayMember = "suplier_name";
        
    }

        private void _txtnamesearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                _itemlist.DataSource = Connection_class.Selecte("SELECT [product_id],[product_name]FROM [dbo].[item_registration]  where [product_name]like'%" + _txtnamesearch.Text + "%'");
                _itemlist.ValueMember = "product_id";
                _itemlist.DisplayMember = "product_name";


            }
            catch (Exception) { }
        
    }

        private void _txt_qty_TextChanged(object sender, EventArgs e)
        {
            toltal();
        }

        private void _txt_u_price_TextChanged(object sender, EventArgs e)
        {
            toltal();
        }
        private void Sum()
        {
            decimal total = 0;
            foreach (DataGridViewRow dr in _dgv1.Rows)
            {
                total = total + Convert.ToDecimal(dr.Cells[4].Value.ToString());

                _txtHT.Text = total.ToString();

            }


        }

        private void _itemlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
