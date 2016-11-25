using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quere
{
    class Program
    {
        static void Main(string[] args)
        {
            int tail = 0;
            int head = 0;
            string keyword;
            int number = 0;
            int[] array = new int[10];
            do
            {
                Console.WriteLine("Press 'a' to enqeue number ");
                Console.WriteLine("Press 'b' to denqeue number ");
                Console.WriteLine("Press 'c' to verify if queue is empty ");
                Console.WriteLine("Press 'd' to verify if queue is full ");
                Console.WriteLine("Press 'i' to view all elements ");
                Console.WriteLine("Press 'x' for exit ");
                keyword = Convert.ToString(Console.ReadLine());
                switch(keyword)
                {
                    case "a":
                        {
                            if (isFull(tail, head) != 0)
                            { 

                            number = Convert.ToInt32(Console.ReadLine());
                            tail = Enqueue(tail, head, number, array);
                            break;
                            }
                            else
                            {
                                Console.WriteLine("Queue is full");
                                break;
                            }
                        }
                    case "b":
                        {
                            if (IsEmpty(tail, head) != 0)
                            {
                                head = Dequeue(tail, head, array);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty");
                                break;
                            }
                        }
                    case "c":
                        {
                            if (IsEmpty(tail, head) != 0)
                            {
                                Console.WriteLine("Queue is not empty");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Queue is empty");
                                break;
                            }
                        }
                    case "d":
                        {
                            if (isFull(tail, head) != 0)
                            { 
                                Console.WriteLine("Queue is not full");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Queue is full");
                                break;
                            }
                        }
                    case "i":
                        {
                            Peek(head, tail, array);
                            break;
                        }
                        
                }

            }
            while (keyword!="x");

        }

        static int Enqueue(int tail, int head, int number, params int[] arr)
        {
            if (tail < 9)
            {
                arr[tail] = number;
                tail++;
                return tail;
            }
            else if (tail == 9 && head != 0)
            {
                tail = 0;
                return tail;
            }
            else return 0;

        }
        static int Dequeue(int tail, int head, params int[] arr)
        {
            if (head < 9)
            {
                arr[head] = 0;
                head++;
                return head;
            }
            else if (head == 9 && tail != 0)
            {
                head = 0;
                return head;
            }
            else
            {
                Console.WriteLine("Queue is empry");
                return 0;
            }
        }
        static int isFull (int tail, int head)
        {
            if (head > tail && (head - tail) == 1)
                return 0;
            else
            if (head < tail && (head + tail) == 9)
                return 0;
            else return 1;
        }
        static int IsEmpty (int tail, int head)
        {
            if (tail == head)
                return 0;
            else return 1;
        }

        static void Peek(int head, int tail, params int[] arr)
        { int i = 0;
            if (tail>head)
            for ( i = head; i <tail; i++)
            {
                Console.WriteLine("Steck elements:");
                Console.WriteLine(arr[i]);
            }
            else if (head>tail)
            {
                for ( i = head; i < 9; i++)
                { Console.WriteLine("Steck elements:");
                    Console.WriteLine(arr[i]);
                }
                for (i=0;i<tail;i++)
                {
                    Console.WriteLine("Steck elements:");
                    Console.WriteLine(arr[i]);
                }
            }
        }
        }
}
