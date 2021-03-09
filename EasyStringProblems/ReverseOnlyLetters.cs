using System;

namespace EasyStringProblems
{

    
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 917
    */
    class ReverseOnlyLetters
    {
        public string reverseOnlyLetters(string S)
        {
            if (S.Trim().Length < 2) return S;

            int leftIndex = 0;
            int rightIndex = S.Length - 1;
            char left, right;
            char[] array = S.ToCharArray();
            while (leftIndex < rightIndex)
            {
                left = S[leftIndex];
                right = S[rightIndex];
                if ((left > 64 && left < 91) || (left > 96 && left < 123))
                {
                    if ((right > 64 && right < 91) || (right > 96 && right < 123))
                    {
                        array[leftIndex] = right;
                        array[rightIndex] = left;    

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

            return new string(array);

        }

    }
}