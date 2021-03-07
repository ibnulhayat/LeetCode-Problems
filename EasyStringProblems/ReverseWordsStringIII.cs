using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 557
    */
    class ReverseWordsStringIII{

        public string ReverseWords(string s) {
            string[] stList = s.Split(" ");
            StringBuilder sb = new StringBuilder();
            int i =0;
            while(i < stList.Length){
                char[] array = stList[i].ToCharArray();
                Array.Reverse(array);
                sb.Append(" "+new string(array));
                i++;
            }
            return sb.ToString().Trim();
        }
        

    }
}