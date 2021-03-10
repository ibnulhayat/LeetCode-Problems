using System;
using System.Collections.Generic;

namespace EasyStringProblems{
     /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 929
    */
    class UniqueEmailAddresses{
         public int NumUniqueEmails(string[] emails) {
              Dictionary<string,int> hash = new Dictionary<string, int>();

             foreach (var email in emails)
             {
                string localName = "";
                 
                foreach (var ch in email)
                {
                    if(ch == '.') continue;
                    if(ch == '+' || ch == '@') break;
                    localName += ch;
                }
                 
                 localName += email.Substring(email.IndexOf("@"));
                 
                if(!hash.ContainsKey(localName)){
                    hash.Add(localName , 1);
                }
                 
             }
     
            return hash.Count;
        }
    }
}
