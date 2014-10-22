using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerLibrary.interfaces;
using DomainLibrary;

namespace ControllerLibrary
{
    public class QuestionsController : DBHandler, IRepository<Question, int>
    {
        public QuestionsController()
        {
            //Populate Questions
        }
    }
}
