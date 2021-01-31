using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 67
    */
    class AddBinary{

        public AddBinary(){
        }
        public string addBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int aLength = a.Length-1;
            int bLength = b.Length -1;
            int carry = 0;
            while(aLength >= 0 || bLength >= 0){
                int ch1 = aLength < 0 ? 0: a[aLength]-'0';
                int ch2 = bLength < 0 ? 0: b[bLength]-'0';
                /* this logic 24 % faster */
                int value = ch1+ch2+carry;
                sb.Insert(0,value % 2);
                carry = (int) value/2;
                
                /* this logic 12 % faster */
                // string sum = Convert.ToString( (ch1+ch2+carry) , 2) ;
                //Console.WriteLine("value="+ value % 2+" b1="+ch1+" b2="+ch2+" c="+carry);
                // if(sum.Length == 2){
                //     sb.Insert(0,sum[1]);
                //     carry = sum[0]-'0';
                // }else{
                //     sb.Insert(0,sum[0]);
                //     carry = 0;
                // }
                aLength--;
                bLength--;
            } 
            return carry>0 ? sb.Insert(0,Convert.ToString(carry)).ToString(): sb.ToString();
        }

    }
}