using System;
using System.Collections.Generic;

namespace EasyStringProblems{

     /*  
       LeetCode Problem
       Difficulty = easy
       Tags = string
       Problem no = 1790
   */
    class OneStringSwapCan{

        public bool AreAlmostEqual(string s1, string s2) {
        var list = new List<int>();
        for(int i=0; i<s1.Length; i++){
            if(s1[i] != s2[i]) list.Add(i);
            if(list.Count > 2 ) return false;
        }
        return list.Count == 0 || (list.Count == 2 && s1[list[0]] == s2[list[1]] && s1[list[1]] == s2[list[0]]) ;
    }
    }
}