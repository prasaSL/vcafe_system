using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace cafe_system
{
   public class connectionManager
    {
       public static SqlConnection sqlcon;
       public static string cost =ConfigurationManager.ConnectionStrings["cafeDB"].ConnectionString;

       public static SqlConnection getconn() { 
           sqlcon = new SqlConnection(cost);
           return sqlcon;
       }
    }
}
