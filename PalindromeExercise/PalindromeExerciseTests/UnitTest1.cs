using System;
using Xunit;
namespace PalindromeExercise
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Theory]
        [InlineData("racecar" , true)]
        [InlineData("poop", true)]
        [InlineData("turtle", false)]
        [InlineData("aaa", false)]

        public void PalindromeTester(string word, bool expected)
        {
            //arrange
            var tester = new Palindromes();
            //act
            var actual = tester.Palindrome(word);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
