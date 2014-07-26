using Entidade;
using System;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> funcionalidade_filtrar
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess
{
    public class DaCadastrarProcesso
    {
        public SqlConnection Conn { get; set; }

        public DaCadastrarProcesso(SqlConnection conn)
        {
            this.Conn = conn;
        }


        public List<Categoria> ListarCategoria()
        {
            SqlDataReader rdr = null;
            string sql = string.Empty;
            List<Categoria> lstCategoria = new List<Categoria>();

            try
            {
                sql = "select * from categoria";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                rdr = cmd.ExecuteReader();
                lstCategoria.Add(new Categoria{Id=0,Descricao="*** Selecione ***"});
                while (rdr.Read())
                {
                    lstCategoria.Add(new Categoria { Id = Convert.ToInt32(rdr[0]), Descricao = rdr[1].ToString() });
                }

                return lstCategoria;

            }
            catch (Exception)
            {                
                throw;
            }
        }

        public List<Interessado> ListarInteressado()
        {
            SqlDataReader rdr = null;
            string sql = string.Empty;
            List<Interessado> lstInteressado = new List<Interessado>();

            try
            {
                sql = "select * from interessado";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                rdr = cmd.ExecuteReader();
                lstInteressado.Add(new Interessado { Id = 0, Nome = "*** Selecione ***" });
                while (rdr.Read())
                {
                    lstInteressado.Add(new Interessado { Id = Convert.ToInt32(rdr[0]), Nome = rdr[1].ToString() });
                }

                return lstInteressado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Processo processo)
        {
            string sql = string.Empty;

            try
            {
                sql = @"insert into Processo (Categoria,Interessado,Data_Julgamento,Valor_Acao,Descricao) values 
                    (@categoria,@interessado,@dataJulgamento,@valorAcao,@descricao)";
                SqlCommand cmd = new SqlCommand(sql, Conn);

<<<<<<< HEAD
                //cmd.Parameters.AddWithValue("@numero", processo.Numero);
=======
>>>>>>> funcionalidade_filtrar
                cmd.Parameters.AddWithValue("@categoria", processo.Categoria);
                cmd.Parameters.AddWithValue("@interessado", processo.Interessado);
                cmd.Parameters.AddWithValue("@dataJulgamento", processo.DataJulgamento);
                cmd.Parameters.AddWithValue("@valorAcao", processo.ValorAcao);
                cmd.Parameters.AddWithValue("@descricao", processo.Descricao);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

<<<<<<< HEAD
        public List<Processo> ListarProcessos()
=======
        public List<Processo> ListarProcessos(Hashtable ht)
>>>>>>> funcionalidade_filtrar
        {
            var lstProcesso = new List<Processo>();
            SqlDataReader rdr = null;
            string sql = string.Empty;

            try
            {
                sql = @"select p.Numero, c.Descricao,i.Nome, p.Data_Julgamento from processo p
                    inner join Categoria c on c.Id = p.Categoria
                    inner join Interessado i on i.Id = p.Interessado";
<<<<<<< HEAD

                SqlCommand cmd = new SqlCommand(sql, Conn);
=======
                SqlCommand cmd = new SqlCommand();

                if (ht.ContainsKey("CATEGORIA") && Convert.ToInt32(ht["CATEGORIA"])>0)
                {
                    sql = string.Concat(sql, " and c.Id = @Categoria");
                    cmd.Parameters.AddWithValue("Categoria",Convert.ToInt32(ht["CATEGORIA"]));
                }

                cmd.CommandText = sql;
                cmd.Connection = Conn;
>>>>>>> funcionalidade_filtrar

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lstProcesso.Add(new Processo { Numero = Convert.ToInt32(rdr[0]), 
                                                   DescricaoCategoria = rdr[1].ToString(),
                                                   NomeInteressado = rdr[2].ToString(),
                                                   DataJulgamento = Convert.ToDateTime(rdr[3])
                                                    });
                }

                return lstProcesso;
            }
            catch (Exception)
            {                
                throw;
            }
        }
<<<<<<< HEAD
=======

        public Processo RetornarProcesso(int numero)
        {
            Processo processo = new Processo();
            SqlDataReader rdr = null;
            string sql = string.Empty;

            try
            {
                sql = "select * from processo where numero = @numero";
                SqlCommand cmd = new SqlCommand(sql, this.Conn);
                cmd.Parameters.AddWithValue("@numero", numero);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    processo.Numero = Convert.ToInt32(rdr["Numero"].ToString());
                    processo.Categoria = Convert.ToInt32(rdr["Categoria"].ToString());
                    processo.Interessado = Convert.ToInt32(rdr["Interessado"].ToString());
                    processo.DataJulgamento = Convert.ToDateTime(rdr["Data_Julgamento"]);
                    processo.ValorAcao = Convert.ToInt32(rdr["Valor_Acao"].ToString());
                    processo.Descricao = rdr["Descricao"].ToString();
                }

                return processo;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void Alterar(Processo processo)
        {
            string sql = string.Empty;

            try
            {
                sql = @"update processo set Categoria = @categoria, Interessado = @interessado, Data_Julgamento = @dataJulgamento,
                    Valor_Acao = @valorAcao, Descricao = @descricao where Numero = @numero";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                cmd.Parameters.AddWithValue("@numero", Convert.ToInt32(processo.Numero));
                cmd.Parameters.AddWithValue("@categoria", processo.Categoria);
                cmd.Parameters.AddWithValue("@interessado", processo.Interessado);
                cmd.Parameters.AddWithValue("@dataJulgamento", processo.DataJulgamento);
                cmd.Parameters.AddWithValue("@valorAcao", processo.ValorAcao);
                cmd.Parameters.AddWithValue("@descricao", processo.Descricao);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeletarProcesso(int numeroProcesso)
        {
            string sql = string.Empty;

            try
            {
                sql = @"delete from processo where Numero = @numero";
                SqlCommand cmd = new SqlCommand(sql, Conn);

                cmd.Parameters.AddWithValue("@numero", numeroProcesso);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
>>>>>>> funcionalidade_filtrar
    }
}