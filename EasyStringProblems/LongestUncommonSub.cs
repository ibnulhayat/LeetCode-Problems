using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 521
    */
    class LongestUncommonSub{

        public int FindLUSlength(string a, string b) {
            // if(a.Equals(b))
            //     return -1;
            // int i = 0,j = 0;
            // StringBuilder sb = new StringBuilder();
            // while(j<b.Length){
            //     if(i<a.Length){
            //         if(!a[i].Equals(b[j])){
            //             sb.Append(b[j]);
            //         }
            //     }else{
            //         sb.Append(b[j]);
            //     }
            //     i++;
            //     j++;

            // }
        
        return a==b ? -1 : Math.Max(a.Length,b.Length);
    }
        

    }
}