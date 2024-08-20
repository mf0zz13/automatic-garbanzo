using System;

namespace WeekSevenAssignments
{
    internal static class AssignmentSevenThree
    {
        public static void SevenThree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Console.WriteLine("This part will take values to create a Binary Search Tree, and then allow you to search for a value");
            Console.Write("How many items would you like to put in the tree: ");
            int numItems = InputValidation.Ints.GetNum();

            for(int i = 1; i <= numItems; i++)
            {
                Console.Write($"{i}: ");
                tree.InsertNode(tree.Root, InputValidation.Ints.GetNum());
            }

            Console.WriteLine();
            Console.Write("What number would you like to search: ");
            int searchNum = InputValidation.Ints.GetNum();

            tree.Search(searchNum,tree.Root);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    internal class Node
    {
        #region Fields
        private Node _left;
        private Node _right;
        private int _data;
        #endregion

        #region Properties
        public Node LessThan
        { get => _left; set => _left = value; }

        public Node MoreThan
        { get => _right; set => _right = value; }

        public int Data
        { get => _data; set => _data = value; }
        #endregion

        #region Constructor
        public Node(int data, Node left = null, Node right = null)
        {
            _left = left;
            _right = right;
            _data = data;
        }
        #endregion
    }

    internal class BinarySearchTree
    {
        #region Fields
        private Node _rootNode;
        #endregion

        #region Properties
        public Node Root
        { get => _rootNode; }
        #endregion

        #region Constructor
        public BinarySearchTree()
        {
            _rootNode = null;
        }
        #endregion

        #region Methods
        public void InsertNode(Node root, int val)
        {
            Node tempRoot = root;
            Node newNode = new Node(val);

            if (_rootNode != null)
            {
                if (root != null)
                {
                    if (root.Data == val) { return; }
                    else if (val < root.Data)
                    {
                        InsertNode(root.LessThan, val);
                        if (root.LessThan == null) { root.LessThan = newNode; }
                    }
                    else
                    {
                        InsertNode(root.MoreThan, val);
                        if (root.MoreThan == null) { root.MoreThan = newNode; }
                    }
                }
                else { root = newNode; }
            }
            else { _rootNode = newNode; }
        }
            #endregion


            public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.LessThan);
                Console.Write($"{root.Data} ");
                InOrder(root.MoreThan);
            }
        }

        public void Search(int val, Node root)
        {
            if (root != null)
            {
                if (val < root.Data) { Search(val, root.LessThan); }
                else if (val > root.Data) { Search(val, root.MoreThan); }
                else if (val == root.Data) { Console.Write($"{val} is in tree, its subtree consists of "); this.InOrder(root); }
            }
            if (root == null) { Console.WriteLine($"{val} is not in tree"); }

        }
    }
}