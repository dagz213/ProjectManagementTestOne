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
    public class AnswersController : DBHandler, IRepository<Answer, int>
    {
        public AnswersController()
        {
            if (!CheckIfPopulated(ANSWERS))
            {
                #region Chapter One Questions 1- 10
                addItem(new Answer() { AnswerID = 1, QuestionID = 1, AnswerOne = "10 percent", AnswerTwo = "25 percent", 
                    AnswerThree = "50 percent", AnswerFour = "75 percent", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 2, QuestionID = 2, AnswerOne = "Shorter development times", AnswerTwo = "Higher worker morale", 
                    AnswerThree = "Lower cost of capital", AnswerFour = "Higher profit margins", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 3, QuestionID = 3, AnswerOne = "program", AnswerTwo = "process", 
                    AnswerThree = "project", AnswerFour = "portfolio", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 4, QuestionID = 4, AnswerOne = "projects are unique", AnswerTwo = "projects are developed using progressive elaboration", 
                    AnswerThree = "projects have a primary customer or sponsor", AnswerFour = "projects involve little uncertainty", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 5, QuestionID = 5, AnswerOne = "meeting scope goals", AnswerTwo = "meeting time goals", 
                    AnswerThree = "meeting communications goals", AnswerFour = "meeting cost goals", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 6, QuestionID = 6, AnswerOne = "Project management", AnswerTwo = "Program management", 
                    AnswerThree = "Project portfolio management", AnswerFour = "Requirements management", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 7, QuestionID = 7, AnswerOne = "strategic, tactical", AnswerTwo = "tactical, strategic",
                    AnswerThree = "internal, external", AnswerFour = "external, internal" , AnswerFive = ""});
                addItem(new Answer() { AnswerID = 8, QuestionID = 8, AnswerOne = "portfolio", AnswerTwo = "program", 
                    AnswerThree = "investment", AnswerFour = "collaborative", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 9, QuestionID = 9, AnswerOne = "Most American companies have a project management office.", AnswerTwo = "You can earn an advanced degree in project management from hundreds of colleges and universities.", 
                    AnswerThree = "Employers are looking for project management skills in new graduates", AnswerFour = "IT hiring managers reported that project management certification did not affect starting pay.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 10, QuestionID = 10, AnswerOne = "Certified Project Manager (CPM)", AnswerTwo = "Project Management Professional (PMP)", 
                    AnswerThree = "Project Management Expert (PME)", AnswerFour = "Project Management Mentor (PMM)", AnswerFive = "" });
                #endregion

                #region Chapter Two Questions 11 - 20
                addItem(new Answer() { AnswerID = 11, QuestionID = 11, AnswerOne = "business", AnswerTwo = "information", 
                    AnswerThree = "technology", AnswerFour = "organization", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 12, QuestionID = 12, AnswerOne = "structural", AnswerTwo = "human resources", 
                    AnswerThree = "political", AnswerFour = "symbolic", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 13, QuestionID = 13, AnswerOne = "functional", AnswerTwo = "project", 
                    AnswerThree = "matrix", AnswerFour = "hybrid", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 14, QuestionID = 14, AnswerOne = "member identity", AnswerTwo = "group emphasis", 
                    AnswerThree = "risk tolerance", AnswerFour = "control", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 15, QuestionID = 15, AnswerOne = "deliverable", AnswerTwo = "product", 
                    AnswerThree = "work package", AnswerFour = "tangible goal", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 16, QuestionID = 16, AnswerOne = "An analysis project life cycle is a collection of project phases.", AnswerTwo = "A product life cycle is the same as a project life cycle", 
                    AnswerThree = "The waterfall approach is an example of a predictive life cycle model.", AnswerFour = "Agile is an example of an adaptive life cycle model.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 17, QuestionID = 17, AnswerOne = "systems development life cycle", AnswerTwo = "rapid application development", 
                    AnswerThree = "predictive life cycle", AnswerFour = "extreme programming", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 18, QuestionID = 18, AnswerOne = "expensive", AnswerTwo = "technical", 
                    AnswerThree = "diverse", AnswerFour = "challenging", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 19, QuestionID = 19, AnswerOne = "globalization", AnswerTwo = "offshoring", 
                    AnswerThree = "exporting", AnswerFour = "global sourcing", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 20, QuestionID = 20, AnswerOne = "Extreme programming", AnswerTwo = "Sprint", 
                    AnswerThree = "Six sigma", AnswerFour = "Scrum", AnswerFive = "" });
                #endregion

                #region Chapter Three Questions 21 - 30
                addItem(new Answer() { AnswerID = 21, QuestionID = 21, AnswerOne = "goal", AnswerTwo = "process", 
                    AnswerThree = "plan", AnswerFour = "project", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 22, QuestionID = 22, AnswerOne = "Initiating", AnswerTwo = "Planning", 
                    AnswerThree = "Executing", AnswerFour = "Monitoring and controlling", AnswerFive = "Closing" });
                addItem(new Answer() { AnswerID = 23, QuestionID = 23, AnswerOne = "Initiating", AnswerTwo = "Planning", 
                    AnswerThree = "Executing", AnswerFour = "Monitoring and controlling", AnswerFive = "Closing" });
                addItem(new Answer() { AnswerID = 24, QuestionID = 24, AnswerOne = "Six Sigma", AnswerTwo = "RUP", 
                    AnswerThree = "PMBOK® Guide", AnswerFour = "PRINCE2", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 25, QuestionID = 25, AnswerOne = "stakeholder register", AnswerTwo = "business case", 
                    AnswerThree = "project charter", AnswerFour = "kick-off meeting", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 26, QuestionID = 26, AnswerOne = "Initiating", AnswerTwo = "Planning", 
                    AnswerThree = "Executing", AnswerFour = "Monitoring and controlling", AnswerFive = "Closing" });
                addItem(new Answer() { AnswerID = 27, QuestionID = 27, AnswerOne = "integration", AnswerTwo = "scope", 
                    AnswerThree = "communications", AnswerFour = "risk", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 28, QuestionID = 28, AnswerOne = "Initiating", AnswerTwo = "Planning", 
                    AnswerThree = "Executing", AnswerFour = "Monitoring and controlling", AnswerFive = "Closing" });
                addItem(new Answer() { AnswerID = 29, QuestionID = 29, AnswerOne = "The project has unclear up-front requirements.", AnswerTwo = "The project team is inexperienced and dispersed.", 
                    AnswerThree = "Large risks are involved.", AnswerFour = "The completion date is fairly rigid.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 30, QuestionID = 30, AnswerOne = "methodologies", AnswerTwo = "templates", 
                    AnswerThree = "project management software", AnswerFour = "standards", AnswerFive = "" });
                #endregion

                #region Chapter Four Questions 31 - 40
                addItem(new Answer() { AnswerID = 31, QuestionID = 31, AnswerOne = "developing the project business case", AnswerTwo = "developing the project charter", 
                    AnswerThree = "developing the project management plan", AnswerFour = "closing the project or phase", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 32, QuestionID = 32, AnswerOne = "IT strategy planning", AnswerTwo = "business area analysis", 
                    AnswerThree = "mind mapping", AnswerFour = "resource allocation", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 33, QuestionID = 33, AnswerOne = "aligning projects and resources with business strategy", AnswerTwo = "selecting projects that will take less than two years to provide payback", 
                    AnswerThree = "focusing on customer needs in identifying projects", AnswerFour = "assigning project managers to lead projects", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 34, QuestionID = 34, AnswerOne = "problem", AnswerTwo = "opportunity", 
                    AnswerThree = "directive", AnswerFour = "regulation", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 35, QuestionID = 35, AnswerOne = "$20,000", AnswerTwo = "$120,000", 
                    AnswerThree = "20 percent", AnswerFour = "120 percent", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 36, QuestionID = 36, AnswerOne = "project charter", AnswerTwo = "contract", 
                    AnswerThree = "business case", AnswerFour = "project management plan", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 37, QuestionID = 37, AnswerOne = "the name of the project manager", AnswerTwo = "budget information", 
                    AnswerThree = "stakeholder signatures", AnswerFour = "a Gantt chart", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 38, QuestionID = 38, AnswerOne = "Configuration management", AnswerTwo = "Integrated change control", 
                    AnswerThree = "Integration management", AnswerFour = "A change control board", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 39, QuestionID = 39, AnswerOne = "use good configuration management", AnswerTwo = "minimize change", 
                    AnswerThree = "establish a formal change control system", AnswerFour = "view project management as a process of constant communication and negotiation", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 40, QuestionID = 40, AnswerOne = "project management software", AnswerTwo = "templates", 
                    AnswerThree = "expert judgment", AnswerFour = "all of the above", AnswerFive = "" });
                #endregion

                #region Chapter Five Questions 41 - 50
                addItem(new Answer() { AnswerID = 41, QuestionID = 41, AnswerOne = "Deliverables", AnswerTwo = "Milestones", 
                    AnswerThree = "Scope", AnswerFour = "Product development", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 42, QuestionID = 42, AnswerOne = "interviews", AnswerTwo = "focus groups", 
                    AnswerThree = "surveys", AnswerFour = "observation", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 43, QuestionID = 43, AnswerOne = "scope statement", AnswerTwo = "WBS", 
                    AnswerThree = "WBS dictionary", AnswerFour = "work package", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 44, QuestionID = 44, AnswerOne = "top-down", AnswerTwo = "bottom-up", 
                    AnswerThree = "analogy", AnswerFour = "mind mapping", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 45, QuestionID = 45, AnswerOne = "0", AnswerTwo = "1", 
                    AnswerThree = "2", AnswerFour = "3", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 46, QuestionID = 46, AnswerOne = "Keep the scope realistic.", AnswerTwo = "Use off-the-shelf hardware and software whenever possible", 
                    AnswerThree = "Follow good project management processes.", AnswerFour = "Don’t involve too many users in scope management.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 47, QuestionID = 47, AnswerOne = "The company found a better technology.", AnswerTwo = "The company decided to outsource the work.", 
                    AnswerThree = "The scope was too much to handle.", AnswerFour = "The government requirement that prompted the project was repealed.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 48, QuestionID = 48, AnswerOne = "acceptance", AnswerTwo = "validation", 
                    AnswerThree = "completion", AnswerFour = "close-out", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 49, QuestionID = 49, AnswerOne = "Develop a good project selection process for IT projects.", AnswerTwo = "Have users on the project team.", 
                    AnswerThree = "Co-locate users with developers", AnswerFour = "Only have meetings as needed, not on a regular basis.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 50, QuestionID = 50, AnswerOne = "project plan", AnswerTwo = "schedule", 
                    AnswerThree = "WBS", AnswerFour = "deliverable", AnswerFive = "" });
                #endregion

                #region Chapter Six Questions 51 - 60
                addItem(new Answer() { AnswerID = 51, QuestionID = 51, AnswerOne = "planning schedule management", AnswerTwo = "defining activities", 
                    AnswerThree = "estimating activity resources", AnswerFour = "activity sequencing", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 52, QuestionID = 52, AnswerOne = "items in an activity list", AnswerTwo = "items on a Gantt chart", 
                    AnswerThree = "milestone attributes", AnswerFour = "activity attributes", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 53, QuestionID = 53, AnswerOne = "technical", AnswerTwo = "mandatory", 
                    AnswerThree = "discretionary", AnswerFour = "external", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 54, QuestionID = 54, AnswerOne = "finish-to-start", AnswerTwo = "start-to-start", 
                    AnswerThree = "finish-to-finish", AnswerFour = "start-to-finish", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 55, QuestionID = 55, AnswerOne = "A resource breakdown structure is a hierarchical structure that identifies the project’s resources by category and type.", AnswerTwo = "Duration and effort are synonymous terms.", 
                    AnswerThree = "A three-point estimate includes an optimistic, most likely, and pessimistic estimate.", AnswerFour = "A Gantt chart is a common tool for displaying project schedule information.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 56, QuestionID = 56, AnswerOne = "a black arrow", AnswerTwo = "a white arrow", 
                    AnswerThree = "a black diamond", AnswerFour = "a white diamond", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 57, QuestionID = 57, AnswerOne = "a network diagram", AnswerTwo = "a Gantt chart",
                    AnswerThree = "a Tracking Gantt chart", AnswerFour = "a milestone chart", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 58, QuestionID = 58, AnswerOne = "PERT", AnswerTwo = "A Gantt chart", 
                    AnswerThree = "Critical path method", AnswerFour = "Crashing", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 59, QuestionID = 59, AnswerOne = "Growing grass was on the critical path for a large theme park project.", AnswerTwo = "The critical path is the series of activities that determine the earliest time by which a project can be completed.", 
                    AnswerThree = "A forward pass through a project network diagram determines the early start and early finish dates for each activity.", AnswerFour = "Fast tracking is a technique for making cost and schedule trade-offs to obtain the greatest amount of schedule compression for the least incremental cost.", AnswerFive = "" });
                addItem(new Answer() { AnswerID = 60, QuestionID = 60, AnswerOne = "Parkinson’s Law", AnswerTwo = "Murphy’s Law", 
                    AnswerThree = "Critical path analysis", AnswerFour = "Critical chain scheduling", AnswerFive = "" });
                #endregion

                #region Chapter Seven Questions 61 - 70
                addItem(new Answer() { AnswerID = 61, QuestionID = 61, AnswerOne = "money", AnswerTwo = "liability", 
                    AnswerThree = "trade", AnswerFour = "cost", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 62, QuestionID = 62, AnswerOne = "to complete a project for as little cost as possible", AnswerTwo = "to complete a project within an approved budget", 
                    AnswerThree = "to provide truthful and accurate cost information on projects", AnswerFour = "to ensure that an organization’s money is used wisely", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 63, QuestionID = 63, AnswerOne = "activity cost estimates", AnswerTwo = "a cost baseline",
                    AnswerThree = "basis of estimates", AnswerFour = "project documents updates", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 64, QuestionID = 64, AnswerOne = "-5 percent", AnswerTwo = "5 percent", 
                    AnswerThree = "-$5", AnswerFour = "$5", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 65, QuestionID = 65, AnswerOne = "Contingency", AnswerTwo = "Financial", 
                    AnswerThree = "Management", AnswerFour = "Baseline", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 66, QuestionID = 66, AnswerOne = "parametric", AnswerTwo = "analogous", 
                    AnswerThree = "bottom-up", AnswerFour = "top-down", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 67, QuestionID = 67, AnswerOne = "Reserve analysis", AnswerTwo = "Life cycle costing", 
                    AnswerThree = "Project cost budgeting", AnswerFour = "Earned value analysis", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 68, QuestionID = 68, AnswerOne = "Reserve analysis", AnswerTwo = "Life cycle costing", 
                    AnswerThree = "Project cost budgeting", AnswerFour = "Earned value management", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 69, QuestionID = 69, AnswerOne = "The cost variance is -$500, which is over budget.", AnswerTwo = "The cost variance is -$500, which is under budget.", 
                    AnswerThree = "The cost variance is $500, which is over budget.", AnswerFour = "The cost variance is $500, which is under budget.", AnswerFive = "" });

                addItem(new Answer() { AnswerID = 70, QuestionID = 70, AnswerOne = "It is ahead of schedule and under budget.", AnswerTwo = "It is ahead of schedule and over budget.", 
                    AnswerThree = "It is behind schedule and under budget.", AnswerFour = "It is behind schedule and over budget.", AnswerFive = "" });
                #endregion
            }
        }

        public void addItem(Answer newItem)
        {
            connection.Open();
            command = new SQLiteCommand("INSERT INTO " + ANSWERS + " (answerID, questionID, answerone, answertwo, answerthree, answerfour, answerfive)  VALUES (@answerID, @questionID, @answerone, @answertwo, @answerthree, @answerfour,  @answerfive)", connection);
            command.Parameters.Add("@answerID", DbType.Int32).Value = newItem.AnswerID;
            command.Parameters.Add("@questionID", DbType.Int32).Value = newItem.QuestionID;
            command.Parameters.Add("@answerone", DbType.String).Value = newItem.AnswerOne;
            command.Parameters.Add("@answertwo", DbType.String).Value = newItem.AnswerTwo;
            command.Parameters.Add("@answerthree", DbType.String).Value = newItem.AnswerThree;
            command.Parameters.Add("@answerfour", DbType.String).Value = newItem.AnswerFour;
            command.Parameters.Add("@answerfive", DbType.String).Value = newItem.AnswerFive;
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

        public List<Answer> getAllItems()
        {
            throw new NotImplementedException();
        }
    }
}
