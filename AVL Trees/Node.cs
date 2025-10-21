using System;

namespace AVLTreeDemo{
    // Represents a single node in the AVL tree
    public class Node
    {
        public int Value;         // The data value of the node
        public Node Left;         // Reference to left child
        public Node Right;        // Reference to right child
        public int Height;        // Height of the node in the tree

        public Node(int value)
        {
            Value = value;
            Height = 1; // A new node starts with height 1
        }
    }
}
