using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AVLNode
    {
        public string value;
        public int height, individualCounter;
        private int offsetEstimate;
        public AVLNode left, right;
        public int OffsetEstimate
        {
            get { return offsetEstimate; }
        } 
        public AVLNode(string d, int pcount)
        {
            offsetEstimate = pcount;
            individualCounter = pcount;
            value = d;
            height = 1;
        }
    }

    public class AVLTree
    {

        public AVLNode root;
        private int count = 0;
        public int Size()
        {
            return count;
        }
        public int[] Check(string x)
        {
            int[] check = new int[2];
            AVLNode ptemp = root;
            while (ptemp != null)
            {
                int compare = string.Compare(x, ptemp.value, StringComparison.CurrentCulture);
                if(compare == -1)
                {
                    ptemp = ptemp.left;
                }
                else if(compare == 1)
                {
                    ptemp = ptemp.right;
                }
                else if(compare == 0)
                {
                    check[0] = ptemp.individualCounter;
                    check[1] = ptemp.OffsetEstimate;
                    return check;
                }
            }
            return null;
        }
        public bool Increment(AVLNode node, string key)
        {
            
            int order = string.Compare(node.value, key, StringComparison.CurrentCulture);
            if (order == -1)
                Increment(node.left, key);
            else if (order == 1)
                Increment(node.right, key);
            else
            {
                node.individualCounter++;
                return true;
            }
            return false;
        }
        public bool Decrement(AVLNode node, string key)
        {

            int order = string.Compare(node.value, key, StringComparison.CurrentCulture);
            if (order == -1)
                Decrement(node.left, key);
            else if (order == 1)
                Decrement(node.right, key);
            else
            {
                node.individualCounter--;
                return true;
            }
            return false;
        }
        // A utility function to get
        // the height of the tree
        int height(AVLNode N)
        {
            if (N == null)
                return 0;

            return N.height;
        }

        // A utility function to get
        // maximum of two integers
        int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        // A utility function to right
        // rotate subtree rooted with y
        // See the diagram given above.
        AVLNode rightRotate(AVLNode y)
        {
            AVLNode x = y.left;
            AVLNode T2 = x.right;

            // Perform rotation
            x.right = y;
            y.left = T2;

            // Update heights
            y.height = max(height(y.left),
                        height(y.right)) + 1;
            x.height = max(height(x.left),
                        height(x.right)) + 1;

            // Return new root
            return x;
        }
        
        // A utility function to left
        // rotate subtree rooted with x
        // See the diagram given above.
        AVLNode leftRotate(AVLNode x)
        {
            AVLNode y = x.right;
            AVLNode T2 = y.left;

            // Perform rotation
            y.left = x;
            x.right = T2;

            // Update heights
            x.height = max(height(x.left),
                        height(x.right)) + 1;
            y.height = max(height(y.left),
                        height(y.right)) + 1;

            // Return new root
            return y;
        }

        // Get Balance factor of node N
        public int getBalance(AVLNode N)
        {
            if (N == null)
                return 0;

            return height(N.left) - height(N.right);
        }


        public AVLNode insert(AVLNode node, string key)
        {
            {

                /* 1. Perform the normal BST insertion */
                if (node == null) 
                {
                    count++;
                    return (new AVLNode(key,count));
                    
                }
                int order = string.Compare(node.value, key, StringComparison.CurrentCulture);
                if (order == -1)
                    node.left = insert(node.left, key);
                else if (order == 1)
                    node.right = insert(node.right, key);
                else // Duplicate Keys increase count
                {
                    node.individualCounter++;
                    return node;
                }


                /* 2. Update height of this ancestor node */
                node.height = 1 + max(height(node.left),
                                height(node.right));

                /* 3. Get the balance factor of this ancestor
                    node to check whether this node became
                    unbalanced */
                int balance = getBalance(node);

                // If this node becomes unbalanced, then there
                
                int leftorder;
                int rightorder;
                if (node.left == null)
                {
                    leftorder = 0;
                }
                else
                {
                    leftorder = string.Compare(node.left.value, key, StringComparison.CurrentCulture);
                }
                if (node.right == null)
                {
                    rightorder = 0;
                }
                else
                {
                  rightorder = string.Compare(node.right.value, key, StringComparison.CurrentCulture);
                }
                // are 4 cases Left Left Case
                if (balance > 1 && leftorder == 1)
                    return rightRotate(node);

                // Right Right Case
                if (balance < -1 && rightorder == -1)
                    return leftRotate(node);

                // Left Right Case
                if (balance > 1 && leftorder == 1)
                {
                    node.left = leftRotate(node.left);
                    return rightRotate(node);
                }

                // Right Left Case
                if (balance < -1 && rightorder == -1)
                {
                    node.right = rightRotate(node.right);
                    return leftRotate(node);
                }

                /* return the (unchanged) node pointer */
                return node;
            }
        }
            

        // A utility function to print preorder traversal
        // of the tree.
        // The function also prints height of every node
        public void preOrder(AVLNode node)
        {
            if (node != null)
            {
                Console.Write(node.value + " ");
                preOrder(node.left);
                preOrder(node.right);
            }
        }
    }
}


