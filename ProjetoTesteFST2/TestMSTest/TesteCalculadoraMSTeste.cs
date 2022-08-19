using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteFST2;

namespace TestMSTest
{
    [TestClass]
    public class TesteCalculadoraMSTeste
    {
        [TestMethod]
        public void TestMeTesteSomarDoisNumeros()
        {
            //Arrenge - Prepara��o
            double Pnum = 1;
            double Snum = 1;
            double tNum = 2;

            //Act - A��o
            var resultado = Calculadora.Somar(Pnum, Snum);

            //Assert - Verifica��o
            Assert.AreEqual(tNum, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 2)]
        public void TesteSomarDoisNumerosLista(double pNum, double sNum, double tNum)
        {
            //Act - A��o
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verifica��o
            Assert.AreEqual(tNum, resultado);

        }
    }
}