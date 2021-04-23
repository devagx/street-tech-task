using FluentAssertions;
using System;
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
        [Fact]
        public void CsvParser_NullFilePath_ReturnsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new CsvParser(null));
        }
        [Fact]
        public void CsvParser_EmptyFilePath_ReturnsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CsvParser(""));
        }
        [Fact]
        public void People_IsTypeOf_ListPerson()
        {
            string filePath = @"C:\examples.csv";
            CsvParser parser = new CsvParser(filePath);
            parser.People.Should().BeOfType<List<Person>>();
        }
    }
}
