using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 541
    */
    class ReverseStringII
    {
        public ReverseStringII()
        {

        }
        public string reverseStr(string s, int k)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < s.Length; i = 2 * k)
            {
                char c = chars[i];
                Console.WriteLine("char " + c);
                // chars[i]= chars[i+1];
                // chars[i+1] = c;

            }
            return new String(chars);
        }

    }
}