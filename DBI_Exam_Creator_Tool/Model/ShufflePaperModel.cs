using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBI_Exam_Creator_Tool.Commons;
using DBI_Exam_Creator_Tool.Entities;

namespace DBI_Exam_Creator_Tool.Model
{
    class ShufflePaperModel
    {
        public QuestionSet QuestionSet;//QBank from Creator
        public PaperSet PaperSet;//Include PaperSet after create 

        /// <summary>
        /// Create List of PaperSet
        /// </summary>
        /// <param name="questionSet"></param>
        /// <param name="numOfPage"></param>
        public ShufflePaperModel(QuestionSet questionSet, int numOfPage)
        {
            QuestionSet = questionSet;
            PaperSet = new PaperSet(new List<Paper>(), QuestionSet.DBScriptList, new List<int>(), QuestionSet);

            List<List<CandidateNode>> allCases = GetAllPaperCases();

            List<List<CandidateNode>> papersCandidateNode = new List<List<CandidateNode>>();

            if (Constants.PaperSet != null && Constants.PaperSet.ListPaperMatrixId != null && Constants.PaperSet.ListPaperMatrixId.Count > 0)
            {
                foreach (var paperId in Constants.PaperSet.ListPaperMatrixId)
                {
                    papersCandidateNode.Add(allCases.ElementAt(paperId));
                }
            }
            else
            {
                papersCandidateNode = GetRandomNElementsInList(numOfPage, allCases, PaperSet.ListPaperMatrixId);
            }

            //Adding Matrix Id
            foreach (var candidateNode in papersCandidateNode)
            {
                PaperSet.ListPaperMatrixId.Add(allCases.IndexOf(candidateNode));
            }


            //List<List<CandidateNode>> cases = new List<List<CandidateNode>>();
            //List<List<CandidateNode>> tmp = GetAllPaperCases();
            //List<CandidateNode> first = tmp.First();
            //List<CandidateNode> last = tmp.Last();
            //cases.Add(first);
            //cases.Add(last);
            //PaperSet.ListPaperMatrixId.Add(tmp.IndexOf(first));
            //PaperSet.ListPaperMatrixId.Add(tmp.IndexOf(last));

            //codeTestCount: for TestCode
            int codeTestCount = 0;
            //Adding candidate into Tests
            foreach (List<CandidateNode> c in papersCandidateNode)
            {
                List<Candidate> candidateList = new List<Candidate>();
                //Adding candidate into a Test

                foreach (var candidateNode in c)
                {
                    candidateList.Add(candidateNode.Candi);
                }
                var paper = new Paper
                {
                    PaperNo = (++codeTestCount).ToString(),
                    CandidateSet = candidateList
                };
                PaperSet.Papers.Add(paper);
            }
        }

        /// <summary>
        /// Get random elements in List
        /// </summary>
        /// <param name="numOfCases"></param>
        /// <param name="allCases"></param>
        /// <param name="listPaperMatrixId"></param>
        /// <returns></returns>
        private List<List<CandidateNode>> GetRandomNElementsInList(int numOfCases, List<List<CandidateNode>> allCases, List<int> listPaperMatrixId)
        {
            List<List<CandidateNode>> newList = new List<List<CandidateNode>>();
            int jump = (allCases.Count - 1) / (numOfCases - 1);

            for (int i = 0; i < numOfCases; i++)
            {
                int pos = jump * i;
                newList.Add(allCases.ElementAt(pos));
            }

            //Shuffle a list C# (Fisher-Yates shuffle)
            int n = numOfCases;
            while (n > 1)
            {
                n--;
                int k = new Random().Next(n + 1);
                List<CandidateNode> value = newList[k];
                newList[k] = newList[n];
                newList[n] = value;
            }
            
            return newList;
        }

        /// <summary>
        /// Add all cases of the tests
        /// </summary>
        /// <returns></returns>
        private List<List<CandidateNode>> GetAllPaperCases()
        {
            CandidateNode root = SetCandidateNode(null, 0, BuildingTree());
            root.AddPath(root, new List<CandidateNode>());
            return root.paths;
        }

        /// <summary>
        /// Building a tree of Candidates for generate all the cases
        /// </summary>
        /// <returns></returns>
        private int[] BuildingTree()
        {
            var quizs = new int[QuestionSet.QuestionList.Count];
            int i = 0;
            foreach (var question in QuestionSet.QuestionList)
            {
                quizs[i++] = question.Candidates.Count;
            }
            return quizs;
        }

        /// <summary>
        /// Set relation of all Nodes in the Tree
        /// </summary>
        /// <param name="value"></param>
        /// <param name="pos"></param>
        /// <param name="quizs"></param>
        /// <returns></returns>
        public CandidateNode SetCandidateNode(Candidate value, int pos, int[] quizs)
        {
            CandidateNode child = new CandidateNode
            {
                Candi = value
            };
            if (pos < quizs.Length)
            {
                foreach (var candi in QuestionSet.QuestionList.ElementAt(pos).Candidates)
                {
                    child.Children.Add(SetCandidateNode(candi, pos + 1, quizs));
                }
            }
            else
            {
                child.Children = null;
            }
            return child;
        }
    }
}
