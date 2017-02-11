using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AnuncioBO
    {
        public int InserirAnuncio(AnuncioInformation anu)
        {
            AnuncioDAO obj = new AnuncioDAO();
            int id = obj.InserirAnuncio(anu);
            return id;
        }

        public SqlDataReader RetornaAnuncioVitrine()
        {
            AnuncioDAO obj = new AnuncioDAO();
            return obj.RetornaAnunciosVitrine();
        }

        public UsuarioeAnuncioInformation DadosGeraisAnuncio(int id_anuncio)
        {
            AnuncioDAO obj = new AnuncioDAO();
            var dados = obj.DadosGeraisAnuncio(id_anuncio);
            return dados;
        }

        public AnuncioInformation RetornaDadosAnuncio(int id_anuncio)
        {
            AnuncioDAO obj = new AnuncioDAO();
            var dados = obj.RetornaDadosAnuncio(id_anuncio);
            return dados;
        }

        public void AlterarAnuncio(AnuncioInformation anu)
        {
            AnuncioDAO obj = new AnuncioDAO();
            obj.AlterarAnuncio(anu);
        }
    }
}
