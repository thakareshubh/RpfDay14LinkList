using System;
using System.Collections.Generic;

namespace Uc_2_AddingTwoElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Creating linked list method

            LinkedList<string> list = new LinkedList<string>();

            ///creating data with 56

            list.AddFirst("56");


            ///calling list 

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Now Appending two more elemnet");

            ///Appending 30 and 70 above the 56
            ///

            list.AddLast("30");
            list.AddLast("70");

            foreach (string item in list)
            {
                Console.Write("-> " + item);
            }


        }
    }
}
