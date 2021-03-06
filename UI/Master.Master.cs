﻿using BLL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ContemSession())
            {
                ObterNome();
            }
        }

        public bool ContemSession()
        {
            return Session["Perfil"] != null;
        }

        public void ObterNome()
        {
            UsuarioBO obj = new UsuarioBO();
            int idSession = Convert.ToInt32(Session["Perfil"]);
            UsuarioInformation usu = obj.RetornaDados(idSession);
            string logout = "<a href='Default.aspx?logout=logout'>Sair</a>";
            lblUsuario.Text = "Bem-vindo, <b>" + usu.usu_nome + "</b> | " + logout;
        }
    }
}