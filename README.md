# AVL Tree Demo

This project demonstrates the implementation of an **AVL Tree** in C#.
An AVL Tree is a type of **self-balancing Binary Search Tree (BST)** that automatically maintains its height balance after every insertion or deletion operation.
This ensures that search, insertion, and deletion operations all occur in **O(log n)** time complexity.

---

## What’s Included

### **1. Node.cs**

Defines a single node in the AVL Tree.

Each node contains:

* `Value`: The integer value stored in the node.
* `Left` and `Right`: References to the left and right child nodes.
* `Height`: The height of the node, used to check balance.

### **2. AVLTree.cs**

Implements the AVL Tree logic.

It includes:

* **Insertion** with automatic balancing.
* **Rotations** to maintain balance:

  * Left Rotation (RR)
  * Right Rotation (LL)
  * Left-Right Rotation (LR)
  * Right-Left Rotation (RL)
* **In-order traversal** to print the tree in sorted order.

---

## How It Works

When inserting a new value:

1. The value is inserted just like in a Binary Search Tree (BST).
2. The height of the affected nodes is updated.
3. The balance factor is checked.
4. If the tree becomes unbalanced, it performs one of four types of rotations to rebalance itself.

The AVL Tree ensures that the **height difference** (balance factor) between the left and right subtrees of any node never exceeds 1.

---

## Example Output

### Input:

```csharp
int[] values = { 10, 20, 30, 15, 25, 5, 1 };
            foreach (int val in values)
            {
                tree.Insert(val);
            }

            Console.WriteLine("In-order traversal with colors:");
            tree.InOrder(tree.Root);
```

### Output:

```
1(R) 5(B) 10(R) 15(B) 20(B) 25(R) 30(B)
```

The AVL Tree automatically rebalances itself after each insertion.

---

## Key Methods

| Method                         | Description                                            |
| ------------------------------ | ------------------------------------------------------ |
| `Insert(Node node, int value)` | Inserts a new value and rebalances the tree if needed. |
| `RotateLeft(Node x)`           | Performs a left rotation for Right-Right imbalance.    |
| `RotateRight(Node y)`          | Performs a right rotation for Left-Left imbalance.     |
| `InOrder(Node node)`           | Traverses and prints the tree in sorted order.         |
| `GetBalance(Node node)`        | Calculates the balance factor of a node.               |

---

## How to Run

1. Clone this repository:

   ```bash
[   git clone https://github.com/yourusername/AVLTreeDemo.git
](https://github.com/minermikey/Red-Black-Tree.git)
```

2. Open the project in **Visual Studio** or **VS Code**.

3. Build and run the project:

   ```bash
   dotnet run
   ```

4. Observe the console output showing the sorted tree traversal.

---

## Example Tree Visualization

After inserting the values 10, 20, and 30, the AVL Tree performs a rotation and becomes:

```
    20
   /  \
 10    30
```

---

## Concepts Covered

* Binary Search Tree (BST)
* Tree Balancing
* Node Rotations
* Recursion
* Tree Traversal
