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
<<<<<<< HEAD

=======
            if (!IsPostBack)
            {
                this.CarregarCampos();
            }
>>>>>>> funcionalidade_filtrar
        }

        #region Eventos

        protected void btnCadastrarInteressado_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos() == 0)
                {
<<<<<<< HEAD
                    Interessado interessado = new Interessado();
=======
                    int? num = null;

                    Interessado interessado = new Interessado();
                    interessado.Id = txtId.Text != string.Empty ? Convert.ToInt32(txtId.Text) : num;
>>>>>>> funcionalidade_filtrar
                    interessado.Nome = txtNome.Text;
                    interessado.CPF = txtCpf.Text;
                    interessado.Contato = txtContato.Text;
                    interessado.Endereco = txtEndereco.Text;

                    BusCadastrarInteressado bus = new BusCadastrarInteressado();
<<<<<<< HEAD
                    bus.CadastrarInteressado(interessado);
=======

                    if (interessado.Id == null)
                    {
                        bus.CadastrarInteressado(interessado);
                    }
                    else
                    {
                        bus.AlterarInteressado(interessado);
                    }

                    this.CarregarCampos();
>>>>>>> funcionalidade_filtrar

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

<<<<<<< HEAD
        #endregion
=======
        public void CarregarCampos()
        {
            this.CarregarGridInterresado();
        }

        private void CarregarGridInterresado()
        {
            List<Interessado> lstInteressado = new List<Interessado>();
            lstInteressado = new BusCadastrarInteressado().ListarInteressados();
            gvInteressado.DataSource = lstInteressado;
            gvInteressado.DataBind();
        }

        #endregion

        protected void gvInteressado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = 0;
            switch (e.CommandName)
            {
                case "Editar":
                    id = Convert.ToInt32(e.CommandArgument);
                    Interessado interessado = new Interessado();
                    interessado = new BusCadastrarInteressado().BuscarInteressado(id);

                    txtId.Text = interessado.Id.ToString();
                    txtNome.Text = interessado.Nome;
                    txtCpf.Text = interessado.CPF;
                    txtEndereco.Text = interessado.Endereco;
                    txtContato.Text = interessado.Contato;

                    break;

                case "Excluir":
                    id = Convert.ToInt32(e.CommandArgument);
                    new BusCadastrarInteressado().DeletarInteressado(id);
                    CarregarGridInterresado();
                    break;
            }
        }
>>>>>>> funcionalidade_filtrar
    }
}