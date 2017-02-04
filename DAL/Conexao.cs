using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexao
    {
        public static string conectionString = System.Configuration.ConfigurationManager.
            ConnectionStrings["anuncios"].ConnectionString;

        public static SqlConnection con = new SqlConnection(conectionString);

        public static void Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
