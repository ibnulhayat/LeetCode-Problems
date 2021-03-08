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
            if (s.Length < k)
            {
                return Reverse(s, 0, s.Length - 1);
            }
            else
            {
                for (int i = 0; i < s.Length; i += k * 2)
                {
                    if (s.Length - i < k)
                    {
                        s = Reverse(s, i, s.Length - 1);
                    }
                    else
                    {
                        s = Reverse(s, i, i + k - 1);
                    }
                }
            }
            return s;

        }

        public string Reverse(string s, int start, int end)
        {
            if (end < 1) return s;
            char[] array = s.ToCharArray();
            while (start < end)
            {
                char ch = s[start];
                array[start] = s[end];
                array[end] = ch;
                start++;
                end--;
            }
            return new string(array);
        }

    }
}