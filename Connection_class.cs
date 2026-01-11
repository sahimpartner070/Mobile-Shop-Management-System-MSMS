using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Mobile_shop_application
{
    class Connection_class
    {
        public static SqlConnection con;

        public static SqlConnection don_con()
        {
            if (con == null)
            {
                con = new SqlConnection(Mobile_shop_application.Properties.Settings.Default.connection1);
               }

            if(con.State!=System.Data.ConnectionState.Open)
            {
                con.Open();
            }  return con;


        } public static void Execute(String Sql)
        {
//con.Open();
            SqlCommand cmd = new SqlCommand(Sql, don_con());



            cmd.ExecuteNonQuery();
        }


        
        public static DataTable Selecte(String Sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(Sql, don_con());

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
           



        }
        public static void combofill()
        {



        }





    }
}

