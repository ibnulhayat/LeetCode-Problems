using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 345
    */
    class ReverseVowelsString
    {

        public ReverseVowelsString()
        {
        }
        public string reverseVowels(string s)
        {
            //StringBuilder sb = new StringBuilder(s);
            /* faster to string build*/
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            string vowels = "aeiouAEIOU";
            while (left < right)
            {
                if (vowels.Contains(s[left]) && vowels.Contains(s[right]))
                {
                    char ch = s[left];
                    chars[left] = s[right];
                    chars[right] = ch;
                    left++;
                    right--;
                }
                else if (vowels.Contains(s[left]))
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return string.Join("", chars);
        }

    }
}