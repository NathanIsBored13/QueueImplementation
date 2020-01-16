using System;
using System.Collections.Generic;
using System.Text;

namespace QueImplementation
{
    class Queue
    {
        private int front, back, count;
        private int[] queue;
        public Queue(int size)
        {
            queue = new int[size];
            front = 0;
            back = 0;
            count = 0;
        }
        public bool isFull() => count == queue.Length;
        public bool isEmpty() => count == 0;
        public void Add(int value)
        {
            if (!isFull())
            {
                queue[front] = value;
                front = (front + 1) % queue.Length;
                count++;
            }
            else Console.WriteLine("Queue is already full");
        }
        public int Remove()
        {
            int ret;
            if (!isEmpty())
            {
                ret = queue[back];
                back = (back + 1) % queue.Length;
                count--;
            }
            else
            {
                ret = -1;
                Console.WriteLine("Queue is empty");
            }
            return ret;
        }
    }
}
