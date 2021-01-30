using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 680
    */
    class ValidPalindromeII{

        public ValidPalindromeII(){
        }

        
        public bool validPalindrome(string s)
        {
            s = s.Trim().ToLower();
            if (s.Length < 2)
            {
                return true;
            }
            StringBuilder sb_one = new StringBuilder(s);
            StringBuilder sb_two = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[(s.Length - 1) - i])
                {
                    sb_one.Remove(((s.Length - 1) - i), 1);
                    sb_two.Remove(i, 1);
                    //s = sb.ToString();
                    Console.WriteLine("one " + sb_one.ToString() + " two " + sb_two.ToString());
                    break;
                }

                //Console.WriteLine(i + "-> " + s[i] + " == " + ((s.Length - 1) - i) + "-> " + s[(s.Length - 1) - i]);
            }
            if (sb_one.ToString() == (Reverse(sb_one.ToString())) || sb_two.ToString() == (Reverse(sb_two.ToString())))
            {
                return true;
            }
            return false;
        }
        private string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            
            Array.Reverse(chars);
            return new String(chars);
        }

        public bool validPalindrome2(string s)
        {
            s = s.Trim().ToLower();
            if (s.Length < 2)
            {
                return true;
            }
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return checkPalindrome(s, start, end - 1) || checkPalindrome(s, start + 1, end);
                }
                start++;
                end--;
            }


            return true;
        }
        private bool checkPalindrome(String s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }


        

    }
}