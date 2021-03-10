using System;

namespace EasyStringProblems{

    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1221
    */

    class BalancedStrings {
    public int BalancedStringSplit(string s) {
        int count = 0, balance = 0;
        foreach(var ch in s){
            count += ch == 'R'?1:-1;
            if(count == 0) balance++;
        }
        return balance;
    }
}
}