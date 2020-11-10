/* Given an array A of integers and integer K, return the maximum S such that there exists i < j with A[i] + A[j] = S and S < K. 
 * If no i, j exist satisfying this equation, return -1. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Easy
{
    class TwoSumLessThanK
    {
        public int TwoSmLessThanK(int[] A, int K)
        {
            Array.Sort(A);
            int greatAtThisPoint = -1;
            int left = 0, right = A.Length - 1;
            while (left < right)
            {
                if ((A[left] + A[right]) >= K)
                    right--;
                else
                {
                    greatAtThisPoint = Math.Max(greatAtThisPoint, A[left] + A[right]);
                    left++;
                }
            }
            return greatAtThisPoint;
        }
    }
}
