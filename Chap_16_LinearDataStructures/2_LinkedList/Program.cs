using System;
using System.Collections.Generic;

namespace _2_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<string> shoppingList = new DynamicList<string>();

            shoppingList.Add("Milk");
            shoppingList.Remove("Milk");

            shoppingList.Add("Vodka");
            shoppingList.Add("Olives");
            shoppingList.Add("Hot Pockets");
            Console.WriteLine(shoppingList.Count);

            Console.WriteLine("\n I need to buy: ");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(" - " + shoppingList[i]);
            }
        }

        public class DynamicList<T>
        {
            public DynamicList()
            {
                this.head = null;
                this.tail = null;
                this.count = 0; 
            }

            private ListNode head;
            private ListNode tail;
            private int count; 

            private class ListNode
            {
                public T Element { get; set; }
                public ListNode NextNode { get; set; }

                public ListNode(T element)
                {
                    this.Element = element;
                    NextNode = null;
                }

                public ListNode(T element, ListNode prevNode)
                {
                    this.Element = element;
                    prevNode.NextNode = this;
                }
            }

            public void Add(T item)
            {
                if (this.head == null)
                {
                    // if there is an empty list, creates a new head and tail
                    this.head = new ListNode(item);
                    this.tail = this.head;
                } 
                else
                {
                    ListNode newNode = new ListNode(item, this.tail);
                    this.tail = newNode;
                }

                this.count++;
            }

            public T RemoveAt(int index)
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }

                int currentIndex = 0;
                ListNode currentNode = this.head;
                ListNode prevNode = null;
                while (currentIndex < index)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }

                RemoveListNode(currentNode, prevNode);

                return currentNode.Element;
            }

            private void RemoveListNode(ListNode node, ListNode prevNode)
            {
                count--;
                if (count == 0)
                {
                    this.head = null;
                    this.tail = null;
                }
                else if (prevNode == null)
                {
                    this.head = node.NextNode;
                }
                else
                {
                    prevNode.NextNode = node.NextNode;
                }

                if(object.ReferenceEquals(this.tail, node))
                {
                    this.tail = prevNode;
                }
            }

            public int Remove(T item)
            {
                int currentIndex = 0;
                ListNode currentNode = this.head;
                ListNode prevNode = null;
                while (currentNode != null )
                {
                    if (object.Equals(currentNode.Element, item))
                    {
                        break;
                    }
                    prevNode = currentNode;
                    currentNode = currentNode.NextNode;
                    currentIndex++;
                }

                if (currentNode != null)
                {
                    RemoveListNode(currentNode, prevNode);
                    return currentIndex; 
                }
                else
                {
                    // element not found
                    return -1;
                }
            }

            public int IndexOf(T item)
            {
                int index = 0;
                ListNode currentNode = this.head;
                while (currentNode != null)
                {
                    if (object.Equals(currentNode.Element, item))
                    {
                        return index;
                    }
                    currentNode = currentNode.NextNode;
                    index++;
                }
                return -1; 
            }

            public bool Contains(T item)
            {
                int index = IndexOf(item);
                bool found = (index != -1);
                return found; 
            }

            public T this[int index]
            {
                get
                {
                    if (index >= count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException("Invalid index: " + index);
                    }
                    ListNode currentNode = this.head;
                    for (int i = 0; i < index; i ++ )
                    {
                        currentNode = currentNode.NextNode;
                    }
                    return currentNode.Element;
                }
                set
                {
                    if (index >= count || index < 0)
                    {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                    }

                    ListNode currentNode = this.head;
                    for (int i = 0; i < index; i++ )
                    {
                        currentNode = currentNode.NextNode;
                    }
                    currentNode.Element = value; 
                }
            }

            public int Count
            {
                get
                {
                    return this.count;
                }
            }
        }
    }
}