using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 551
    */
    class StudentAttendanceRecord
    {

        public bool CheckRecord(string s)
        {
            if (s.Length < 2) return true;
            int Acount = 0, i = 0;
          
            while (i < s.Length)
            {
                if(Acount>1) return false;
                if (s[i] == 'A'){
                    Acount++;
                }
                if (s.Length > 2 && i>0 && i < s.Length-1 && s[i-1]=='L'&&s[i]=='L'&&s[i+1]=='L'){
                    return false;
                }
                i++;
            }
    
        return Acount> 1  ? false : true;
    }
        

    }
}