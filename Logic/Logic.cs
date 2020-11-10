using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace MyFirstWebsite.Logic
{
    public class Logic
    {

        public static string getConnString(string connName="test")
        {
            return ConfigurationManager.ConnectionStrings[connName].ConnectionString;
        }
    
        public static List<T> LoadSQLData<T>(string sql)
        {
            using (IDbConnection conn = new SqlConnection(getConnString()))
            {

                return conn.Query<T>(sql).ToList();
            }

        }

        public static void saveSQLData<T>(string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(getConnString()))
            {
                    conn.Execute(sql, data);          

            }

        }
    
    }
}