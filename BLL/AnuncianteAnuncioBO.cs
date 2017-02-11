using Modelos;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AnuncianteAnuncioBO
    {
        public void Inserir(AnuncianteAnuncioInformation aai)
        {
            AnuncianteAnuncioDAO obj = new AnuncianteAnuncioDAO();
            obj.Inserir(aai);
        }
    }
}
