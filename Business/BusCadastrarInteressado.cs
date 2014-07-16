using DataAccess;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business
{
    public class BusCadastrarInteressado
    {
        public void CadastrarInteressado(Interessado interessado)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarInteressado daCadastrarInteressado = new DaCadastrarInteressado(conn);
            daCadastrarInteressado.CadastrarInteressado(interessado);
        }
    }
}