using Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    public static class AddTwoLists
    {
        public static void Run()
        {

        }

        public static LinkedListNode Add(LinkedListNode l1, LinkedListNode l2)
        {
            if (l1 == null || l2 == null)
            {
                return new LinkedListNode(0);
            }

            while (l1 != null || l2 != null)
            {
                int _Value = (l1.Value + l2.Value) % 10;
                int _Carry = (l1.Value + l2.Value) / 10;
            }
        }
    }
}
