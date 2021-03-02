using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 459
    */
    class SubstringPattern
    {

        public bool RepeatedSubstringPattern(string s)
        {

            for (int i = 1; i <= s.Length/2; i++)
            {
                if (s.Length % i != 0){
                    Console.WriteLine(i+" i - "+s.Length % i);
                    continue;
                }
                    
                bool found = true;
                String substr = s.Substring(0, i);
                for (int j = substr.Length; j < s.Length; j += substr.Length)
                {
                     Console.WriteLine(i+" = "+substr);
                    String substr2 = s.Substring(j, substr.Length);

                    if (!substr.Equals(substr2))
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    return true;
            }


            return false;
        }


    }
}