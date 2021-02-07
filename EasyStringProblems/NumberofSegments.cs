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
    class NumberofSegments{

        public NumberofSegments(){
        }

        public int countSegments(string s) {

            // if(s.Trim().Length == 0) return 0;
            // string[] segments = s.Trim().Split(" "); 
            // return segments.Length;
            
            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
        

    }
}