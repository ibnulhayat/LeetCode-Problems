using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 125
    */
    class ValidPalindrome{

        public ValidPalindrome(){
        }
        
        public bool isPalindrome(string s)
        {

            s = s.Trim().ToLower();
            if (s.Length < 2)
            {
                return true;
            }

            int leftIndex = 0;
            int rightIndex = s.Length - 1;
            char left, right;
            while (leftIndex < rightIndex)
            {
                left = s[leftIndex];
                right = s[rightIndex];
                if ((left > 47 && left < 58) || (left > 96 && left < 123))
                {
                    if ((right > 47 && right < 58) || (right > 96 && right < 123))
                    {
                        if (left != right)
                        {
                            return false;
                        }
                        leftIndex++;
                        rightIndex--;
                    }
                    else
                    {
                        rightIndex--;
                    }
                }
                else
                {
                    leftIndex++;
                }
            }

            return true;
        }


    }
}