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
            if (filePath.Length == 0)
            {
                throw new ArgumentException("Zero-length string invalid", "filePath");
            }
        }
    }
}
