using MyFirstWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebsite.Logic
{
    public class dataBaseLogic
    {
        public static void addPersonToTable(string _name, int _age)
        {
            modelTest data = new modelTest
            {

                name = _name,
                age = _age
            };

            string sql = $"insert into [dbo].[people] VALUES('{_name}', {_age});";

            Logic.saveSQLData(sql, data);
        }

        public static List<modelTest> showPeople()
        {

            string sql = $"SELECT Id, Name, Age FROM [dbo].[people] ORDER BY Id;";

            return Logic.LoadSQLData<modelTest>(sql);
        }
    }
}