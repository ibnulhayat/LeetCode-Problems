using System;
using System.Collections.Generic;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 
    */
    class RearrangeSpacesBetweenWords
    {

        List<string> wordList = new List<string>();

        public string ReorderSpaces(string text)
        {

            int totalSpaces = getTotalSpace(text);
            int totalWords = wordList.Count;

            //Console.WriteLine(totalWords);
            int equalSpace = totalWords == 1 ? 0 : totalSpaces / (totalWords - 1);
            int endSpace = totalWords == 1 ? totalSpaces : totalSpaces % (totalWords - 1);

            //string space = " ".Repeat();
            //Console.WriteLine(equalSpace);

            string newString = "";
            for (int j = 0; j < totalWords; j++)
            {
                newString += wordList[j];
                //Console.WriteLine(word != wordList[totalWords-1]);
                if (j != totalWords - 1)
                {
                    newString += new String(' ', equalSpace);

                }
            }

            if (endSpace > 0) newString += new String(' ', endSpace);





            return newString;
        }

        public int getTotalSpace(string s)
        {
            int totalSpace = 0;
            string word = "";

            foreach (char ch in s)
            {
                if (ch != ' ')
                {
                    word += ch;
                }
                if (ch == ' ')
                {
                    totalSpace++;
                    if (word != "")
                    {
                        wordList.Add(word);
                        word = "";
                    }

                }
            }
            if (word != "") wordList.Add(word);


            return totalSpace;
        }



    }
}