<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstrativa/Adminstrativa.Master" AutoEventWireup="true" CodeBehind="MeusDados.aspx.cs" Inherits="UI.Adminstrativa.MeusDados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    var linkMenu = "meusDados";
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
        <tr height="80px">
            <td style="padding-left: 10px; color: #006cac;">
                <h1>
                    Meus Dados
                </h1>
            </td>
        </tr>
        </table>
        <br />
        <br />
        <br />
        <div style="padding-left: 40px; padding-right: 40px;">

            <!--FORMULARIO-->

            <h2>
                Alterar Dados da Conta
            </h2>
            <hr />
            <span class="failureNotification">
                <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" 
                CssClass="failureNotification"  ValidationGroup="RegisterUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="register">
                    <legend>Dados Gerais</legend>

                    <p>
                        <asp:Label ID="lblUsuario" runat="server">Usuário:</asp:Label>
                        <asp:TextBox ID="txtUsuario" runat="server" Enabled="False"></asp:TextBox>                              
                    </p>

                    <p>
                        <asp:Label ID="lblEmail" runat="server">E-mail:</asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ControlToValidate="txtEmail" 
                            ErrorMessage="E-mail obrigatório">E-mail Obrigatório</asp:RequiredFieldValidator>                                
                    </p>

                    <!--Adicionar Telefone-->
                    <p>
                        <asp:Label ID="lblTelefone" runat="server">Telefone:</asp:Label>
                        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTelefone" 
                            ErrorMessage="E-mail obrigatório">Telefone Obrigatório</asp:RequiredFieldValidator>                                
                    </p>
                    <!--FIM TELEFONE-->

                    <asp:Label ID="lblMensagemDados" runat="server" Text=""></asp:Label> 

                    <p class="submitButton">
                        <asp:Button ID="btnAlterarDados" runat="server" CssClass="buttonCSS" 
                            Text="Alterar Dados" OnClick="btnAlterarDados_Click" />
                    </p>                    
                </fieldset> 
                
                <p class="submitButton">
                    <asp:Button ID="btnSenha" runat="server" CssClass="buttonCSS" 
                    Text="Minha Senha" OnClick="btnSenha_Click"/>
                </p>                            
            </div>
            <!--FIM FORMULARIO-->
        </div>
    </div>
</asp:Content>