<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstrativa/Adminstrativa.Master" AutoEventWireup="true" CodeBehind="AdicionarAnuncio.aspx.cs" Inherits="UI.Adminstrativa.AdicionarAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    var linkMenu = "adicionarAnuncio";
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Adicionar Anúncio
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <div style="padding-left: 210px; padding-right: 40px;">
            <table width="550px" cellspacing="20">
                <tr>
                    <td align="right">
                        Título:
                    </td>
                    <td>
                        <asp:TextBox ID="txtTitulo" runat="server" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Descrição:
                    </td>
                    <td>
                    <asp:TextBox ID="txtDescricao" TextMode="MultiLine" runat="server" Width="450px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Preço:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPreco" Width="100px" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Tipo:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server">
                            <asp:ListItem Value="1">Novo</asp:ListItem>
                            <asp:ListItem Value="2">Usado</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Foto 1:
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Foto 2:
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Foto 3:
                    </td>
                    <td>
                        <asp:FileUpload ID="FileUpload3" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <b>* Ao ser adicionado, o anúncio será automaticamente publicado.</b>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAdicionar" CssClass="buttonCSS"  runat="server" Text="Adicionar" OnClick="btnAdicionar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="lblMsg" runat="server" ></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
