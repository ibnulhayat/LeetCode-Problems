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

            int[] count = new int[26];
            int n = s.Length;
            // build char count bucket : <charIndex, count>
            for (int i = 0; i < n; i++) {            
                int index = s[i] - 'a';
                count[index]++;
            }
        
            // find the index
            for (int i = 0; i < n; i++) {
                int index = s[i] - 'a';
                if (count[index] == 1) {
                    return i;
                } 
            }
            return -1;
        }

    }
}