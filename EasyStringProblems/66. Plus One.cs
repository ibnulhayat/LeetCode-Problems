using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = array
        Problem no = 66
    */
        class PlusOne{

        	public int[] PlusOne(int[] digits) {
        		int n = digits.Length-1;
        		bool overflow = true;
        		for(int i = n; i>=0; --i) {
        			if(digits[i] == 9) {
        				digits[i] = 0;
        				continue;
        			}
        			overflow = false;
        			digits[i] = digits[i] + 1;
        			break;
        		}
        		if(overflow) {
        			int[] arr = new int[n+2];
        			arr[0] = 1;
        			return arr;
        		}
        		return digits;
        	}


        }
    }