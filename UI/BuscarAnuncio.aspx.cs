using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class BuscaAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var testes = Session["texto"];
                if(Session["texto"] != null && Session["texto"] != "")
                {
                    txtBusca.Text = Session["texto"].ToString();
                    ListView1.DataBind();
                }
            }

        }

        protected void btnPesquisa_Click(object sender, EventArgs e)
        {
            txtBusca.Text = Session["texto"].ToString();
            ListView1.DataBind();

            if(txtBusca.Text != "")
            {
                lblContador.Text = "Encontrados " + DataPager1.TotalRowCount.ToString() + " anuncio(s)";
            }
        }
    }
}