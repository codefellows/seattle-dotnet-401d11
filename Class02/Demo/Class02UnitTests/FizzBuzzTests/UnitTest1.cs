using System;
using Xunit;
using static Class02UnitTests.Program;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturn1ForFizzBuzz()
        {
            //Arrange
            int number = 1;

            // Act
            string value = FizzBuzz(number);

            // Assert

            Assert.Equal("1", value);
        }

        [Fact]
        public void CanReturn2ForFizzBuzz()
        {
            // arrange and act
            string value = FizzBuzz(2);

            Assert.Equal("2", value);
        }

        [Fact]
        public void CanReturnFizzFor3()
        {
            string fizz = FizzBuzz(3);

            // assert
            Assert.Equal("Fizz", fizz);
        }

        [Fact]
        public void CanReturnBuzzFor5()
        {
            string buzz = FizzBuzz(5);

            Assert.Equal("Buzz", buzz);
        }

        [Fact]
        public void CanReturnFizzFor6()
        {
            string fizz = FizzBuzz(6);
            Assert.Equal("Fizz", fizz);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]

        public void FizzBuzzTest(int number, string expected)
        {
          string result =  FizzBuzz(number);

            Assert.Equal(expected, result);
        }
    }
}
