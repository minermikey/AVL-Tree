namespace AVLTreeDemo
{

    public class AVLTree {

        // creating an instance of the root node 
        public Node Root;


        // getting the heigt of the node 
        private int Height(Node node) {
            return node?.Height ?? 0; 
        }

        // Helper getting the balance factor 
        private int Getbalance(Node node)
        {
            return node == null ? 0 : Height(node.Left) - Height(node.Right);
        }

        // Helper update Height 
         private void UpdateHeight(Node node)
        {
            // this height is used further on to calculate the taller child to get the height 
            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
        }

        // Creating the Right Rotation 
        private Node RotateRight(Node y) {

            Node x = y.Left;
            Node T2 = x.Right;

            // Preform Rotation 
            x.Right = y;
            y.Left = T2;

            // Update Heights 
            UpdateHeight(y);
            UpdateHeight(x);

            return x;

        }

        // Left rotation (RR Case)
        private Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            UpdateHeight(x);
            UpdateHeight(y);

            // Return new root
            return y;
        }


        // Insert Node 
        public Node Insert(Node node, int value) {

            // preform the Standard SBT insertion 
            // if there is no node yet or we reached a empty spot in the tree create a new node 
             if (node == null)
                return new Node(value);

            if (value < node.Value) // is the new value ( node ) is smalled then the current node or value 
            node.Left = Insert(node.Left, value); // insert the information on the left hand side ( Left Child )
            else if (value > node.Value) // is the new value larger than the current node
            node.Right = Insert(node.Right, value); // insert it on the right hand side 
            else
            return node; // Duplicate values not allowed
            // This if statement will continue until a empty node is found. 
            

            /* 
            ( recalculate the height after the insertion is completed )
            Height = 1 ( Parent ) + the taller of the 2 children
            */ 
            UpdateHeight(node);

            // getting to see is the node is balanced or not
            // balance = height(Left) - Height(Right) 
            // if its equal to -1, 0, 1 then we chilling if greater then rotate 
            int balance = Getbalance(node);

            // Case 1: Left Left
            //The left side is too tall because a node was inserted into the left child’s left subtree.
            //Fix: perform a right rotation.
            if (balance > 1 && value < node.Left.Value)
                return RotateRight(node);

            // Case 2: Right Right
            //The right side is too tall because of an insert in the right child’s right subtree.
            // Fix: perform a left rotation.
            if (balance < -1 && value > node.Right.Value)
                return RotateLeft(node);

            // Case 3: Left Right
            // Inserted into left child’s right subtree.
            // Fix: do two rotations (left rotation on child, then right rotation on parent).
            if (balance > 1 && value > node.Left.Value)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            // Case 4: Right Left
            //Inserted into right child’s left subtree.
            // Fix: do two rotations (right rotation on child, then left rotation on parent).
            if (balance < -1 && value < node.Right.Value)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            // Return the (unchanged) node pointer
            return node;

         }

         // This is a simple method but its an important method. 

         public void InOrder(Node node)
        {
            if (node != null)
            {
                // This goes in order frmo left child to right child 
                InOrder(node.Left); // this prints it out 
                Console.Write(node.Value + " ");
                InOrder(node.Right);
            }
        }

        

    }

} 