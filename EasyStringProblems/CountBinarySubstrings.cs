using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 696
    */
    class CountBinarySubstrings
    {

        public int countBinarySubstrings(string s)
        {
            int zero = 0, one = 0, ans = 0, i = 1;

            if (s[0] == '0') zero++;
            else one++;

            bool firstCharIsOne = one > 0 ? true : false;

            Console.WriteLine(firstCharIsOne);

            while (i < s.Length)
            {
                
                if (!firstCharIsOne)
                {
                    //Console.WriteLine("if "+firstCharIsOne);
                    while (i < s.Length && s[i] == '0') // counting zero's
                    { zero++; i++; }
                    Console.WriteLine("zero "+zero+" "+one+" ans="+ans);
                    ans += Math.Min(zero, one);
                    one = 0;
                    
                }
                firstCharIsOne = false;

                while (i < s.Length && s[i] == '1') // counting one's
                { one++; i++; }
                Console.WriteLine("one "+zero+" "+one+" ans="+ans);
                ans += Math.Min(zero, one);
                zero = 0;
                
               
            }
            return ans;
        }


    }
}