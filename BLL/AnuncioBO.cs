using DAL;
using Modelos;
using System;
using System.Collections.Generic;
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
    }
}
