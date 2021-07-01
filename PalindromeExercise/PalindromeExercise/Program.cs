using System;
using System.Linq;
namespace PalindromeExercise
{
    public class Palindromes
    {
        static void Main(string[] args)
        {
            
        }


            public bool Palindrome(string p)
            {
                string q = new string(p.ToCharArray().Reverse().ToArray());
                return p == q;
            }

    }
}
