﻿using Microsoft.Data.SqlClient;

namespace TrainingFPT
{
    public class Database
    {
        public static string GetStringConnection()
        {
            string strConnection = @"Data Source=DESKTOP-UELDG31\SQLEXPRESS;Initial Catalog=TrainingFPT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            return strConnection;
        }

        public static SqlConnection GetSqlConnection()
        {
            string strConnection = GetStringConnection();
            SqlConnection connection = new SqlConnection(strConnection);
            return connection;
        }
    }
}
