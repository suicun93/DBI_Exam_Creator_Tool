using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DBI_Exam_Creator_Tool.Entities
{
    [Serializable]
    public class QuestionSet
    {
        public List<Question> QuestionList { get; set; }
        public List<string> DBScriptList { get; set; }

        public QuestionSet()
        {
            QuestionList = new List<Question>();
            DBScriptList = new List<string>();
        }

        public QuestionSet(List<Question> questionList, List<string> dBScriptList)
        {
            QuestionList = questionList;
            DBScriptList = dBScriptList;
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
