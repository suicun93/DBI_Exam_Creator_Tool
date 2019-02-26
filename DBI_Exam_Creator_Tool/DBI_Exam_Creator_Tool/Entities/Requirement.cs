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
        public enum RequirementTypes
        {
            ResultSet = 1,
            Effect = 2,
            Calculation = 3
        }

        public int RequirementId { get; set; }
        public string CandidateId { get; set; }
        public RequirementTypes Type { get; set; }

        public string ResultQuery { get; set; }
        public bool RequireSort { get; set; }

        public string EffectTable { get; set; }
        public string CheckEffectQuery { get; set; }
        public string ActivateTriggerQuery { get; set; }

        public string OutputParameter { get; set; }

        public Requirement()
        {
            Type = RequirementTypes.ResultSet;
        }

        public Requirement(int requirementId, string candidateId, RequirementTypes type, string resultQuery, bool requireSort, string effectTable, string checkEffectQuery, string activateTriggerQuery, string outputParameter)
        {
            RequirementId = requirementId;
            CandidateId = candidateId;
            Type = type;
            ResultQuery = resultQuery;
            RequireSort = requireSort;
            EffectTable = effectTable;
            CheckEffectQuery = checkEffectQuery;
            ActivateTriggerQuery = activateTriggerQuery;
            OutputParameter = outputParameter;
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
