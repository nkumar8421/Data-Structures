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
    class ConvertTreeToDoublyIist
    {
       
    public static Node prevNode = null;
    public static Node head = null;
        public static void toDoublyList(Node root)
        {
          if (root == null)
            return;
          toDoublyList(root.left);
          if (head == null)
              head = root;
          else
          {
              root.left = prevNode;
              prevNode.right = root;
          }
          prevNode = root;
          toDoublyList(root.right);
        }
        public static void printList(Node head)
        {

            Node temp = head;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.right;
            }

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

            toDoublyList(root);

            printList(head);
            Console.ReadLine();
        }
    }
}
