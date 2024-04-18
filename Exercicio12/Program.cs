/* 
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação.
*/

using System;
using System.Globalization;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            string[] value;

            Console.Write("Digite os valores de x e y: ");
            value = Console.ReadLine().Split(' ');
            x = float.Parse(value[0]);
            y = float.Parse(value[1]);

            if (x > 0 && y > 0) { Console.WriteLine("Q1"); }
            else if (x < 0 && y > 0) { Console.WriteLine("Q2"); }
            else if (x < 0 && y < 0) { Console.WriteLine("Q3"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Q4"); }
            else { Console.WriteLine("Origem"); }

        }
    }
}