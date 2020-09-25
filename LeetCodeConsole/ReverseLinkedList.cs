using Structures;
using System;

namespace LeetCodeConsole
{
    public static class ReverseLinkedList
    {
        public static void Run()
        {
            LinkedListNode _Node = new LinkedListNode(1);
            _Node.Next = new LinkedListNode(2);
            _Node.Next.Next = new LinkedListNode(3);
            _Node.Next.Next.Next = new LinkedListNode(4);
            _Node.Next.Next.Next.Next = new LinkedListNode(5);

            Console.WriteLine(_Node.ToString());
            //Console.WriteLine(ReverseRecursive(_Node).ToString());
            Console.WriteLine(ReverseIterative(_Node).ToString());
        }

        public static LinkedListNode ReverseRecursive(LinkedListNode head)
        {
            LinkedListNode _ReverseHead = null;
            ReverseHelper(ref _ReverseHead, head);
            return _ReverseHead;
        }

        public static LinkedListNode ReverseHelper(ref LinkedListNode reverseHead, LinkedListNode node)
        {
            if (node.Next == null)
            {
                reverseHead = node;
            }
            else
            {
                ReverseHelper(ref reverseHead, node.Next).Next = node;
                node.Next = null;
            }

            return node;
        }

        public static LinkedListNode ReverseIterative(LinkedListNode head)
        {
            LinkedListNode _Previous = null;

            while (head != null)
            {
                LinkedListNode _Next = head.Next;
                head.Next = _Previous;
                _Previous = head;
                head = _Next;
            }

            return _Previous;
        }
    }
}
