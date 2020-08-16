using Structures;
using System;

namespace LeetCodeConsole
{
    public static class LinkedListAddition
    {
        public static void Run()
        {
            LinkedListNode _List1 = new LinkedListNode(2);
            _List1.Next = new LinkedListNode(4);
            _List1.Next.Next = new LinkedListNode(3);

            LinkedListNode _List2 = new LinkedListNode(5);
            _List2.Next = new LinkedListNode(6);
            _List2.Next.Next = new LinkedListNode(4);

            LinkedListNode _Result = AddLinkedListsIterative(_List1, _List2);
            Console.WriteLine(_Result);
        }

        private static LinkedListNode AddLinkedListsIterative(LinkedListNode list1, LinkedListNode list2)
        {
            LinkedListNode _List1 = list1;
            LinkedListNode _List2 = list2;
            int _CarryOver = 0;

            LinkedListNode _Return = null;
            LinkedListNode _Current = _Return;

            while (_List1 != null || _List2 != null)
            {
                int _Sum = _List1.Value + _List2.Value + _CarryOver;
                _CarryOver = _Sum / 10;

                if (_Current == null)
                {
                    _Return = _Current = new LinkedListNode(_Sum % 10);
                }
                else
                {
                    _Current.Next = new LinkedListNode(_Sum % 10);
                    _Current = _Current.Next;
                }

                if (_List1.Next != null || _List2.Next != null)
                {
                    if (_List1.Next == null)
                    {
                        _List1.Next = new LinkedListNode(0);
                    }
                    else if (_List2.Next == null)
                    {
                        _List2.Next = new LinkedListNode(0);
                    }
                }

                _List1 = _List1.Next;
                _List2 = _List2.Next;

            }

            return _Return;
        }

        private static LinkedListNode AddListsRecursive(LinkedListNode list1, LinkedListNode list2)
        {
            return AddListsRecursiveHelper(list1, list2, 0);
        }

        private static LinkedListNode AddListsRecursiveHelper(LinkedListNode list1, LinkedListNode list2, int carryOver)
        {
            int _Sum = list1.Value + list2.Value + carryOver;
            int _CarryOver = _Sum / 10;

            LinkedListNode _Result = new LinkedListNode(_Sum % 10);

            if (list1.Next != null || list2.Next != null)
            {
                if (list1.Next == null)
                {
                    list1.Next = new LinkedListNode(0);
                }
                else if (list2.Next == null)
                {
                    list2.Next = new LinkedListNode(0);
                }

                _Result.Next = AddListsRecursiveHelper(list1.Next, list2.Next, _CarryOver);
            }

            return _Result;
        }
    }
}
