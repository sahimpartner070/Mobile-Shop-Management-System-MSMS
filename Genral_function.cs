using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Mobile_shop_application
{
    class Genral_function
    {
        public static void MY_message(String mess,String title)
        {
            MessageBox.Show(mess, title, MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        public static void enterkey(KeyEventArgs aa, Control Control_Name)
        {
            if(aa.KeyCode==Keys.Enter || aa.KeyCode == Keys.Down)
            {
                Control_Name.Focus();

            } }
        public static void upkey(KeyEventArgs aa, Control Control_Name)
        {
            if (aa.KeyCode == Keys.Up)
            {
                Control_Name.Focus();

            }






        }


    }


}

