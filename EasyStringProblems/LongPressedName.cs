using System;

namespace EasyStringProblems
{


    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 925
    */
    class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
             
        int i = 0, j = 0;
        int n = name.Length, t = typed.Length;
        while (i < n && j < t){
            char c1 = name[i];
            char c2 = typed[j];
			if (c1 != c2) return false;
            
            int l1 = 0, l2 = 0;
			while (i < n && name[i] == c1){ 
                i++;
                l1++;  
            } 
            while (j < t && typed[j] == c1){
                j++;
                l2++;  
            } 
           // Console.WriteLine(l2+" < "+l1);
            if (l2 < l1) return false;
        }
        //Console.WriteLine(n+" "+i+" i = j "+j+" "+t);
        return i == n && j == t;
        }
    }
}