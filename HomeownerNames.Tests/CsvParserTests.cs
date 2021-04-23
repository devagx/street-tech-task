using FluentAssertions;
using Xunit;

namespace HomeownerNames.Tests
{
    public class CsvParserTests
    {
        [Fact]
        public void CsvParser_ValidFilePath_ReturnsNotNullObject()
        {
            string filePath = @"C:\examples.csv";
            CsvParser parser = new CsvParser(filePath);
            parser.Should().NotBeNull();
        }
    }
}
