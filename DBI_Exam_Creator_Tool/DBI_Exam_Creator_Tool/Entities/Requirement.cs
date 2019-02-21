using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class Requirement
    {
        public enum Types
        {
            ResultSet = 1,
            Effect = 2
        }

        public int RequirementId { get; set; }
        public int CandidateId { get; set; }
        public int Type { get; set; }

        public string ResultQuery { get; set; }
        public bool RequireSort { get; set; }

        public string EffectTable { get; set; }
        public string CheckEffectQuery { get; set; }
        public string TriggerTriggerQuery { get; set; }

        public Requirement()
        {
            Type = (int)Types.ResultSet;
        }

        public Requirement(int requirementId, int candidateId, int type, string resultQuery, bool requireSort, string effectTable, string checkEffectQuery, string triggerTriggerQuery)
        {
            RequirementId = requirementId;
            CandidateId = candidateId;
            Type = type;
            ResultQuery = resultQuery;
            RequireSort = requireSort;
            EffectTable = effectTable;
            CheckEffectQuery = checkEffectQuery;
            TriggerTriggerQuery = triggerTriggerQuery;
        }

        public override bool Equals(object obj)
        {
            var requirement = obj as Requirement;
            return requirement != null &&
                   RequirementId == requirement.RequirementId &&
                   CandidateId == requirement.CandidateId;
        }
    }
}
