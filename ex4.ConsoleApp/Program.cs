using System;

namespace ex4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            int cont_negativos = 0, cont_positivos = 0;
            int media_aritmetica = 0;
            int somador=0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write("Digite o " + i + "º valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());

                somador = somador + valores[i];
                media_aritmetica = somador / valores.Length;

                if (valores[i] < 0)
                {
                    cont_negativos++;
                }
                else
                {
                    cont_positivos++;
                }
            }
            Console.WriteLine("\r\nA média aritmética é: " + media_aritmetica);
            Console.WriteLine("Quantidade de valores positivos: " + cont_positivos);
            Console.WriteLine("Quantidade de valores negativos: " + cont_negativos);
        }
    }
}
