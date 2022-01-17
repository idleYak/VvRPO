using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Oformlenie_biletov
{
    class DB_connect
    {
        static string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";

        //редактирование данных 
        public static DataTable Connectoux(string sqlExpression)
        {
            SqlCommand cmd = new SqlCommand(sqlExpression);
            SqlDataAdapter da = new SqlDataAdapter(sqlExpression, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        // статичный вывод данных
        public static void Сonnect_stat(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}





 //   static string connectionString = "Server=ALEXIUS;Database=Oformlenie_biletov;Trusted_Connection=True;TrustServerCertificate=True;";
