/* Given the coordinates of four points in 2D space, return whether the four points could construct a square.
 * The coordinate (x,y) of a point is represented by an integer array with two integers.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Medium
{
    class ValidSquare
    {
        /*    public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4) 
         *    {
         *    return Check(p1, p2, p3, p4) || Check(p1, p2, p4, p3) || Check(p1, p3, p2, p4);
         *    } */
        public bool ValidSquare1(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            //return Check(p1, p2, p3, p4) || Check(p1, p2, p4, p3) || Check(p1, p3, p2, p4);
            int[][] p = { p1, p2, p3, p4 };
            return CheckAllPermutations(p, 0);
        }

        bool CheckAllPermutations(int[][]p, int l)
        {
            if (l == 4)
                return Check(p[0], p[1], p[2], p[3]);
            else
            {
                bool res = false;
                for (int i = l; i < 4; i++)
                {
                    Swap(p, l, i);
                    res |= CheckAllPermutations(p, l + 1);
                    Swap(p, l, i);
                }
                return res;
            }
        }

        public void Swap(int[][]p, int x, int y)
        {
            int[] temp = p[x];
            p[x] = p[y];
            p[y] = temp;
        }
        public bool Check(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            return (Distance(p1,p2) > 0  && Distance(p1, p2) == Distance (p2,p3) &&
                Distance(p2,p3) == Distance(p3,p4) && 
                Distance(p3,p4) == Distance(p4,p1) &&
                Distance(p1,p3) == Distance(p2,p4) );
        }

        public double Distance(int[]p1, int[] p2)
        {
            return ((p2[1] - p1[1]) * (p2[1] - p1[1])) + ((p2[0] - p1[0]) * (p2[0] - p1[0]));
        }
    }
}
