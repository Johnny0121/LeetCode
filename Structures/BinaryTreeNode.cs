namespace Structures
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value, BinaryTreeNode left = null, BinaryTreeNode right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
