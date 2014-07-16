using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidade
{
    public class Interessado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }
    }
}