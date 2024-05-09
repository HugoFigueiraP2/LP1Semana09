﻿using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string fileName; 
            string line;

            Queue<string> queue = new Queue<string>();

            if (args.Length <= 0)
            {
                Console.WriteLine("Must provide file name as argument");

                return;
            }

            fileName = args[0];


            Console.WriteLine("Enter text to add to file. Press enter to stop");

            while(true)
            {
                line = Console.ReadLine();

                if(line.Length <= 0) break;

                queue.Enqueue(line);
            }

            File.WriteAllLines(fileName, queue);

        }
    }
}
