using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_shop_application.Backup
{
    public partial class Restore : Form
    {
        public Restore()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Back(*.bak) | *.bak";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                _txtrestore.Text = opn.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("use Master Restore database Mobile_shop_application from disk='" + _txtrestore.Text + "' with replace");
            MessageBox.Show("The Data hasbeen Restore From The Selected File ");
            Application.Exit();
            _txtrestore.Clear();
        }
    }
}
