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
    }
}
