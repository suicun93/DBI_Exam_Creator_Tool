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
            Query = 1,
            Procedure = 2,
            Trigger = 3
        }

        public int CandidateId { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public int QuestionType { get; set; }
        public string ImageData { get; set; }
        public List<Requirement> Requirements { get; set; }

        public Candidate()
        {
            QuestionType = (int)QuestionTypes.Query;
            Requirements = new List<Requirement>();
        }

        public Candidate(int candidateId, int questionId, string content, int questionType, string iamgedata, List<Requirement> requirements)
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
