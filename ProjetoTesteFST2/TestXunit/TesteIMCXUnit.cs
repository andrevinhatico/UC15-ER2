using ProjetoTesteFST2;
using Xunit;

namespace TestXUnit
{
    public class TesteIMCXUnit
    {
        [Fact]
        public void CalculoImc()
        {
            //Arrenge - Preparação
            double Altura = 1.80;
            double Peso = 50;
            string Iresultado = "Abaixo do peso";

            //Act - Ação
            string? resultado = IMCCalcular.CalcularImc(Altura, Peso);

            //Assert - Verificação
            Assert.Equal(Iresultado, resultado);

        }

        [Theory]
        [InlineData(1.80, 100, "Sobrepeso")]
        [InlineData(1.90, 82, "Peso normal!")]
        [InlineData(1.85, 150, "Obesidade grau III")]

        public void TesteImcLista(double Altura, double Peso, string Iresultado)
        {
            //Act - Ação
            string? resultado = IMCCalcular.CalcularImc(Altura, Peso);

            //Assert - Verificação
            Assert.Equal(Iresultado, resultado);

        }
    }
}
