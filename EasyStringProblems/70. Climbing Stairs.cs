using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = 
        Problem no = 70
    */
        class ClimbingStairs{
        	//faster than 60.55% 
        	public int climbStairs(int n) {

        		if (n == 0 || n == 1) return 1;

        		int ways1 = 1, ways2 = 1;

        		for (int i = 2; i <= n; i++) {
            		//Console.WriteLine(i+"before "+ways1+" "+ways2);
        			int ways = ways1 + ways2;
            		//Console.WriteLine(i+"way "+ways);
        			ways2 = ways1;
        			ways1 = ways;
            		//Console.WriteLine(i+"after "+ways1+" "+ways2);

        		}

        		return ways1;
        	}


        }
    }