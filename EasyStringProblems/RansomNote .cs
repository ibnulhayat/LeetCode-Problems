using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 383
    */
    class RansomNote
    {

        public RansomNote()
        {
        }

        // best case 
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }
            else
            {
                int count = 0;
                StringBuilder sbMZ = new StringBuilder(magazine);
                foreach (char ch in ransomNote.ToCharArray())
                {
                    int index = sbMZ.ToString().IndexOf(ch);
                    if (index != -1)
                    {
                        //Console.WriteLine("index = "+index+" "+ch);
                        sbMZ.Remove(index, 1);
                        count++;
                    }
                }

                //Console.WriteLine("count = "+count);
                if (ransomNote.Length == count)
                {
                    return true;
                }
            }
            return false;
        }

        // not bad but not best
        public bool CanConstruct2(string ransomNote, string magazine) {
        if(ransomNote.Length > magazine.Length){
            return false;
        }else{
            StringBuilder sbMZ = new StringBuilder(magazine); 
            foreach(char ch in ransomNote.ToCharArray()){           
                int index = sbMZ.ToString().IndexOf(ch);
                if(index != -1){
                    //Console.WriteLine("index = "+index+" "+ch);
                    sbMZ.Remove(index,1);
                }
            }
            //Console.WriteLine("count = "+count);
            if(ransomNote.Length == (magazine.Length - sbMZ.Length)){
                return true;
            }
        }
        return false;
    }
    


    }
}