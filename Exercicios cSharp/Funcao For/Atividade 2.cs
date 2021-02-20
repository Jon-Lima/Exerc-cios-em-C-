//Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.

//Entrada

//A entrada contém um valor inteiro N (5 < N < 2000).

//Saída

//Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

//Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000 o 
//que ocasionará resposta errada. Neste caso, configure a precisão adequadamente para que isso não ocorra.

using System;

namespace funcao para1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = i * i;
                    Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        }
    }
}