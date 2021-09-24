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
    }
}
