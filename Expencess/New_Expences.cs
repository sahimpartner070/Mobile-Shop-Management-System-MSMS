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
    public partial class New_Expences : Form
    {
        public New_Expences()
        {
            InitializeComponent();
        }

        private void _btnsave_Click(object sender, EventArgs e)
        {
            Connection_class.Execute(@"INSERT INTO [dbo].[Expence_type]
           ([Expence_type_Name])
     VALUES
           ('"+_txtName.Text+"')");

            MessageBox.Show("Expence Type is Saved");
            _txtName.Clear();
            this.Close();
        }

        private void New_Expences_Load(object sender, EventArgs e)
        {

        }
    }
}
