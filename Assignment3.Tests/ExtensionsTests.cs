using System;
using Xunit;

namespace BDSA2020.Assignment3.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_Given_HTTP_Return_False()
        {
            //Arrange
            Uri input = new Uri("http://github.com/nissemand243/Assignment_01/blob/main/Assignment1.Tests/IteratorsTests.cs");

            //Act
            bool output = input.IsSecure();

            //Assert

            Assert.False(output);

        }

        [Fact]
        public void WordCount_Given_HejMedDig_Return_3()
        {
            //Arrange
            var input = "hej med dig";

            var expected = 3;


            //Act
            var actual = input.WordCount();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
