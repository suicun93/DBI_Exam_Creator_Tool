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


        public static Dictionary<string, int> QuestionTypes()
        {
            return new Dictionary<string, int> {
                { QuestionType.QUERY, 1 },
                { QuestionType.PROCUDURE, 2 },
                { QuestionType.TRIGGER, 3 }
            };
        }

        public static Dictionary<string, int> RequirementTypes()
        {
            return new Dictionary<string, int>
            {
                { RequirementType.RESULT_SET, 1 },
                { RequirementType.EFFECT, 2 }
            };
        }

        public class Size
        {
            public const int IMAGE_WIDTH = 680;
        }
    }
}
