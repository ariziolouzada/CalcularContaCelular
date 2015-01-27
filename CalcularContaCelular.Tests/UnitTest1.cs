using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcularContaCelular.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FuncionamentoBasicoDoPlano()
        {
            //Arrange

            var consumo = new Consumo("Arizio", 1, 2 , 3);

            var plano = new Plano("Smart", 0.10m, 0.35m, 0.75m, 30m);

            var total = (consumo.MinutosParaFixo * plano.ValorParaFixo) +
                        (consumo.MinutosParaCelular * plano.ValorParaCelular) +
                        (consumo.MinutosParaInterurbano * plano.ValorParaInterurbano) +
                        plano.ValorAssinatura;

            //Act
            var conta = plano.CalcularConta(consumo);

            //Assert
            Assert.AreEqual(total, conta.Total);
        }
    }
}
