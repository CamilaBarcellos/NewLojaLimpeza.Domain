using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestProduto
    {
        [TestMethod]
        public void AdicionarEstoqueTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                NomeProduto = "Detergente Ypê",
                QuantidadeEstoque = 15
            };

            produto.AdicionarEstoque(5);

            Assert.AreEqual(produto.QuantidadeEstoque, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior que 0.")]
        public void AdicionarNegativoEstoqueTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                NomeProduto = "Detergente Ypê",
                QuantidadeEstoque = 15
            };

            produto.AdicionarEstoque(-1);
        }

        [TestMethod]
        public void RemoverEstoqueTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                NomeProduto = "Detergente Ypê",
                QuantidadeEstoque = 15
            };

            produto.RemoverEstoque(2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior que 0.")]
        public void RemoverNegativoEstoqueTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                NomeProduto = "Detergente Ypê",
                QuantidadeEstoque = 15
            };

            produto.RemoverEstoque(-1);
        }



    }
}
