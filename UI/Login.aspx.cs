using BLL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            UsuarioInformation usu = new UsuarioInformation();
            usu.usu_nome = txtUsuario.Text;
            usu.usu_senha1 = txtSenha.Text;
            try
            {
                UsuarioBO obj = new UsuarioBO();
                var usuario = obj.Login(usu);
                FormsAuthentication.RedirectFromLoginPage(usu.usu_nome, false);
                Session["Perfil"] = usuario.usu_id;
            }
            catch (UsuarioouSenhaInvalidadoException)
            {
                lblMensagem.Text = "Usuario ou Senha Invalidos";
            }
            catch (Exception)
            {
                lblMensagem.Text = "Erro no sistema";
            } 
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperacaoSenha.aspx");
        }
    }
}