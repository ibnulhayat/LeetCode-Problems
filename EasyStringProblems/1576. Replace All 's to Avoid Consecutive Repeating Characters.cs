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
    class ReplaceAll{

        public string ModifyStringOneWay(string s) {
        
            StringBuilder sb = new StringBuilder(s);
            for(int i=0;i<sb.Length;i++){
                if(s[i]=='?'){
                    for(char j='a'; j<='z';j++){
                        if(i-1>=0 && j == sb[i-1]) continue;
                        if(i+1<sb.Length && j == sb[i+1]) continue;
                        sb[i] = j;
                        Console.WriteLine(j);
                        break;
                    }
                }
            }
            return sb.ToString();
        }
        
        public string ModifyString(string s) {
            StringBuilder sb = new StringBuilder(s);
            char ch = 'a';
            int j = 0;
            for(int i=0;i<sb.Length;i++){
                if(s[i]=='?'){
                    ch += (char)j++;
                    if(i-1>=0 && ch == sb[i-1]) ch += (char)j++;
                    if(i+1<sb.Length && ch == sb[i+1]) ch += (char)j++;
                    sb[i] = ch;
                    //Console.WriteLine(ch);
                }
            }
            return sb.ToString();
        }

    }
}