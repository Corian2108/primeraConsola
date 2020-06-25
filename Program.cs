using System;

namespace primeraConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hola" + args[0]);
            }
            else
            {
                Console.WriteLine("Introduce tu nombre");
                string nombre = Console.ReadLine();
                if (nombre != "" && nombre !=null)
                {
                    Console.WriteLine("Bienvenido" + nombre);
                    Console.ReadKey();
                }
                else
                {
                   Console.WriteLine("Para iniciar programa ingrese un nombre");
                   Console.ReadKey();
                }
            }

        }
    }
}
