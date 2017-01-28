<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstrativa/Adminstrativa.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Adminstrativa.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    var linkMenu = "buscarMeusAnuncios";
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr>
                <td colspan="2" style="padding-left: 40px; color: #006cac; padding-top: 15px; padding-bottom: 8px;">
                    <h1>
                        Meus Anúncios</h1>
                </td>
            </tr>
            <tr height="50px">
                <td width="600px" style="padding-left: 10px" align="right">
                 <asp:TextBox ID="txtBusca" CssClass="unwatermarked" runat="server"></asp:TextBox>
                </td>
                <td>
                  <asp:Button ID="btnPesquisa" CssClass="buttonCSS"  runat="server" Text="Button" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>