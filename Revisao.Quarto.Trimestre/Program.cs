using System;

namespace Revisao.Quarto.Trimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a altura do quadrado:");
            decimal altura = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura do quadrado:");
            decimal largura = decimal.Parse(Console.ReadLine());

            //classe concreta pode ser instanciada
            Quadrado quadrado = new Quadrado(altura, largura);

            //classe abstrata não pode ser instanciada
            //AbstractFiguraGeometreica figura
            //    = new AbstractFiguraGeometreica();

            

            Console.WriteLine("A área do quadrado é:"
                + quadrado.CalcularArea());
        }
    }
}
