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
        private string fileRelPath = "../../prog_settings/";
        private string fileName;
        public TextWriter(){}

        public TextWriter(string fileName)
        {
            this.fileName = fileName.Trim();
        }
        public void setFileName(string fileName)
        {
            this.fileName = fileName.Trim();
        }

        public void writeContent(string content)
        {
            if (fileName == null)
            {
                Console.Error.WriteLine("File name not set");
            }
            else
            {
                File.WriteAllText(fileRelPath + fileName, content);
            }
        }
    }
}