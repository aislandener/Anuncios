using BLL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Adminstrativa
{
    public partial class MeusDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarDados();
            }
            ObterDadosGerais();
        }

        private void CarregarDados()
        {
            int id = Convert.ToInt32(Session["Perfil"]);
            UsuarioBO obj = new UsuarioBO();
            UsuarioInformation usu = obj.RetornaDados(id);

            txtUsuario.Text = usu.usu_nome;
            txtEmail.Text = usu.usu_email;
            txtTelefone.Text = usu.usu_telefone;
        }

        private UsuarioInformation ObterDadosGerais()
        {
            UsuarioInformation usu = new UsuarioInformation();
            usu.usu_id = Convert.ToInt32(Session["Perfil"]);
            usu.usu_email = txtEmail.Text;
            usu.usu_telefone = txtTelefone.Text;
            return usu;
        }

        protected void btnAlterarDados_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioInformation usu = ObterDadosGerais();
                UsuarioBO obj = new UsuarioBO();
                obj.AlterarDadosGerais(usu);

                lblMensagemDados.ForeColor = System.Drawing.Color.Green;
                lblMensagemDados.Text = "Dados Alterados";
            }
            catch (Exception)
            {
                lblMensagemDados.ForeColor = System.Drawing.Color.Red;
                lblMensagemDados.Text = "Falha na Alteração";
            }
        }

        protected void btnSenha_Click(object sender, EventArgs e)
        {
            Response.Redirect("AlterarSenha.aspx");
        }
    }
}