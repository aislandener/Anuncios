using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Deslogar();

            //RetornaAnunciosVitrine();
        }

        /*private void RetornaAnunciosVitrine()
        {
            AnuncioBO obj = new AnuncioBO();
            DataList1.DataSource = obj.RetornaAnunciosVitrine();
            DataList1.DataBind();

            ConexaoBO con = new ConexaoBO();
            con.Desconectar();
        }*/

        private void Deslogar()
        {
            if (String.IsNullOrEmpty(Page.Request.QueryString["logout"]))
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
                Session["Perfil"] = null;
            }
        }
    }
}