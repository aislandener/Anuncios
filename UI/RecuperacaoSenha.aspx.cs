using BLL;
using Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class RecuperacaoSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            UsuarioInformation usu = new UsuarioInformation();
            usu.usu_nome = txtUsuario.Text;
            usu.usu_email = txtEmail.Text;
            try
            {
                UsuarioBO obj = new UsuarioBO();
                usu.usu_id = obj.UsuarioExiste(usu);

                if (usu.usu_id > 0)
                {
                    EnviarEmail(usu);
                }
                else
                {
                    throw new Exception("Usuario não localizado no sistema");
                }
                FormsAuthentication.RedirectFromLoginPage(usu.usu_nome, false);
                lblResposta.ForeColor = System.Drawing.Color.Green;
                lblResposta.Text = "Foi enviada nova senha para seu E-mail";
            }
            catch (Exception ex)
            {
                lblResposta.ForeColor = System.Drawing.Color.Red;
                lblResposta.Text = ex.Message;
            }
        }

        private void EnviarEmail(UsuarioInformation usu)
        {
            usu.usu_senha2 = System.IO.Path.GetRandomFileName();
            usu.usu_senha2 = usu.usu_senha2.Replace(".", "");

            UsuarioBO obj = new UsuarioBO();
            obj.AlterarSenha(usu);

            try
            {
                MailMessage oEmail = new MailMessage();
                //COLOQUE AQUI UMA CAIXA VALIDA @seudominio PARA O ENVIO SEJA REALIZADO
                MailAddress sDe = new MailAddress("Curso" + "<aspnetcursos@gmail.com>");
                MailAddress sRpt = new MailAddress("aspnetcursos@gmail.com");



                //DIGITE AQUI O E-MAIL PARA O QUAL SERÁ ENCAMINHADO O FORMULARIO
                oEmail.To.Add(usu.usu_email);
                oEmail.From = sDe;
                oEmail.Priority = MailPriority.Normal;
                oEmail.IsBodyHtml = false;
                oEmail.Subject = "Nova Senha";

                //Monta o corpo da mensagem a ser enviar
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Nome do Contato: " + usu.usu_nome + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("E-mail do Contato: " + usu.usu_email + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Assunto: " + usu.usu_senha2 + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);

                oEmail.Body = mensagem.ToString();

                Modelos.SMTP json = JsonConvert.DeserializeObject<Modelos.SMTP>(File.ReadAllText(Server.MapPath("~/assets/json/smtp.json")));

                SmtpClient enviar = new SmtpClient();
                //DIGITE AQUI O NOME DO SERVIDOR DE SMTP QUE VOCÊ IRA UTILIZAR
                enviar.Host = json.host;
                //DIGITE UM E-MAIL VÁLIDO E UMA SENHA PARA AUTENTICACAO NO SERVIDOR SMTP
                enviar.Credentials = new System.Net.NetworkCredential(json.user, json.pass);
                enviar.Port = json.port;
                enviar.EnableSsl = json.useSSL;
                enviar.Send(oEmail);
                oEmail.Dispose();

                lblResposta.Text = "O e-mail com a nova senha foi enviado com sucesso";
            }
            catch (Exception)
            {

                lblResposta.Text = "Houve uma falha no envio do e-mail";
                throw;
            }
        }
    }
}