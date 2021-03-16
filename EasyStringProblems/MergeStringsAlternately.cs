using System;

namespace EasyStringProblems{

     /*  
       LeetCode Problem
       Difficulty = easy
       Tags = string
       Problem no = 1768
   */
    class MergeStringsAlternately{
        public string MergeAlternately(string word1, string word2) {
        int i=0, j=0; string mergeString="";
        
        while(i<word1.Length || j< word2.Length){
            if(i<word1.Length) mergeString += word1[i];
            if(j<word2.Length) mergeString += word2[j];
            i++;
            j++;
        }
        
        return mergeString;
    }
    }
}