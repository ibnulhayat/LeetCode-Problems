using System;

namespace EasyStringProblems{

    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1374
    */

    class GenerateStringCharacters {

        public string GenerateTheString(int n) {
            var result = "";
            if(n % 2 == 0){
                for (var i = 0; i < n-1; i++)
                    result +="a";
                result +="b";
            }else{
                for (var i = 0; i < n; i++)
                    result +="a";
            }
            return result;
        }
    
    }
}