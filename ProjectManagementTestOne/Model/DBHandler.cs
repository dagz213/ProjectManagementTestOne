using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finisar.SQLite;

namespace ProjectManagementTestOne.Model
{
    public class DBHandler
    {
        private const string DBNAME = "QuestionBank.db";

        SQLiteConnection connection;
        SQLiteCommand command;
        //SQLiteDataReader dataReader;

        public DBHandler()
        {
            if (File.Exists(DBNAME))
            {
                connection = new SQLiteConnection("Data Source=" + DBNAME + ";Version=3;");
            }
            else
            {
                connection = new SQLiteConnection("Data Source=" + DBNAME + ";Version=3;New=True;");
            }
        }
    }
}
