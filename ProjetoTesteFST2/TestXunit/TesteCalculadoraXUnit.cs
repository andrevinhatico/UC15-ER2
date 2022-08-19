using ProjetoTesteFST2;
using Xunit;

namespace TestXUnit
{
    public class TesteCalculadoraXUnit
    {
        [Fact]
        public void TesteSomarDoisNumeros()
        {
            //Arrenge - Preparação
            double Pnum = 1;
            double Snum = 1;
            double tNum = 2;

            //Act - Ação
            var resultado = Calculadora.Somar(Pnum, Snum);

            //Assert - Verificação
            Assert.Equal(tNum, resultado);

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(1, 2, 2)]

        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.Equal(tNum, resultado);

        }
    }
}