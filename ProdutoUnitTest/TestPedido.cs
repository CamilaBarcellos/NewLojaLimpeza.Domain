using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewLojaLimpeza.Domain;

namespace ProdutoUnitTest
{
    [TestClass]
    public class TestPedido
    {
        [TestMethod]
        public void IncluirItemDePedidoTest()
        {
            var produto = new NewLojaLimpeza.Domain.Produto()
            {
                IdProduto = "Dt001",
                QuantidadeEstoque = 15,
                Preco = 2
            };

            var itemPedido = new NewLojaLimpeza.Domain.ItemDePedido()
            {
                produto = produto,
                quantidade = 5
            };
            itemPedido.CalcularValorTotalItem();

            var item = new NewLojaLimpeza.Domain.Pedido()
            {
                ValorTotal = 0
            };
                        
            item.produtosItemLista.Add(itemPedido);
            Assert.IsNotNull(item.produtosItemLista);            
        }

        
       
    }
}
