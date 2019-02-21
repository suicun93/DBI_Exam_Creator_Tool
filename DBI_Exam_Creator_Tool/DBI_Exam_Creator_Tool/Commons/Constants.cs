using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBI_Exam_Creator_Tool.Entities;

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


        public static Dictionary<string, Candidate.QuestionTypes> QuestionTypes()
        {
            return new Dictionary<string, Candidate.QuestionTypes>
            {
                { QuestionType.QUERY, Candidate.QuestionTypes.Query },
                { QuestionType.PROCUDURE, Candidate.QuestionTypes.Procedure },
                { QuestionType.TRIGGER, Candidate.QuestionTypes.Trigger },
            };
        }

        public static Dictionary<string, Requirement.RequirementTypes> RequirementTypes()
        {
            return new Dictionary<string, Requirement.RequirementTypes>
            {
                { RequirementType.RESULT_SET, Requirement.RequirementTypes.ResultSet },
                { RequirementType.EFFECT, Requirement.RequirementTypes.Effect },
            };
        }

        public class Size
        {
            public const int IMAGE_WIDTH = 680;
        }
    }
}
