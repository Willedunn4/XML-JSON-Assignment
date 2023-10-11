using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML___JSON_Assignment
{
    public abstract class FileParsingEngine
    {
        protected IFileParser _parser;

        public FileParsingEngine(IFileParser parser)
        {
            _parser = parser;
        }

        public abstract void ParseFile(string filePath);

        public void WriteToOutput(string data, string outputFile)
        {
            try
            {
                File.WriteAllText(outputFile, data);
                Console.WriteLine($"Data written to {outputFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to output file: {ex.Message}");
            }
        }
    }
}
