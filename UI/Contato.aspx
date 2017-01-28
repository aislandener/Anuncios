<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="UI.Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var linkMenu = "contato";
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>Contato
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <div style="padding-left: 40px; padding-right: 40px;">
            <table width="550px" cellspacing="20">
                <tr>
                    <td align="right">Nome:
                    </td>
                    <td>
                        <asp:TextBox ID="txtNome" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">Email:
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">Assunto:
                    </td>
                    <td>
                        <asp:TextBox ID="txtAssunto" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">Mensagem:
                    </td>
                    <td>
                        <asp:TextBox ID="txtMensagem" runat="server" TextMode="MultiLine" Height="150px" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right">
                        <asp:Button ID="btnEnviar" CssClass="buttonCSS" runat="server" Text="Enviar"
                            OnClick="btnEnviar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="right">
                        <asp:Label ID="lblResposta" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
