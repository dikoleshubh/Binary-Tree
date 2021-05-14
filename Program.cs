using System;

namespace BInaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO BINARY TREE");
            BST<int> bst = new BST<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(31);
            bst.Insert(75);
            bst.Insert(15);
            bst.Insert(40);
            bst.GetSize();
            bst.Display();
            bool result = bst.Search(15, bst);
            Console.WriteLine();
            Console.WriteLine("The element 63 exists in the BST: " + bst.Search(15, bst));
            Console.Read();
        }
    }
}
