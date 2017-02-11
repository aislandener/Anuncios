using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace UI
{
    public partial class Contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage oEmail = new MailMessage();
                //COLOQUE AQUI UMA CAIXA VALIDA @seudominio PARA O ENVIO SEJA REALIZADO
                MailAddress sDe = new MailAddress("Curso" + "<aspnetcursos@gmail.com>");
                MailAddress sRpt = new MailAddress("aspnetcursos@gmail.com");

                

                //DIGITE AQUI O E-MAIL PARA O QUAL SERÁ ENCAMINHADO O FORMULARIO
                oEmail.To.Add("aspnetcursos@gmail.com");
                oEmail.From = sDe;
                oEmail.ReplyTo = sRpt;
                oEmail.Priority = MailPriority.Normal;
                oEmail.IsBodyHtml = false;
                oEmail.Subject = "Mensagem do site";

                //Monta o corpo da mensagem a ser enviar
                StringBuilder mensagem = new StringBuilder();
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Nome do Contato: " + txtNome.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("E-mail do Contato: " + txtEmail.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Assunto: " + txtAssunto.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);
                mensagem.Append("Mensagem: " + txtMensagem.Text + "").Append(Environment.NewLine);
                mensagem.Append("").Append(Environment.NewLine);

                oEmail.Body = mensagem.ToString();

                Modelos.SMTP json = JsonConvert.DeserializeObject<Modelos.SMTP>(File.ReadAllText(Server.MapPath("~/assets/json/smtp.json")));

                SmtpClient enviar = new SmtpClient();
                //DIGITE AQUI O NOME DO SERVIDOR DE SMTP QUE VOCÊ IRA UTILIZAR
                enviar.Host = json.host;
                //DIGITE UM E-MAIL VÁLIDO E UMA SENHA PARA AUTENTICACAO NO SERVIDOR SMTP
                enviar.Credentials = new System.Net.NetworkCredential(json.user,json.pass);
                enviar.Port = json.port;
                enviar.EnableSsl = json.useSSL;
                enviar.Send(oEmail);
                oEmail.Dispose();

                txtNome.Text = "";
                txtEmail.Text = "";
                txtAssunto.Text = "";
                txtMensagem.Text = "";

                lblResposta.Text = "O e-mail foi enviado com sucesso";
                lblResposta.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblResposta.Text = "Houve uma falha no envio do e-mail: " + ex.Message;
                //throw;
            }

        }
    }
}