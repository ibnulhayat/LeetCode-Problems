using System;

namespace EasyStringProblems
{
    class LengthOfLastWord
    {
        /*  
            LeetCode Problem
            Difficulty = easy
            Tags = string
            Problem no = 58
         */
        public LengthOfLastWord()
        {

        }
        public int lengthOfLastWord(string s)
        {
            /* Declear an integer value to store string of last word length */
            int value = 0;

            /* check this string is empty or null and trim 
            if this strig empty or null then return zero */
            if (String.IsNullOrEmpty(s.Trim()))
            {
                return 0;
            }

            /* fisrtly trim this string and then split by 
            single space and store in an array */
            string[] arr = s.Trim().Split(' ');

            /* now check array is null or not 
            if array is null then return zero
            or get array last word and length
            now length store in value and return this value */
            value = arr == null ? 0 : arr[arr.Length - 1].Length;
            return value;
        }

    }
}