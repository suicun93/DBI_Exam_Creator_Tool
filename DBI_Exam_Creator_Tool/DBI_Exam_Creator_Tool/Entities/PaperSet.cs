﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    class PaperSet
    {
        public List<Paper> Papers { get; set; }
        public List<string> DBScriptList { get; set; }
        public List<int> ListPaperMatrixId { get; set; }
        public QuestionSet QuestionSet { get; set; }


        public PaperSet() { }

        public PaperSet(List<Paper> papers, List<string> dBScriptList, List<int> listPaperMatrixId, QuestionSet questionSet)
        {
            Papers = papers;
            DBScriptList = dBScriptList;
            ListPaperMatrixId = listPaperMatrixId;
            QuestionSet = questionSet;
        }

        public T CloneObjectSerializable<T>() where T : class
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Position = 0;
            object result = bf.Deserialize(ms);
            ms.Close();
            return (T)result;
        }
    }
}