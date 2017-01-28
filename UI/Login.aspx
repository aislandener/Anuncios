<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Login
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <div style="padding-left: 160px; padding-right: 40px;">
            <p>                
                Por favor, digite seu email e senha. 
                <!--HYPERLINK-->
                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Cadastro.aspx" runat="server">Cadastre-se</asp:HyperLink>
                se você ainda não possui uma conta.
            </p>
            <br />
            <!--FORMULARIO-->
        <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false">
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Informações da Conta</legend>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Usuário:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="Usuário é obrigatório." ToolTip="Usuário é obrigatório." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Senha:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="Senha é obrigatória." ToolTip="Senha é obrigatória." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:CheckBox ID="RememberMe" runat="server"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Mantenha-me conectado</asp:Label>
                    </p>
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="buttonCSS" Text="Log In" ValidationGroup="LoginUserValidationGroup"/>
                </p>
                <p align="center">
                    <asp:HyperLink ID="HyperLink2" NavigateUrl="~/RecuperacaoSenha.aspx" runat="server">Esqueci minha senha</asp:HyperLink>
                </p>
            </div>
        </LayoutTemplate>
    </asp:Login>


            <!--FINAL DO FORMULARIO-->
        </div>
    </div>
</asp:Content>