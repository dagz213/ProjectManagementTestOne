using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLibrary;
using System.Data;
using System.Data.SQLite;
using ControllerLibrary.interfaces;

namespace ControllerLibrary
{
    public class QuestionController : DBHandler, IRepository<Question, int>
    {
        public QuestionController()
        {
            if (!CheckIfPopulated(QUESTIONS))
            {

                #region Chapter One
                addItem(new Question() { QuestionID = 1, ChapterID = 1, QuestionName = "Approximately what percentage of the world’s gross product is spent on projects?", Answer = 'b' });
                addItem(new Question() { QuestionID = 2, ChapterID = 1, QuestionName = "Which of the following is not a potential advantage of using good project management?", Answer = 'c' });
                addItem(new Question() { QuestionID = 3, ChapterID = 1, QuestionName = "A ____ is a temporary endeavor undertaken to create a unique product, service, or result.", Answer = 'c' });
                addItem(new Question() { QuestionID = 4, ChapterID = 1, QuestionName = "Which of the following is not an attribute of a project?", Answer = 'd' });
                addItem(new Question() { QuestionID = 5, ChapterID = 1, QuestionName = "Which of the following is not part of the triple constraint of project management?", Answer = 'c' });
                addItem(new Question() { QuestionID = 6, ChapterID = 1, QuestionName = "____ is the application of knowledge, skills, tools, and techniques to project activities to meet project requirements.", Answer = 'a' });
                addItem(new Question() { QuestionID = 7, ChapterID = 1, QuestionName = "Project portfolio management addresses ____ goals of an organization, while project management addresses _____ goals.", Answer = 'a' });
                addItem(new Question() { QuestionID = 8, ChapterID = 1, QuestionName = "Several application development projects done for the same functional group might best be managed as part of a ____.", Answer = 'b' });
                addItem(new Question() { QuestionID = 9, ChapterID = 1, QuestionName = "Which of the following is not true?", Answer = 'd' });
                addItem(new Question() { QuestionID = 10, ChapterID = 1, QuestionName = "What is the name of one of the popular certifications provided by the Project Management Institute?", Answer = 'b' });
                #endregion

                #region Chapter Two
                addItem(new Question() { QuestionID = 11, ChapterID = 2, QuestionName = "Which of the following is not part of the three-sphere model for systems management?", Answer = 'b' });
                addItem(new Question() { QuestionID = 12, ChapterID = 2, QuestionName = "Which of the four frames of organizations addresses how meetings are run, employee dress codes, and expected work hours?", Answer = 'd' });
                addItem(new Question() { QuestionID = 13, ChapterID = 2, QuestionName = "Personnel in a ____ organizational structure often report to two or more bosses.", Answer = 'c' });
                addItem(new Question() { QuestionID = 14, ChapterID = 2, QuestionName = "Project work is most successful in an organizational culture where all of the following characteristics are important except ____", Answer = 'd' });
                addItem(new Question() { QuestionID = 15, ChapterID = 2, QuestionName = "A ____ is a product or service, such as a technical report, a training session, or hardware, produced or provided as part of a project.", Answer = 'a' });
                addItem(new Question() { QuestionID = 16, ChapterID = 2, QuestionName = "Which of the following statements is false?", Answer = 'b' });
                addItem(new Question() { QuestionID = 17, ChapterID = 2, QuestionName = "Which of the following terms describes a framework of the phases involved in developing information systems?", Answer = 'a' });
                addItem(new Question() { QuestionID = 18, ChapterID = 2, QuestionName = "The nature of IT projects is different from projects in many other industries because they are very ____", Answer = 'c' });
                addItem(new Question() { QuestionID = 19, ChapterID = 2, QuestionName = "What term describes an organization’s acquisition of goods and services from an outside source in another country?", Answer = 'b' });
                addItem(new Question() { QuestionID = 20, ChapterID = 2, QuestionName = "____ is the leading agile development method.", Answer = 'd' });
                #endregion

                #region Chapter Three
                addItem(new Question() { QuestionID = 21, ChapterID = 3, QuestionName = "A ____ is a series of actions directed toward a particular result.", Answer = 'b' });
                addItem(new Question() { QuestionID = 22, ChapterID = 3, QuestionName = "______ processes include coordinating people and other resources to carry out project plans and create the products, services, or results of the project or phase.", Answer = 'c' });
                addItem(new Question() { QuestionID = 23, ChapterID = 3, QuestionName = "Which process group normally requires the most resources and time?", Answer = 'c' });
                addItem(new Question() { QuestionID = 24, ChapterID = 3, QuestionName = "What methodology was developed in the United Kingdom, defines 45 separate subprocesses, and organizes them into eight process groups?", Answer = 'd' });
                addItem(new Question() { QuestionID = 25, ChapterID = 3, QuestionName = "Which of the following outputs is often completed before initiating a project?", Answer = 'b' });
                addItem(new Question() { QuestionID = 26, ChapterID = 3, QuestionName = "A work breakdown structure, project schedule, and cost estimates are outputs of the _____ process.", Answer = 'b' });
                addItem(new Question() { QuestionID = 27, ChapterID = 3, QuestionName = "Initiating involves developing a project charter, which is part of the project _____ management knowledge area.", Answer = 'a' });
                addItem(new Question() { QuestionID = 28, ChapterID = 3, QuestionName = "_____ involves measuring progress toward project objectives and taking corrective actions.", Answer = 'd' });
                addItem(new Question() { QuestionID = 29, ChapterID = 3, QuestionName = "Which of the following is not a typical reason that project teams would use a predictive approach versus an agile approach to managing a project?", Answer = 'a' });
                addItem(new Question() { QuestionID = 30, ChapterID = 3, QuestionName = "Many people use _____ to have a standard format for preparing various project management documents.", Answer = 'b' });
                #endregion

                #region Chapter Four
                addItem(new Question() { QuestionID = 31, ChapterID = 4, QuestionName = "Which of the following processes is not part of project integration management?", Answer = 'a' });
                addItem(new Question() { QuestionID = 32, ChapterID = 4, QuestionName = "What is the last step in the four-stage planning process for selecting IT projects?", Answer = 'd' });
                addItem(new Question() { QuestionID = 33, ChapterID = 4, QuestionName = "Which of the following is not a best practice for new product development projects?", Answer = 'b' });
                addItem(new Question() { QuestionID = 34, ChapterID = 4, QuestionName = "A new government law requires an organization to report data in a new way. Which of the following categories would include a new information system project to provide this data?", Answer = 'c' });
                addItem(new Question() { QuestionID = 35, ChapterID = 4, QuestionName = "If estimates for total discounted benefits for a project are $120,000 and total discounted costs are $100,000, what is the estimated return on investment (ROI)?", Answer = 'c' });
                addItem(new Question() { QuestionID = 36, ChapterID = 4, QuestionName = "A ____ is a document that formally recognizes the existence of a project and provides direction on the project’s objectives and management.", Answer = 'a' });
                addItem(new Question() { QuestionID = 37, ChapterID = 4, QuestionName = "Which of the following items is not normally included in a project charter?", Answer = 'd' });
                addItem(new Question() { QuestionID = 38, ChapterID = 4, QuestionName = "____ ensures that the descriptions of the project’s products are correct and complete.", Answer = 'a' });
                addItem(new Question() { QuestionID = 39, ChapterID = 4, QuestionName = "Which of the following is not a suggestion for performing integrated change control?", Answer = 'b' });
                addItem(new Question() { QuestionID = 40, ChapterID = 4, QuestionName = "What tool and technique is used for all processes of project integration management?", Answer = 'c' });
                #endregion

                #region Chapter Five
                addItem(new Question() { QuestionID = 41, ChapterID = 5, QuestionName = "____ refer(s) to all the work involved in creating the products of the project and the processes used to create them.", Answer = 'c' });
                addItem(new Question() { QuestionID = 42, ChapterID = 5, QuestionName = "Which tool or technique for collecting requirements is often the most expensive and time consuming?", Answer = 'a' });
                addItem(new Question() { QuestionID = 43, ChapterID = 5, QuestionName = "A ____ is a deliverable-oriented grouping of the work involved in a project that definesits total scope.", Answer = 'b' });
                addItem(new Question() { QuestionID = 44, ChapterID = 5, QuestionName = "What approach to developing a WBS involves writing down or drawing ideas in a nonlinear format?", Answer = 'd' });
                addItem(new Question() { QuestionID = 45, ChapterID = 5, QuestionName = "Assume that you have a project with major categories called planning, analysis, design,and testing. What level of the WBS would these items fall under?", Answer = 'c' });
                addItem(new Question() { QuestionID = 46, ChapterID = 5, QuestionName = "Which of the following is not a best practice that can help in avoiding scope problems on IT projects?", Answer = 'd' });
                addItem(new Question() { QuestionID = 47, ChapterID = 5, QuestionName = "Why did McDonald’s terminate a large project after spending $170 million on it?", Answer = 'c' });
                addItem(new Question() { QuestionID = 48, ChapterID = 5, QuestionName = "Scope ____ is often achieved by a customer inspection and then sign-off on key deliverables.", Answer = 'b' });
                addItem(new Question() { QuestionID = 49, ChapterID = 5, QuestionName = "Which of the following is not a suggestion for improving user input?", Answer = 'd' });
                addItem(new Question() { QuestionID = 50, ChapterID = 5, QuestionName = "Project management software helps you develop a ____, which serves as a basis for creating Gantt charts, assigning resources, and allocating costs.", Answer = 'c' });
                #endregion

                #region Chapter Six
                addItem(new Question() { QuestionID = 51, ChapterID = 6, QuestionName = "Which of the following processes involves determining the policies, procedures, and documentation that will be used for planning, executing, and controlling the project schedule?", Answer = 'a' });
                addItem(new Question() { QuestionID = 52, ChapterID = 6, QuestionName = "Predecessors, successors, logical relationships, leads and lags, resource requirements, constraints, imposed dates, and assumptions are all examples of ____", Answer = 'd' });
                addItem(new Question() { QuestionID = 53, ChapterID = 6, QuestionName = "As the project manager for a software development project, you are helping to develop the project schedule. You decide that writing code for a system should not start until users sign off on the analysis work. What type of dependency is this?", Answer = 'c' });
                addItem(new Question() { QuestionID = 54, ChapterID = 6, QuestionName = "You cannot start editing a technical report until someone else completes the first draft. What type of dependency does this represent?", Answer = 'a' });
                addItem(new Question() { QuestionID = 55, ChapterID = 6, QuestionName = "Which of the following statements is false?", Answer = 'b' });
                addItem(new Question() { QuestionID = 56, ChapterID = 6, QuestionName = "What symbol on a Gantt chart represents a slipped milestone?", Answer = 'd' });
                addItem(new Question() { QuestionID = 57, ChapterID = 6, QuestionName = "What type of diagram shows planned and actual project schedule information?", Answer = 'c' });
                addItem(new Question() { QuestionID = 58, ChapterID = 6, QuestionName = "____ is a network diagramming technique used to predict total project duration.", Answer = 'c' });
                addItem(new Question() { QuestionID = 59, ChapterID = 6, QuestionName = "Which of the following statements is false?", Answer = 'd' });
                addItem(new Question() { QuestionID = 60, ChapterID = 6, QuestionName = "____ is a method of scheduling that considers limited resources when creating a project schedule and includes buffers to protect the project completion date.", Answer = 'd' });
                #endregion

                #region Chapter Seven
                addItem(new Question() { QuestionID = 61, ChapterID = 7, QuestionName = "Accountants usually define ____ as a resource sacrificed or foregone to achieve a specific objective or something given up in exchange.", Answer = 'd' });
                addItem(new Question() { QuestionID = 62, ChapterID = 7, QuestionName = "What is the main goal of project cost management?", Answer = 'b' });
                addItem(new Question() { QuestionID = 63, ChapterID = 7, QuestionName = "Which of the following is not an output of the project cost management process called estimating costs, according to the PMBOK® Guide?", Answer = 'b' });
                addItem(new Question() { QuestionID = 64, ChapterID = 7, QuestionName = "If a company loses $5 for every $100 in revenue for a certain product, what is the profit margin for that product?", Answer = 'a' });
                addItem(new Question() { QuestionID = 65, ChapterID = 7, QuestionName = "____ reserves allow for future situations that are unpredictable", Answer = 'c' });
                addItem(new Question() { QuestionID = 66, ChapterID = 7, QuestionName = "You are preparing a cost estimate for a building based on its location, purpose, number of square feet, and other characteristics. What cost-estimating technique are you using?", Answer = 'a' });
                addItem(new Question() { QuestionID = 67, ChapterID = 7, QuestionName = "____ involves allocating the project cost estimate to individual material resources or work items over time.", Answer = 'c' });
                addItem(new Question() { QuestionID = 68, ChapterID = 7, QuestionName = "____ is a project performance measurement technique that integrates scope, time, and cost data.", Answer = 'd' });
                addItem(new Question() { QuestionID = 69, ChapterID = 7, QuestionName = "If the actual cost for a WBS item is $1,500 and its earned value is $2,000, what is its cost variance, and is it under or over budget?", Answer = 'd' });
                addItem(new Question() { QuestionID = 70, ChapterID = 7, QuestionName = "If a project is halfway completed, its schedule performance index is 110 percent, and its cost performance index is 95 percent, how is it progressing?", Answer = 'b' });
                #endregion
            }
        }

