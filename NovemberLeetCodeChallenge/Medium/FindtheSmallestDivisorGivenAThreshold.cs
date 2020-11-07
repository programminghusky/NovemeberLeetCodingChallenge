/* Given an array of integers nums and an integer threshold, we will choose a positive integer divisor and divide 
 * all the array by it and sum the result of the division. Find the smallest divisor such that the result mentioned 
 * above is less than or equal to threshold.Each result of division is rounded to the nearest integer greater than 
 * or equal to that element. (For example: 7/3 = 3 and 10/2 = 5). It is guaranteed that there will be an answer. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Medium
{
    class FindtheSmallestDivisorGivenAThreshold
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int left = 1;
            int right = nums[nums.Length - 1];

            while(left <= right)
            {               
                int pivot = left + ((right - left) / 2);
                int sum = ComputeSum(nums, pivot);
                if (sum > threshold)
                {
                    left = pivot + 1;
                }
                else
                {
                    right = pivot - 1;
                }
            }
            return left;
        }

        public int ComputeSum(int[] nums, int x)
        {
            int s = 0;
            foreach(int n in nums)
            {
                s += n / x + (n % x == 0 ? 0 : 1);
            }
            return s;
        }
    }
}
