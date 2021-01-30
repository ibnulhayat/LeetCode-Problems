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
    class AddBinary{

        public AddBinary(){
        }
        public string addBinary(string a, string b)
        {
            if (1 <= a.Trim().Length && a.Trim().Length <= 14 && 1 <= b.Trim().Length && b.Trim().Length <= 14)
            {
                long number_one = Convert.ToInt64(a.Trim(), 2);
                long number_two = Convert.ToInt64(b.Trim(), 2);
                return Convert.ToString(number_one + number_two, 2);
            }
            else
            {
                return "0";
            }
        }

    }
}