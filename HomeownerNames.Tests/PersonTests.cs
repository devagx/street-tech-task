using FluentAssertions;
using Xunit;

namespace HomeownerNames.Tests
{
    public class PersonTests
    {
        [Fact]
        public void FirstName_IsTypeOf_String()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.FirstName.Should().BeOfType<string>();
        }
        [Fact]
        public void Initial_IsTypeOf_String()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.Initial.Should().BeOfType<string>();
        }
        [Fact]
        public void LastName_IsTypeOf_String()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.LastName.Should().BeOfType<string>();
        }
        [Fact]
        public void Title_IsTypeOf_String()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.Title.Should().BeOfType<string>();
        }
        [Fact]
        public void FirstName_ReturnsStringValue_Joe()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.FirstName.Should().Be("Joe");
        }
        [Fact]
        public void Initial_ReturnsStringValue_A()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.Initial.Should().Be("A");
        }
        [Fact]
        public void LastName_ReturnsStringValue_Bloggs()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.LastName.Should().Be("Bloggs");
        }
        [Fact]
        public void Title_ReturnsStringValue_Mr()
        {
            Person person = new Person
            {
                FirstName = "Joe",
                Initial = "A",
                LastName = "Bloggs",
                Title = "Mr"
            };

            person.Title.Should().Be("Mr");
        }
    }
}
