using System;
using System.Collections.Generic;

namespace Uc_4_InsertElementInLinkList
{
    internal class Program
    {


        static void Main(string[] args)
        {
            ///Creating linked list method

            LinkedList<string> list = new LinkedList<string>();

            ///creating data with 56 and 70

            list.AddFirst("56");
            list.AddLast("70");


            ///calling list 

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Insert 30 Between 56 And 70");
            
            list.AddAfter("56", "30");


            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

