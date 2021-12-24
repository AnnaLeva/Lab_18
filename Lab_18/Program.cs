using System;
using System.Collections.Generic;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach (int l in list)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
    }
}
