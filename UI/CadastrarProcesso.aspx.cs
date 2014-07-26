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
                this.CarregarCampos();

                if (Request.Params["modo"] == "editar")
                {
                    int numero = Convert.ToInt32(Request.Params["idProcesso"]);
                    this.PreencherCampos(numero);
                    btnCadastrarProcesso.Text = "Alterar";
                }
            }           

        }

        #region Metodos

        private void PreencherCampos(int numero)
        {
            var processo = new BusCadastrarProcesso().RetornarProcesso(numero);
            txtNumero.Text = processo.Numero.ToString();
            ddlCategoria.SelectedIndex = ddlCategoria.Items.IndexOf(ddlCategoria.Items.FindByValue(processo.Categoria.ToString()));
            ddlInteressado.SelectedIndex = ddlInteressado.Items.IndexOf(ddlInteressado.Items.FindByValue(processo.Interessado.ToString()));
            txtDataJulgamento.Text = processo.DataJulgamento.ToString();
            txtValorAcao.Text = processo.ValorAcao.ToString();
            txtDescricao.Text = processo.Descricao;
        }

        private void CarregarCampos()
        {
            BusCadastrarProcesso busCadastrarProcesso = new BusCadastrarProcesso();
            this.LstCategoria = busCadastrarProcesso.ListarCategoria();
            this.LstInteressado = busCadastrarProcesso.ListarInteressado();
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
                    int? num = null;

                    Processo processo = new Processo();
                    processo.Numero = txtNumero.Text != string.Empty ? Convert.ToInt32(txtNumero.Text) : num;
                    processo.Categoria = Convert.ToInt32(ddlCategoria.SelectedItem.Value);
                    processo.Interessado = Convert.ToInt32(ddlInteressado.SelectedItem.Value);
                    processo.DataJulgamento = Convert.ToDateTime(txtDataJulgamento.Text);
                    processo.ValorAcao = Convert.ToInt32(txtValorAcao.Text);
                    processo.Descricao = txtDescricao.Text;

                    BusCadastrarProcesso busCadastrarProcesso = new BusCadastrarProcesso();

                    if (processo.Numero == null)
                    {
                        busCadastrarProcesso.CadastrarProcesso(processo);
                    }
                    else
                    {
                        busCadastrarProcesso.AlterarProcesso(processo);
                    }

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