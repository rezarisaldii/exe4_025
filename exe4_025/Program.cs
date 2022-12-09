using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_025
{
    class Program
    {
        static void Main(string[] args)
        {
            int top = -1;
            int[] reza = new int[45];
            Console.WriteLine("Enter Size Of The Stack");
            int MAX = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice : ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        if (top > MAX - 1)
                            Console.WriteLine("... Stack Overflow...");
                        else
                        {
                            Console.WriteLine("Enter the item: ");
                            int n = int.Parse(Console.ReadLine());
                            reza[++top] = n;
                        }
                        break;
                }
            }
        }
    }
}
