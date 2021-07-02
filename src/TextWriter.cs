using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_and_Maintenance_Management_System.src
{
    class TextWriter
    {
        private static string fileRelPath = "../../prog_logs/";
        private static string fileName;
        public TextWriter(){}

        public TextWriter(string name)
        {
            fileName = name.Trim();
        }
        public static void setFileName(string name)
        {
            fileName = name.Trim();
        }

        public static void writeContent(string fileName, string content)
        {
            if (fileName == null)
            {
                Console.Error.WriteLine("File name not set");
            }
            else
            {
                File.WriteAllText(fileRelPath + fileName, "[" + DateTime.Now.ToString() + "]:\n" + content);
            }
        }
    }
}