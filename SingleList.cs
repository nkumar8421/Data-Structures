using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nkumar
{
    class Node
    {
        
       public object data;
        public Node next;
        public Node(object d)
        {
            data = d;
            next = null;
        }
    }
    class SingleList
    {


        public Node addInFront(Node head,object d)
        {
            Node toAdd = new Node(d);
            if(head==null)
            {
                head = toAdd;
            }
            else
            {
                toAdd.next = head;
                return toAdd;
            }
            return head;
        }

        public Node addInLast(Node head,object d)
        {
            Node toAdd = new Node(d);
            if (head == null)
            {
                head = toAdd;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = toAdd;
            }
            return head;
        }

        public Node addInMiddle(Node head,object d,int position)
        {
            Node toAdd = new Node(d);
            if(head==null || head.next==null)
            {
                Console.WriteLine("List is having less than 2 member data so cant insert in middle");
            }
            else
            {
                Node nextNode = head;
                Node prevNode = head;
                for(int i=0;i<position;i++)
                {
                    prevNode = nextNode;
                    nextNode = nextNode.next;
                }

                prevNode.next = toAdd;
                toAdd.next = nextNode;
            }
            return head;
        }

        public void printList(Node head)
        {
            Node temp = head;

            while(temp!=null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
                
            }
        }

        public void reverse(Node head)
        {
            if(head==null)
            {
                return;
            }
            reverse(head.next);
            Console.Write(head.data + " ");
        }

        public Node reverseWOrec(Node head)
        {
            if(head.next==null)
            {
                return head;
                //break; 
            }
            Node temp =reverseWOrec(head.next);
            head.next.next = head;
            head.next = null;
            return temp;

        }
        static void Main(string[] args)
        {
            Node head = null;
            SingleList o = new SingleList();
            head=o.addInFront(head,5);
            head = o.addInFront(head, 4);
            head = o.addInFront(head, 3);
            head = o.addInLast(head, 6);

            head = o.addInMiddle(head, "midVal1", 2);
            o.printList(head);

            //Reverse print the list using Rec
            Console.WriteLine("\n\nReverse print using recursion");
            o.reverse(head);


            //Reverse the list using Rec
            Console.WriteLine("\n\nReverse List using recursion");
            head = o.reverseWOrec(head);
            o.printList(head);

            
            Console.ReadLine();
        }
    }
}
