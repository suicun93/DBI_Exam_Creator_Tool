using System;
using System.Collections.Generic;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class Question
    {
        public string QuestionId { get; set; }
        public double Point { get; set; }
        public List<Candidate> Candidates { get; set; }

        public Question()
        {
            Candidates = new List<Candidate>();
        }

        public Question(string questionId, double point, List<Candidate> candidates)
        {
            QuestionId = questionId;
            Point = point;
            Candidates = candidates;
        }

        public override bool Equals(object obj)
        {
            var question = obj as Question;
            return question != null &&
                   QuestionId == question.QuestionId;
        }
    }
}
