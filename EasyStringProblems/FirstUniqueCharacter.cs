using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 
    */
    class FirstUniqCharacter{

        public FirstUniqCharacter(){
        }
        public int firstUniqChar(string s) {
            foreach(char ch in s.ToCharArray()){
                if(s.Contains(ch)){
                    return s.IndexOf(ch);
                }
            }

            return -1;
        }

    }
}