using C42_G01_ADV02.Q03;
using C42_G01_ADV02.Q04;
using System;
using System.Collections;
using System.Collections.Generic;

namespace C42_G01_ADV02
{
    internal class Program
    {
        #region PrintArrayList Method
        public static void PrintArrayList(ArrayList arr)
        {
            if (arr != null)
            {
                Console.WriteLine();
                Console.Write("Elements: ");
                foreach (var item in arr)
                {
                    Console.Write($" {item},");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region PrintList Method
        public static void PrintList(List<int> list)
        {
            if (list != null)
            {
                Console.WriteLine();
                Console.Write("Elements: ");
                foreach (var item in list)
                {
                    Console.Write($" {item},");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Reverse ArrayList Method
        public static void ReverseArrayList(ArrayList list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                object temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;
            }
        }
        #endregion

        #region Method to get even numbers from list
        public static void ReturnEvenNumbersOnly(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region Report
            // 01 -> ArrayList (Non-generic collection) 
            //                --> Exists in the namespace: 'System.Collections'
            //                --> Holds elements of any type and stores them as objects  
            //                --> Leading to potential boxing/unboxing overhead and the need for type casting.
            //    performance --> Due to boxing/unboxing of value types, performance may suffer compared to generic collections.
            //    Safety      --> Lacks type safety, which can lead to runtime errors if elements of the wrong type are added.
            /*    Structure   --> */
            ArrayList arrayList = new ArrayList(); // --> Generates an array of type Object

            // 02 -> List<T> (Generic collection)
            //               --> Exists in the namespace: 'System.Collections.Generic'
            //               --> Is a strongly-typed collection that can hold elements of a specified type and stores them in an array of this type
            //   performance --> More efficient for value types due to the absence of boxing/unboxing. Access is type-safe and faster.
            //   Safety      --> Provides compile-time type checking, reducing the risk of runtime errors due to type mismatches.
            /*   Structure   --> */
            List<string> list = new List<string>(); // --> Generates an array of type string

            // 03 -> LinkedList<T> (Generic collection)
            //               --> Exists in the namespace: 'System.Collections.Generic'
            //               --> Is a doubly-linked list that can hold elements of a specified type
            //   performance --> Efficient for insertions and deletions, as these operations can be done in constant time.
            //               --> However, access time is linear (O(n)), making it less efficient for indexed access compared to List<T>.
            //   Safety      --> Provides compile-time type checking, reducing the risk of runtime errors due to type mismatches.
            //   Structure   --> 
            LinkedList<string> linkedList = new LinkedList<string>(); // --> Generates a linked list of type string

            // 04 -> Stack<T> (Generic collection)
            //               --> Exists in the namespace: 'System.Collections.Generic'
            //               --> Is a collection that follows the Last-In-First-Out (LIFO) principle
            //   performance --> Efficient for push and pop operations, as these operations can be done in constant time.
            //               --> Access time is linear (O(n)) for searching elements.
            //   Safety      --> Provides compile-time type checking, reducing the risk of runtime errors due to type mismatches.
            //   Structure   --> 
            Stack<int> stack = new Stack<int>(); // --> Generates a stack of type int


            // 05 -> Queue<T> (Generic collection)
            //               --> Exists in the namespace: 'System.Collections.Generic'
            //               --> Is a collection that follows the First-In-First-Out (FIFO) principle
            //   performance --> Efficient for enqueue and dequeue operations, as these operations can be done in constant time.
            //               --> Access time is linear (O(n)) for searching elements.
            //   Safety      --> Provides compile-time type checking, reducing the risk of runtime errors due to type mismatches.
            //   Structure   --> 
            Queue<int> queue = new Queue<int>(); // --> Generates a queue of type int

            #endregion

            #region Part02

            #region Q01 -->You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            // ArrayList names = new ArrayList()
            // {
            //     "Ahmed", "Mohamed", "Mostafa"
            // };
            // ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Console.WriteLine("Names and Numbers Before Reverse -->");
            // PrintArrayList(names);
            // PrintArrayList(numbers);

            // ReverseArrayList(names);
            // ReverseArrayList(numbers);

            // Console.WriteLine("Names and Numbers After Reverse -->");
            // PrintArrayList(names);
            // PrintArrayList(numbers);
            #endregion

            #region Q02 -->You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> numbersList = new List<int>() { 1, 4, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //Console.WriteLine("List Num before get Even Numbers Only");
            //PrintList(numbersList);
            //ReturnEvenNumbersOnly(numbersList);
            //Console.WriteLine("List Num after getting Even Numbers Only");
            //PrintList(numbersList);
            #endregion

            #region Q03
            //var fixedlist = new FixedSizeList<int>(3);

            //fixedlist.Add(1);
            //fixedlist.Add(2);
            //fixedlist.Add(3);

            //fixedlist.Add(4); 

            //Console.WriteLine(fixedlist.Get(1)); 
            //Console.WriteLine(fixedlist.Get(3));
            #endregion

            #region Q04
            string input = "SASS";
            int index = FirstNonRepeatedCharacter.GetFirstNonRepeatedCharacterIndex(input);
            if (index != -1)
            {
                Console.WriteLine($"The first non-repeated character is at index {index}.");
            }
            else
            {
                Console.WriteLine("No non-repeated character found.");
            }
            #endregion
            #endregion
        }
    }
}
