using System;
using System.Collections.Generic;

namespace Uc_3_AppendingElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                ///Creating linked list method

                LinkedList<string> list = new LinkedList<string>();

                ///creating data with 70

                list.AddFirst("70");


                
                ///calling list 

                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Now Adding two more elemnet");

                ///now adding 30 after 70 and 56 after 30
                ///

                list.AddLast("30");
                list.AddLast("56");

                foreach (string item in list)
                {
                    Console.Write(" " + item);
                }


            }
        }
    }
}
