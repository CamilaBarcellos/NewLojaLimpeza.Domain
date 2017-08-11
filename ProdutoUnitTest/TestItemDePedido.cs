using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewLojaLimpeza.Domain;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestItemDePedido
    {
        //------------------------------------------------------------------------------------------
        [TestMethod]
        public void InserirProdutoTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 15,
                Preco = 1.99                                
            };

            var item = new NewLojaLimpeza.Domain.ItemDePedido(produto, 5);

            Assert.AreEqual(5, item.quantidade);
        }

        //------------------------------------------------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior que 0.")]
        public void InserirProdutoNegativoTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 15,
                Preco = 1.99
            };

            var item = new NewLojaLimpeza.Domain.ItemDePedido()
            {
                produto = produto
            };

            item.InserirProduto(-3);            
        }

        //------------------------------------------------------------------------------------------
        [TestMethod]
        public void RemoverProdutoTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 10
            };

            var item = new NewLojaLimpeza.Domain.ItemDePedido()
            {
                produto = produto,
                quantidade = 5
            };

            item.RemoverProduto(5);
            Assert.AreEqual(item.quantidade, 0);
        }

        //------------------------------------------------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior que 0.")]
        public void RemoverProdutoNegativoTest()        
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 10
            };

            var item = new NewLojaLimpeza.Domain.ItemDePedido()
            {
                produto = produto,
                quantidade = 5
            };

            item.RemoverProduto(-2);
        }

        //------------------------------------------------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(Exception), "Não existe essa quantidade de produtos.")]
        public void RemoverProdutoQuantidadeInexistente()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 10
            };

            var item = new NewLojaLimpeza.Domain.ItemDePedido()
            {
                produto = produto,
                quantidade = 5
            };

            item.RemoverProduto(6);
        }
        
        //------------------------------------------------------------------------------------------
        [TestMethod]
        public void CalcularValorTotalItemTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 15,
                Preco = 2
            };

            var item = new NewLojaLimpeza.Domain.ItemDePedido()
            {
                produto = produto,
                quantidade = 5   
            };

            item.CalcularValorTotalItem();
            Assert.AreEqual(10, item.valorTotalItem);
        }
    }
}
