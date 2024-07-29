using System;
using System.Collections;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        public static void PrintLinkedList(LinkedList<int> linkedList)
        {
            if (linkedList != null)
            {
                Console.Write("LinkedList Elements: ");
                foreach (var item in linkedList)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintStack(Stack<int> stack)
        {
            if (stack != null)
            {
                Console.Write("Stack Elements: ");
                foreach (var item in stack)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintQueue(Queue<int> queue)
        {
            if (queue != null)
            {
                Console.Write("Queue Elements: ");
                foreach (var item in queue)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
        public static void PrintValue(List<int> arr)
        {
            Console.Write("Values: ");
            foreach (object obj in arr) // unboxing --> transfer data to integer
            {
                int i = (int)obj;
                Console.Write($"{i}, ");
            }
            Console.WriteLine($"\nCount: {arr.Count} --Capacith : {arr.Capacity}");
        }
        public static void PrintSum(ArrayList array) {
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                sum += (int?)array[i] ?? 0;//Unboxing.
                //Casting form oblect [reference type] to int [Value Type]
            }
            Console.WriteLine($"Sum : {sum}");

        }
        static void Main(string[] args)
        {
            #region Collections
            // Collection:- Is data structure implemented in .Net
            // Non-generic collection --> [ArrayList -- SortedArray -- Stack -- Queue -- Hashtable]

            #region Non-generic collection --> [ArrayList]
            ////  ** ArrayList --> dynamic length
            ////ArrayList arr= new ArrayList() {1,5,4,8,9,6,3 }; //Object initalizer
            ////ArrayList arr= new ArrayList(5); // constructor initializer of capacity
            //ArrayList arr = new ArrayList();
            //PrintValue(arr);
            //arr.Add(1);
            //PrintValue(arr);
            //arr.Add(2); // Boxing
            //PrintValue(arr);
            //// Add --> add element to array
            //arr.AddRange(new int[] { 3, 4, 5, 6, 7, 8, 9, 10 }); // Add range of elements to array
            //PrintValue(arr);
            //arr.TrimToSize(); // Create new array with actual size used
            //PrintValue(arr);
            //PrintSum(arr);

            ////arr.Add("Hamda");  //CLR can not transfer data from int to string in runtime
            ////PrintSum(arr);
            ////ArrayList can store heterogeneous(mixed-type) elements.To demonstrate this,
            ////we can modify the example to include various types of data. 
            #endregion

            // Generic collection --> [List]
            #region List (Genaric version of array list)
            //List<int> list = new List<int>();
            ////CLR will generate Empity array of size 0
            //PrintValue(list);
            //list.Add(0);  
            ////CLR will genrate new array with sise 4
            //PrintValue(list);
            //// We can use all method used on arrylist 
            //list.AddRange(new int[] {5,6,7,8}); //add range of numbre in list
            //PrintValue(list);  // list allocate 8 bites in array
            //list.TrimExcess(); // create new array with actuals size allocated
            //PrintValue(list);
            ////list.Add("Hamada"); //--> compiler can infore type Exciption
            //list[2] = 100;//Use Indexer as Update not as setter
            //Console.WriteLine(list[2]); //Use Indexer as Getter


            #endregion

            #region Methods Used In List
            //List<int> Numbers = new List<int>() /*{ 1,2,3,4,5,6,7,8,9,10 }*/;
            //Numbers = Enumerable.Range(1, 10).ToList(); // Add numbers to the list from 1 to 10

            //// Object member methods
            //// 01 --> Add()
            //Numbers.Add(1); // Add an element to the list

            //// 02 --> Insert()
            //Numbers.Insert(0, 5); // Insert number '5' at index '0', shifting all numbers one position
            //PrintValue(Numbers);

            //// 03 --> BinarySearch()
            ////    01
            //// Console.WriteLine(Numbers.BinarySearch(30)); 
            //// Return the index of the element if it exists.
            //// If not, returns a negative number indicating the bitwise complement of the index of the next element
            //// that is larger or, if there is no larger element, the bitwise complement of Count.

            //// List<string> Names = new List<string>() { "Ahmed", "Mona", "Aya", "Mostafa", "Wanees" };
            //// Names.Sort(); // Sort the list
            //// Console.WriteLine(Names.BinarySearch("aya")); // -2 indicates that the element does not exist.
            ////    02
            //Console.WriteLine(Numbers.BinarySearch(0, 5, 10, null));
            //// Binary search in the first 5 elements of the list for the value 10

            //// 04 --> Clear()
            //// Numbers.Clear(); // Remove all elements from the list
            //// PrintValue(Numbers);

            //// 05 --> Remove()
            //// Numbers.Remove(1); // Remove the first occurrence of value 1
            //// PrintValue(Numbers);

            //// 06 --> CopyTo()
            ////int[] arr = new int[15]; // Ensure the array is large enough
            ////                         // Numbers.CopyTo(arr);
            ////Numbers.CopyTo(arr, 3); // Copy the list elements to the array starting at index 3
            ////foreach (var item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// 07 --> EnsureCapacity()
            ////Numbers.EnsureCapacity(22); // Ensure the list has at least the specified capacity
            ////PrintValue(Numbers);

            //// 08 --> Indexof()
            ////Console.WriteLine(Numbers.IndexOf(15));
            #endregion

            #region linkedList
            ////LinkedList --> List of node consist of two node (Data & Link) or( head & tail)

            //LinkedList<int> Linkedlist = new LinkedList<int>();
            ////linkedlist Methods
            //// 01 --> Count()
            //Console.WriteLine($"Count : {Linkedlist.Count}");
            //PrintLinkedList(Linkedlist);
            ////linkedList not have capacity
            //// 02 --> AddFrist()
            //Linkedlist.AddFirst(1);
            //Console.WriteLine($"Count : {Linkedlist.Count}");
            //PrintLinkedList(Linkedlist);
            //Linkedlist.AddFirst(2);
            //PrintLinkedList(Linkedlist);
            //// 03 --> AddLast()
            //Linkedlist.AddLast(3);
            //PrintLinkedList(Linkedlist);
            //// 04 --> AddAfter()
            //// 05 --> AddBefore()
            //// 06 --> Find()
            //Linkedlist.AddAfter(Linkedlist.Find(2), 5);
            //Linkedlist.AddBefore(Linkedlist.Find(2), 7);
            //PrintLinkedList(Linkedlist);
            //// 07 --> Frist()
            //// 08 --> Last()

            //Console.WriteLine(Linkedlist.First());
            //Console.WriteLine(Linkedlist.Last());

            #endregion

            #region Array Vs List Vs Linkedlist Vs Arraylist
            //Data 
            //    --> Heterogeneous --> different Datatype
            //        Arraylist
            //    --> Homogeneous   --> Same Datatype
            //        --> Fixed length -->Array

            //        --> Dynamic length 
            //            --> Add  -->Linked List 
            //            --> Retrieve --> List
            #endregion

            #region Stack [FILO || LIFO]
            //Stack<int> stack = new Stack<int>();
            //// 01 Push()
            //stack.Push(1);
            //stack.Push(5);
            //stack.Push(8);
            //stack.Push(7);
            //PrintStack(stack);
            //// 02 Peek() 
            ////Console.WriteLine(stack.Peek());// --> return last elemnt pushed on array without removing
            //// 03 Pop()
            //Console.WriteLine(stack.Pop());// --> return last elemnt pushed on array and remove it
            //// not when we need to use Pop() in empity array program get exciption
            //// 04 tryPop()
            //stack.TryPop(out int lastnumbre);

            //PrintStack(stack);
            //Console.WriteLine(stack.TryPeek(out int last));

            #endregion

            #region Queue [FIFO || LILO]
            //Queue<int> queue = new Queue<int>();
            //// 01 Enqueue()
            //queue.Enqueue(1); 
            //queue.Enqueue(2); 
            //PrintQueue(queue);  
            //// 02 Dequeue()
            //queue.Dequeue();
            //PrintQueue(queue);
            //// 03 Clear()
            ////queue.Clear();// Remoce all Item from array
            #endregion

            #region HashTable[Dictionary]
            ////Dictionary --> New version of hashtable (non genaric based on object)
            //Hashtable PhoneBook = new Hashtable();
            //PhoneBook.Add("Ahmed", 123);    //
            //                                // two values have same hashcode 
            //// PhoneBook.Add("Ahmed", 456); //
            ////key is unique
            ////O(1)

            //int x=10;
            //int y=10;
            //Console.WriteLine(x.GetHashCode());
            //Console.WriteLine(y.GetHashCode());
            //Console.WriteLine(x.Equals(y));
            #endregion

            #region MyRegion

            #endregion

            #endregion
        }
    }
}
