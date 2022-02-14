using System;

namespace ex5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero_jogador1, numero_jogador2, cont_vitorias_jogador1 = 0, cont_vitorias_jogador2 = 0;

            Console.Write("Nome do Jogador 1: ");
            string jogador1 = Console.ReadLine();

            Console.Write("Nome do Jogador 2: ");
            string jogador2 = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("\r\n" + i + "ª Rodada: ");

                do
                {
                    Console.Write(jogador1 + ": ");
                    numero_jogador1 = Convert.ToInt32(Console.ReadLine());
                } while (numero_jogador1 > 6);

                do
                {
                    Console.Write(jogador2 + ": ");
                    numero_jogador2 = Convert.ToInt32(Console.ReadLine());
                } while (numero_jogador2 > 6);

                if (numero_jogador1 > numero_jogador2)
                {
                    Console.WriteLine("O jogador " + jogador1 + " jogou " + numero_jogador1 + " e venceu a " + i + "ª Rodada");
                    cont_vitorias_jogador1++;
                }
                else if (numero_jogador1 < numero_jogador2)
                {
                    Console.WriteLine("O jogador " + jogador2 + " jogou " + numero_jogador2 + " e venceu a " + i + "ª Rodada");
                    cont_vitorias_jogador2++;
                }
                else if (numero_jogador1 == numero_jogador2)
                {
                    Console.WriteLine("\r\nHouve um empate definitivo, tentem novamente!");
                    do
                    {
                        Console.Write(jogador1 + ": ");
                        numero_jogador1 = Convert.ToInt32(Console.ReadLine());
                    } while (numero_jogador1 > 6);

                    do
                    {
                        Console.Write(jogador2 + ": ");
                        numero_jogador2 = Convert.ToInt32(Console.ReadLine());
                    } while (numero_jogador2 > 6);

                    if (numero_jogador1 > numero_jogador2)
                    {
                        Console.WriteLine("O jogador " + jogador1 + " jogou " + numero_jogador1 + " e venceu a " + i + "ª Rodada");
                        cont_vitorias_jogador1++;
                    }
                    else if (numero_jogador1 < numero_jogador2)
                    {
                        Console.WriteLine("O jogador " + jogador2 + " jogou " + numero_jogador2 + " e venceu a " + i + "ª Rodada");
                        cont_vitorias_jogador2++;
                    }
                }
            }

            if (cont_vitorias_jogador1 > cont_vitorias_jogador2)
            {
                Console.WriteLine("\r\nParabéns " + jogador1 + " você ganhou o jogo!");
            }
            else if (cont_vitorias_jogador1 < cont_vitorias_jogador2)
            {
                Console.WriteLine("\r\nParabéns " + jogador2 + " você ganhou o jogo!");
            }
        }
    }
}