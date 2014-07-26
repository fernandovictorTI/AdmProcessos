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

        public List<Interessado> ListarInteressados()
        {
            string sql = string.Empty;
            List<Interessado> lstInteressado = new List<Interessado>();
            SqlDataReader rdr = null;

            try
            {
                sql = @"select * from interessado";
                SqlCommand cmd = new SqlCommand(sql, this.Conn);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lstInteressado.Add(new Interessado { Id = Convert.ToInt32(rdr["Id"]), Nome = rdr["Nome"].ToString(),CPF = rdr["Cpf"].ToString(),Contato = rdr["Contatos"].ToString(),Endereco = rdr["Endereco"].ToString() });
                }

                return lstInteressado;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public Interessado BuscarInteressado(int id)
        {
            Interessado interessado = new Interessado();
            SqlDataReader rdr = null;
            string sql = string.Empty;

            try
            {
                sql = @"select * from interessado where id  = @id";
                SqlCommand cmd = new SqlCommand(sql, this.Conn);

                cmd.Parameters.AddWithValue("@id", id);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    interessado.Id = Convert.ToInt32(rdr[0]);
                    interessado.Nome = rdr[1].ToString();
                    interessado.CPF = rdr[2].ToString();
                    interessado.Contato = rdr[3].ToString();
                    interessado.Endereco = rdr[4].ToString();
                }

                return interessado;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void AlterarInteressado(Interessado interessado)
        {
            string sql = string.Empty;

            try
            {
                sql = @"update interessado set nome = @nome, cpf = @cpf, contatos = @contatos,
                    endereco = @endereco where id = @id";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                cmd.Parameters.AddWithValue("@id",interessado.Id);
                cmd.Parameters.AddWithValue("@nome", interessado.Nome);
                cmd.Parameters.AddWithValue("@cpf", interessado.CPF);
                cmd.Parameters.AddWithValue("@contatos", interessado.Contato);
                cmd.Parameters.AddWithValue("@endereco", interessado.Endereco);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarInteressado(int id)
        {
            string sql = string.Empty;

            try
            {
                sql = @"delete from interessado where id = @id";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
