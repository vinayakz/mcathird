﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sixteen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nNumber of CommadLine Arguments :" + args.Length);
            Console.Write("\nCommandline Arguments Are :\t");
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + "\t");
            }
            Console.ReadLine();  
        }
    }
}
