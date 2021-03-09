using System;
using System.Collections.Generic;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 804
    */

    class UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            if(words.Length < 2) return words.Length;
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<string, int> hash = new Dictionary<string, int>();
            int i = 0;
            foreach (var word in words)
            {
                string str = "";
                foreach (var c in word)
                {
                    str += morse[c - 'a'];
                }
                if (!hash.ContainsKey(str)){
                    hash.Add(str, i);
                    i++;
                }
            }
                
            return hash.Count;
        }
    }
}

