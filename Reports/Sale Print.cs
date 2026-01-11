using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Reports
{
    public partial class Sale_Print : Form
    {
        public Sale_Print()
        {
            InitializeComponent();
        }

        private void Sale_Print_Load(object sender, EventArgs e)


        {

            String saleid="0";
            DataTable dt_id = Connection_class.Selecte("select max(sale_id)from Sale_view");
            if (dt_id.Rows.Count > 0)
            {
                saleid = dt_id.Rows[0][0].ToString();
            }

            DataTable dt = Connection_class.Selecte("select *from Sale_view where sale_id='"+saleid+"'");
            if (dt.Rows.Count > 0)
            {
              
               Reports.Report rp = new Report();
                rp.SetDataSource(dt);
                _crystal.ReportSource = rp;
                 rp.Refresh();
               
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
