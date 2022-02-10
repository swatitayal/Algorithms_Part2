using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Prob1_NextGreaterElement
    {
        static void Main1(string[] args)
        {
            //int[] A = { 4, 5, 2, 25 };
            // int[] A = { 13, 7, 6, 12 };
            int[] A = { 10, 3, 12, 4, 2, 9, 13, 0, 8, 11, 1, 7, 5, 6 };

            findNGE(A);
        }

        static void findNGE(int[] A)
        {
            int n = A.Length;
            Stack<int> S = new Stack<int>();
            int[] B = new int[n];

            for (int i = n-1; i >= 0; i--)
            {
                while (S.Count != 0 && A[i] > S.Peek())
                {
                    S.Pop();
                }

                if (S.Count == 0)
                {
                    B[i] = -1;
                }

                else
                {
                    B[i] = S.Peek();
                }

                S.Push(A[i]);
            }

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine(A[i] + " ---> " + B[i]);
            }
        }
    }
}
