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

            double px = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(px * (px - x.A) * (px - x.B) * (px - x.C));

            double py = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(py * (py - y.A) * (py - y.B) * (py - y.C));    

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


