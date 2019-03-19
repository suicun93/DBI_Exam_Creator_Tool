using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    class Paper
    {
        public Paper(string paperNo, List<Candidate> candidateSet)
        {
            PaperNo = paperNo;
            CandidateSet = candidateSet;
        }
        public Paper()
        {
        }
        public string PaperNo { get; set; }
        public List<Candidate> CandidateSet { get; set; }
    }
}
