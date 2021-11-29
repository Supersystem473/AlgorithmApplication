using System;

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
                if (compare == -1)
                {
                    ptemp = ptemp.left;
                }
                else if (compare == 1)
                {
                    ptemp = ptemp.right;
                }
                else if (compare == 0)
                {
                    check[0] = ptemp.individualCounter;
                    check[1] = ptemp.OffsetEstimate;
                    return check;
                }
            }
            return null;
        }
        public bool Increment(AVLNode ptemp, string x)
        {

            while (ptemp != null)
            {
                int compare = string.Compare(x, ptemp.value, StringComparison.CurrentCulture);
                if (compare == -1)
                {
                    ptemp = ptemp.left;
                }
                else if (compare == 1)
                {
                    ptemp = ptemp.right;
                }
                else if (compare == 0)
                {
                    ptemp.individualCounter++;
                }
                return true;
            }
            return false;
        }
        public bool Decrement(AVLNode ptemp, string x)
        {

            int order = string.Compare(ptemp.value, x, StringComparison.CurrentCulture);
            while (ptemp != null)
            {
                int compare = string.Compare(x, ptemp.value, StringComparison.CurrentCulture);
                if (compare == -1)
                {
                    ptemp = ptemp.left;
                }
                else if (compare == 1)
                {
                    ptemp = ptemp.right;
                }
                else if (compare == 0)
                {
                    ptemp.individualCounter--;
                    return true;
                }
            }
            return false;
        }
        public void DecrementAll(AVLNode ptemp)
        {
            if(ptemp.left != null)
            {
                DecrementAll(ptemp.left);
                ptemp.left.individualCounter--;
                if(ptemp.left.individualCounter == 0)
                {
                    RemoveLeft(ptemp, ptemp.left);
                }
            }
            if(ptemp.right != null)
            {
                DecrementAll(ptemp.right);
                ptemp.right.individualCounter--;
                if(ptemp.right.individualCounter == 0)
                {
                    RemoveRight(ptemp, ptemp.right);
                }
            }
            if (ptemp == root)
            {
                ptemp.individualCounter--;
                if(ptemp.individualCounter == 0)
                {
                    RemoveRoot(ptemp);
                }
            }
        }
        public void RemoveRoot(AVLNode node)
        {
            AVLNode x = null;
            AVLNode y = null;
            if(node.right == null && node.left == null)
            {
                root = null;
            }
            else if(node.right != null && node.left == null)
            {
                root = node.right;
            }
            else if(node.left != null && node.right == null)
            {
                root = node.left;
            }
            else
            {
                x = node.right;
                
                while(x.left!= null)
                {
                    y = x;
                    x = x.left;
                }
                if(x.right != null)
                {
                    y.left = x.right;
                }
                x.left = root.left;
                x.right = root.right;
                root = x;
            }
        }
        public void RemoveRight(AVLNode parent, AVLNode node)
        {
            AVLNode x;
            AVLNode Y;
            if (node.right == null && node.left == null)
            {
                parent.right = null;
            }
            else if (node.right != null && node.left == null)
            {
                parent.right = node.right;
            }
            else if (node.left != null && node.right == null)
            {
                parent.right = node.left;
            }
            else
            {
                x = node.right;
                Y = node;
                while(node.left != null)
                {
                    Y = x;
                    x = x.left;
                }
                if(x.right != null)
                {
                    Y.left = x.right;
                }
                parent.right = x;
                x.left = node.left;
                x.right = node.right;
            }
        }
        public void RemoveLeft(AVLNode parent, AVLNode node)
        {
            AVLNode x;
            AVLNode Y;
            if (node.right == null && node.left == null)
            {
                parent.left = null;
            }
            else if (node.right != null && node.left == null)
            {
                parent.left = node.right;
            }
            else if (node.left != null && node.right == null)
            {
                parent.left = node.left;
            }
            else
            {
                x = node.right ;
                Y = node;
                while (node.left != null)
                {
                    Y = x;
                    x = x.left;
                }
                if (x.right != null)
                {
                    Y.left = x.right;
                }
                parent.left = x;
                x.left = node.left;
                x.right = node.right;
            }
        }
        public string Results(AVLNode node)
        {
            string results = node.value;
            if (node.left != null)
            {
                results = results + "," + Results(node.left);
            }
            if(node.right != null)
            {
                results = results + "," + Results(node.right);
            }
            return results;
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

        AVLNode minValueNode(AVLNode node)
        {
            AVLNode current = node;

            /* loop down to find the leftmost leaf */
            while (current.left != null)
                current = current.left;

            return current;
        }
        AVLNode deleteNode(AVLNode node, int s)
        {
            AVLNode templ, tempr;
            if (node.left.individualCounter - node.left.OffsetEstimate < s)
            {

            }
            // If the tree had only one node then return
            if (node == null)
                return node;

            // STEP 2: UPDATE HEIGHT OF THE CURRENT NODE
            node.height = max(height(node.left),
                        height(node.right)) + 1;

            // STEP 3: GET THE BALANCE FACTOR
            // OF THIS NODE (to check whether
            // this node became unbalanced)
            int balance = getBalance(node);

            // If this node becomes unbalanced,
            // then there are 4 cases
            // Left Left Case
            if (balance > 1 && getBalance(node.left) >= 0)
                return rightRotate(node);

            // Left Right Case
            if (balance > 1 && getBalance(node.left) < 0)
            {
                node.left = leftRotate(node.left);
                return rightRotate(node);
            }

            // Right Right Case
            if (balance < -1 && getBalance(node.right) <= 0)
                return leftRotate(node);

            // Right Left Case
            if (balance < -1 && getBalance(node.right) > 0)
            {
                node.right = rightRotate(node.right);
                return leftRotate(node);
            }

            return node;
        }
        public AVLNode insert(AVLNode node, string key)
        {


            /* 1. Perform the normal BST insertion */
            if (node == null)
            {
                count++;
                return (new AVLNode(key, count));

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
    /* public AVLNode RemoveNode(AVLNode node)
     {
         AVLNode temp1, temp2;
         if (node.left == null && node.right == null)
             return null;
         else if (node.left != null && node.right == null)
             return node.left;
         else if (node.right != null && node.left == null)
             return node.right;
         else
         {
             temp1 = node.left.right;
             node.left.right = node.right;
             temp2 = node.right;
             while (temp2.left != null)
             {
                 temp2 = temp2.left;
             }
             temp2.left = temp1;
         }
     }

     */
}



