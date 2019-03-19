using System;
using System.Collections.Generic;
using System.IO;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Utils;

namespace DBI_Exam_Creator_Tool.Model
{
    class PaperModel
    {
        public string Path { get; set; }
        public ShufflePaperModel Spm { get; set; }
        public string FirstPagePath { get; set; }

        public void CreateTests()
        {

            //Remove Illustration in PaperSet
            PaperSet paperSet = Spm.PaperSet.CloneObjectSerializable<PaperSet>();

            //Saving Question Set
            QuestionSet tmpQuestionSet = paperSet.QuestionSet.CloneObjectSerializable<QuestionSet>();

            foreach (var paper in paperSet.Papers)
            {
                foreach (var candidate in paper.CandidateSet)
                {
                    candidate.Illustration = new List<string>();
                }
            }
            //Adding Illustration into QuestionSet
            paperSet.QuestionSet = tmpQuestionSet;

            //Remove Duplicated database
            paperSet.QuestionSet.DBScriptList = new List<string>();

            //Export PaperSet.dat
            SerializeUtils.WriteJson(paperSet, Path + @"\PaperSet.dat");


            //Count PaperNo
            int countPaperNo = 0;

            //Write Paper Image
            try
            {
                foreach (Paper paper in Spm.PaperSet.Papers)
                {
                    string paperPath = FileUtils.CreateNewDirectory(Path, (++countPaperNo).ToString("D2"));

                    //Write DbScript
                    string givenPath = FileUtils.CreateNewDirectory(paperPath, "Given");
                    File.WriteAllText(givenPath + @"\DBscript" + ".sql", Spm.PaperSet.DBScriptList[0]);

                    //Create word file
                    ExportDocUtils.ExportDoc(paper, paperPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int MaxNumberOfTests(List<Question> questionsBank)
        {
            int count = 1;
            foreach (Question question in questionsBank)
            {
                if (question == null || question.Candidates.Count == 0)
                {
                    continue;
                }
                count *= question.Candidates.Count;
            }
            if ((count) < 1) count = 1;
            return count;
        }
    }
}
