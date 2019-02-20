using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool.Helpers
{
    public class Utilities
    {
        public static List<string> QuestionTypes()
        {
            return new List<string> { Constants.QuestionType.QUERY,
                Constants.QuestionType.PROCUDURE,
                Constants.QuestionType.TRIGGER };
        }
    }
}
