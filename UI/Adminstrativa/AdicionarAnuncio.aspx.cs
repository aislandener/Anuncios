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
    public partial class AdicionarAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string ext;
                if (FileUpload1.HasFile)
                {
                    ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                    if(ext != ".jpg" && ext != ".png")
                    {
                        throw new Exception("Extensões Válidas: JPG e PNG");
                    }
                }

                if (FileUpload2.HasFile)
                {
                    ext = System.IO.Path.GetExtension(FileUpload2.FileName);
                    if (ext != ".jpg" && ext != ".png")
                    {
                        throw new Exception("Extensões Válidas: JPG e PNG");
                    }
                }

                if (FileUpload3.HasFile)
                {
                    ext = System.IO.Path.GetExtension(FileUpload3.FileName);
                    if (ext != ".jpg" && ext != ".png")
                    {
                        throw new Exception("Extensões Válidas: JPG e PNG");
                    }
                }

                InserirAnuncio();
            }
            catch (Exception ex)
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = ex.Message;
            }
        }

        private void InserirAnuncio()
        {
            try
            {
                string[] nomeArquivo;
                string ext;
                string filename1 = "";
                string filename2 = "";
                string filename3 = "";

                if (FileUpload1.HasFile)
                {
                    //NOME DO ARQUIVO RANDOMICAMENTE
                    filename1 = System.IO.Path.GetRandomFileName();
                    filename1 = filename1.Replace(".", "");
                    ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                    filename1 += ext;

                    FileUpload1.SaveAs(Server.MapPath("~/assets/images/anuncios/") + filename1);
                    nomeArquivo = filename1.Split('.');

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename1, Server.MapPath("~/assets/images/anuncios/") + nomeArquivo[0] + "t." +nomeArquivo[1],50,40,false);

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename1, Server.MapPath("~/assets/images/anuncios/lv_") + filename1, 100, 70, false);

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename1, Server.MapPath("~/assets/images/anuncios/vitrine_") + filename1, 150, 110, false);
                }
                if (FileUpload2.HasFile)
                {
                    //NOME DO ARQUIVO RANDOMICAMENTE
                    filename2 = System.IO.Path.GetRandomFileName();
                    filename2 = filename2.Replace(".", "");
                    ext = System.IO.Path.GetExtension(FileUpload2.FileName);
                    filename2 += ext;

                    FileUpload1.SaveAs(Server.MapPath("~/assets/images/anuncios/") + filename2);
                    nomeArquivo = filename2.Split('.');

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename2, Server.MapPath("~/assets/images/anuncios/") + nomeArquivo[0] + "t." + nomeArquivo[1], 50, 40, false);

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename2, Server.MapPath("~/assets/images/anuncios/lv_") + filename2, 100, 70, false);

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename2, Server.MapPath("~/assets/images/anuncios/vitrine_") + filename2, 150, 110, false);
                }

                if (FileUpload3.HasFile)
                {
                    //NOME DO ARQUIVO RANDOMICAMENTE
                    filename3 = System.IO.Path.GetRandomFileName();
                    filename3 = filename1.Replace(".", "");
                    ext = System.IO.Path.GetExtension(FileUpload3.FileName);
                    filename3 += ext;

                    FileUpload1.SaveAs(Server.MapPath("~/assets/images/anuncios/") + filename3);
                    nomeArquivo = filename3.Split('.');

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename3, Server.MapPath("~/assets/images/anuncios/") + nomeArquivo[0] + "t." + nomeArquivo[1], 50, 40, false);

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename3, Server.MapPath("~/assets/images/anuncios/lv_") + filename3, 100, 70, false);

                    ResizeImage(Server.MapPath("~/assets/images/anuncios/") + filename3, Server.MapPath("~/assets/images/anuncios/vitrine_") + filename3, 150, 110, false);
                }

                AnuncioInformation anu = new AnuncioInformation();
                anu.anu_titulo = txtTitulo.Text;
                anu.anu_descricao = txtDescricao.Text;
                anu.anu_tipo = ddlTipo.SelectedItem.Text;
                anu.anu_preco = Convert.ToDecimal(txtPreco.Text);
                anu.anu_foto1 = filename1;
                anu.anu_foto2 = filename2;
                anu.anu_foto3 = filename3;
                anu.anu_datacad = DateTime.Now;

                AnuncioBO obj = new AnuncioBO();
                int id = obj.InserirAnuncio(anu);

                AnuncianteAnuncioInformation aai = new AnuncianteAnuncioInformation();
                aai.fk_anu_id = id;
                aai.fk_usu_id = Convert.ToInt32(Session["Perfil"]);

                AnuncianteAnuncioBO aabo = new AnuncianteAnuncioBO();
                aabo.Inserir(aai);

                lblMsg.Text = "Anuncio Publicado";

                txtTitulo.Text = "";
                txtDescricao.Text = "";
                txtPreco.Text = "";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Falha: " + ex.Message;
            }
        }

        public static void ResizeImage(string originalFile, string newFile, int newWidth, int maxHeight, bool onlyResizeIfWider)
        {
            System.Drawing.Image fullsizeImage = System.Drawing.Image.FromFile(originalFile);

            fullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            fullsizeImage.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);

            if (onlyResizeIfWider)
            {
                if(fullsizeImage.Width <= newWidth)
                {
                    newWidth = fullsizeImage.Width;
                }
            }

            int newHeight = fullsizeImage.Height * newWidth / fullsizeImage.Width;

            if(newHeight > maxHeight)
            {
                newWidth = fullsizeImage.Width * maxHeight / fullsizeImage.Height;
                newHeight = maxHeight;
            }

            System.Drawing.Image newImage = fullsizeImage.GetThumbnailImage(newWidth , newHeight, null, IntPtr.Zero);

            fullsizeImage.Dispose();

            newImage.Save(newFile);
        }
    }
}