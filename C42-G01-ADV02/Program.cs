using System.Collections;

namespace C42_G01_ADV02
{
    internal class Program
    {
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
            #endregion

#endregion

        }
    }
}
