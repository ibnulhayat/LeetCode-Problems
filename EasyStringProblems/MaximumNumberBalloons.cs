using System;

namespace EasyStringProblems
{

    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1189
    */

    class MaximumNumberBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            int[] count = new int[26];
            foreach (var ch in text)
            {
                count[ch - 'a']++;
            }
            return Math.Min(count[1], Math.Min(count[0], Math.Min(count[11] / 2, Math.Min(count[14] / 2, count[13]))));
        }
    }
}