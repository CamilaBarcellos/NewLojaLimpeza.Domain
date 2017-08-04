using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public class Produto
    {
        public string IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Categoria Categoria { get; set; }


        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
                QuantidadeEstoque += quantidade;
            else
                throw new Exception("A quantidade deve ser maior que 0.");
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0)
                QuantidadeEstoque -= quantidade;
            else
                throw new Exception("A quantidade deve ser maior que 0.");
        }

    }
}
