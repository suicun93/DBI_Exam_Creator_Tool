using DBI_Exam_Creator_Tool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Commons
{
    public static class Constants
    {
        public static string TypeToString(Candidate.QuestionTypes QuestionType)
        {
            switch (QuestionType)
            {
                case Candidate.QuestionTypes.Query:
                    return "Query";
                case Candidate.QuestionTypes.Procedure:
                    return "Procedure";
                case Candidate.QuestionTypes.Trigger:
                    return "Trigger";
                default:
                    return "";
            }
        }

        public static string TypeToString(Requirement.RequirementTypes requirement)
        {
            switch (requirement)
            {
                case Requirement.RequirementTypes.Effect:
                    return "Effect";
                case Requirement.RequirementTypes.ResultSet:
                    return "Result_Set";
                default:
                    return "";
            }
        }

        public static Dictionary<string, int> QuestionTypes()
        {
            return new Dictionary<string, int> {
                { TypeToString(Candidate.QuestionTypes.Query), 1 },
                { TypeToString(Candidate.QuestionTypes.Procedure), 2 },
                { TypeToString(Candidate.QuestionTypes.Trigger), 3 }
            };
        }

        public static Dictionary<string, int> RequirementTypes()
        {
            return new Dictionary<string, int> {
                { TypeToString(Requirement.RequirementTypes.ResultSet), 1 },
                { TypeToString(Requirement.RequirementTypes.Effect), 2 },
            };
        }

        public class Size
        {
            public const int IMAGE_WIDTH = 680;
        }
    }
}
