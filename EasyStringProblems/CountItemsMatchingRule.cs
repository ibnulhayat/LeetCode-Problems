using System;
using System.Collections.Generic;

namespace EasyStringProblems{

    /*  
       LeetCode Problem
       Difficulty = easy
       Tags = string
       Problem no = 1773
   */

    class CountItemsMatchingRule{
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int type = 0, count = 0;
        if(ruleKey == "type")
            type = 0;
        else if(ruleKey == "color")
            type = 1;
        else if(ruleKey == "name")
            type = 2;
        
        for(int i =0; i<items.Count;i++){
            if(items[i][type] == ruleValue)
                count++;
        }
        return count;
    }
    }
}