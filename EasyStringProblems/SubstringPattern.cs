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
            int i = 1;
            bool found = false;
            int subLength;
            while (i < s.Length)
            {

                string substr = s.Substring(0, i);
                subLength = substr.Length;
                //Console.WriteLine(substr + " " + i + " first");
                while (subLength < s.Length)
                {
                    
                    if (s.Length - subLength < substr.Length)
                    {
                        found = false;
                        break;
                    }
                    else
                    {
                        string substr2 = s.Substring(subLength, substr.Length);
                        Console.WriteLine(substr+" "+subLength+" "+substr2);
                        if (!substr2.Equals(substr))
                        {
                            found = false;
                            break;
                        }
                        else
                        {
                            found = true; 
                        }
                    }
                    // string substr2 = s.Substring(subLength, subLength);
                    // Console.WriteLine(substr+" "+s.Length+" "+substr2);
                    subLength += substr.Length;

                }
                Console.WriteLine("length " + subLength);
                if(s.Length == subLength-substr.Length || s.Length == subLength)
                    break;
                i++;
            }

            return found;
        }


    }
}