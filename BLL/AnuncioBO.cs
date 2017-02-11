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
    }
}
