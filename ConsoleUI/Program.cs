using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue(5);

            myQueue.Insert(100);
            myQueue.Insert(10);
            myQueue.Insert(20);
            myQueue.Insert(30);
            myQueue.View();

            Console.WriteLine($"Front of the queue is { myQueue.PeekFront() } ");

            Console.WriteLine("About to remove item from the queue");
            myQueue.Remove();

            Console.WriteLine($"Front of the queue is { myQueue.PeekFront() } ");

            Console.ReadLine();
        }
    }

    public class Queue
    {
        //Set max number of slots
        private int MaxSize;

        //Container for the slots
        private long[] MyQueue;

        private int Front;

        private int Rear;

        private int Items;

        public Queue(int size)
        {
            MaxSize = size;

            MyQueue = new long[size];

            Front = 0;

            Rear = -1;

            Items = 0;
        }

        public void Insert(long j)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (Rear == MaxSize - 1)
                {
                    Rear = -1;
                }

                Rear++;

                MyQueue[Rear] = j;

                Items++;
            }
            

        }

        public long Remove()
        {
            long output = MyQueue[Front];

            Front++;

            if (Front == MaxSize)
            {
                Front = 0;
            }

            return output;
        }

        public long PeekFront()
        {
            long output = MyQueue[Front];

            return output;
        }

        public bool IsQueueEmpty()
        {
            bool output = (Items == 0);

            return output;
        }

        private bool IsFull()
        {
            bool output = (Items == MaxSize);

            return output;
        }

        public void View()
        {
            Console.Write("[");

            for (int i = 0; i < MyQueue.Length; i++)
            {
                Console.Write($"{ MyQueue[i] } ");
            }

            Console.WriteLine("]");
        }
    }
}
