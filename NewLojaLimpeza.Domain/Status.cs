using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public class Status 
    {
        public int IdStatus { get; set; }
        public string Classificacao { get; set; }


        public void DefinirStatus(Cliente cliente)
        {
            if (cliente.LimiteCredito <= 1000)
                IdStatus = 1;

            else if (cliente.LimiteCredito <= 3000)
                IdStatus = 2;

            else if (cliente.LimiteCredito > 3000)
                IdStatus = 3;

            else if (cliente.LimiteCredito < 0)
                throw new Exception("O limite de crédito não pode ser negativo.");
        }        
    }
}
