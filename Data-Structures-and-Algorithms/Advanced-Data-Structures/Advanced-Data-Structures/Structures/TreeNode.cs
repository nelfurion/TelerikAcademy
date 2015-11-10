namespace Advanced_Data_Structures.Structures
{
    using System;

    class TreeNode<T> where T : IComparable
    {
        private T value;
        private TreeNode<T> leftChild;
        private TreeNode<T> rightChild;

        public TreeNode(T value)
        {
            this.value = value;
        }

        public TreeNode(TreeNode<T> leftChild, TreeNode<T> rightChild, T value)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public TreeNode<T> LeftChild
        {
            get { return this.leftChild; }
            set { this.leftChild = value; }
        }

        public TreeNode<T> RightChild
        {
            get { return this.rightChild; }
            set { this.rightChild = value; }
        }
    }
}
