<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstrativa/Adminstrativa.Master" AutoEventWireup="true" CodeBehind="AlterarSenha.aspx.cs" Inherits="UI.Adminstrativa.AlterarSenha" %>
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
                Alterar de Senha
            </h2>
            <hr />
            <span class="failureNotification">
                <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" 
                CssClass="failureNotification"  ValidationGroup="RegisterUserValidationGroup"/>
            <div class="accountInfo">               
                <fieldset class="register">
                    <legend>Alteração de Senha</legend>
                    <p>
                        <asp:Label ID="Label1" runat="server">Senha Atual:</asp:Label>
                        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtSenha" ErrorMessage="Senha obrigatória.">
                            Senha Obrigatória</asp:RequiredFieldValidator>                                
                    </p>

                    <p>
                        <asp:Label ID="lblSenha1" runat="server">Nova Senha:</asp:Label>
                        <asp:TextBox ID="txtSenha1" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Senha1Validator" runat="server" 
                            ControlToValidate="txtSenha1" ErrorMessage="Senha obrigatória.">
                            Senha Obrigatória</asp:RequiredFieldValidator>                                
                    </p>

                    <p>
                        <asp:Label ID="lblSenha2" runat="server">Confirmar Senha:</asp:Label>
                        <asp:TextBox ID="txtSenha2" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtSenha2" ErrorMessage="Senha obrigatória.">
                            Senha Obrigatória</asp:RequiredFieldValidator>                                
                    </p>

                    <asp:Label ID="lblMensagemSenha" runat="server" Text=""></asp:Label> 

                    <p class="submitButton">
                        <asp:Button ID="btnAlterarSenha" runat="server" CssClass="buttonCSS" Text="Alterar Senha" OnClick="btnAlterarSenha_Click"/>
                    </p>

                </fieldset>                          
            </div>
            <!--FIM FORMULARIO-->
        </div>
    </div>
</asp:Content>    
