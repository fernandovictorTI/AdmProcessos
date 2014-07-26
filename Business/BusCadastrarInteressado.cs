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
<<<<<<< HEAD
=======

        public List<Interessado> ListarInteressados()
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarInteressado daCadastrarInteressado = new DaCadastrarInteressado(conn);
            return daCadastrarInteressado.ListarInteressados();
        }

        public Interessado BuscarInteressado(int id)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarInteressado daCadastrarInteressado = new DaCadastrarInteressado(conn);
            return daCadastrarInteressado.BuscarInteressado(id);
        }

        public void AlterarInteressado(Interessado interessado)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarInteressado daCadastrarInteressado = new DaCadastrarInteressado(conn);
            daCadastrarInteressado.AlterarInteressado(interessado);
        }

        public void DeletarInteressado(int id)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarInteressado daCadastrarInteressado = new DaCadastrarInteressado(conn);
            daCadastrarInteressado.DeletarInteressado(id);
        }
>>>>>>> funcionalidade_filtrar
    }
}