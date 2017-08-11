using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestProduto
    {
        NewLojaLimpeza.Domain.Produto produto = new NewLojaLimpeza.Domain.Produto()
        {
            IdProduto = "Dt001",
            NomeProduto = "Detergente Ypê",
            QuantidadeEstoque = 15
        };

        [TestMethod]
        public void AdicionarEstoqueTest()
        {            
            produto.AdicionarEstoque(5);

            Assert.AreEqual(produto.QuantidadeEstoque, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior que 0.")]
        public void AdicionarNegativoEstoqueTest()
        {           
            produto.AdicionarEstoque(-1);
        }

        [TestMethod]
        public void RemoverEstoqueTest()
        {        
            produto.RemoverEstoque(2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior que 0.")]
        public void RemoverNegativoEstoqueTest()
        {         
            produto.RemoverEstoque(-1);
        }



    }
}
