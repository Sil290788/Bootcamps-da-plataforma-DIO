/* Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

Entrada
Não há nenhuma entrada neste problema.

Saída
Imprima a sequencia conforme exemplo abaixo */


using System;

class DIO
{

    static void Main(string[] args)
    {
        int i = 1;

        while (i <= 9)
        {
            for (int j = 7; j > 4; j--)
            {
                Console.WriteLine($"I={i} J={j} ");
            }
            i += 2;
        }
    }
}