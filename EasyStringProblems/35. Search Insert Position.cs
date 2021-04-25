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
        class SearchInsertPosition{
            // using for loop 90%
            public int SearchInsert(int[] nums, int target) {
                int index = 0;
                for(int i=0; i<nums.Length; i++){
                    if(nums[i] == target){
                        return i; 
                    }else if(nums[i] < target){
                        index = i+1;
                    }else if( nums[i] > target){
                        index = i;
                        break;
                    }
                }
                return index;
            }
            
            // using binary search 45%
            public int SearchInsert(int[] nums, int target) {
                int left = 0,right;
                right = nums.Length;
                
                while(left<right){
                    int mid = (left + right)/2;
                    //Console.WriteLine(mid);
                    if(nums[mid] >= target) right = mid;
                    else left = mid + 1;

                }
                
                return left;
            }

            // using while loog 75%
            public int SearchInsert(int[] nums, int target) {
                int length = nums.Length;
                int i = 0;
                while (i < length) {
                    if(nums[i] == target) {
                        break;
                    }else if(nums[i] > target){
                        break;
                    }
                    i++;
                }
                return i;
            }

            // using while loog 75%
            public int SearchInsert(int[] nums, int target) {
                int length = nums.Length;
                int i = 0;
                while (i < length) {
                    if(nums[i] >= target) {
                        break;
                    }
                    i++;
                }
                return i;
            }

        }
    }