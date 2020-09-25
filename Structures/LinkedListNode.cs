namespace Structures
{
    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            string value = Value.ToString();
            return Next != null ? value += " -> " + Next.ToString() : value;
        }

        public int Size()
        {
            LinkedListNode _Pointer = Next;
            int _Count = 1;

            while (_Pointer != null)
            {
                _Count++;
                _Pointer = _Pointer.Next;
            }

            return _Count;
        }

        public LinkedListNode GetNode(int index)
        {
            if (index == 0)
            {
                return this;
            }

            LinkedListNode _Pointer = this;
            while (index > 0)
            {
                _Pointer = _Pointer.Next;
                index--;
            }

            return _Pointer;
        }

        public LinkedListNode Push(LinkedListNode node)
        {
            LinkedListNode _Pointer = this;

            while (_Pointer.Next != null)
            {
                _Pointer = _Pointer.Next;
            }

            _Pointer.Next = node;

            return this;
        }
    }
}
