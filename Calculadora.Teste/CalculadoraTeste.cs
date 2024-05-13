using Xunit;

namespace Calculadora.Teste
{
    public class CalculadoraTestes
    {
        [Fact]
        public void DeveSomarCorretamente()
        {
            var Calculadora = new Calculadora("13/05/2024");

            var resultado = Calculadora.somar(5,3);

            Assert.Equal(8, resultado);
        }
        [Fact]
        public void DeveSubtrairCorretamente()
        {
            // Arrange
            var calculadora = new Calculadora("13/05/2024");

            // Act
            var resultado = calculadora.subtrair(10, 3);

            // Assert
            Assert.Equal(7, resultado);
        }

        [Fact]
        public void DeveMultiplicarCorretamente()
        {
            // Arrange
            var calculadora = new Calculadora("13/05/2024");

            // Act
            var resultado = calculadora.multiplicar(5, 3);

            // Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void DeveDividirCorretamente()
        {
            // Arrange
            var calculadora = new Calculadora("13/05/2024");

            // Act
            var resultado = calculadora.dividir(15, 3);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void DeveRetornarHistoricoCorretamente()
        {
            // Arrange
            var calculadora = new Calculadora("13/05/2024");

            // Act
            calculadora.somar(5, 3);
            calculadora.subtrair(10, 3);
            calculadora.multiplicar(5, 3);
            var historico = calculadora.historico();

            // Assert
            Assert.Equal(3, historico.Count);
        }    
    }
}
