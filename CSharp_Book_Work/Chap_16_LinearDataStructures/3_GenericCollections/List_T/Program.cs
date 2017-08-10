using System;
using System.Collections.Generic; 

namespace List_T
{
    class Program
    {
        static void Main(string[] args)
        {
            // find prime numbers example
            Console.WriteLine("Finding the prime numbers");
            List<int> primes = GetPrimes(200, 300);
            foreach (var item in primes)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();


            // union and intersect example

            Console.WriteLine("Union and intersect using custom methods"); 
            List<int> firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);
            Console.Write("firstList = ");
            PrintList(firstList);

            List<int> secondList = new List<int>();

            secondList.Add(2);
            secondList.Add(4);
            secondList.Add(6);
            Console.Write("secondList = ");
            PrintList(secondList);

            List<int> unionList = Union(firstList, secondList);

            Console.Write("union = ");
            PrintList(unionList);
            List<int> intersectList = Intersect(firstList, secondList);
            Console.Write("intersect = ");
            PrintList(intersectList);


            Console.WriteLine();

            // Union and Intersect using AddRange from the List<T> class

            Console.WriteLine("Union and intersect using AddRange from the List<T> class"); 
            List<int> thirdList = new List<int>();
            thirdList.Add(1);
            thirdList.Add(2);
            thirdList.Add(3);
            thirdList.Add(4);
            thirdList.Add(5);
            Console.Write("thirdList = ");
            PrintList(thirdList);

            List<int> fourthList = new List<int>();
            fourthList.Add(2);
            fourthList.Add(4);
            fourthList.Add(6);
            Console.Write("fourthList = ");
            PrintList(fourthList);

            List<int> unionListTwo = new List<int>();
            unionListTwo.AddRange(thirdList);
            for (int i = unionListTwo.Count - 1; i >= 0; i--)
            {
                if (fourthList.Contains(unionListTwo[i]))
                {
                    unionListTwo.RemoveAt(i);
                }
            }

            unionListTwo.AddRange(fourthList);
            Console.Write("unionListTwo = ");
            PrintList(unionListTwo);

            List<int> intersectListTwo = new List<int>();
            intersectListTwo.AddRange(thirdList);
            for (int i = intersectListTwo.Count - 1; i >= 0; i--)
            {
                if (!fourthList.Contains(intersectListTwo[i]))
                {
                    intersectListTwo.RemoveAt(i);
                }
            }

            Console.Write("intersectListTwo = ");
            PrintList(intersectListTwo);

            Console.WriteLine();

            // List to array and vice versa
            Console.WriteLine("Converting a List to an array and vice versa");
            int[] arr = new int[] { 1, 2, 3 };
            List<int> arrToList = new List<int>(arr);
            PrintList(arrToList);

            int[] listToArray = arrToList.ToArray();
            Console.WriteLine(string.Join(", ", listToArray)); 

        }

        static List<int> GetPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                double numSqrt = Math.Sqrt(num);
                for (int div = 2; div <= numSqrt; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                    if (prime)
                    {
                        primesList.Add(num);
                    }
            }
            return primesList;
        }

        static List<int> Union(List<int> firstList, List<int> secondList)
        {
            List<int> union = new List<int>();
            union.AddRange(firstList);
            foreach(var item in secondList)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }

        static List<int> Intersect(List<int> firstList, List<int> secondList)
        {
            List<int> intersect = new List<int>();
            foreach(var item in firstList) {
                if (secondList.Contains(item))
                {
                    intersect.Add(item);
                }
            }

            return intersect;
        }

        static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            foreach (var item in list)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("}");
        }
    }
}