using Structures;
using System;

namespace LeetCodeConsole
{
    public static class ValidBinarySearchTree
    {
        public static void Run()
        {
            BinaryTreeNode<int> _Node = new BinaryTreeNode<int>(5);
            _Node.Left = new BinaryTreeNode<int>(4);
            _Node.Right = new BinaryTreeNode<int>(7);

            Console.WriteLine(IsValidBinarySearchTree(_Node));
        }

        private static bool IsValidBinarySearchTree(BinaryTreeNode<int> node)
        {
            if (node.Left == null && node.Right == null)
            {
                return true;
            }

            return IsValidBinarySearchTreeHelper(node, int.MinValue, int.MaxValue);
        }

        private static bool IsValidBinarySearchTreeHelper(BinaryTreeNode<int> node, int lower, int upper)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Value > lower && node.Value < upper &&
                IsValidBinarySearchTreeHelper(node.Left, lower, node.Value) &&
                IsValidBinarySearchTreeHelper(node.Right, node.Value, upper))
            {
                return true;
            }

            return false;
        }
    }
}
