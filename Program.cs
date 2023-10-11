using XML___JSON_Assignment;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the path of the file to process:");
        string filePath = Console.ReadLine(); // Read file path from user input

        if (File.Exists(filePath))
        {
            Console.WriteLine("Select the file type: ");
            Console.WriteLine("1. CSV");
            Console.WriteLine("2. Pipe");
            Console.WriteLine("3. XML");
            Console.WriteLine("4. JSON");

            int choice = int.Parse(Console.ReadLine());

            IFileParser parser;

            switch (choice)
            {
                case 1:
                    parser = new CSVParser();
                    break;
                case 2:
                    parser = new PipeParser();
                    break;
                case 3:
                    parser = new XMLParser();
                    break;
                case 4:
                    parser = new JSONParser();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Using CSV parser by default.");
                    parser = new CSVParser();
                    break;
            }

            FileParsingEngine engine = new ConcreteFileParsingEngine(parser);
            engine.ParseFile(filePath);
        }
        else
        {
            Console.WriteLine("File not found at the specified path.");
        }
    }
}