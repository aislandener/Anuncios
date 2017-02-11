<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
    var linkMenu = "restrita";
</script>
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
                Por favor, digite seu email e senha. Cadastre-se se você ainda não possui uma conta.
            </p>
            <br />
            <!--FORMULARIO-->
            <h2>
                LOGIN
            </h2>
            <hr />
  
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Informações da Conta</legend>

                    <p>
                        <asp:Label ID="lblUsuario" runat="server">Usuário:</asp:Label>
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                        <!--<asp:RequiredFieldValidator ID="UsuarioValidacao" runat="server" ControlToValidate="TxtUsuario" 
                            ErrorMessage="Usuário Obrigatório">Usuário Obrigatório.</asp:RequiredFieldValidator>-->

                    </p>
                    
                    <p>
                        <asp:Label ID="lblSenha" runat="server">Senha:</asp:Label>
                        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                        <!--<asp:RequiredFieldValidator ID="SenhaValidator" runat="server" ControlToValidate="txtSenha" 
                             ErrorMessage="Senha Obrigatória.">Senha Obrigatória</asp:RequiredFieldValidator>-->
                    </p>
                </fieldset>
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                <p class="submitButton">
                     <asp:Button ID="btnLogar" runat="server" CssClass="buttonCSS" 
                         Text="Logar" OnClick="btnLogar_Click" />
                </p>
                <p class="submitButton">
                     <asp:Button ID="btnRecuperar" runat="server" CssClass="buttonCSS" 
                         Text="Recuperar Senha" OnClick="btnRecuperar_Click"/>
                </p>
            </div>
            <!--FIM FORMULARIO-->
        </div>
    </div>
</asp:Content>