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
    public partial class ParchasRview : Form
    {
        public ParchasRview()
        {
            InitializeComponent();
        }
        private void fill()
        {
            DataTable dt = Connection_class.Selecte("Select* From ParchasRview");
            _dgv1.DataSource = dt;
            _dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void ParchasRview_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void _dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
