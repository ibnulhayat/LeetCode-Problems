using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
       LeetCode Problem
       Difficulty = easy
       Tags = string
       Problem no = 859
   */

    class BuddyStrings
    {
        public bool BuddyString(string a, string b)
        {
            // if (a.Length < 2 || b.Length < 2) return false;
            // bool status;
            // // for (int i = 0; i < a.Length; i++)
            // // {

            // // }

            // if (a[0] == b[1] && a[1] == b[0])
            // {
            //     status = true;
            // }
            // else if (a[0] == b[2] && a[1] == b[1] && a[2] == b[0])
            // {
            //     status = true;
            // }
            // else
            // {
            //     status = false;
            // }

            // return status;
            if (a.Length != b.Length) return false;     // different length match never not possible
            
        int[] charCount = new int[26];              // to count frequencies of each letter in A

        int diff = 0, misMatchAt = -1;
        bool sameLetterSwapPossible = false, oneSwapMade = false;
        for (int i = 0; i < a.Length; i++)
        {
            int index = a[i] - 'a';
            if (charCount[index] > 1){
                charCount[index]++;
                sameLetterSwapPossible = true;
            }
            if (a[i] != b[i])
            {
                if (diff++ > 2)                     // no of different characters more than 2
                    return false;

                if (misMatchAt == -1)               // 1st misMatch
                    misMatchAt = i;
                else                                // 2nd misMatch
                {
                    // if swap not possible return false
                    if (a[misMatchAt] != b[i] || b[misMatchAt] != a[i])
                        return false;
                    oneSwapMade = true;             // else update one SwapMade
                }
            }
        }

        return diff % 2 == 0 && (oneSwapMade || sameLetterSwapPossible);
        }
    }
}