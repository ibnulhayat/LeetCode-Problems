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
            int zero = 0, one = 0, count = 0, i = 0;

            bool firstCharIsOne = one > 0 ? true : false;

            while (i < s.Length)
            {
                if (!firstCharIsOne)
                {
                    while (i < s.Length && s[i] == '0') {
                        zero++; 
                        i++; 
                    }
                    //Console.WriteLine(i+" zero "+zero+" one "+one+" ans="+Math.Min(zero, one));
                    count += Math.Min(zero, one);
                    one = 0;
                    //Console.WriteLine(i+" zero "+zero+" one "+one+" ans="+Math.Min(zero, one));
                    
                }
                firstCharIsOne = false;
                while (i < s.Length && s[i] == '1'){ 
                    one++; 
                    i++; 
                }
                //Console.WriteLine(i+" one "+zero+" one "+one+" ans="+Math.Min(zero, one));
                count += Math.Min(zero, one);
                zero = 0;
                //Console.WriteLine(i+" one "+zero+" one "+one+" ans="+Math.Min(zero, one));
               
            }
            
            return count;
        }


    }
}