using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLojaLimpeza.Domain
{
    public class Fornecedor : Pessoa
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
    }
}
