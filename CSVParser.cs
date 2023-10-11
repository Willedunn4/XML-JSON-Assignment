using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;


namespace XML___JSON_Assignment
{
    public class CSVParser : IFileParser
    {
        public void Parse(string filePath)
        {
            // Code to parse CSV file
            Console.WriteLine($"Parsing CSV file: {filePath}");
        }
    }
}
