﻿using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> mylist = new List<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);

            foreach (int i in mylist)
                Console.Write((i + 2) * 5 + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
