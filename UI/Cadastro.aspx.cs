using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CapturaDados();
        }

        private UsuarioInformation CapturaDados()
        {
            var usu = new UsuarioInformation();
            usu.usu_nome = txtUsuario.Text;
            usu.usu_email = txtEmail.Text;
            usu.usu_senha1 = txtSenha1.Text;
            usu.usu_senha2 = txtSenha2.Text;

            return usu;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioInformation usu = CapturaDados();

                UsuarioBO obj = new UsuarioBO();
                obj.ValidaUsuario(usu);

                obj.InserirUsuario(usu);

                txtEmail.Text = "";
                txtUsuario.Text = "";
                txtSenha1.Text = "";
                txtSenha2.Text = "";


                //Capturar id do usuario
                int id = obj.RetornaID(usu);
                Response.Redirect("~/Adminstrativa/Default.apsx?id=" + id, false);
            }
            catch (Exception)
            {
                lblMensagem.ForeColor = System.Drawing.Color.Red;
                lblMensagem.Text = "Senhas não conferem"
            }
        }
    }
}