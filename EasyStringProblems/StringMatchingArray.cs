using System;
using System.Collections.Generic;

namespace EasyStringProblems{

    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1408
    */

    class StringMatchingArray {

        public IList<string> StringMatching(string[] words) {
            IList<string> ilist = new List<string>();
            foreach(var firstWord in words){
                foreach(var secondWord in words){
                    if(firstWord != secondWord && secondWord.Contains(firstWord)){
                        ilist.Add(firstWord);
                        break;
                    }
                }
            }
            return ilist;
        }
    
    }
}