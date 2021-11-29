using System;

namespace WindowsFormsApp1
{
    enum Color
    {
        Red,
        Black
    }
    class Red_BlackTree
    {
        private int size = 0;
        public int resultNum;
        public int Size
        {
            get { return size; }
        }




        /// <summary>
        /// Object of type Node contains 4 properties
        /// Colour
        /// Left
        /// Right
        /// Parent
        /// Data
        /// </summary>
        public class RBNode
        {
            public int Counter, OffsetCounter;
            public Color colour;
            public RBNode left;
            public RBNode right;
            public RBNode parent;
            public string data;

            public RBNode(string data, int s) { this.data = data; Counter = s; OffsetCounter = s; }
            public RBNode(Color colour) { this.colour = colour; }
            public RBNode(string data, Color colour) { this.data = data; this.colour = colour; }
        }
        /// <summary>
        /// Root node of the tree (both reference & pointer)
        /// </summary>
        public RBNode root;
        /// <summary>
        /// New instance of a Red-Black tree object
        /// </summary>
        public Red_BlackTree() { }
        /// <summary>
        /// Left Rotate
        /// </summary>
        /// <param name="X"></param>
        /// <returns>void</returns>
        private void LeftRotate(RBNode X)
        {
            RBNode Y = X.right; // set Y
            X.right = Y.left;//turn Y's left subtree into X's right subtree
            if (Y.left != null)
            {
                Y.left.parent = X;
            }
            if (Y != null)
            {
                Y.parent = X.parent;//link X's parent to Y
            }
            if (X.parent == null)
            {
                root = Y;
            }
            else if (X == X.parent.left)
            {
                X.parent.left = Y;
            }
            else
            {
                X.parent.right = Y;
            }
            Y.left = X; //put X on Y's left
            if (X != null)
            {
                X.parent = Y;
            }

        }
        /// <summary>
        /// Rotate Right
        /// </summary>
        /// <param name="Y"></param>
        /// <returns>void</returns>
        private void RightRotate(RBNode Y)
        {
            // right rotate is simply mirror code from left rotate
            RBNode X = Y.left;
            Y.left = X.right;
            if (X.right != null)
            {
                X.right.parent = Y;
            }
            if (X != null)
            {
                X.parent = Y.parent;
            }
            if (Y.parent == null)
            {
                root = X;
            }
            else
            {
                if (Y == Y.parent.right)
                {
                    Y.parent.right = X;
                }
                else if (Y == Y.parent.left)
                {
                    Y.parent.left = X;
                }
            }
            X.right = Y;//put Y on X's right
            if (Y != null)
            {
                Y.parent = X;
            }
        }
        /// <summary>
        /// Display Tree
        /// </summary>
        public void DisplayTree()
        {
            if (root == null)
            {
                return;
            }
            if (root != null)
            {
                InOrderDisplay(root);
            }
        }
        /// <summary>
        /// Find item in the tree
        /// </summary>
        /// <param name="key"></param>
        public RBNode Check(string key)
        {
            bool isFound = false;
            RBNode temp = root;
            RBNode item = null;
            while (!isFound)
            {
                if (temp == null)
                {
                    break;
                }
                else
                {
                    if (key.CompareTo(temp.data) == -1 && temp.left != null)
                    {
                        temp = temp.left;
                    }
                    else if (key.CompareTo(temp.data) == -1 && temp.left == null)
                    {
                        break;
                    }
                    if (key.CompareTo(temp.data) == 1 && temp.right != null)
                    {
                        temp = temp.right;
                    }
                    else if (key.CompareTo(temp.data) == 1 && temp.right == null)
                    {
                        break;
                    }
                    if (key == temp.data)
                    {
                        isFound = true;
                        item = temp;
                    }

                }
            }
            if (isFound)
            {

                return temp;
            }
            else
            {

                return null;
            }
        }
        /// <summary>
        /// Insert a new object into the RB Tree
        /// </summary>
        /// <param name="item"></param>
        public void Add(string item, int s)
        {
            RBNode newItem = new RBNode(item, s);
            size++;
            if (root == null)
            {
                root = newItem;
                root.colour = Color.Black;
                root.Counter = s;
                return;
            }
            RBNode Y = null;
            RBNode X = root;
            while (X != null)
            {
                Y = X;
                if (newItem.data.CompareTo(X.data) == -1)
                {
                    X = X.left;
                }
                else if (newItem.data.CompareTo(X.data) == 1)
                {
                    X = X.right;
                }
                else
                {
                    X.Counter++;
                    return;
                }
            }
            newItem.parent = Y;
            if (newItem.data.CompareTo(Y.data) == -1)
            {
                Y.left = newItem;
            }
            else
            {
                Y.right = newItem;
            }
            newItem.left = null;
            newItem.right = null;
            newItem.colour = Color.Red;//colour the new node red
            InsertFixUp(newItem);//call method to check for violations and fix
        }
        private void InOrderDisplay(RBNode current)
        {
            if (current != null)
            {
                InOrderDisplay(current.left);
                Console.Write("({0}) ", current.data);
                InOrderDisplay(current.right);
            }
        }
        private void InsertFixUp(RBNode item)
        {
            //Checks Red-Black Tree properties
            while (item != root && item.parent.colour == Color.Red)
            {
                /*We have a violation*/
                if (item.parent == item.parent.parent.left)
                {
                    RBNode Y = item.parent.parent.right;
                    if (Y != null && Y.colour == Color.Red)//Case 1: uncle is red
                    {
                        item.parent.colour = Color.Black;
                        Y.colour = Color.Black;
                        item.parent.parent.colour = Color.Red;
                        item = item.parent.parent;
                    }
                    else //Case 2: uncle is black
                    {
                        if (item == item.parent.right)
                        {
                            item = item.parent;
                            LeftRotate(item);
                        }
                        //Case 3: recolour & rotate
                        item.parent.colour = Color.Black;
                        item.parent.parent.colour = Color.Red;
                        RightRotate(item.parent.parent);
                    }

                }
                else
                {
                    //mirror image of code above
                    RBNode X = null;

                    X = item.parent.parent.left;
                    if (X != null && X.colour == Color.Black)//Case 1
                    {
                        item.parent.colour = Color.Red;
                        X.colour = Color.Red;
                        item.parent.parent.colour = Color.Black;
                        item = item.parent.parent;
                    }
                    else //Case 2
                    {
                        if (item == item.parent.left)
                        {
                            item = item.parent;
                            RightRotate(item);
                        }
                        //Case 3: recolour & rotate
                        item.parent.colour = Color.Black;
                        item.parent.parent.colour = Color.Red;
                        LeftRotate(item.parent.parent);

                    }

                }
                root.colour = Color.Black;//re-colour the root black as necessary
            }
        }
        /// <summary>
        /// Deletes a specified value from the tree
        /// </summary>
        /// <param name="ptemp"></param>
        public void Delete(RBNode ptemp)
        {
            size--;
            Color ogColor = ptemp.colour;
            RBNode X = null;
            RBNode Y = null;

            if (ptemp == null)
            {
                return;
            }
            else if (ptemp == root)
            {
                root = null;
                return;
            }
            else if (ptemp.left == null && ptemp.right == null)
            {
                if (ptemp == ptemp.parent.left)
                    ptemp.parent.left = null;
                else
                    ptemp.parent.right = null;
            }
            Y = ptemp;
            if (ptemp.left == null)
            {
                X = ptemp.right;
                Transplant(ptemp, ptemp.right);
            }
            else if (ptemp.right == null)
            {
                X = ptemp.left;
                Transplant(ptemp, ptemp.left);
            }
            else
            {
                Y = TreeSuccessor(ptemp.right);
                ogColor = Y.colour;
                X = Y.right;
                if (Y.right == null) { }
                else if (Y.parent == ptemp)
                {
                    X.parent = Y;
                }
                else
                {
                    Transplant(Y, Y.right);
                    Y.right = ptemp.right;
                    Y.right.parent = Y;
                }
                Y.left = ptemp.left;
                Y.left.parent = Y.right.parent;
                Y.colour = ptemp.colour;

            }
            if (ogColor == Color.Black)
            {
                DeleteFixUp(X);
            }



            //if (ptemp.left == null || ptemp.right == null)
            //{
            //    Y = ptemp;
            //}

            //else
            //{
            //    Y = TreeSuccessor(ptemp);
            //}
            //if (Y.left != null)
            //{
            //    X = Y.left;
            //}
            //else
            //{
            //    X = Y.right;
            //}
            //if (X != null)
            //{
            //    X.parent = Y;
            //}
            //if (Y.parent == null)
            //{
            //    root = X;
            //}
            //else if (Y == Y.parent.left)
            //{
            //    Y.parent.left = X;
            //}
            //else
            //{
            //    Y.parent.right = X;
            //}
            //if (Y != ptemp)
            //{
            //    ptemp.data = Y.data;
            //}
            //if (Y.colour == Color.Black)
            //{
            //    DeleteFixUp(X);
            //}

        }
        private void Transplant(RBNode u, RBNode v)
        {
            if (u.parent == null)
                root = v;
            else if (u == u.parent.left)
                u.parent.left = v;
            else
                u.parent.right = v;
            if (v != null)
                v.parent = u.parent;
        }
        /// <summary>
        /// Checks the tree for any violations after deletion and performs a fix
        /// </summary>
        /// <param name="X"></param>
        private void DeleteFixUp(RBNode X)
        {

            while (X != null && X != root && X.colour == Color.Black)
            {
                if (X == X.parent.left)
                {
                    RBNode W = X.parent.right;
                    if (W == null)
                    {
                        X.colour = Color.Red;
                    }
                    else if (W.colour == Color.Red)
                    {
                        W.colour = Color.Black; //case 1
                        X.parent.colour = Color.Red; //case 1
                        LeftRotate(X.parent); //case 1
                        W = X.parent.right; //case 1
                    }
                    else if (W.left.colour == Color.Black && W.right.colour == Color.Black)
                    {
                        if (W.left != null)
                            W.colour = Color.Red; //case 2
                        X = X.parent; //case 2
                    }
                    else if (W.right.colour == Color.Black)
                    {
                        W.left.colour = Color.Black; //case 3
                        W.colour = Color.Red; //case 3
                        RightRotate(W); //case 3
                        W = X.parent.right; //case 3
                    }
                    else
                    {
                        W.colour = X.parent.colour; //case 4
                        X.parent.colour = Color.Black; //case 4
                        W.right.colour = Color.Black; //case 4
                        LeftRotate(X.parent); //case 4
                        X = root; //case 4
                    }

                }
                else //mirror code from above with "right" & "left" exchanged
                {
                    RBNode W = X.parent.left;
                    if (W.colour == Color.Red)
                    {
                        W.colour = Color.Black;
                        X.parent.colour = Color.Red;
                        RightRotate(X.parent);
                        W = X.parent.left;
                    }
                    if (W.right.colour == Color.Black && W.left.colour == Color.Black)
                    {
                        W.colour = Color.Black;
                        X = X.parent;
                    }
                    else if (W.left.colour == Color.Black)
                    {
                        W.right.colour = Color.Black;
                        W.colour = Color.Red;
                        LeftRotate(W);
                        W = X.parent.left;
                    }
                    W.colour = X.parent.colour;
                    X.parent.colour = Color.Black;
                    W.left.colour = Color.Black;
                    RightRotate(X.parent);
                    X = root;
                }
            }
            if (X != null)
                X.colour = Color.Black;
        }
        private RBNode Minimum(RBNode X)
        {
            if (X.left == null)
            {
                return X;
            }
            if (X.left.left == null)
            {
                return X.left.left;
            }
            else
            {
                while (X.left.left != null)
                {
                    X = X.left;
                }
                return X;
            }
        }
        public void Increment(string x)
        {
            Check(x).Counter++;
        }
        public void Decrement(string x)
        {
            Check(x).Counter--;
        }
        private RBNode TreeSuccessor(RBNode X)
        {
            if (X.left != null && X.right != null)
            {
                return Minimum(X.right);
            }
            else
            {
                RBNode Y = X.parent;
                while (Y != null && X == Y.right)
                {
                    X = Y;
                    Y = Y.parent;
                }
                return Y;
            }
        }
        public string get_larger_than(double s, RBNode ptemp)
        {
            string results = "";
            if (ptemp == null)
            {
                return results;
            }
            if (ptemp.left != null)
            {
                results += get_larger_than(s, ptemp.left);
            }
            if (ptemp.right != null)
            {
                results += get_larger_than(s, ptemp.right);
            }


            if (ptemp.Counter - ptemp.OffsetCounter >= s)
            {
               
                results = ptemp.data + " " + results;
                resultNum++;
            }
            return results;
        }

        public void remove_small(int s, RBNode ptemp)

        {
            if (ptemp == null)
            {
                return;
            }
            else if (ptemp.left != null)
            {
                remove_small(s, ptemp.left);
            }
            if (ptemp.right != null)
            {
                remove_small(s, ptemp.right);
            }

            if (ptemp.Counter - ptemp.OffsetCounter < s)
            {
                size--;
                Delete(ptemp);
            }
        }
    }
}
