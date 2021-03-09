using System;
using System.Collections.Generic;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 819
    */

    class MostCommonWprd
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            string mostCommonWord = "";
            char[] punc = {' ', '!', '?', ',', ';', '.','\''};
            Dictionary<string, int> hash = new Dictionary<string, int>();
            string[] wordArray = paragraph.ToLower().Split(punc,StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var word in wordArray)
            {
                    if (Array.IndexOf(banned,word) == -1)
                    {
                        if (hash.ContainsKey(word))
                        {
                            hash[word]++;
                        }
                        else
                        {
                            hash.Add(word.ToLower(), 1);
                        }

                    }
            }
            int max = Int32.MinValue;
            foreach (var val in hash)
            {
                max = Math.Max(max,val.Value);
                if(max == val.Value)
                    mostCommonWord = val.Key;
                Console.WriteLine("key: "+val.Key+" max: "+max); 
            }

            return mostCommonWord;
        }
    }
}
