using FluentAssertions;
using Xunit;

namespace XUnitTestProject
{
    public class MyUnitTest
    {
        [Fact]
        public void FirstTest()
        {
            var sut = new CodeKata.CodeKata();
            var c = sut.Add(1, 2);
            c.Should().Be(3);
        }
    }
}