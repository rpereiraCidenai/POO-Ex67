using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Ex67
{
    internal class Triangulo
    {
        // Atributos privados que representam os lados do triângulo
        private double ladoA;
        private double ladoB;
        private double ladoC;

        // Construtor vazio
        public Triangulo() { }

        // Método para definir as dimensões dos lados do triângulo
        public void Dimensoes(double A, double B, double C)
        {
            ladoA = A;
            ladoB = B;
            ladoC = C;
        }

        // Método para identificar o tipo de triângulo
        public string Tipo()
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                return "Equilátero";
            }
            else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
            {
                return "Escaleno";
            }
            else
            {
                return "Isósceles";
            }
        }
    }
}
