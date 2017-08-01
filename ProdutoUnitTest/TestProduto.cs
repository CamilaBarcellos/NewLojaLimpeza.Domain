using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestProduto
    {
        [TestMethod]
        public void AdicionarEstoque()
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
        public void AdicionarNegativoEstoque()
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
        public void RemoverEstoque()
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
        public void RemoverNegativoEstoque()
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
