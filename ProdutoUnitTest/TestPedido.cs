using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewLojaLimpeza.Domain;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestPedido
    {
        [TestMethod]
        public void AdicionarItemTest()
        {
            var produto = new Produto
            {
                QuantidadeEstoque = 10
            };

            var itemPedido = new NewLojaLimpeza.Domain.ItemDePedido(produto, 1);
            var item = new NewLojaLimpeza.Domain.Pedido(itemPedido, 1);

            item.AdicionarItem(itemPedido);

            Assert.AreEqual(1, item.produtosItemLista.Count);
        }

        
        [TestMethod]
        public void CalcularValorTotalTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 15,
                Preco = 2
            };

            
            var itemPedido = new NewLojaLimpeza.Domain.ItemDePedido(produto, 5);

            var pedido = new NewLojaLimpeza.Domain.Pedido(itemPedido, 1);
            
            
            Assert.AreEqual(10, pedido.ValorTotal);
            
        }       
    }
}
