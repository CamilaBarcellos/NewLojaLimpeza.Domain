using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestStatus
    {
        [TestMethod]
        public void TestDefinirStatus()
        {
            var status = new NewLojaLimpeza.Domain.Status()
            {
                IdStatus = 1,
                Classificacao = "Ruim"
            };

            var cliente = new NewLojaLimpeza.Domain.Cliente()
            {
                IdCliente = "C001",
                LimiteCredito = 2500,
                Status = status                
            };

            status.DefinirStatus(cliente);
            cliente.Status = status;
            Assert.AreEqual(cliente.Status.IdStatus, 2);
        }

   
        
    }
}
