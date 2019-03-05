using System;
using System.Collections.Generic;
using System.IO;
using DBI_Exam_Creator_Tool.Entities;
using Newtonsoft.Json;

namespace DBI_Exam_Creator_Tool.Utils
{
    class SerializeUtils
    {
        /// <summary>
        /// Write to File
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool WriteJson(object obj, string path)
        {
            try
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(obj));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        /// <param name="localPath"></param>
        /// <returns></returns>
        public static List<Question> DeserializeJson(String localPath)
        {
            // read file into a string and deserialize JSON to a type
            return JsonConvert.DeserializeObject<List<Question>>(File.ReadAllText(localPath));
        }
    }
}
