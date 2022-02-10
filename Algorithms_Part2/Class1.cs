using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Prob4_GetMinElementFromStack_leetCode
    {
        static void Main(string[] args)
        {
            MinStack st = new MinStack();

            st.GetMin();
            st.Push(2);
            st.GetMin();
            st.Push(0);
            st.Push(3);
            st.Push(0);
            st.GetMin();
            st.Pop();
            st.GetMin();
            st.Pop();
            st.GetMin();
            st.Pop();
            st.GetMin();
        }


        public class MinStack
        {
            Stack<int> s;
            int min;

            public MinStack()
            {
                s = new Stack<int>();

            }

            public void Push(int data)
            {

                if (data > min)
                {
                    s.Push(data);
                    Console.WriteLine("The element " + data + " is added to this stack");
                }
                else
                {
                    Console.WriteLine("The element " + data + " is added to this stack as: " + (2 * data - min));
                    s.Push(2 * data - min);
                    min = data;
                }
            }

            public void Pop()
            {
                Console.WriteLine("The top element is " + s.Peek());
                if (s.Peek() > min)
                {
                    Console.WriteLine("The element " + s.Peek() + " is removed from the stack");
                    s.Pop();
                }
                else
                {
                    Console.WriteLine("The element " + min + " is removed from the stack as " + s.Peek());
                    min = 2 * min - s.Peek();
                    s.Pop();
                }
            }


            public void Top()
            {

                if (s.Peek() > min)
                {
                    Console.WriteLine("The top element of this stack is: " + s.Peek());
                }
                else
                {
                    Console.WriteLine("The top element of this stack is: " + ((s.Peek() + min) / 2));
                }
            }

            public void GetMin()
            {

                Console.WriteLine("The minimum element of this stack is: " + min);
            }

        }

        

    }
}