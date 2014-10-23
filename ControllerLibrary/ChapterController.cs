using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerLibrary.interfaces;
using DomainLibrary;
using System.Data;
using System.Data.SQLite;

namespace ControllerLibrary
{
    public class ChapterController : DBHandler, IRepository<Chapter, int>
    {
        public ChapterController()
        {
            //Populate Questions
            if (!CheckIfPopulated(CHAPTER))
            {
                addItem(new Chapter() { ChapterID = 1, ChapterName = "Introduction To Project Management" });
                addItem(new Chapter() { ChapterID = 2, ChapterName = "The Project Management and Information Technology" });
                addItem(new Chapter() { ChapterID = 3, ChapterName = "The Project Management Process Groups" });
                addItem(new Chapter() { ChapterID = 4, ChapterName = "Project Integration Management" });
                addItem(new Chapter() { ChapterID = 5, ChapterName = "Project Scope Management" });
                addItem(new Chapter() { ChapterID = 6, ChapterName = "Project Time Management" });
                addItem(new Chapter() { ChapterID = 7, ChapterName = "Project Cost Management" });
            }
        }

        public void addItem(Chapter newItem)
        {
            connection.Open();
            command = new SQLiteCommand("INSERT INTO " + CHAPTER +" (chapterID, chapterName)  VALUES (@chapterID, @chapterName)", connection);
            command.Parameters.Add("@chapterID", DbType.Int32).Value = newItem.ChapterID;
            command.Parameters.Add("@chapterName", DbType.String).Value = newItem.ChapterName;
            try
            {
                command.ExecuteNonQuery(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                connection.Close();
                throw new Exception(ex.Message);
            }
        }

        public List<Chapter> getAllItems()
        {
            throw new NotImplementedException();
        }
    }
}
