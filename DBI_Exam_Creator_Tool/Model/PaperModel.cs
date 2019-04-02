using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Utils;

namespace DBI_Exam_Creator_Tool.Model
{
    internal class PaperModel
    {
        public string Path { get; set; }
        public ShufflePaperModel Spm { get; set; }
        public string FirstPagePath { get; set; }

        public void CreateTests()
        {
            //Remove Illustration in PaperSet
            var paperSet = Spm.PaperSet.CloneObjectSerializable<PaperSet>();
            IFormatter formatter = new BinaryFormatter();

            //Saving Question Set
            var tmpQuestionSet = paperSet.QuestionSet.CloneObjectSerializable<QuestionSet>();

            foreach (var paper in paperSet.Papers)
                foreach (var candidate in paper.CandidateSet)
                    candidate.Illustration = new List<string>();
            //Adding Illustration into QuestionSet
            paperSet.QuestionSet = tmpQuestionSet;

            //Remove Duplicated database
            paperSet.QuestionSet.DBScriptList = new List<string>();

            // Export PaperSet.dat
            //SerializeUtils.WriteJson(paperSet, Path + @"\PaperSet.dat");
            //  Binary
            using (var stream = new FileStream(Path + @"\PaperSet.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, paperSet);
            }

            //Count PaperNo
            var countPaperNo = 0;

            //Write Paper Image
            try
            {
                foreach (var paper in Spm.PaperSet.Papers)
                {
                    var paperPath = FileUtils.CreateNewDirectory(Path, (++countPaperNo).ToString("D2"));

                    //Write DbScript
                    var givenPath = FileUtils.CreateNewDirectory(paperPath, "Given");
                    File.WriteAllText(givenPath + @"\DBscript" + ".sql", Spm.PaperSet.DBScriptList[0]);

                    //Create word file
                    ExportDocUtils.ExportDoc(paper, paperPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int MaxNumberOfTests(List<Question> questionsBank)
        {
            var count = 1;
            foreach (var question in questionsBank)
            {
                if (question == null || question.Candidates.Count == 0)
                    continue;
                count *= question.Candidates.Count;
            }
            if (count < 1) count = 1;
            return count;
        }
    }
}