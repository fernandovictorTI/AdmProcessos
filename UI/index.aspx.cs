using Business;
using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAdmProcessos
{
    public partial class index : System.Web.UI.Page
    {
        public object LstCategoria { get; set; }

        public Hashtable ht { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ht = new Hashtable();
                this.CarregarCampos();
            }
        }

        private void CarregarCampos()
        {
            this.CarregarGridProcesso(ht);            
            this.LstCategoria = new BusCadastrarProcesso().ListarCategoria();
            this.ListarCategoria();
        }

        private void CarregarGridProcesso(Hashtable ht)
        {
            gvProcesso.DataSource = new BusCadastrarProcesso().ListarProcessos(ht);
            gvProcesso.DataBind();
        }

        private void ListarCategoria()
        {
            ddlCategoria.DataSource = LstCategoria;
            ddlCategoria.DataValueField = "Id";
            ddlCategoria.DataTextField = "Descricao";
            ddlCategoria.DataBind();
        }

        protected void gvProcesso_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int numeroProcesso = 0;
                switch (e.CommandName)
                {
                    
                    case "Editar":
                        numeroProcesso = Convert.ToInt32(e.CommandArgument);
                        Response.Redirect("CadastrarProcesso.aspx?modo=editar&idProcesso="+numeroProcesso);
                        break;

                    case "Excluir":
                        numeroProcesso = Convert.ToInt32(e.CommandArgument);
                        new BusCadastrarProcesso().DeletarProcesso(numeroProcesso);
                        this.CarregarGridProcesso(ht);
                        break;

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                ht = new Hashtable();
                int categoria = Convert.ToInt32(ddlCategoria.SelectedItem.Value);
                ht.Add("CATEGORIA",categoria);
                CarregarCampos();
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}