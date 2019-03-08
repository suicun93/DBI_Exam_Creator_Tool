using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class Candidate
    {
        public enum QuestionTypes {
            Select = 1,
            Procedure = 2,
            Trigger = 3,
            Schema = 4,
            DML = 5
        }

        public string CandidateId { get; set; }
        public string QuestionId { get; set; }
        public string QuestionRequirement { get; set; }
        public QuestionTypes QuestionType { get; set; }

        public string Solution { get; set; }
        public string TestQuery { get; set; }
        
        public bool RequireSort { get; set; }
        public bool CheckColumnName { get; set; }

        public string DBName { get; set; }

        public List<string> Illustration { get; set; }

        //public List<Requirement> Requirements { get; set; }

        public Candidate()
        {
            QuestionType = QuestionTypes.Select;
            Illustration = new List<string>();
        }

        public Candidate(string candidateId, string questionId, string content, QuestionTypes questionType, List<string> images, string solution, string testQuery, bool requireSort, bool checkColumnName, string _DBName)
        {
            CandidateId = candidateId;
            QuestionId = questionId;
            QuestionRequirement = content;
            QuestionType = questionType;
            Illustration = images;
            Solution = solution;
            TestQuery = testQuery;
            RequireSort = requireSort;
            CheckColumnName = checkColumnName;
            DBName = _DBName;
        }

        public override bool Equals(object obj)
        {
            var candidate = obj as Candidate;
            return candidate != null &&
                   CandidateId == candidate.CandidateId;
        }
    }
}
