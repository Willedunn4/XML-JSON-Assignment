using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML___JSON_Assignment
{
    public class JSONParser : IFileParser
    {
        public void Parse(string filePath)
        {
            // Code to parse JSON file
            Console.WriteLine($"Parsing JSON file: {filePath}");
        }
    }
}
