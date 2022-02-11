using System;

namespace ex3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a hora atual: ");
            int hora_atual = Convert.ToInt32(Console.ReadLine());

            if (hora_atual >= 5 && hora_atual <= 12)
            {
                Console.WriteLine("Bom dia!!!");
            }
            else if (hora_atual >= 13 && hora_atual < 18)
            {
                Console.WriteLine("Boa tarde!!!");
            }
            else if (hora_atual >= 18 && hora_atual <= 23 && hora_atual >= 0 && hora_atual <= 4)
            {
                Console.WriteLine("Boa noite!!!");
            }
        }
    }
}
