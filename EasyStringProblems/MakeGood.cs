using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 1544
    */
    class MakeGood{

        public MakeGood(){
            Console.WriteLine("template class");
        }
        
        
        public string makeGood(string s)
        {
            string goodString = "";
            if (s.Length < 2)
            {
                return s;
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (checkChar(s[i], s[i + 1]) || checkChar(s[i], s[i + 1]))
                {
                    goodString = makeGood(s.Remove(i, 2));
                    Console.WriteLine(s[i] + " " + s[i + 1] + " s =" + s.Remove(i, 2));
                    break;
                }
                else
                {
                    goodString = s;
                }
            }

            return goodString;
        }


        public string makeGood2(string s)
        {
            StringBuilder goodString = new StringBuilder(s);
            if (s.Length < 2)
            {
                return s;
            }
            int start = 0;
            int end = goodString.Length ;

            while (start < end-1)
            {
                Console.WriteLine(start+" str " + goodString+" len = "+end);

                if (checkChar(goodString[start], goodString[start + 1]))
                {
                    goodString.Remove(start, 2);
                    end -= 2;
                    start = 0;
                }else{
                    start++;
                }
               

            }
            //Console.WriteLine(start+" str " + goodString+" len = "+end);

            return goodString.ToString();
        }


        private bool checkChar(char c1, char c2)
        {
            //Console.WriteLine(c1+" "+Char.IsLower(c1)+" "+ c2+" "+Char.IsUpper(c2));

            if (c1.ToString().ToLower() == c2.ToString().ToLower())
            {
                if (Char.IsLower(c1) && Char.IsUpper(c2))
                {
                    return true;
                }
                else if (Char.IsUpper(c1) && Char.IsLower(c2))
                {
                    return true;
                }
            }
            return false;
        }

    }
}