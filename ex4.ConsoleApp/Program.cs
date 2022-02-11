using System;

namespace ex4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];

            for (int i = 1; i < valores.Length; i++)
            {
                Console.Write("Digite o " + i + "º valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
