using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public class ItemDePedido
    {
        public Produto produto;
        public int quantidade;
        public double valorTotalItem;
        public int quantidadeRemovida;

        public Produto Produto { get { return this.produto; } }
        public int Quantidade { get { return this.quantidade; } }
        public double ValorTotalItem { get { return this.valorTotalItem; } }

                      
        public void InserirProduto(int quantidade)
        {
            if (quantidade > produto.QuantidadeEstoque)
                throw new Exception("Estoque insuficiente.");

            else if (quantidade <= 0)
                throw new Exception("A quantidade deve ser maior que 0.");

            else
            {
                produto.RemoverEstoque(quantidade);
                this.quantidade = quantidade;
            }
        }


        public void RemoverProduto(int quantidadeRemovida)
        {
            if (quantidadeRemovida <= quantidade)
            {
                quantidade -= quantidadeRemovida;
                produto.AdicionarEstoque(quantidadeRemovida);
            }

            else if (quantidadeRemovida > quantidade)
                throw new Exception("Não existe essa quantidade de produtos.");

            else if (quantidadeRemovida <= 0)
                throw new Exception("A quantidade deve ser maior que 0.");

        }
        

        public void CalcularValorTotalItem()
        {
            this.valorTotalItem = (Produto.Preco * this.quantidade);
        }       
    }
}
