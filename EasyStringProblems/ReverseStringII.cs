using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 541
    */
    class ReverseStringII
    {
        public ReverseStringII()
        {

        }
        public string reverseStr(string s, int k)
        {
            //char[] chars = s.ToCharArray();
            // for (int i = 0; i < s.Length; i=k+k)
            // {
            //     char c = s[i];
            //     Console.WriteLine("char " + c);
            //    chars[i]= chars[i+1];
            //    chars[i+1] = c;

            // }
            // int i = 0,j = 0;
            // while(i<s.Length){
            //     while(j<k/2){
            //         char c = s[i+j];
            //         Console.WriteLine(j+" char " + c+" "+s[i+k-1-j]);
            //         chars[i+j]= s[i+k-1-j];
            //         chars[i+k-1-j] = c;
            //         j++;
            //     }

            //     i=i+2*k;
            //     j=0;
            // }
            if(s.Length < 2 || s.Length < k){ return s;
            }else{
                for(int i=0; i < s.Length-1; i+= k*2)
                {
                    string substring = s.Substring(i,k);
                    Console.WriteLine(i+" char " + substring);
                    char[] array = substring.ToCharArray();
                    Array.Reverse(array);
                    s =s.Replace(substring, new String(array));
                }
            }
            return s;
        }

    }
}