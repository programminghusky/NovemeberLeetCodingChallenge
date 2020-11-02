/* Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if a person could attend all meetings.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Easy
{
    class MeetingRooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, new ArrayComparer());
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][1] > intervals[i + 1][0])
                    return false;
            }
            return true;
        }

        class ArrayComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0] - y[0];
            }
        }
    }
}
