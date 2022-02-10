using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Prob2_ImplementingQueueUsingTwoStacks
    {
        static void Main2(string[] args)
        {
            MyQueue mq = new MyQueue();

            mq.dequeue();
            mq.enqueue(1);
            mq.enqueue(2);
            mq.enqueue(3);
            mq.enqueue(4);
            mq.dequeue();
            mq.dequeue();
            mq.enqueue(5);
            mq.enqueue(6);
            mq.dequeue();
            mq.dequeue(); 
            mq.dequeue();
            mq.dequeue();
            mq.dequeue();
            
        }

        class MyQueue
        {
            Stack<int> S1 = new Stack<int>();
            Stack<int> S2 = new Stack<int>();

            public void enqueue(int data)
            {
                S1.Push(data);
                Console.WriteLine("Element " + data + " is queued");
            }

            public void dequeue()
            {
                if (S2.Count == 0)
                {
                    if (S1.Count == 0)
                    {
                        Console.WriteLine("Invalid Operation!!!");
                    }
                    
                    else
                    {
                        while (S1.Count != 0)
                        {
                            S2.Push(S1.Pop());
                        }
                        Console.WriteLine("Element Dequeued is: " + S2.Pop());
                    }
                }
                
                else
                    Console.WriteLine("Element Dequeued is: " + S2.Pop());
            }
        }
    }
}
