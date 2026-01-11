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
    public partial class Sale_return_view : Form
    {
        public Sale_return_view()
        {
            InitializeComponent();
        }

        private void Sale_return_view_Load(object sender, EventArgs e)
        {
            _dgv1.DataSource = Connection_class.Selecte("Select * from [dbo].[Sale_R_view]");
        }
    }
}
