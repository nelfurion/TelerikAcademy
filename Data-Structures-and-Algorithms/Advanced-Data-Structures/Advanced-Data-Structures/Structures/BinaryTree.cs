namespace Advanced_Data_Structures.Structures
{
    using System;

    class BinaryTree<T> where T : IComparable
    {
        private TreeNode<T> root;

        public BinaryTree() { }

        public BinaryTree(TreeNode<T> root)
        {
            this.Root = root;
        }

        public TreeNode<T> Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public void Add(TreeNode<T> node)
        {
            if (this.Root == null)
            {
                this.Root = node;
            }
            else
            {
                TraverseToAdd(this.Root, node);
            }
        }

        private void TraverseToAdd(TreeNode<T> node, TreeNode<T> newNode)
        {
            if (node == null)
            {
                node = newNode;
                return;
            }

            if (newNode.Value.CompareTo(node.Value) < 0)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = newNode;
                    return;
                }

                TraverseToAdd(node.LeftChild, newNode);
            }
            else if (newNode.Value.CompareTo(node.Value) > 0)
            {
                if (node.RightChild == null)
                {
                    node.RightChild = newNode;
                    return;
                }

                TraverseToAdd(node.RightChild, newNode);
            }
        }
    }
}
