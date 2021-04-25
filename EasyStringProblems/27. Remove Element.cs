using System;
using System.Text;

namespace EasyStringProblems
{
    /*  
        LeetCode Problem
        Difficulty = easy
        Tags = string
        Problem no = 
    */
    class RemoveElement
    {

        public int removeElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != val) nums[j++] = nums[i];
            }
            return j;
        }


    }
}