/* You are given two non-empty linked lists representing two non-negative integers. The most significant digit comes 
 * first and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
 * You may assume the two numbers do not contain any leading zero, except the number 0 itself.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Medium
{
    class AddTwoNumbersII
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

        public ListNode ReverseList(ListNode head)
        {
            ListNode last = null;
            while(head != null)
            {
                ListNode temp = head.next;
                head.next = last;
                last = head;
                head = temp;
            }
            return last;
        }

        public ListNode AddTwoNumbers(ListNode l1 , ListNode l2)
        {
            l1 = ReverseList(l1);
            l2 = ReverseList(l2);

            ListNode head = null;
            int carry = 0;

            while(l1 != null || l2 != null)
            {
                int x1 = l1 != null ? l1.val : 0;
                int x2 = l2 != null ? l2.val : 0;

                int sum = carry + x1 + x2;
                carry = sum / 10;

                ListNode curr = new ListNode(sum % 10);
                curr.next = head;
                head = curr;

                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            if(carry != 0)
            {
                ListNode curr = new ListNode(carry);
                curr.next = head;
                head = curr;
            }
            return head;
        }
    }
}
