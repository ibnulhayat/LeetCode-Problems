using System;

namespace EasyStringProblems{

    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1108
    */
    class DefangingIPAddress {
    public string DefangIPaddr(string address) {
        string str = "";
        foreach (var ch in address){
            str += ch == '.'?"[.]":ch.ToString();
        }
        return str;
    }
}
}