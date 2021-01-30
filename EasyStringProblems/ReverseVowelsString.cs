using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 345
    */
    class ReverseVowelsString{

        public ReverseVowelsString(){
        }
        public string reverseVowels(string s) {
        StringBuilder sb = new StringBuilder(s);
        int pre_index = -1; 
        // Char pre_ch = ''; 
        string vowels = "aeiouAEIOU";
        foreach(char c in s.ToCharArray()){
            if(vowels.Contains(c)){
                int index = s.IndexOf(c);
                if(pre_index != -1){
                    Console.WriteLine(pre_index);
                    sb[pre_index] = c;
                    //sb[index] = pre_ch;
                }else{
                    pre_index =index;
                    // pre_ch = c;
                }
            }
            
            
        }
        
        return sb.ToString();
    }

    }
}