using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLibrary;

namespace ControllerLibrary.interfaces
{
    public interface IAnswerRepository : IRepository<Answer, int>
    {
        Answer getAnswerByQuestionID(int questionID);
    }
}
