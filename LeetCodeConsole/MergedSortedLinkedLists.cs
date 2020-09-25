using Structures;
using System;

namespace LeetCodeConsole
{
    public static class MergedSortedLinkedLists
    {
        // Given 2 sorted linked lists, merge them together and return a sorted list

        public static void Run()
        {
            LinkedListNode _List1 = new LinkedListNode(2);
            _List1.Next = new LinkedListNode(5);
            _List1.Next.Next = new LinkedListNode(7);
            _List1.Next.Next.Next = new LinkedListNode(8);

            LinkedListNode _List2 = new LinkedListNode(3);
            _List2.Next = new LinkedListNode(4);
            _List2.Next.Next = new LinkedListNode(5);
            _List2.Next.Next.Next = new LinkedListNode(9);
            _List2.Next.Next.Next.Next = new LinkedListNode(12);

            Console.WriteLine(Merge(_List1, _List2).ToString());
        }

        public static LinkedListNode Merge(LinkedListNode head1, LinkedListNode head2)
        {
            int p1 = 0, p2 = 0;

            LinkedListNode _Result = new LinkedListNode(-1);

            while (p1 < head1.Size() && p2 < head2.Size())
            {
                if (head1.GetNode(p1).Value <= head2.GetNode(p2).Value)
                {
                    _Result.Push(new LinkedListNode(head1.GetNode(p1++).Value));
                }
                else
                {
                    _Result.Push(new LinkedListNode(head2.GetNode(p2++).Value));
                }
            }

            while (p1 < head1.Size())
            {
                _Result.Push(new LinkedListNode(head1.GetNode(p1++).Value));
            }

            while (p2 < head2.Size())
            {
                _Result.Push(new LinkedListNode(head2.GetNode(p2++).Value));
            }

            return _Result.Next;
        }
    }
}
