using System;
using System.Collections.Generic;

namespace cosa_de_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            PolacResolver();
        }
       public static void PolacResolver()
        {
            Stack<int> My_stack = new Stack<int>();
            Queue<string> My_queue = new Queue<string>();

            string cadena;
            do
            {
                System.Console.WriteLine("Introduce un número");
                cadena = System.Console.ReadLine();
                if (cadena != "")
                {
                    My_stack.Push(System.Convert.ToInt32(cadena));
                }
            }
            while (cadena != "" );

            do
            {
                System.Console.WriteLine("Introduce un signo");
                cadena = System.Console.ReadLine();
                if (cadena != "")
                {
                    My_queue.Enqueue(cadena);
                }
            }
            while (cadena != "" && My_queue.Count < My_stack.Count -1);
      
            int v1 = My_stack.Pop();
            int v2 = My_stack.Pop();
            string v3 = My_queue.Dequeue();
        
            do
            {
                if(v3 == "+")
                {
                    My_stack.Push(v2 + v1);

                }
                else if (v3 == "-")
                {
                    My_stack.Push(v2 - v1);
                }
                else if(v3 == "*")
                {
                    My_stack.Push(v2 * v1);
                }
                else if(v3 == "/")
                {
                    My_stack.Push(v2 / v1);
                }
            }
            while (My_stack.Count > 0);
        }
    }
}
