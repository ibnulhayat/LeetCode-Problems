using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 788
    */
    class RotatedDigits{

        public int rotatedDigits(int N) {
        int result = 0;
        
        for (int i = 1; i <= N; i++) {
            if (isGoodNumber(i)) result++;
        }
        
        return result;
    }
    
    public bool isGoodNumber(int num) {
        bool isValid = false;
        
        while (num > 0) {
            int n = num % 10;
            //Console.WriteLine(num+" "+n);
            if (n == 3 || n == 4 || n == 7) return false;
            
            if (n == 2 || n == 5 || n == 6 || n == 9) isValid = true;
        
            num = num / 10;
        }
        
        return isValid;
    }
        

    }
}