using DataAccess;
using Entidade;
using System;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> funcionalidade_filtrar
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

<<<<<<< HEAD
        public List<Processo> ListarProcessos()
=======
        public List<Processo> ListarProcessos(Hashtable ht)
>>>>>>> funcionalidade_filtrar
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
<<<<<<< HEAD
            return daCadastrarProcesso.ListarProcessos();
=======
            return daCadastrarProcesso.ListarProcessos(ht);
        }

        public Processo RetornarProcesso(int numero)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();
            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            return daCadastrarProcesso.RetornarProcesso(numero);
        }

        public void AlterarProcesso(Processo processo)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            daCadastrarProcesso.Alterar(processo);
        }

        public void DeletarProcesso(int numeroProcesso)
        {
            ConexaoBancoDados conexao = new ConexaoBancoDados();

            var conn = conexao.AbrirConnexao();
            DaCadastrarProcesso daCadastrarProcesso = new DaCadastrarProcesso(conn);
            daCadastrarProcesso.DeletarProcesso(numeroProcesso);
>>>>>>> funcionalidade_filtrar
        }
    }
}