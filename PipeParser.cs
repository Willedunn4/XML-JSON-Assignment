using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML___JSON_Assignment
{
    public class PipeParser : IFileParser
    {
        public void Parse(string filePath)
        {
            // Code to parse Pipe-delimited file
            Console.WriteLine($"Parsing Pipe-delimited file: {filePath}");
        }
    }
}
