using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
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
        public void CsvParser_NoArguments_ReturnsNotNullObject()
        {
            CsvParser parser = new CsvParser();
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
        public void RunParser_InvalidFolderPath_ReturnsDirectoryNotFoundException()
        {
            string filePath = @"C:\invalidpath\examples.csv";
            CsvParser parser = new CsvParser(filePath);
            Assert.Throws<DirectoryNotFoundException>(() => parser.ProcessAllLines());
        }
        [Fact]
        public void RunParser_InvalidFileName_ReturnsFileNotFoundException()
        {
            string filePath = @"C:\invalidfile.csv";
            CsvParser parser = new CsvParser(filePath);
            Assert.Throws<FileNotFoundException>(() => parser.ProcessAllLines());
        }
        [Fact]
        public void People_ReturnsValidList_Count18()
        {
            string filePath = @"C:\examples.csv";
            CsvParser parser = new CsvParser(filePath);
            parser.ProcessAllLines();
            parser.People.Should().HaveCount(c => c == 18);
        }
        [Fact]
        public void People_ReturnsValidList_Count1()
        {
            CsvParser parser = new CsvParser();
            parser.ProcessSingleLine("Mr John Smith");
            parser.People.Should().HaveCount(c => c == 1);
        }
        [Fact]
        public void People_ReturnsValidList_Count2_a()
        {
            CsvParser parser = new CsvParser();
            parser.ProcessSingleLine("Mr and Mrs Smith");
            parser.People.Should().HaveCount(c => c == 2);
        }
        [Fact]
        public void People_ReturnsValidList_Count2_b()
        {
            CsvParser parser = new CsvParser();
            parser.ProcessSingleLine("Dr & Mrs Joe Bloggs");
            parser.People.Should().HaveCount(c => c == 2);
        }
        [Fact]
        public void People_ReturnsValidList_Count2_c()
        {
            CsvParser parser = new CsvParser();
            parser.ProcessSingleLine("Mr Tom Staff and Mr John Doe");
            parser.People.Should().HaveCount(c => c == 2);
        }
        [Fact]
        public void People_ReturnsValidStringInitial_M()
        {
            CsvParser parser = new CsvParser();
            parser.ProcessSingleLine("Mr M Mackie");
            parser.People[0].Initial.Should().Be("M");
        }
        [Fact]
        public void People_ReturnsValidStringInitial_J()
        {
            CsvParser parser = new CsvParser();
            parser.ProcessSingleLine("Mr J. Smith");
            parser.People[0].Initial.Should().Be("J");
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
