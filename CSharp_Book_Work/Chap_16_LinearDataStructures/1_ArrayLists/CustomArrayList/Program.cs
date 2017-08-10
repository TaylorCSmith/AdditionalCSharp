using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // difference between Array and ArrayList --> Arrays are fixed sized so adding elements is troublesome...

            CustomArrayList<string> shoppingList = new CustomArrayList<string>();
            
            // this list is a joke and not reflective of my drinking habits
            shoppingList.Add("Milk");
            shoppingList.Add("Beer");
            shoppingList.Add("Whiskey");
            shoppingList.Add("Vodka");
            shoppingList.Add("Bread");
            shoppingList.Add("Rice");
            shoppingList.Add("Pork Belly");

            Console.WriteLine("I drink too much {0}", shoppingList[3]);

            Console.WriteLine("Here's the shopping list: ");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(" - " + shoppingList[i]);
            }
        }

        public class CustomArrayList<T>
        {
            private T[] arr;
            private int count;

            public int Count
            {
                get { return this.count; }
            }

            private const int INITIAL_CAPACITY = 4;

            public CustomArrayList(int capacity = INITIAL_CAPACITY)
            {
                this.arr = new T[capacity];
                this.count = 0;
            }

            // doubles the size of the Array if it is full
            private void GrowIfArrIsFull()
            {
                if (this.count + 1 > this.arr.Length)
                {
                    T[] extendedArr = new T[this.arr.Length * 2];
                    Array.Copy(this.arr, extendedArr, this.count);
                    this.arr = extendedArr;
                }
            }

            // adds element to the list at element "count"
            public void Add(T item)
            {
                GrowIfArrIsFull();
                this.arr[this.count] = item;
                this.count++;
            }

            // Inserts item into specified element. throws an exception if the index is out of range
            public void Insert(int index, T item)
            {
                if (index > this.count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid Index: " + index);
                }

                GrowIfArrIsFull();
                Array.Copy(this.arr, index, this.arr, index + 1, this.count - index);
                this.arr[index] = item;
                this.count++;
            }

            // Summary: returns the index of the first occurence of a specific element in the list... 
            // param item: element be searched for
            // returns: index of element or -1 if it is not found
            public int IndexOf(T item)
            {
                for (int i = 0; i < this.arr.Length; i++)
                {
                    if (object.Equals(item, this.arr[i]))
                    {
                        return i;
                    }
                }

                return -1;
            }

            // Summary: checks if an element exists
            // Param item: the item to be checked
            // returns: if the item exists
            public bool Contains(T item)
            {
                int index = IndexOf(item);
                bool found = (index != -1);
                return found;
            }

            // Indexer
            public T this[int index]
            {
                get
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException("Invalid index: " + index);
                    }
                    return this.arr[index];
                }
                set
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException("Invaid index: " + index);
                    }
                    this.arr[index] = value;
                }
            }

            // clears everything in the list
            public void Clear()
            {
                this.arr = new T[INITIAL_CAPACITY];
                this.count = 0;
            }

            // removes element at specified index
            public T RemoveAt(int index)
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                T item = this.arr[index];
                Array.Copy(this.arr, index + 1, this.arr, index, this.count - index - 1);
                this.arr[this.count - 1] = default(T);
                this.count--;

                return item;
            }

            // removes specified item
            public int Remove(T item)
            {
                int index = IndexOf(item);
                if (index != -1)
                {
                    this.RemoveAt(index);
                }
                return index;
            }
        }
    }
}