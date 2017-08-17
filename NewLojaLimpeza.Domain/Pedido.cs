using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public double ValorTotal { get; set; }

        private List<ItemDePedido> ProdutosItemLista { get; set; }
        
        public List<ItemDePedido> produtosItemLista
        {
            get
            {
                return this.ProdutosItemLista;
            }
            set
            {
                this.ProdutosItemLista = ProdutosItemLista;
            }
        }


        public void AdicionarItem(ItemDePedido item)
        {
            this.ProdutosItemLista.Add(item);
            CalcularValorTotal();
        }

        public void RemoverItem(ItemDePedido item)
        {
            this.produtosItemLista.Remove(item);
            CalcularValorTotal();
        }

        public void CalcularValorTotal()
        {
            ValorTotal = produtosItemLista.Sum(x => x.valorTotalItem);
        }



    }
}