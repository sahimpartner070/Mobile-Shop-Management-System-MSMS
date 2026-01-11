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
    public partial class Backup_and_Restore : Form
    {
        public Backup_and_Restore()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Back (*.bak)|*.bak";
            saveFileDialog1.ShowDialog();
            _txtbackup.Text = saveFileDialog1.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection_class.Execute("backup database Mobile_shop_application to disk='"+_txtbackup.Text+"'");
            MessageBox.Show("Back UP Have Been Save To The Selected Distination");
            _txtbackup.Clear();
        }
    }
}
