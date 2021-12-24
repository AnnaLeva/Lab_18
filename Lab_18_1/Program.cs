using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The prase:");
            char[] arrayS = Convert.ToString(Console.ReadLine()).ToArray();

            Stack<char> stack = new Stack<char>();
            stack.Push('0');
            foreach (char i in arrayS)
            {
                if (i == '(')
                {
                    stack.Push(')');
                }

                if (i == '{')
                {
                    stack.Push('}');
                }

                if (i == '[')
                {
                    stack.Push(']');
                }

                if (i == stack.Peek())
                {
                    stack.Pop();
                }
            }

            stack.Pop(); 

            if (stack.Count == 0)
            {
                Console.WriteLine("Nice.");
            }
            else
            {
                Console.WriteLine("Not Good.");
            }
            Console.ReadKey();
        }
    }
}