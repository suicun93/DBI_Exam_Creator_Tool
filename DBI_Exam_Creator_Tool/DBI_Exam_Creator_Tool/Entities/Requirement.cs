using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBI_Exam_Creator_Tool.Entities
{
    class Requirement
    {
        public string RequirementId { get; set; }
        public int CandidateId { get; set; }
        public int Type { get; set; }

        public string ResultQuery { get; set; }

        public string EffectTable { get; set; }
        public string CheckEffectQuery { get; set; }

        public Requirement()
        {
        }

        public Requirement(string requirementId, int candidateId, int type, string resultQuery, string effectTable, string checkEffectQuery)
        {
            RequirementId = requirementId;
            CandidateId = candidateId;
            Type = type;
            ResultQuery = resultQuery;
            EffectTable = effectTable;
            CheckEffectQuery = checkEffectQuery;
        }
    }
}
