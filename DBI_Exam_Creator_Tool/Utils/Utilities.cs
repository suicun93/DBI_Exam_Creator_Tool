using System;
using System.IO;
using System.Drawing;

namespace DBI_Exam_Creator_Tool.Utils
{
    public class Utilities
    {
        public static Image Base64StringToImage(string inputString)
        {
            Image img = null;

            byte[] imageBytes = Convert.FromBase64String(inputString);

            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                img = Image.FromStream(ms, true);
                ms.Close();
                imageBytes = null;
            }
            return img;
        }

        public static string ImageToBase64(string filePath)
        {
            using (Image image = Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }
    }
}
