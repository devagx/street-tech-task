using System;

namespace HomeownerNames
{
    public class CsvParser
    {
        public CsvParser(string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("filePath");
            }
        }
    }
}
