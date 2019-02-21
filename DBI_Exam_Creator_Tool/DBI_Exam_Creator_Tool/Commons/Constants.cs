using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Commons
{
    public static class Constants
    {

        public class QuestionType
        {
            public const string QUERY = "Query";
            public const string PROCUDURE = "Procedure";
            public const string TRIGGER = "Trigger";
        }

        public class RequirementType
        {
            public const string RESULT_SET = "Result Set";
            public const string EFFECT = "Effect";
        }


        public static List<string> QuestionTypes()
        {
            return new List<string> { Constants.QuestionType.QUERY,
                Constants.QuestionType.PROCUDURE,
                Constants.QuestionType.TRIGGER };
        }

        public static List<string> RequirementTypes()
        {
            return new List<string> { Constants.RequirementType.RESULT_SET,
                Constants.RequirementType.EFFECT };
        }

        public class Size
        {
            public const int IMAGE_WIDTH = 680;
        }
    }
}
