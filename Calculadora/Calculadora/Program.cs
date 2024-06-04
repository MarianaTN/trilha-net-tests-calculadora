
namespace CalculadoraProjeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            int a = 10;
            int b = 5;

            Console.WriteLine($"Somar: {calculadora.Somar(a, b)}"); // 15
            Console.WriteLine($"Subtrair: {calculadora.Subtrair(a, b)}"); // 5
            Console.WriteLine($"Multiplicar: {calculadora.Multiplicar(a, b)}"); // 50
            Console.WriteLine($"Dividir: {calculadora.Dividir(a, b)}"); // 2.0
        }
    }
}