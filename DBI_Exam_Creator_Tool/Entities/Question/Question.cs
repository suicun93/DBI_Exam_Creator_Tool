﻿using System;
using System.Collections.Generic;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class Question
    {
        public Question()
        {
            Candidates = new List<Candidate>();
        }

        public Question(string questionId, decimal point, List<Candidate> candidates)
        {
            QuestionId = questionId;
            Point = point;
            foreach (var candidate in candidates)
                candidate.Point = decimal.ToDouble(point);
            Candidates = candidates;
        }

        public string QuestionId { get; set; }
        public decimal Point { get; set; }
        public List<Candidate> Candidates { get; set; }

        public override bool Equals(object obj)
        {
            var question = obj as Question;
            return question != null &&
                   QuestionId == question.QuestionId;
        }
    }
}