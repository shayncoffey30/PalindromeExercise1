using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("John", false)]
        [InlineData("Jose", false)]
        [InlineData("Amoriss", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindromeTest(string palin, bool expected)
        {

            // Arrange
            var ws = new WordSmith();

            // Act
            var actual = ws.IsAPalindrome(palin);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
