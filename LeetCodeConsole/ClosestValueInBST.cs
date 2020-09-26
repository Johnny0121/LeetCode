using Structures;
using System;

namespace LeetCodeConsole
{
    public static class ClosestValueInBST
    {
        public static void Run()
        {
            Console.WriteLine(Closest(GetTree(), 12));
        }

        public static int Closest(BinaryTreeNode<int> tree, int target)
        {
            int _Closest = int.MaxValue;
            BinaryTreeNode<int> _CurrentNode = tree;

            while (true)
            {
                if (_CurrentNode.Value == target)
                {
                    return target;
                }

                int _Diff = Math.Abs(_CurrentNode.Value - target);
                if (_Diff < Math.Abs(_Closest - target))
                {
                    _Closest = _CurrentNode.Value;
                }

                if (target > _CurrentNode.Value)
                {
                    if (_CurrentNode.Right == null)
                    {
                        break;
                    }

                    _CurrentNode = _CurrentNode.Right;
                }
                else if (target < _CurrentNode.Value)
                {
                    if (_CurrentNode.Left == null)
                    {
                        break;
                    }

                    _CurrentNode = _CurrentNode.Left;
                }
            }

            return _Closest;
        }

        public static BinaryTreeNode<int> GetTree()
        {
            BinaryTreeNode<int> _Root = new BinaryTreeNode<int>(10);

            _Root.Left = new BinaryTreeNode<int>(5);
            _Root.Left.Right = new BinaryTreeNode<int>(5);
            _Root.Left.Left = new BinaryTreeNode<int>(2);

            _Root.Right = new BinaryTreeNode<int>(15);
            _Root.Right.Right = new BinaryTreeNode<int>(22);
            _Root.Right.Left = new BinaryTreeNode<int>(13);
            _Root.Right.Left.Right = new BinaryTreeNode<int>(14);

            return _Root;
        }
    }
}
