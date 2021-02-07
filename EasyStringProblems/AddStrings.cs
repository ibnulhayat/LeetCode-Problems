using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 415
    */
    class AddStrings{

        public AddStrings(){
        }
        public string addStrings(string num1, string num2) {
            StringBuilder sb = new StringBuilder();
            int num1Len = num1.Length-1;
            int num2Len = num2.Length -1;
            int carry = 0;
            while(num1Len >= 0 || num2Len >= 0){
                int ch1 = num1Len < 0 ? 0: num1[num1Len]-'0';
                int ch2 = num2Len < 0 ? 0: num2[num2Len]-'0';
                Console.WriteLine(ch1+" "+ch2);
                /* this logic 24 % faster */
                int value = ch1+ch2+carry;
                sb.Insert(0,value % 10);
                carry = (int) value/10;
                    
                num1Len--;
                num2Len--;
            } 
            return carry>0 ? sb.Insert(0,Convert.ToString(carry)).ToString(): sb.ToString();
        }
        

    }
}