<%@ Page Title="" Language="C#" MasterPageFile="~/Adminstrativa/Adminstrativa.Master" AutoEventWireup="true" CodeBehind="EditarAnuncio.aspx.cs" Inherits="UI.Adminstrativa.EditarAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Alterar Anúncio
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
                        <asp:TextBox ID="txtTitulo" runat="server" 
                            Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Descrição:
                    </td>
                    <td>
                    <asp:TextBox ID="txtDescricao" TextMode="MultiLine" 
                        runat="server" Width="450px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Preço:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPreco" Width="100px" 
                            runat="server"></asp:TextBox>
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
                    <td colspan="2" align="center">
                        <asp:Button ID="btnSalvar" CssClass="buttonCSS"  
                            runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
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
