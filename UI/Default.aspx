<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- ScriptManager AjaxExtensions -->
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="conteudo">
        <table width="100%" cellpadding="0px" cellspacing="0px">
            <tr>
                <td>
                    <!-- IMAGE -->
                    <asp:Image ID="Image1" ImageUrl="~/assets/images/banner.jpg" runat="server" />
                </td>
            </tr>
        </table>
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td width="450px" style="padding-left: 10px">
                    <asp:TextBox ID="txtBusca" CssClass="unwatermarked" runat="server"></asp:TextBox>
                    <ajaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" WatermarkText="Faça sua busca" WatermarkCssClass="watermarked" TargetControlID="txtBusca" runat="server" />
                </td>
                <td width="100px">
                    <asp:Button ID="btnPesquisa" CssClass="buttonCSS" runat="server" Text="Pesquisar" />
                </td>
                <td width="right" style="padding-right: 15px">
                    <asp:LinkButton ID="lnkAnunciar" CssClass="bigButtonCSS" PostBackUrl="~/Cadastro.aspx" runat="server">Anuciar Gratis</asp:LinkButton>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
