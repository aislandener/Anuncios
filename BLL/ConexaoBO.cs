using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConexaoBO
    {
        public void Desconectar()
        {
            Conexao con = new Conexao();
            con.DesconectarDataBind();
        }
    }
}
