using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Prob4_GetMinElementFromStack
    {
        static void Main4(string[] args)
        {
            MyStack st = new MyStack();

            st.push(18);
            st.push(19);
            st.push(29);
            st.push(15);
            st.push(16);
            st.getMin();
            st.pop();
            st.pop();
            st.getMin();

            //st.push(3);
            //st.push(5);
            //st.push(2);
            //st.push(1);
            //st.push(1);
            //st.push(-1);
            //st.getMin();
            //st.peek();
            //st.pop();
            //st.getMin();
            //st.pop();
            //st.pop();
            //st.getMin();
            //st.pop();
            //st.getMin();
            //st.pop();
            //st.getMin();
            //st.pop();
            //st.getMin();
            //st.pop();
        }

        class MyStack
        {
            Stack<int> S = new Stack<int>();
            int min;

            public void getMin()
            {
                if(S.Count == 0)
                {
                    Console.WriteLine("Invalid Operation!!!");
                }
                else
                {
                    Console.WriteLine("The minimum element of this stack is: " + min + "\n");
                }
            }

            public void peek()
            {
                if (S.Peek() > min)
                {
                    Console.WriteLine("The top element of this stack is: " + S.Peek());
                }
                else
                {
                    int old_min = 2 * min - S.Peek();
                    Console.WriteLine("The top element of this stack is: " + ((S.Peek() + old_min) / 2));
                }
            }

            public void push(int data)
            {
                if (S.Count == 0)
                {
                    min = data;
                    S.Push(data);
                    Console.WriteLine("The element " + data + " is added to this stack.");
                }

                else
                {
                    if (data > min)
                    {
                        S.Push(data);
                        Console.WriteLine("The element " + data + " is added to this stack.");
                    }
                    else
                    {
                        Console.WriteLine("The element " + data + " is added to this stack.");
                        S.Push(2*data - min);
                        min = data;
                    }
                }
            }

            public void pop()
            {
                if (S.Count == 0)
                {
                    Console.WriteLine("Stack is empty!!");
                }

                else
                {
                    if (S.Peek() > min)
                    {
                        Console.WriteLine("The element " + S.Pop() + " is removed from the stack.");
                    }
                    else
                    {
                        Console.WriteLine("The element " + min + " is removed from the stack.");
                        min = 2*min - S.Peek();
                        S.Pop();
                    }
                }
            }
        
        }
        
    }
}


      