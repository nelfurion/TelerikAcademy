/*
Implement a class PriorityQueue<T> based on the data structure "binary heap".
*/
namespace Advanced_Data_Structures
{
    using System;
    using Advanced_Data_Structures.Structures;

    class PriorityQueueExample
    {
        static void Main(string[] args)
        {
            TreeNode<int> root = new TreeNode<int>(5);
            BinaryTree<int> binaryTree = new BinaryTree<int>(root);

            BinaryMaxHeap<int> heap = new BinaryMaxHeap<int>();

            PriorityQueue<int> queue = new PriorityQueue<int>();

            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(7);

            DFS(queue.TopNode, 0);
            //Console.WriteLine(queue.Peek());
            Console.WriteLine(new string('-', 20));
            queue.Dequeue();
            DFS(queue.TopNode, 0);
        }

        public static void DFS(TreeNode<int> node, int spaceCount)
        {
            if (node == null)
            {
                return;
            }

            DFS(node.LeftChild, spaceCount + 4);
            Console.WriteLine(new string(' ', spaceCount / 2) + "│" + new string('─', spaceCount / 2) + node.Value);
            DFS(node.RightChild, spaceCount + 4);
        }
    }
}
