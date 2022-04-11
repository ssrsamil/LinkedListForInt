using System;
using static LinkedListForInt.LinkedList;

namespace LinkedListForInt
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddFirst(0);
            list.AddFirst(45);
            list.AddFirst(1);
            list.AddFirst(88);
            list.Print(list.head);
            Console.WriteLine("___________________________");

            list.RemoveLast();
            list.Print(list.head);

            Console.WriteLine("___________________________");
            Console.WriteLine();

            list.RemoveLast();
            list.Print(list.head);

            Console.WriteLine(new string('-', 80));

            list.RemoveLast();
            list.Print(list.head);

            list.RemoveLast();
            list.Print(list.head);


            Console.WriteLine();
            Console.WriteLine(list.Empty());

            Console.ReadKey();
        }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;
        public Node last;

        public static int count;

        public class Node
        {
            public int value;
            public Node next;

            public Node(int val)
            {
                value = val;
                next = null;
                count++;
            }
        }

        public void AddFirst(int val)
        {
            Node current = new Node(val);
            if (head == null)
            {
                head = current;
                tail = current;
            }
            else
            {
                current.next = head;
                head = current;
            }
        }

        public void AddLast(int val)
        {
            Node current = new Node(val);
            if (head == null)
            {
                head = current;
                tail = current;
            }
            else if (tail.next == null)
            {
                tail.next = current;
                tail = current;
            }
        }
        public bool Empty()
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public bool RemoveFirst()
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                head = head.next;
                return true;
            }
        }
        public bool RemoveLast()
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                tail = GetLast(head);
                tail.next = null;

                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                return true;
            }
        }

        public Node GetLast(Node head)
        {
            while (head.next != null)
            {
                last = head;
                head = head.next;
            }            
            return last;
        }

        public void Print(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
        }

        public void Bro(string name)
        {
            Console.WriteLine("{0} is a true bro!", name);
        }
    }    
}
