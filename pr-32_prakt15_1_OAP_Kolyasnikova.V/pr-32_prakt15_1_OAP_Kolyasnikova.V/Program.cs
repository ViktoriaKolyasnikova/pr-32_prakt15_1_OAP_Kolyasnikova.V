using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt15_1_OAP_Kolyasnikova.V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int r= Convert.ToInt32(Console.ReadLine());
            Stack s = new Stack();
            for (int i = 1; i <= r; i++)
            {
                s.Push(i);
            }    
            Console.WriteLine("Размерность стека: " + s.Count);
            Console.WriteLine("Верхний элемент стека: " + s.Peek());
            Console.Write("Содержимое стека: ");
            while (s.Count != 0)
            {
                Console.Write(" "+s.Pop());
            }  
            Console.WriteLine("\nНовая размерность стека: " + s.Count);
            Console.ReadKey();
        }
    }
}
