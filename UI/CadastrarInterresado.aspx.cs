using Business;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAdmProcessos
{
    public partial class CadastrarInterresado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Eventos

        protected void btnCadastrarInteressado_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos() == 0)
                {
                    Interessado interessado = new Interessado();
                    interessado.Nome = txtNome.Text;
                    interessado.CPF = txtCpf.Text;
                    interessado.Contato = txtContato.Text;
                    interessado.Endereco = txtEndereco.Text;

                    BusCadastrarInteressado bus = new BusCadastrarInteressado();
                    bus.CadastrarInteressado(interessado);

                    calSucces.Visible = true;
                    calDanger.Visible = false;
                }
                else
                {
                    calSucces.Visible = false;
                    calDanger.Visible = true;
                }                
            }
            catch (Exception)
            {                
                throw;
            }
        }

        #endregion

        #region Metodos

        private int ValidarCampos()
        {
            int contErro = 0;

            if (txtNome.Text == string.Empty)
            {
                contErro++;
            }

            if (txtCpf.Text == string.Empty)
            {
                contErro++;
            }

            return contErro;
        }

        #endregion
    }
}