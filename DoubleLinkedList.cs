using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Node
    {
       public object data;
       public Node next;
       public Node prev;
        public Node(object d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }
    class Program
    {
        public static Node addInFront(Node head,object d)
        {
            Node temp = new Node(d);
            if (head == null)
            {
                head = temp;
            }
            else
            {
                //temp.next = head;
                head.prev = temp;
                temp.next = head;
                return temp;
            }
            return head;
        }

        public static Node addInLast(Node head, object d)
        {
            Node temp = new Node(d);
            if (head == null)
            {
                head = temp;
            }
            else
            {
                Node t = head;
                Node prev = head;
                
                while (t.next != null)
                {
                    t = t.next;
                    prev = t;
                }
                t.next = temp;
                temp.prev = t;
                //return temp;
            }
            return head;
        }

        public static void printList(Node head)
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        static void Main(string[] args)
        {
            Node head = null;
           head= addInFront(head, 5);
           head = addInFront(head, 4);
           head = addInFront(head, 3);
           head = addInLast(head, 6);

            printList(head);

            Console.ReadLine();
        }
    }
}
