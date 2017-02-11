using BLL;
using System;
using System.Linq;
using System.Web.UI;

namespace UI
{
    public partial class DetalheAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarDadosAnuncio();
        }

        private void MostrarDadosAnuncio()
        {
            if (Request.QueryString.AllKeys.Contains("ID"))
            {
                Int32 id_anuncio = Convert.ToInt32(Request.QueryString["ID"]);
                AnuncioBO obj = new AnuncioBO();
                var dados = obj.DadosGeraisAnuncio(id_anuncio);

                ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(),
                    "mensagem", "inicializaImagens(['" + dados.anu_foto1 + "','" +
                    dados.anu_foto2 + "', '" + dados.anu_foto3 + "'])", true);

                lblTitulo.Text = dados.anu_titulo;
                lblTelefone.Text = dados.usu_telefone;
                lblNome.Text = dados.usu_nome;
                lblEmail.Text = dados.usu_email;
                lblPreco.Text = dados.anu_preco.ToString();
                lblDescricao.Text = dados.anu_descricao;
                DateTime data = dados.anu_datacad;
                string dataCurta = data.ToShortDateString();
                lblDataCadastro.Text = "Anunciado em: " + dataCurta;
                lblTipo.Text = dados.anu_tipo;
            }
        }
    }
}