using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTALGOQueueApp
{
    class CircularQueue<T>
    {
        private T[] array;
        private int count, front, rear;

        public CircularQueue()
        {
            array = new T[6];
            count = 0; front = 0; rear = -1;
        }
        public int Count
        {
            get { return count; }
        }
        public void Enqueue(T item)
        {
            if (count < array.Length)
            {
                rear = (rear + 1) % array.Length;
                array[rear] = item;
                count++;
            }
            else
                throw new Exception("Queue is Full");
        }
        public T Dequeue()
        {
            if (count > 0)
            {
                T item = array[front];
                front = (front + 1) % array.Length;
                count--;
                return item;
            }
            else
            {
                throw new Exception("Array is Empty!");
            }
        }
        public T Peek()
        {
            if (count > 0)
            {
                T item = array[front];
                return item;
            }
            else
            {
                throw new Exception("Array is Empty!");
            }
        }
        public void PrintQueue()
        {
            int counter = count;
            int index = front;
            int number = 1;
            //while (counter > 0)
            //{
            //    Console.WriteLine(number + ". " + array[index]);
            //    index = (index + 1) % array.Length;
            //    counter--;
            //    number++;
            //}
            while (counter > 0)
            {
                Console.Write(number + ". ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(array[index]);
                Console.ForegroundColor = ConsoleColor.Gray;
                index = (index + 1) % array.Length;
                counter--;
                number++;
            }
        }
    }
}
