using System;
using System.Text;

namespace EasyStringProblems
{

    /*  
       LeetCode Problem
       Difficulty = easy
       Tags = string
       Problem no = 824
   */
    class GoatLatin
    {
        public string ToGoatLatin(string S)
        {
            //char[] punc = { ' ', '!', '?', ',', ';', '.', '\'' };

            string[] wordList = S.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int i = 1;
            StringBuilder sb = new StringBuilder();
            foreach (var word in wordList)
            {
                sb.Append(" " + addChar(word, i));
                i++;
            }
            return sb.ToString().Trim();
        }

        public string addChar(string s, int position)
        {
            string str = "";
            string vowels = "aeiouAEIOU";
            while (position > 0)
            {
                str += "a";
                position--;
            }
            if (vowels.Contains(s[0]))
            {
                str = s + "ma" + str;
            }
            else
            {
                char firstChar = s[0];
                str = s.Remove(0, 1) + firstChar + "ma" + str;
            }
            return str;
        }
    }
}