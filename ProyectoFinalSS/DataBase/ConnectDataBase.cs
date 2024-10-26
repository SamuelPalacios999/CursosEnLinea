using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalSS.DataBase
{
    public class ConnectDataBase
    {
        public static SqlConnection ConnectionDataBase()
        {
            SqlConnection connect = new SqlConnection("Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=PROYECTUMG;Data Source=localhost");
            connect.Open();
            return connect;
        }
    }
}
