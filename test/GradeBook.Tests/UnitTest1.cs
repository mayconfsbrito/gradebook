using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrenge section
            var x = 5;
            var y = 2;
            var expected = 10;

            //Act section
            var actual = x * y;

            //Assert section
            Assert.Equal(expected, actual);
        }
    }
}
