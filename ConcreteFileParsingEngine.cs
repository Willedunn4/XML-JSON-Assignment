using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML___JSON_Assignment
{
    public class ConcreteFileParsingEngine : FileParsingEngine
    {
        public ConcreteFileParsingEngine(IFileParser parser) : base(parser)
        {
        }

        public override void ParseFile(string filePath)
        {
            try
            {
                _parser.Parse(filePath);
                // Code to process parsed data
                string processedData = "Processed Data"; // Replace with actual processed data
                WriteToOutput(processedData, Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + "_out.txt"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing file: {ex.Message}");
            }
        }
    }
}
