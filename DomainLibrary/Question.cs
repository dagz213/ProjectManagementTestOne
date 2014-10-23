using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLibrary
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int ChapterID { get; set; }
        public string QuestionName { get; set; }
        public char Answer { get; set; }
        public bool IsAnswered { get; set; }
    }
}
