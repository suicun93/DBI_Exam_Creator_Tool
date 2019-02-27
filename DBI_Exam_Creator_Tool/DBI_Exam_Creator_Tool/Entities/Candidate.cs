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
        public string Content { get; set; }
        public QuestionTypes QuestionType { get; set; }
        public List<string> Images { get; set; }

        public string Solution { get; set; }
        public string ActivateQuery { get; set; }

        public bool ResultSet { get; set; }
        public bool RequireSort { get; set; }
        public bool Effect { get; set; }

        //public List<Requirement> Requirements { get; set; }

        public Candidate()
        {
            QuestionType = QuestionTypes.Select;
            Images = new List<string>();
        }

        public Candidate(string candidateId, string questionId, string content, QuestionTypes questionType, List<string> images, string solution, string activateQuery, bool resultSet, bool requireSort, bool effect)
        {
            CandidateId = candidateId;
            QuestionId = questionId;
            Content = content;
            QuestionType = questionType;
            Images = images;
            Solution = solution;
            ActivateQuery = activateQuery;
            ResultSet = resultSet;
            RequireSort = requireSort;
            Effect = effect;
        }

        public override bool Equals(object obj)
        {
            var candidate = obj as Candidate;
            return candidate != null &&
                   CandidateId == candidate.CandidateId;
        }
    }
}