        public void addItem(Question newItem)
        {
            connection.Open();
            command = new SQLiteCommand("INSERT INTO " + QUESTIONS + " (questionID, chapterID, question, answer) VALUES (@questionID, @chapterID, @question, @answer)", connection);
            command.Parameters.Add("@questionID", DbType.Int32).Value = newItem.QuestionID;
            command.Parameters.Add("@chapterID", DbType.Int32).Value = newItem.ChapterID;
            command.Parameters.Add("@question", DbType.String).Value = newItem.QuestionName;
            command.Parameters.Add("@answer", DbType.String).Value = newItem.Answer;
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

        public List<Question> getAllItems()
        {
            var questions = new List<Question>();
            connection.Open();
            command = new SQLiteCommand("SELECT * FROM " + QUESTIONS, connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var q = new Question();
                    q.QuestionID = Convert.ToInt32(reader["questionID"]);
                    q.ChapterID = Convert.ToInt32(reader["chapterID"]);
                    q.QuestionName = reader["question"].ToString();
                    q.Answer = Convert.ToChar(reader["answer"]);
                    q.IsAnswered = false;
                    questions.Add(q);
                }
            }
            connection.Close();
            return questions;
        }

        //public void DeleteProgram(string name)
        //{
        //    connection.Open();
        //    command = new SQLiteCommand("DELETE FROM launcher WHERE name=@name", connection);
        //    command.Parameters.Add("@name", DbType.String).Value = name;
        //    try
        //    {
        //        command.ExecuteNonQuery();
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        connection.Close();
        //        throw new Exception(ex.Message);
        //    }
        //}
    }
}
