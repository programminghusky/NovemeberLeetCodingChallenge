/* Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. 
 * The linked list holds the binary representation of a number. Return the decimal value of the number in the linked list. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Easy
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class ConvertBinaryNumberToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            int num = 0;
            while (head != null)
            {
                num = num * 2 + head.val;
                head = head.next;
            }
            return num;
        }
    }
}
