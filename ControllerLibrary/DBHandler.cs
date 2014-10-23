using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace ControllerLibrary
{
    public class DBHandler
    {
        public const string DBNAME = "QuestionBank.sqlite";
        public const string QUESTIONS = "questions";
        public const string CHAPTER = "chapter";
        public const string ANSWERS = "answers";

        protected SQLiteConnection connection;
        protected SQLiteCommand command;
        //SQLiteDataReader dataReader;

        public DBHandler()
        {
            if (File.Exists(DBNAME))
            {
                connection = new SQLiteConnection("Data Source=" + DBNAME + ";Version=3;");
            }
            else
            {
                SQLiteConnection.CreateFile(DBNAME);
                connection = new SQLiteConnection("Data Source=" + DBNAME + ";Version=3;");
            }

            CreateTables();

        }

        private void CreateTables()
        {
            CreateChapterTable();
            CreateQuestionTable();
            CreateAnswersTable();
        }

        private void CreateQuestionTable()
        {
            
            if (!CheckTableExists(QUESTIONS))
            {
                connection.Open();
                command = connection.CreateCommand();

                string query = "CREATE TABLE " + QUESTIONS + " (" +
                    "questionID INTEGER(11) NOT NULL PRIMARY KEY," +
                    "chapterID INTEGER(11)," +
                    "question TEXT," +
                    "answer CHAR," +
                    "FOREIGN KEY (chapterID) REFERENCES " + CHAPTER + "(chapterID)"
                     + ");";
                // Let the SQLiteCommand object know our SQL-Query:
                command.CommandText = query;

                //execute create table
                command.ExecuteNonQuery(CommandBehavior.CloseConnection);
            }
        }

        private void CreateChapterTable()
        {
            
            // create a new SQL command:
            if (!CheckTableExists(CHAPTER))
            {
                connection.Open();
                command = connection.CreateCommand();

                string query = "CREATE TABLE " + CHAPTER + " (" +
                    "chapterID INTEGER(11) NOT NULL PRIMARY KEY," +
                    "chapterName TEXT"
                     + ");";
                // Let the SQLiteCommand object know our SQL-Query:
                command.CommandText = query;

                //execute create table
                command.ExecuteNonQuery(CommandBehavior.CloseConnection);
            }
        }

        private void CreateAnswersTable()
        {
            
            if (!CheckTableExists(ANSWERS))
            {
                connection.Open();
                command = connection.CreateCommand();

                string query = "CREATE TABLE " + ANSWERS + " (" +
                    "answerID INTEGER(11) NOT NULL PRIMARY KEY," +
                    "questionID INTEGER(11)," +
                    "answerone TEXT," +
                    "answertwo TEXT," +
                    "answerthree TEXT," +
                    "answerfour TEXT," +
                    "answerfive TEXT," +
                    "FOREIGN KEY (questionID) REFERENCES " + QUESTIONS + "(questionID)"
                     + ");";
                // Let the SQLiteCommand object know our SQL-Query:
                command.CommandText = query;

                //execute create table
                command.ExecuteNonQuery(CommandBehavior.CloseConnection);
            }
        }

        private bool CheckTableExists(string tableName)
        {
            connection.Open();
            string query1 = "SELECT COUNT(tbl_name) FROM sqlite_master WHERE tbl_name ='" + tableName + "';";

            SQLiteCommand sqlCommand = new SQLiteCommand(query1, connection);
            try
            {
                int rows = Convert.ToInt32(sqlCommand.ExecuteScalar(CommandBehavior.CloseConnection));
                if (rows > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }

        private bool IfDatabaseIsEmpty()
        {
            connection.Open();
            string query1 = "SELECT COUNT(tbl_name) FROM sqlite_master;";

            SQLiteCommand sqlCommand = new SQLiteCommand(query1, connection);
            try
            {
                int rows = Convert.ToInt32(sqlCommand.ExecuteScalar(CommandBehavior.CloseConnection));
                if (rows == 0)
                {
                    return true;
                }
                else if (rows > 0)
                {
                    return false;
                }
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException(ex.Message);
            }
            return false;    
        }

        public bool CheckIfPopulated(string tableName) 
        {
            connection.Open();
            string query1 = "SELECT * FROM " + tableName + ";";

            SQLiteCommand sqlCommand = new SQLiteCommand(query1, connection);
            try
            {
                int rows = Convert.ToInt32(sqlCommand.ExecuteScalar(CommandBehavior.CloseConnection));
                if (rows > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}
