using System;
using System.Collections.Generic;
using System.Text;

namespace Revisao.Quarto.Trimestre
{
    /// <summary>
    /// Pilar programação OO
    /// Herança
    /// </summary>
    public class Quadrado : AbstractFiguraGeometreica
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }

        /// <summary>
        /// Pilar programação OO
        /// Encapsulamento (obrigando o client a passar
        /// altura e largura para construção do objeto)
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="largura"></param>
        public Quadrado(decimal altura, decimal largura)
        {
            Altura = altura;
            Largura = largura;
        }

        /// <summary>
        /// Programação OO
        /// Polimorfismo (implementado de forma diferente 
        /// para cada figura geometrica)
        /// Metodo concreto implementado
        /// </summary>
        /// <returns></returns>
        public override decimal CalcularArea()
        {
            return Altura * Largura;
        }
    }
}