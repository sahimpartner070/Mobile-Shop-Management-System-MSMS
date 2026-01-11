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
    public partial class Sale_view : Form
    {
        public Sale_view()
        {
            InitializeComponent();
        }

        private void Sale_view_Load(object sender, EventArgs e)
        {
            _dgv1.DataSource = Connection_class.Selecte("select *from Sale_view");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Bill is Ready to Print", "Qustion", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Reports.Sale_Print sell = new Reports.Sale_Print();
                sell.ShowDialog();
            }
        }
    }
}
