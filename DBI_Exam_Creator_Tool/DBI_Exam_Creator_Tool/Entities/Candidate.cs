﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class Candidate
    {
        public int CandidateId { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public string QuestionType { get; set; }
        public string ImageData { get; set; }
        public List<Requirement> Requirements { get; set; }

        public Candidate()
        {
            Requirements = new List<Requirement>();
        }

        public Candidate(int candidateId, int questionId, string content, string questionType, string iamgedata, List<Requirement> requirements)
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
