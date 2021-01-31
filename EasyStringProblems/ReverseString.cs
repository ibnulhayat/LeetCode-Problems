using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 344
    */
    class ReverseString
    {

        public ReverseString()
        {
        }

        // best case
        public void reverseString(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                char c = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = c;
            }
            Console.WriteLine("[{0}]", string.Join(", ", s));
            //Console.WriteLine("reverse : " + s);
        }
        public void reverseString2(char[] s)
        {
            Array.Reverse(s);
            Console.WriteLine("reverse " + s);
        }

    }
}