using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        // Implement a palindrome checker to make the following test cases pass. This starter code is in C# but you are welcome to write your solution in any language

        static bool IsPalindrome(string s)
        {
            string s1 = new string(s.Reverse().ToArray());
            if (s == s1)
                return true;
            return false; 
        }

        static void Check(string s, bool shouldBePalindrome)
        {
            Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
        }
        static void Main(string[] args)
        {
            Check("abcba", true);
            Check("abcde", false);
            Check("Mr owl ate my metal worm", true);
            Check("Never Odd Or Even", true);
            Check("Never Even Or Odd", false);
        }
    }
}
