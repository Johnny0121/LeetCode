using Structures;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    // Problem prompt: https://i.gyazo.com/65eec5e926caa8b1e2bc9c4204101b78.png
    public static class BranchSums
    {
        public static void Run()
        {
            System.Console.WriteLine(string.Join(", ", Sums(GetTree())));
        }

        public static IList<int> Sums(BinaryTreeNode<int> root)
        {
            IList<int> _Sums = new List<int>();
            SumsHelper(root, 0, _Sums);
            return _Sums;
        }

        private static void SumsHelper(BinaryTreeNode<int> node, int currentSum, IList<int> sums)
        {
            int runningSum = currentSum + node.Value;

            if (node.Left == null && node.Right == null)
            {
                sums.Add(runningSum);
                return;
            }

            if (node.Left != null)
            {
                SumsHelper(node.Left, runningSum, sums);
            }

            if (node.Right != null)
            {
                SumsHelper(node.Right, runningSum, sums);
            }
        }

        private static BinaryTreeNode<int> GetTree()
        {
            BinaryTreeNode<int> _Root = new BinaryTreeNode<int>(1);

            _Root.Left = new BinaryTreeNode<int>(2);
            _Root.Right = new BinaryTreeNode<int>(3);
            _Root.Left.Left = new BinaryTreeNode<int>(4);
            _Root.Left.Right = new BinaryTreeNode<int>(5);
            _Root.Right.Left = new BinaryTreeNode<int>(6);
            _Root.Right.Right = new BinaryTreeNode<int>(7);
            _Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            _Root.Left.Left.Right = new BinaryTreeNode<int>(9);
            _Root.Left.Right.Left = new BinaryTreeNode<int>(10);

            return _Root;
        }
    }
}
