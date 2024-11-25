namespace POO_Ex67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma instância da classe Triangulo
            Triangulo triangulo = new Triangulo();

            // Solicitar ao utilizador o comprimento dos lados do triângulo
            Console.WriteLine("Insira o comprimento do lado A:");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o comprimento do lado B:");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o comprimento do lado C:");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            // Definir as dimensões do triângulo com os valores fornecidos
            triangulo.Dimensoes(ladoA, ladoB, ladoC);

            // Guardar o tipo de triângulo numa variável antes de exibir
            string tipoTriangulo = triangulo.Tipo();

            // Exibir o tipo de triângulo
            Console.WriteLine("O triângulo com lados A = " + ladoA + ", B = " + ladoB + ", e C = " + ladoC + " é: " + tipoTriangulo);
            //saasd
        }
    }
}