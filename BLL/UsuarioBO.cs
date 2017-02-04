using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBO
    {
        public void ValidaUsuario(UsuarioInformation usu)
        {
            try
            {
                if (usu.usu_senha1 != usu.usu_senha2)
                {
                    throw new Exception("Senhas não conferem");
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
