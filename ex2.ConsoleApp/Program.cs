using System;

namespace ex2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura = 50;
            int altura = 10;
            string str = "";

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    if (i % 2 == 0)
                    {
                        str += "A";
                    }
                    else
                    {
                        str += "B";
                    }
                }
                str += "\n";
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
