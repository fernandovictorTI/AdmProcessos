using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DataAccess
{
    public class ConexaoBancoDados
    {
        public SqlConnection Connexao { get; set; }

        public ConexaoBancoDados()
        {
            string connString = @"Data Source=FERNANDOVICTORP\SQLEXPRESS;Initial Catalog=AdmProcesso;User ID=sa;Password=123456;Language=Portuguese";
            this.Connexao = new SqlConnection(connString);
        }

        public SqlConnection AbrirConnexao()
        {
            SqlConnection conn = this.Connexao;

            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void FecharConnexao(SqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {                
                throw;
            }
        }

    }
}