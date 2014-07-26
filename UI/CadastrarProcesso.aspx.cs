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
    public partial class CadastrarProcesso : System.Web.UI.Page
    {
        #region Propriedades

        public List<Categoria> LstCategoria { get; set; }
        public List<Interessado> LstInteressado { get; set; }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.PreencherCampos();
                this.CarregarCampos();
            }

        }

        #region Metodos

        private void PreencherCampos()
        {
            BusCadastrarProcesso busCadastrarProcesso = new BusCadastrarProcesso();
            this.LstCategoria = busCadastrarProcesso.ListarCategoria();
            this.LstInteressado = busCadastrarProcesso.ListarInteressado();
        }

        private void CarregarCampos()
        {
            this.ListarCategoria();
            this.ListarInteressado();
        }

        private void ListarInteressado()
        {
            ddlInteressado.DataSource = LstInteressado;
            ddlInteressado.DataValueField = "Id";
            ddlInteressado.DataTextField = "Nome";
            ddlInteressado.DataBind();
        }

        private void ListarCategoria()
        {
            ddlCategoria.DataSource = LstCategoria;
            ddlCategoria.DataValueField = "Id";
            ddlCategoria.DataTextField = "Descricao";
            ddlCategoria.DataBind();
        }

        #endregion

        #region Evento

        protected void btnCadastrarProcesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidarCampos() == 0)
                {
                    Processo processo = new Processo();
                    processo.Numero = Convert.ToInt32(txtNumero.Text);
                    processo.Categoria = Convert.ToInt32(ddlCategoria.SelectedItem.Value);
                    processo.Interessado = Convert.ToInt32(ddlInteressado.SelectedItem.Value);
                    processo.DataJulgamento = Convert.ToDateTime(txtDataJulgamento.Text);
                    processo.ValorAcao = Convert.ToInt32(txtValorAcao.Text);
                    processo.Descricao = txtDescricao.Text;

                    BusCadastrarProcesso busCadastrarProcesso = new BusCadastrarProcesso();
                    busCadastrarProcesso.CadastrarProcesso(processo);

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

        private int ValidarCampos()
        {
            int contErro = 0;

            if (ddlCategoria.SelectedIndex == 0)
            {
                contErro++;
            }

            if (ddlInteressado.SelectedIndex == 0)
            {
                contErro++;
            }

            if (txtValorAcao.Text == string.Empty)
            {
                contErro++;
            }

            return contErro;

        }

        #endregion
    }
}