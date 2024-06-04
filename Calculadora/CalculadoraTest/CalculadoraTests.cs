using CalculadoraProjeto;

namespace CalculadoraTest
{
    public class UnitTest1
    {
        private Calculadora _calculadora = new Calculadora();

        [Fact]
        public void DeveSomarDoisNumerosCorretamente()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int resultadoEsperado = 15;

            // Act
            var resultado = _calculadora.Somar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveSubtrairDoisNumerosCorretamente()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int resultadoEsperado = 5;

            // Act
            var resultado = _calculadora.Subtrair(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveMultiplicarDoisNumerosCorretamente()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int resultadoEsperado = 50;

            // Act
            var resultado = _calculadora.Multiplicar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveDividirDoisNumerosCorretamente()
        {
            // Arrange
            int a = 10;
            int b = 5;
            double resultadoEsperado = 2.0;

            // Act
            var resultado = _calculadora.Dividir(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveLancarExcecaoDividirPorZero()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(a, b));
        }
    }
}