using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace c__final_project.Data
{
    //public static SQLiteConnection Getconnection()
    //
    //return new SQLiteConnection("Data Source=unicom.db;Version=3;");

    public static class DBconnection
    {
        private static string connectionString = "Data Source=unicom.db;Version=3;";

        public static SQLiteConnection Getconnection()
        {
            SQLiteConnection conn= new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }
    }









}
