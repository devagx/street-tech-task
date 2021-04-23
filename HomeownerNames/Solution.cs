using System;

namespace HomeownerNames
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting CSV Parser Application...");
            Console.WriteLine("Please enter full path to CSV file:");
            string filePath = Console.ReadLine();
            CsvParser parser = new CsvParser(filePath);
            parser.ProcessAllLines();

            foreach (var person in parser.People)
            {
                Console.WriteLine("Title = " + person.Title);
                Console.WriteLine("FirstName = " + person.FirstName);
                Console.WriteLine("Initial = " + person.Initial);
                Console.WriteLine("LastName = " + person.LastName);
            }
        }
    }
}
