using System;
using System.Collections.Generic;

namespace Uc_1_CreatLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ///Creating simple linked list method  
           
            LinkedList<string> list = new LinkedList<string>();

            ///creating data with 70 30 56

            list.AddFirst("70");
            list.AddFirst("30");
            list.AddLast("56");



            ///calling list 

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

           


        }
    }
}
