using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeownerNames
{
    public class CsvParser
    {
        private string[] csvLines;
        private string filePath;
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people; }
        }
        public CsvParser(string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("filePath");
            }
            if (filePath.Length == 0)
            {
                throw new ArgumentException("Zero-length string invalid", "filePath");
            }
            this.filePath = filePath;
        }
        public CsvParser()
        {


        }
        public void ProcessAllLines()
        {
            ReadFile();
        }
        public void ProcessSingleLine(string line)
        {
            PersonIdentifier(line);
        }
        private void ReadFile()
        {
            try
            {
                csvLines = File.ReadAllLines(filePath);
                //Ignore first linein file.
                csvLines = csvLines.Skip(1).ToArray();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        private void PersonIdentifier(string line)
        {
            string[] parts = line.Split(' ');

            if (parts.Length == 4)
            {
                Person person = new Person
                {
                    Title = parts[0],
                    LastName = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1)
                };
                people.Add(person);
                person = new Person
                {
                    Title = parts[2],
                    LastName = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1)
                };
                people.Add(person);
            }
            else if (parts.Length == 5)
            {
                Person person = new Person
                {
                    Title = parts[0],
                    FirstName = parts[3],
                    LastName = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1)
                };
                people.Add(person);
                person = new Person
                {
                    Title = parts[2],
                    FirstName = parts[3],
                    LastName = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1)
                };
                people.Add(person);
            }
            else if (parts.Length == 7)
            {
                Person person = new Person
                {
                    Title = parts[0],
                    FirstName = parts[1],
                    LastName = parts[2]
                };
                people.Add(person);
                person = new Person
                {
                    Title = parts[4],
                    FirstName = parts[5],
                    LastName = parts[6].Substring(0, parts[6].Length - 1)
                };
                people.Add(person);
            }
            else if (parts.Length == 3 && parts[1].Length > 2)
            {
                Person person = new Person
                {
                    Title = parts[0],
                    FirstName = parts[1],
                    LastName = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1)
                };
                people.Add(person);
            }
            else if (parts.Length == 3 && parts[1].Length <= 2)
            {
                Person person = new Person
                {
                    Title = parts[0],
                    Initial = parts[1].Substring(0, 1),
                    LastName = parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1)
                };
                people.Add(person);
            }
        }
    }
}
