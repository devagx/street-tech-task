using FluentAssertions;
using HomeownerNames;
using Xunit;

namespace InterviewChallenge.Tests
{
    public class MyClassTests
    {
        [Fact]
        public void TestMyClassTestMethodReturns1()
        {
            MyClass obj = new MyClass();
            obj.TestMethod().Should().Be(1);

        }
    }
}
