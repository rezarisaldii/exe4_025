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
            Console.WriteLine("Masukkan Ukuran Tumpukan");
            int MAX = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("Masukkan Pilihan : ");
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
                    case 2:
                        if(top == -1)
                            Console.WriteLine("...Stack Underflow...");
                        else
                        {
                            Console.WriteLine("Popped Item :" + reza[top--]);
                        }
                        break;
                    case 3:
                        if(top == -1)
                            Console.WriteLine("...Stack Underflow...");
                        else
                        {
                            Console.WriteLine("Element in the stack");
                            for (int i = top; i >= 0; i--)
                                Console.WriteLine(reza[i]);
                        }
                        break ;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Pilihan salah");
                        break;
                }
            }
        }
    }
}
