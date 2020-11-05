using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Easy.MinimumCosttoMoveChipstoTheSamePosition min = new Easy.MinimumCosttoMoveChipstoTheSamePosition();
            min.MinCostToMoveChips(new int[]{ 2, 2, 2, 3, 3});
            Console.ReadLine();
        }
    }
}
