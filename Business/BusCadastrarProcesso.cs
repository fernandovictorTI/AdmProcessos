using DataAccess;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business
{
    public class BusCadastrarProcesso
    {
        public List<Categoria> ListarCategoria()
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            return daCadastrarProcesso.ListarCategoria();

        }

        public List<Interessado> ListarInteressado()
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            return daCadastrarProcesso.ListarInteressado();
        }

        public void CadastrarProcesso(Processo processo)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            daCadastrarProcesso.Cadastrar(processo);
        }

        public List<Processo> ListarProcessos()
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            return daCadastrarProcesso.ListarProcessos();
        }
    }
}