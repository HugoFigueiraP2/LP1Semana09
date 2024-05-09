using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        private static void Main(string[] args)
        {

            List<int> listInts          = new List<int>     {1,10,-30,10,-5};
            Stack<int> stackInts        = new Stack<int>    (listInts);
            Queue<int> queueInts        = new Queue<int>    (listInts);
            HashSet<int> hashSetInts    = new HashSet<int>  (listInts);

            Console.Write("List: ");

            foreach (int i in listInts) 
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            Console.Write("Stack: ");

            foreach (int i in stackInts) 
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.Write("Queue: ");

            foreach (int i in queueInts)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.Write("Hash: ");

            foreach (int i in hashSetInts) 
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
