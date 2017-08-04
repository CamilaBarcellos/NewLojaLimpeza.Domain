using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Endereço Endereco { get; set; }
    }
}
