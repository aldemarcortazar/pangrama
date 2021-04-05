using System;
using System.Collections.Generic;

namespace pangrama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! seguidamente se te solicitaran que escribas una palabra para comparar si es un pangrama");
            string frase = Console.ReadLine().ToLower();
            Pangrama pangrama = new Pangrama();
            pangrama.compararPagrama( frase );
            Console.ReadKey();
        }
    }
}
