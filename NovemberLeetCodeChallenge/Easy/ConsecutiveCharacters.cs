/* Given a string s, the power of the string is the maximum length of a non-empty substring that contains only one unique character.
 * Return the power of the string.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Easy
{
    class ConsecutiveCharacters
    {
        public int MaxPower(string s)
        {
            if (s.Length < 2)
                return s.Length;
            int maxLength = 0, count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                maxLength = Math.Max(count + 1, maxLength);
            }
            return maxLength;
        }
    }
}
