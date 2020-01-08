using System;
using System.Collections.Generic;

namespace ssl_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SinglyLinkedList SLL = new SinglyLinkedList();
            SLL.Add(1);
            SLL.Add(2);
            SLL.Add(3);
            SLL.Add(4);
            SLL.Add(5);
            SLL.Add(6);
            SLL.Add(7);
            SLL.Add(8);
            SLL.Add(9);
            SLL.Add(10);
            SLL.Add(11);
            SLL.PrintValues();
            SLL.Remove();
            SLL.PrintValues();
            // SLL .Find(4);
            SLL.RemoveAt(4);
            SLL.PrintValues();
        }
        public class SllNode
        {
            public int Value;
            public SllNode Next;
            public SllNode(int value)
            {
                Value = value;
                Next = null;
            }
        }
        public class SinglyLinkedList
        {
            public SllNode Head;
            public SinglyLinkedList()
            {
                Head = null;
            }
            public void Add(int value)
            {
                SllNode newNode = new SllNode(value);
                if(Head == null)
                {
                    Head = newNode;
                }
                else
                {
                    SllNode runner = Head;
                    while(runner.Next != null)
                    {
                        runner = runner.Next;
                    }
                    runner.Next = newNode;
                }
            }
            public void Remove()
            {
                if(Head == null)
                {
                    Console.WriteLine("there isn't a list!");
                }
                else
                {
                    SllNode runner = Head;
                    while(runner.Next != null)
                    {
                        runner = runner.Next;
                    }
                    runner.Next = null;
                }
            }
            public void PrintValues()
            {
                if(Head == null)
                {
                    Console.WriteLine("there isn't a list!");
                }
                else
                {
                    SllNode runner = Head;
                    while(runner.Next != null)
                    {
                        Console.WriteLine(runner.Value);
                        runner = runner.Next;
                    }
                }
            }
            public bool Find(int value)
            {
                if(Head == null)
                {
                    Console.WriteLine("there isn't a list!");
                    return false;
                }
                else
                {
                    if(Head.Value == value)
                    {
                        return true;
                    }
                    SllNode runner = Head;
                    while(runner.Next != null)
                    {
                        if(runner.Value == value)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            public void RemoveAt(int location)
            {
                if(Head == null)
                {
                    Console.WriteLine("there isn't a list!");
                }
                else
                {
                    SllNode runner = Head;
                    if(location < 1)
                    {
                        Head = runner.Next;
                    }
                    else
                    {
                        while(runner.Next.Next != null || location <0)
                        {
                            if(location == 1)
                            {
                                runner.Next = runner.Next.Next;
                                break;
                            }
                            runner = runner.Next;
                            location-=1;
                        }
                    }
                }
            }
        }
    }
}
