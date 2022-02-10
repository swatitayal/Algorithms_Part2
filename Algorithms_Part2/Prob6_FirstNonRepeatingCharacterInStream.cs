using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Prob6_FirstNonRepeatingCharacterInStream
    {
        static void Main6(string[] args)
        {
            //string stream = "abcbbac";
            //string stream = "aabc";
            string stream = "aqizqazpn";

            findFirstNonRepeat(stream);
        }
        public static void findFirstNonRepeat(string A)
        {
            int n = A.Length;
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            Queue<char> myQueue = new Queue<char>();

            for (int i = 0; i < n; i++)
            {
                myQueue.Enqueue(A[i]);
                if (myDictionary.ContainsKey(A[i]))
                {
                    myDictionary[A[i]]++;
                }
                else
                {
                    myDictionary.Add(A[i], 1);
                }

                if (A[i] == myQueue.Peek())
                {
                    while (myQueue.Count > 0 && myDictionary[myQueue.Peek()] > 1)
                    {
                        myQueue.Dequeue();
                    }
                    if (myQueue.Count == 0)
                    {
                        Console.Write("-1 ");
                    }
                    else
                    {
                        Console.Write(myQueue.Peek() + " ");
                    }
                }
                else
                {
                    Console.Write(myQueue.Peek() + " ");
                }
            }
        }
    }
}
