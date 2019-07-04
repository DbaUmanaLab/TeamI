using AppLogic.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class SqliteDataAccess
    {

        public static List<Classe> LoadClassi(string query = "SELECT * FROM classe ORDER by anno DESC")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Classe>(query,new DynamicParameters());
                return output.ToList();
            }
        }


        public static void SaveClasse(Classe classe)
        {

        }


        public static List<Alunno> LoadAlunni(string query = "SELECT * FROM alunno ORDER by cognome")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Alunno>(query, new DynamicParameters());
                return output.ToList();
            }
        }


        //public static void SaveAlunno(Alunno alunno)
        //{ }

        private static string LoadConnectionString(string id = "DemoDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
