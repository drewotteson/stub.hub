using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubHub
{
    public class FileRead
    {
        public string fileName;

        public string ReadFrom(string fileName)
        {
            StreamReader read = new StreamReader(fileName);
            string text = read.ReadToEnd();
            read.Close();
            return text;
        }
    }
}
