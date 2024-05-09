﻿using System;
using System.IO;

namespace FilePower2
{
    class Program
    {
         private static void Main(string[] args)
        {
            string fileName; 

            string line;


            if (args.Length <= 0) 
            {
                Console.WriteLine("Must provide file name as argument");

                return;
            }

            fileName = args[0];
            Console.WriteLine("Enter text to add to file. Press enter to stop");

            {           
                using StreamWriter writer = new StreamWriter(fileName);

                while(true)
                {
                    
                    line = Console.ReadLine();

                    
                    if(line.Length <= 0) break;

                   
                    writer.WriteLine(line);
                }


            }

        }
    }
}
