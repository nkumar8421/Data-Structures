using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class treeNode
    {
        public object data;
        public treeNode left;
        public treeNode right;
        public treeNode(object d)
        {
            data = d;
            left = null;
            right = null;
        }
    }
    class Program
    {
        public static void inOrderTraversal(treeNode root)
        {
            if(root==null)
            {
              //  Console.WriteLine("No data in tree");
                return;
            }
           // if(root.left==null || root.right==null)
            //{
              //  return;
            //}
            inOrderTraversal(root.left);
            Console.Write(root.data + " ");
            inOrderTraversal(root.right);
        }

        public static void preOrderTraversal(treeNode root)
        {
            if (root == null)
                return;
            Console.Write(root.data + " ");
            preOrderTraversal(root.left);
            preOrderTraversal(root.right);
        }

        public static void postOrderTraversal(treeNode root)
        {
            if (root == null)
                return;
            
            postOrderTraversal(root.left);
            postOrderTraversal(root.right);
            Console.Write(root.data + " ");
        }
        static void Main(string[] args)
        {
            treeNode root = null;
            //in order traversal
            //inOrderTraversal(root);

            root = new treeNode(5); ;
            root.left = new treeNode(4);
            root.right = new treeNode(3);
            root.left.left = new treeNode(2);
            root.left.right = new treeNode(1);
            root.right.left = new treeNode(6);
            root.right.right = new treeNode(7);

            //in order traversal
            Console.WriteLine("In order traversal");
            inOrderTraversal(root);

            Console.WriteLine("\nPre order traversal");
                preOrderTraversal(root);

            Console.WriteLine("\nPost order traversal");
            postOrderTraversal(root);

            Console.ReadLine();
        }
    }
}
