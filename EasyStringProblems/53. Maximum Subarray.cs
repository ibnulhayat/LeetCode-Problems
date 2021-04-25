using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = array
        Problem no = 53
    */
        class MaximumSubarray{

            public int MaxSubArray(int[] nums) {

                int sum = Int32.MinValue;
                int subsum = 0;
                foreach(int num in nums){
                    //Console.WriteLine("before "+sum+" "+subsum);
                    subsum += num;
                    //Console.WriteLine("after "+sum+" "+subsum);
                    if(subsum > sum) sum = subsum;
                    if(subsum < 0) subsum = 0;
                }

                return sum;
            }


        }
    }