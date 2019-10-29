using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Node
    {
        public int data;
        public Node next;
        public Node()
        {
            data = 0;
        }
        public Node(int data)
        {
            this.data = data;
        }

    }

    class LinkedList
    {
        public Node head;

        public void del(int pos)
        {
            int count = 0;
            Node tmp;
            tmp = head;
            for(int i = 0; i < pos; i ++)
            {
                tmp = tmp.next;
                count++;
            }
            tmp.next = tmp.next.next;
        }
        public void insertAt(int pos, int value)
        {
            int count = 0;
            Node tmp;
            Node tmp2;
            tmp = head;
            for (int i = 0; i < pos; i++)
            {
                tmp = tmp.next;
                count++;
            }
            tmp2 = new Node(value);
            tmp2.next = tmp.next;
            tmp.next = tmp2;
        }
        public void addHead(int x)
        {
            Node tmp = new Node(x);
            tmp.next = head;
            head = tmp;
        }

        public void addTail(int x)
        {
            if (head == null)
            {
                head = new Node(x);
                return;
            }
            Node tmp;
            tmp = head;
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }
            tmp.next = new Node(x);
        }

        public void print()
        {
            Node tmp;

            tmp = head;

            while (tmp != null)
            {
                Console.Write(tmp.data + " ");
                tmp = tmp.next;
            }
            Console.WriteLine();
        }

        public int getSize()
        {
            int n = 0;
            Node tmp;

            tmp = head;

            while (tmp != null)
            {
                n++;
                tmp = tmp.next;
            }
            return n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.addTail(7);
            list.addTail(4);
            list.addTail(6);
            list.addTail(2);

            list.print();

            int n = list.getSize();
            Console.WriteLine(n);

            Node x = new Node(8);

            x.next = list.head.next.next;

            list.head.next.next = x;

            list.print();

            list.addTail(3);

            list.print();

            list.addHead(9);

            list.print();

            list.insertAt(3, 10);

            list.print();

            list.del(3);

            list.print();

        }
    }
}
