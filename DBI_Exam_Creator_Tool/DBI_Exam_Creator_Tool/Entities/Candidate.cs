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
        public string ImageData { get; set; }

        public string Solution { get; set; }
        public string ActivateQuery { get; set; }
        public List<Requirement> Requirements { get; set; }

        public Candidate()
        {
            QuestionType = QuestionTypes.Select;
            Requirements = new List<Requirement>();
        }

        public Candidate(string candidateId, string questionId, string content, QuestionTypes questionType, string iamgedata, List<Requirement> requirements)
        {
            CandidateId = candidateId;
            QuestionId = questionId;
            Content = content;
            QuestionType = questionType;
            ImageData = iamgedata;
            Requirements = requirements;
        }

        public override bool Equals(object obj)
        {
            var candidate = obj as Candidate;
            return candidate != null &&
                   CandidateId == candidate.CandidateId &&
                   QuestionId == candidate.QuestionId;
        }
    }
}
