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

        public List<ItemDePedido> produtosItemLista = new List<ItemDePedido>();


        public void CalcularValorTotal()
        {
            ValorTotal = produtosItemLista.Sum(x => x.valorTotalItem);
        }



    }
}