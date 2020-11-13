/* You are given a perfect binary tree where all leaves are on the same level, and every parent has two children.
 * The binary tree has the following definition: */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovemberLeetCodeChallenge.Medium
{
    class PopulatingNextRightPointersinEachNode
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return root;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node prevNode = null;
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    Node node = queue.Dequeue();
                    if (prevNode != null)
                    {
                        prevNode.next = node;
                    }
                    prevNode = node;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return root;
        }


        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
