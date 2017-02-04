<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="UI.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Cadastro
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <div style="padding-left: 220px; padding-right: 40px;">
            <!--FORMULÁRIO-->
            <h2>
                Criar nova conta
            </h2>
            <hr />
            <span class="failureNotification">
                <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" 
                CssClass="failureNotification"  ValidationGroup="RegisterUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="register">
                    <legend>Informações da Conta</legend>

                    <p>
                        <asp:Label ID="lblUsuario" runat="server">Usuário:</asp:Label>
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UsuarioValidator" runat="server" ControlToValidate="TxtUsuario" 
                            ErrorMessage="Nome obrigatório">  Usuário obrigatório. </asp:RequiredFieldValidator>                                
                    </p>

                    <p>
                        <asp:Label ID="lblEmail" runat="server">E-mail:</asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ControlToValidate="txtEmail" 
                            ErrorMessage="E-mail obrigatório">E-mail Obrigatório</asp:RequiredFieldValidator>                                
                    </p>

                    <!--ADICIONAR TELEFONE-->
                    <p>
                        <asp:Label ID="lblTelefone" runat="server">Telefone:</asp:Label>
                        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTelefone" 
                            ErrorMessage="Telefone obrigatório">Telefone Obrigatório</asp:RequiredFieldValidator>                                
                    </p>
                    <!--FIM ADICIONAR TELEFONE-->

                    <p>
                        <asp:Label ID="lblSenha1" runat="server">Senha:</asp:Label>
                        <asp:TextBox ID="txtSenha1" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Senha1Validator" runat="server" ControlToValidate="txtSenha1" 
                            ErrorMessage="Senha obrigatória.">Senha Obrigatória</asp:RequiredFieldValidator>                                
                    </p>

                    <p>
                        <asp:Label ID="lblSenha2" runat="server">Confirmar Senha:</asp:Label>
                        <asp:TextBox ID="txtSenha2" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSenha2" 
                            ErrorMessage="Senha obrigatória.">Senha Obrigatória</asp:RequiredFieldValidator>                                
                    </p>
                </fieldset>   
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>                
                <p class="submitButton">
                    <asp:Button ID="btnSalvar" runat="server" CssClass="buttonCSS" Text="Salvar"/>
                </p>
            </div>
            <!--FIM FORMULARIO-->
        </div>
    </div>
</asp:Content>
