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
            bst.Display();
        }
    }
}
