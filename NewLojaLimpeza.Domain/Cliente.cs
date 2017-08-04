using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public class Cliente : Pessoa
    {
        public string IdCliente { get; set; }
        public string Filiacao { get; set; }
        public double LimiteCredito { get; set; }
        public Status Status { get; set; }                        
    }
}
