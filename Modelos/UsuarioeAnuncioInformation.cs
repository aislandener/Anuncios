using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class UsuarioeAnuncioInformation:UsuarioInformation
    {
        public int anu_id { get; set; }
        public string anu_titulo { get; set; }
        public string anu_descricao { get; set; }
        public string anu_tipo { get; set; }
        public decimal anu_preco { get; set; }
        public string anu_foto1 { get; set; }
        public string anu_foto2 { get; set; }
        public string anu_foto3 { get; set; }
        public DateTime anu_datacad { get; set; }
    }
}
