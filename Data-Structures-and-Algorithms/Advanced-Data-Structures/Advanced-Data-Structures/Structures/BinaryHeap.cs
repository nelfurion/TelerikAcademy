namespace Advanced_Data_Structures.Structures
{
    using System;

    class BinaryMaxHeap<T> where T : IComparable
    {
        private BinaryTree<T> tree; //this can be just node, not a tree
        private int leftLength;
        private int rightLength;

        public BinaryMaxHeap()
        {
            this.tree = new BinaryTree<T>();
            this.rightLength = 0;
            this.leftLength = 0;
        }

        public BinaryTree<T> Tree
        {
            get { return this.tree; }
        }

        public void Add(T value)
        {
            if (this.Tree.Root == null)
            {
                this.Tree.Root = new TreeNode<T>(value);
                return;
            }

            if (this.tree.Root.LeftChild == null)
            {
                this.Tree.Root.LeftChild = new TreeNode<T>(value);
                this.leftLength++;
                ReOrder(this.Tree.Root);
                return;
            }

            if (this.tree.Root.RightChild == null)
            {
                this.Tree.Root.RightChild = new TreeNode<T>(value);
                this.rightLength++;
                ReOrder(this.Tree.Root);
                return;
            }

            TraverseToAdd(this.Tree.Root, value);
        }

        private void TraverseToAdd(TreeNode<T> node, T newValue)
        {
            if (node == null)
            {
                return;
            }

            if (this.leftLength < this.rightLength)
            {
                if (node.LeftChild != null)
                {
                    TraverseToAdd(node.LeftChild, newValue);
                    ReOrder(node);
                    return;
                }

                if (node.RightChild == null)
                {
                    node.RightChild = new TreeNode<T>(newValue);
                    ReOrder(node);
                }
                else
                {
                    node.LeftChild = new TreeNode<T>(newValue);
                    ReOrder(node);
                }

                this.leftLength++;
            }
            else
            {
                if (node.RightChild != null)
                {
                    TraverseToAdd(node.RightChild, newValue);
                    ReOrder(node);
                    return;
                }

                if (node.LeftChild == null)
                {
                    node.LeftChild = new TreeNode<T>(newValue);
                    ReOrder(node);
                }
                else
                {
                    node.RightChild = new TreeNode<T>(newValue);
                    ReOrder(node);
                }

                this.rightLength++;
            }
        }

        internal void ReOrder(TreeNode<T> node)
        {
            if (node.RightChild != null &&
                node.RightChild.Value.CompareTo(node.Value) > 0)
            {
                T temp = node.Value;
                node.Value = node.RightChild.Value;
                node.RightChild.Value = temp;
            }

            if ((node.LeftChild != null &&
                node.LeftChild.Value.CompareTo(node.Value) > 0))
            {
                T temp = node.Value;
                node.Value = node.LeftChild.Value;
                node.LeftChild.Value = temp;
            }
        }
    }
}
