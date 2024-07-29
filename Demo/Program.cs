using System;
using System.Collections;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
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


            #endregion
        }
    }
}
