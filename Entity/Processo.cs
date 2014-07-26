using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entidade
{
    public class Processo
    {
        public int? Numero { get; set; }
        public int Categoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public int Interessado { get; set; }
        public string NomeInteressado { get; set; }
        public DateTime DataJulgamento { get; set; }
        public int ValorAcao { get; set; }
        public string Descricao { get; set; }
    }
}