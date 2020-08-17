namespace Structures
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value, BinaryTreeNode left, BinaryTreeNode right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}
