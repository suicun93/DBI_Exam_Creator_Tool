using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Entities
{
    class Candidate
    {
        public string CandidateId { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public int QuestionType { get; set; }
        public string ImageURL { get; set; }
        public List<Requirement> Requirements { get; set; }

        public Candidate()
        {
        }

        public Candidate(string candidateId, int questionId, string content, int questionType, string imageURL, List<Requirement> requirements)
        {
            CandidateId = candidateId;
            QuestionId = questionId;
            Content = content;
            QuestionType = questionType;
            ImageURL = imageURL;
            Requirements = requirements;
        }
    }
}
