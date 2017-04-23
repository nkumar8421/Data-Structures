using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BST
{
    class Node
    {
        public object data;
        public Node left;
        public Node right;
        public Node(object d)
        {
            data = d;
            left = right = null;
        }
    }
    class IsBinarySearchTree
    {
       
public static bool isBST(Node root, int min , int max)
    {
        if (root == null)
            return true;
        if ((int)root.data < min || (int)root.data > max)
            return false;

        bool isLeft = isBST(root.left, min, (int)root.data - 1);
        bool isRight = isBST(root.right, (int)root.data + 1, max);
        return isLeft && isRight;
        //return (isBST(root.left,min,(int)root.data-1) && isBST(root.right,(int)root.data-2,max));
    }
public static bool isBST1(Node root)
{
    Node prev = null;
    if(root!=null)
    {
        if (!isBST1(root.right))
            return false;

        if (prev!=null && (int)root.data <= (int)prev.data)
            return false;
        prev = root;
        root = root.left;
        isBST1(root);
    }
    return true;
}
        static void Main(string[] args)
        {
            Node root = new Node(6);
            root.left = new Node(4);
            root.right=new Node(10);

            root.left.left=new Node(3);
            root.left.right=new Node(5);

            root.right.left = new Node(9);
            root.right.right = new Node(12);
            
            // Verifying BST by comparing all the tree values against Min and Max values of integer
            if(isBST(root,int.MinValue,int.MaxValue))
                Console.WriteLine("Yes its a binary search tree");
            else
                Console.WriteLine("Not a binary search tree");

            // Verify BST by inorder traversal and comparing prev value with next value
            if (isBST1(root))
                Console.WriteLine("Yes its a binary search tree");
            else
                Console.WriteLine("Not a binary search tree");
            Console.ReadLine();
        }
    }
}
