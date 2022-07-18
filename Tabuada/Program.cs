using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Digite um número para fazer a tabuada");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int x = 0; x <= 10; x++)
            {
                resultado = numero * x;
                Console.WriteLine(x+" x "+numero+" = "+resultado);
            }
            Console.ReadLine();
            
        }
    }
}
