using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Sale
{
    public partial class Sale_Return : Form
    {
        public Sale_Return()
        {
            InitializeComponent();
        }

        private void Sale_Return_Load(object sender, EventArgs e)
        {

            _itemlist.ClearSelected();
            _dgv1.Columns.Add("colid", "ID");
            _dgv1.Columns.Add("colname", "Name");
            _dgv1.Columns.Add("colqty", "Quntity");
            _dgv1.Columns.Add("colup", "Unit Price");
            _dgv1.Columns.Add("coltp", "Total Price");

            _itemlist.DataSource = Connection_class.Selecte("SELECT [product_id],[product_name]FROM [dbo].[item_registration]");
            _itemlist.ValueMember = "product_id";
            _itemlist.DisplayMember = "product_name";

            //code to add customer in combo


            _combo1.DataSource = Connection_class.Selecte("SELECT [customer_id],[customer_name]FROM[dbo].[customer_t]");

            _combo1.ValueMember = "customer_id";
            _combo1.DisplayMember = "customer_name";

        }

        private void _itemlist_Click(object sender, EventArgs e)
        {
            _txtnamesearch.Text = _itemlist.Text;
        }
        private void Clear()
        {
            _txt_u_price.Clear();
            _txt_qty.Clear();
            _txtTotal_price.Clear();
            _txtnamesearch.Clear();

        }
        private void Sum()
        {
            decimal total = 0;
            foreach (DataGridViewRow dr in _dgv1.Rows)
            {
                total = total + Convert.ToDecimal(dr.Cells[4].Value.ToString());

                _txtTotalAmount.Text = total.ToString();

            }
        }
        private void toltal()
        {
            try
            {

                _txtTotal_price.Text = (Convert.ToDecimal(_txt_qty.Text) * Convert.ToDecimal(_txt_u_price.Text)).ToString();


            }
            catch (Exception)
            { }

        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (_txt_qty.Text.Trim() == "" || Convert.ToDecimal(_txt_qty.Text) <= 0)
            {
                MessageBox.Show("Sorry 0 and Empty value is not Allowed", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txt_qty.Focus();
                return;

            }
            if (_txt_u_price.Text.Trim() == "")
            {
                MessageBox.Show("Please insert a price of Item", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _txt_u_price.Focus();
                return;
            }
            foreach (DataGridViewRow dr in _dgv1.Rows)
            {
                if (_itemlist.SelectedValue.ToString().CompareTo(dr.Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("Sorr=y[" + _itemlist.Text + "] Product is alrady exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _dgv1.ClearSelection();
                    dr.Selected = true;
                    Clear();
                    _txtnamesearch.Focus();
                    return;



                }
            }
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
                Clear();


            }
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

        private void _txtPaid_TextChanged(object sender, EventArgs e)
        {
            _txtBlance.Text = (Convert.ToDecimal(_txtTotalAmount.Text) - Convert.ToDecimal(_txtPaid.Text)).ToString();
        }

        private void _btnsave_Click(object sender, EventArgs e)
        {

            Connection_class.Execute(@"INSERT INTO[dbo].[sale_R_t]
           ([sale_R_date]
           ,[customer_id]
           ,[paid]
           ,[balance]
           ,[total])
     VALUES
           ('" + _time.Value.ToString() + "', '" + _combo1.SelectedValue + "', '" + _txtPaid.Text + "', '" + _txtBlance.Text + "', '" + _txtTotalAmount.Text + "')");

            DataTable dt_id = Connection_class.Selecte("SELECT max([sale_R_id])FROM [dbo].[sale_R_t]");

            string sale_id = "0";
            if (dt_id.Rows.Count > 0)
            {
                sale_id = dt_id.Rows[0][0].ToString();
            }
            foreach (DataGridViewRow dr in _dgv1.Rows)
            {
                string product_id = dr.Cells[0].Value.ToString();
                string qty = dr.Cells[2].Value.ToString();
                string unit_price = dr.Cells[3].Value.ToString();
                string total = dr.Cells[4].Value.ToString();

                Connection_class.Execute(@"INSERT INTO[dbo].[sale_R_detail_t]
           ([sale_R_id]
           ,[product_id]
           ,[quntity]
           ,[unit_price]
           ,[total_price])
     VALUES
           ('" + sale_id + "', '" + product_id + "', '" + qty + "', '" + unit_price + "', '" + total + "')");

                //cod for updat stok

                Connection_class.Execute("UPDATE [dbo].[item_registration] SET [quntity] =[quntity]+ '" + qty + "' WHERE product_id='" + product_id + "'");

                MessageBox.Show("The Inserted Data Saccefully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

