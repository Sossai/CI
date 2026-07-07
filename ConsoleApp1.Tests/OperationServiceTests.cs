using ConsoleApp1;
using Xunit;

namespace ConsoleApp1.Tests
{
    public class OperationServiceTests
    {
        [Theory]
        [InlineData(10, 2, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 5, 0)]
        [InlineData(-3, -7, -10)]
        public void Soma_DeveRetornarSomaCorreta(int val1, int val2, int esperado)
        {
            var service = new OperationService();

            var resultado = service.Soma(val1, val2);

            Assert.Equal(esperado, resultado);
        }
    }
}
