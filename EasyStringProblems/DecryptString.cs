using System;

namespace EasyStringProblems{

    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1309
    */

    class DecryptString {
    public string FreqAlphabets(string s) {
        int i=0;
        string decrypt = "";
        while(i<s.Length){
            if (i<s.Length-2 && s[i+2] == '#'){
                decrypt += (char)(((s[i]-'0')*10) + (s[i+1]-'0')+96) ;
                i +=3;
            }else{
                decrypt +=(char) ((s[i]- 48)+96);
                i++;
            }
        }
        return decrypt;
    }
}
}