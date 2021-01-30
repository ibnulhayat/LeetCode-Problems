using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 520
    */
    class DetectCapital{

        public DetectCapital(){
            Console.WriteLine("template class");
        }
        
        public bool DetectCapitalUse(string word) {
            if(word.Length ==1) return true;
            int count = 0;
            foreach(char ch in word.ToCharArray()){
                if(ch> 64 && ch < 91){
                    count++;
                }
            }
            return count == word.Length || count == 0 || (count == 1 && Char.IsUpper(word[0])); 
        }

    }
}