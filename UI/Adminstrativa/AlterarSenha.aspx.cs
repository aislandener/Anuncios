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
    public partial class AlterarSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ObterDadosTela();
        }

        private UsuarioInformation ObterDadosTela()
        {
            UsuarioInformation usu = new UsuarioInformation();
            usu.usu_id = Convert.ToInt32(Session["Perfil"]);
            usu.usu_senha1 = txtSenha.Text; //senha Atual
            usu.usu_senha2 = txtSenha1.Text; //senha Nova
            return usu;

        }

        protected void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    UsuarioInformation usu = ObterDadosTela();
                    UsuarioBO obj = new UsuarioBO();
                    int qtd = obj.ConfereSenha(usu);

                    if (qtd > 0)
                    {
                        obj.AlterarSenha(usu);
                    }
                    else
                    {
                        txtSenha.Text = "";
                        throw new Exception("Senha Atual não confere");
                    }

                    lblMensagemSenha.ForeColor = System.Drawing.Color.Green;
                    lblMensagemSenha.Text = "Senha Alterada";
                }
                else
                {
                    txtSenha1.Text = "";
                    txtSenha2.Text = "";
                    throw new Exception("Confirme novamente a nova senha");
                }
            }
            catch (Exception ex)
            {
                lblMensagemSenha.ForeColor = System.Drawing.Color.Red;
                lblMensagemSenha.Text = ex.Message;
            }
        }
    }
}