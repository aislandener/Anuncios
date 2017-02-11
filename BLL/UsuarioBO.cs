using DAL;
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
            catch (Exception ex)
            {
                throw;
            }
        }

        public void InserirUsuario(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            obj.InserirUsuario(usu);
        }

        public int RetornaID(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            return obj.RetornaID(usu);
        }

        public int UsuarioExiste(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            int id = obj.UsuarioExiste(usu);
            return id;
        }

        public UsuarioInformation Login(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            var login = obj.Login(usu);

            if (login == null)
            {
                throw new UsuarioouSenhaInvalidadoException();
            }
            else
            {
                return login;
            }
        }

        public void AlterarSenha(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            obj.AlterarSenha(usu);
        }

        public int ConfereSenha(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            return obj.ConfereSenha(usu);
        }

        public UsuarioInformation RetornaDados(int id)
        {
            UsuarioDAO obj = new UsuarioDAO();
            return obj.RetornaDados(id);
        }

        public void AlterarDadosGerais(UsuarioInformation usu)
        {
            UsuarioDAO obj = new UsuarioDAO();
            obj.AlterarDadosGerais(usu);
        }
    }
}
