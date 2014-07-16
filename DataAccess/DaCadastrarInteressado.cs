using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Business
{
    public class DaCadastrarInteressado
    {
        public SqlConnection Conn { get; set; }

        public DaCadastrarInteressado(SqlConnection conn)
        {
            this.Conn = conn;
        }

        public void CadastrarInteressado(Interessado interessado)
        {
            string sql = string.Empty;

            try
            {
                sql = "insert into interessado (nome,cpf,contatos,endereco) values (@nome,@cpf,@contatos,@endereco)";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                cmd.Parameters.AddWithValue("@nome",interessado.Nome);
                cmd.Parameters.AddWithValue("@cpf",interessado.CPF);
                cmd.Parameters.AddWithValue("@contatos",interessado.Contato);
                cmd.Parameters.AddWithValue("@endereco",interessado.Endereco);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
