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
        public int height, count = 1;
        public AVLNode left, right;

        public AVLNode(string d)
        {
            value = d;
            height = 1;
        }
    }

    public class AVLTree
    {

        public AVLNode root;
        /*
        private string[,] AlphabeticalOrder = new string[,] {
                                                               {"1","-9"},
                                                               {"2", "-8" },
                                                               {"3","-7" },
                                                               {"4","-6" },
                                                               {"5","-5" },
                                                               {"6","-4" },
                                                               {"7","-3" },
                                                               {"8","-2" },
                                                               {"9", "-1" },
                                                               {"A","1"},
                                                               {"B","2"},
                                                               {"C","3"},
                                                               {"D","4"},
                                                               {"E","5"},
                                                               {"F","6"},
                                                               {"G","7"},
                                                               {"H","8"},
                                                               {"I","9"},
                                                               {"J","10"},
                                                               {"K","11"},
                                                               {"L","12" },
                                                               {"M","13" },
                                                               {"N","14" },
                                                               {"O","15" },
                                                               {"P","16" },
                                                               {"Q","17" },
                                                               {"R","18" },
                                                               {"S","19" },
                                                               {"T","20" },
                                                               {"U","21" },
                                                               {"V","22" },
                                                               {"W","23" },
                                                               {"X", "24" },
                                                               {"Y","25" },
                                                               {"Z","26" } };
        */
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
                    return (new AVLNode(key));
                int order = string.Compare(node.value, key, StringComparison.CurrentCulture);
                if (order == -1)
                    node.left = insert(node.left, key);
                else if (order == 1)
                    node.right = insert(node.right, key);
                else // Duplicate keys not allowed
                {
                    node.count++;
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
                // are 4 cases Left Left Case
                int leftorder = string.Compare(node.left.value, key, StringComparison.CurrentCulture);
                int rightorder = string.Compare(node.right.value, key, StringComparison.CurrentCulture);
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


