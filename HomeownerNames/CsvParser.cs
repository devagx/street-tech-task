using System;
using System.Collections.Generic;

namespace HomeownerNames
{
    public class CsvParser
    {
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
        }
        public CsvParser()
        {

        }
        public void ProcessSingleLine(string line)
        {

        }
    }
}
