using System;
using Xunit;
namespace PalindromeExercise
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mtest = new Palindromes();

            bool test = mtest.Palindrome("hello");

            Assert.False(test);
        }
        [Theory]
        [InlineData("racecar" , true)]
        [InlineData("poop", true)]
        [InlineData("turtle", false)]
        [InlineData("aaa", true)]

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
