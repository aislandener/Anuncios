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
    public partial class EditarAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregaDados();
            }
            ObterDadosGerais();

        }

        private void CarregaDados()
        {
            if (Request.QueryString.AllKeys.Contains("ID"))
            {
                int id_anuncio = Convert.ToInt32(Request.QueryString["ID"]);
                AnuncioBO obj = new AnuncioBO();
                AnuncioInformation anu = obj.RetornaDadosAnuncio(id_anuncio);
                txtTitulo.Text = anu.anu_titulo;
                txtDescricao.Text = anu.anu_descricao;
                if (anu.anu_tipo == "Novo")
                {
                    ddlTipo.SelectedIndex = 0;
                }
                else
                {
                    ddlTipo.SelectedIndex = 1;
                }
                txtPreco.Text = anu.anu_preco.ToString();
            }
        }

        private AnuncioInformation ObterDadosGerais()
        {
            if (Request.QueryString.AllKeys.Contains("ID"))
            {
                AnuncioInformation anu = new AnuncioInformation();
                anu.anu_id = Convert.ToInt32(Request.QueryString["ID"]);
                anu.anu_titulo = txtTitulo.Text;
                anu.anu_descricao = txtDescricao.Text;
                anu.anu_tipo = ddlTipo.SelectedItem.Text;
                anu.anu_preco = Convert.ToDecimal(txtPreco.Text);

                return anu;
            }
            else
            {
                return null;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                AnuncioInformation anu = ObterDadosGerais();

                AnuncioBO obj = new AnuncioBO();
                obj.AlterarAnuncio(anu);

                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = "Dados alterados no anuncio";
            }catch(Exception ex)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "Erro na atualização: " + ex.Message;
            }
        }
    }
}