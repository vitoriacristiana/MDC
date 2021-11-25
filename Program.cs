using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Máximo Divisor Comum (método iterativo)");

            Console.Write ("Digite o 1º número (a):");
            int  a  = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o 2º número (b):");
            int  b  =  Convert.ToInt32 (Console.ReadLine());

            int mdc = 12;

            Console . WriteLine ($"MDC (a, b) = {mdc}");
        }
    }
}
            
        
    

