using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Prob3_ImplementingStackUsingTwoQueues
    {
        static void Main3(string[] args)
        {
            MyStack st = new MyStack();

            st.pop();
            st.push(1);
            st.push(2);
            st.push(3);
            st.push(4);
            st.pop(); 
            st.pop();
            st.pop();
            st.push(5);
            st.push(6);
            st.pop(); 
            st.pop(); 
            st.pop();
            st.pop();

        }

        class MyStack
        {
            private Queue<int> Q1 = new Queue<int>();
            private Queue<int> Q2 = new Queue<int>();

            public void push(int data)
            {
                if(Q1.Count == 0 && Q2.Count == 0)
                {
                    Q1.Enqueue(data);
                }
                else if (Q1.Count == 0 && Q2.Count > 0)
                {
                    Q2.Enqueue(data);
                }
                else
                    Q1.Enqueue(data);
                
                Console.WriteLine("Element " + data + " has been pushed into the stack.");

            }

            public void pop()
            {
                if (Q1.Count == 0 && Q2.Count == 0)
                {
                    Console.WriteLine("Invalid Operation!!");
                }
                else if (Q1.Count == 0 && Q2.Count > 0)
                {
                    while(Q2.Count!= 1)
                    {
                        Q1.Enqueue(Q2.Dequeue());
                    }
                    Console.WriteLine("Element " + Q2.Dequeue() + " is popped out of the stack");
                }
                else
                {
                    while (Q1.Count != 1)
                    {
                        Q2.Enqueue(Q1.Dequeue());
                    }
                    Console.WriteLine("Element " + Q1.Dequeue() + " is popped out of the stack");
                }
            }
        }
    }
}

