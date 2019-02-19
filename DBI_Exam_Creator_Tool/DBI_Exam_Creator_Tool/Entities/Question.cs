﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class Question
    {
        public int QuestionId { get; set; }
        public double Point { get; set; }
        public List<Candidate> Candidates { get; set; }

        public Question()
        {
            Candidates = new List<Candidate>();
        }

        public Question(int questionId, double point, List<Candidate> candidates)
        {
            QuestionId = questionId;
            Point = point;
            Candidates = candidates;
        }
    }
}
