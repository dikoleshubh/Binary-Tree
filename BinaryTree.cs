using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInaryTree
{


    public class BST<T> where T : IComparable<T>
    {//The nodes in the BST can be keyed by any type that implements IComparable
        public T NodeData { get; set; }
        public BST<T> LeftTree { get; set; }
        public BST<T> RightTree { get; set; }


        public BST(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }

        int LeftCount = 0;
        int RightCount = 0;
        bool result = false;

        public void Insert(T item)//create method and pass parameter item
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (LeftTree == null)
                    LeftTree = new BST<T>(item);
                else
                    LeftTree.Insert(item);
            }
            else
            {
                if (RightTree == null)
                    RightTree = new BST<T>(item);
                else
                    RightTree.Insert(item);
            }
        }
        public void GetSize() //Countint the size
        {
            Console.WriteLine("\nSize " + (1 + LeftCount + RightCount));
        }

        public bool Search(T element, BST<T> node) // Parametrized Constructor
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
               
                result = true;
            }

            else if (node.NodeData.CompareTo(element) < 0)
            {
                Search(element, node.RightTree);
                //The right subtree of a node contains only nodes with keys greater than the node’s key.
            }
            else
            {  //The left subtree of a node contains only nodes with keys lesser than the node’s key.
                Search(element, node.LeftTree);
            }
            return result;
        }
        public void Display()
        {
            if (LeftTree != null)
            {
                LeftCount++;
                LeftTree.Display();
            }
            Console.Write(NodeData.ToString() + "-->");
            if (RightTree != null)
            {
                RightCount++;
                RightTree.Display();
            }
        }
    }
 }
