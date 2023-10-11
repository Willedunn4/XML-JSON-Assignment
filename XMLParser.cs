using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML___JSON_Assignment
{
    public class XMLParser : IFileParser
    {
        public void Parse(string filePath)
        {
            // Code to parse XML file
            Console.WriteLine($"Parsing XML file: {filePath}");
        }
    }
}
