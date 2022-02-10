using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class Prob5_ImplementLRUCache
    {
        static void Main(string[] args)
        {
            LRUCache lru = new LRUCache(3);
            lru.set(1, 100);
            lru.set(2, 200);
            lru.set(3, 300);
            Console.WriteLine("The data for 1st node is: " + lru.get(1));
            lru.set(4, 400);
            Console.WriteLine("The data for 2nd node is: " + lru.get(2));
            lru.set(1, 800);
            lru.set(5, 500);
            Console.WriteLine("The data for 3rd node is: " + lru.get(3));
            Console.WriteLine("The data for 1st node is: " + lru.get(1));
            lru.print();
        }

        class LRUCache
        {
            int Capacity;
            LinkedList<CacheItem> myLL = new LinkedList<CacheItem>();
            Dictionary<int, LinkedListNode<CacheItem>> myDictionary = new Dictionary<int, LinkedListNode<CacheItem>>();
            
            public LRUCache (int capacity)
            {
                Capacity = capacity;
            }

            public int get(int x)
            {
                if (!myDictionary.ContainsKey(x))
                {
                    return -1;
                }
                else
                {
                    LinkedListNode<CacheItem> cache = myDictionary[x];
                    myLL.Remove(cache);
                    myLL.AddFirst(cache);
                    return cache.Value.Data;
                }
            }

            public void set(int x, int y)
            {
                if (myDictionary.ContainsKey(x))
                {
                    LinkedListNode<CacheItem> cache = myDictionary[x];
                    myLL.Remove(cache);
                    myLL.AddFirst(cache);
                    myLL.First.Value.Data = y;
                    myDictionary[x] = myLL.First;
                }
                else
                {
                    if (myLL.Count == Capacity)
                    {
                        int temp = myLL.Last.Value.Key;
                        myDictionary.Remove(temp);
                        myLL.RemoveLast();
                        myLL.AddFirst(new CacheItem(x, y));
                        myDictionary.Add(x, myLL.First);
                    }
                    else
                    {
                        myLL.AddFirst(new CacheItem(x, y));
                        myDictionary.Add(x, myLL.First);
                    }
                }
            }

            public void print()
            {
                LinkedListNode<CacheItem> head = myLL.First;
                while (head!= null)
                {
                    Console.WriteLine("The value for the key " + head.Value.Key + " is: " + head.Value.Data);
                    head = head.Next;
                }
            }
        }
        class CacheItem
        {
            public int Key;
            public int Data;
            public CacheItem(int key, int value)
            {
                Key = key;
                Data = value;
            }
        }
    }
}
