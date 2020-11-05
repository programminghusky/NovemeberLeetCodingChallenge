﻿/* We have n chips, where the position of the ith chip is position[i]. We need to move all the chips to the same position.
 * In one step, we can change the position of the ith chip from position[i] to:
 * position[i] + 2 or position[i] - 2 with cost = 0.
 * position[i] + 1 or position[i] - 1 with cost = 1.
 * Return the minimum cost needed to move all the chips to the same position. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Easy
{
    class MinimumCosttoMoveChipstoTheSamePosition
    {
        public int MinCostToMoveChips(int[] position)
        {
            int evenCount = 0;
            int oddCount = 0;
            for(int i = 0;i < position.Length; i++)
            {
                if (position[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            return Math.Min(evenCount, oddCount);
        }
    }
}
