namespace Advanced_Data_Structures.Structures
{
    using System;

    class PriorityQueue<T> where T : IComparable
    {
        private BinaryMaxHeap<T> heap;

        public PriorityQueue()
        {
            this.heap = new BinaryMaxHeap<T>();
        }

        public TreeNode<T> TopNode
        {
            get { return this.heap.Tree.Root; }
        }

        public void Enqueue(T value)
        {
            this.heap.Add(value);
        }

        public void Dequeue()
        {
            TreeNode<T> root = this.heap.Tree.Root;
            T result = root.Value;

            TreeNode<T> left = root.LeftChild;
            TreeNode<T> right = root.RightChild;

            if (left.Value.CompareTo(right.Value) >= 0)
            {
                this.heap.Tree.Root = left != null ? left : right;
                if (this.heap.Tree.Root != null)
                {
                    Append(this.heap.Tree.Root, right);
                }
            }
            else
            {
                this.heap.Tree.Root = right != null ? right : left;
                if (this.heap.Tree.Root != null)
                {
                    Append(this.heap.Tree.Root, left);
                }
            }
        }

        private void Append(TreeNode<T> parrent, TreeNode<T> newNode)
        {
            if (parrent == null)
            {
                return;
            }

            if (parrent.LeftChild != null)
            {
                Append(parrent.LeftChild, newNode);
                this.heap.ReOrder(parrent.LeftChild);
            }

            parrent.LeftChild = newNode;
        }

        public T Peek()
        {
            return this.heap.Tree.Root.Value;
        }
    }
}
