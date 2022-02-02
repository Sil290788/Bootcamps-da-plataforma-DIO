// Escreva um algoritmo para calcular e escrever o valor de S, sendo S dada pela fórmula:
// S = 1 + 1/2 + 1/3 + ... 1/100

// ENTRADA - Não há nenhuma entrada nesse problema.

// SAÍDA - A saída contém um valor correspondente ao valor de S. O valor deve ser impresso com dois digítos após o ponto decimal.

using System;
class DIO
{
    static void Main(string[] args)
    {
        double divisao, soma = 0;
        for (double numero = 1; numero <= 100; numero++)
        {
            divisao = 1 / numero;  // Coloque a sua lógica nos espaços em branco
            soma = soma + divisao;
        }
        var x = Math.Round(soma, 2);
        Console.WriteLine(x);
    }
}
