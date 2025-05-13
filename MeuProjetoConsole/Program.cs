// See https://aka.ms/new-console-template for more information
using System;

namespace MeuProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo x, y;

            // Criando os objetos triangulo
            // Usando o operador new para instanciar os objetos
             x = new triangulo();
             y  = new triangulo();

            Console.WriteLine("Digite as medidas do triângulo X");  
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());
            
            // Calculando a área do triângulo
            // Usando a fórmula de Heron


            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X: " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}


