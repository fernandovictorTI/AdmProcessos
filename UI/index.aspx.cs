using Business;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAdmProcessos
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CarregarCampos();
        }

        private void CarregarCampos()
        {
            this.CarregarGridProcesso();
        }

        private void CarregarGridProcesso()
        {
            gvProcesso.DataSource = new BusCadastrarProcesso().ListarProcessos();
            gvProcesso.DataBind();
        }
    }
}