/// In this code we will look at AVL Trees and see how the work and their properties and benifits 

// They are self balancing binary search trees 

/*

    Workings : 
    - At most has 2 children 
    - Left child smaller value 
    - right child larger value 

    Properties : 
    - Keeps self balanced 
    - Calculating the balance factor : 
        - Balance factor = height of left subtree - height of right subtree 
        - If balance factor is 1, 0, or -1, the tree is balanced 
        - If balance factor is greater than 1, the tree is left heavy 
        - If balance factor is less than -1, the tree is right heavy 

    Rotations : 
        Right Rotations : Used in a node is unbalanced becuase of the left hand side 
        Left Rotations : Used in a node is unbalanced becuase of the right hand side   
        Right-Left Roatinos : A combinations of Left Right Roations 
        Left-Right Rotations : A combinations of Right Left Rotations 


    Examples : 

    10, 20, 30 
// Balanced        // Unbalanced             // Balanced        
      10                10                        20
       \                 \                      /   \
       20                20                   10    30
                          \
                          30

    // now we are going to insert 30 

        // https://www.geeksforgeeks.org/dsa/introduction-to-avl-tree/
        // https://www.geeksforgeeks.org/dsa/insertion-in-an-avl-tree/
        // https://www.geeksforgeeks.org/dsa/deletion-in-an-avl-tree/

*/


using System;
using System.Windows.Markup;

namespace AVLTreeDemo{
    class Program{
        static void Main(string[] args){
            AVLTree tree = new AVLTree();

            // insert Values into tree
            int[] value = {10, 20, 30, 40, 50, 25};

            foreach (int val in value){
                tree.Root = tree.Insert(tree.Root, val);
            }

            // print the tree 
            Console.WriteLine("Inorder traversal of the tree : ");
            tree.InOrder(tree.Root);
            Console.WriteLine();
        }
    }
}