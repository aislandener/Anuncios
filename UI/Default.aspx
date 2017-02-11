<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<div class="conteudo">
    <table width="100%" cellpadding="0px" cellspacing="0px">
        <tr>
            <td>
                <asp:Image ID="Image1" ImageUrl="~/assets/images/banner.jpg" runat="server" />
            </td>
        </tr>
    </table>
    <table width="100%" style="background-color: #cfcfcf;" border="0">
        <tr height="80px">
            <td width="450px" style="padding-left: 10px">
                <asp:TextBox ID="txtBusca" CssClass="unwatermarked" runat="server"></asp:TextBox>
                <ajaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1"  WatermarkText="Digite o produto, marca ou modelo" WatermarkCssClass="watermarked" TargetControlID="txtBusca" runat="server" />
            </td>
            <td width="100px">
                <asp:Button ID="btnPesquisa" CssClass="buttonCSS"  runat="server" Text="Buscar" />
            </td>
            <td align="right" style="padding-right: 15px;">
                <asp:LinkButton ID="lnkAnunciar" CssClass="bigButtonCSS" PostBackUrl="~/Cadastro.aspx" runat="server">Anunciar Grátis</asp:LinkButton>
            </td>
        </tr>
    </table>
    <!--DATALIST-->
<br />
<div align="center">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
    <tr valign="top">
        <td>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" 
            CellPadding="3" CellSpacing="0">
            <ItemTemplate>
                <table width="250px" border="0" style="padding-left: 25px; 
                    padding-right: 25px;" cellpadding="6">
                    <tr height="120px">
                    <td align="center">
                        <!--IMAGEM-->
                        <asp:Image ID="Image2" runat="server" 
                        ImageUrl='<%# "~/assets/images/anuncios/vitrine_" + 
                        DataBinder.Eval(Container.DataItem, "anu_foto1") %>' />
                    </td>
                    </tr>
                    <tr height="90px" valign="top">
                    <td>
                        <!--TITULO-->
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl='<%# "~/DetalheAnuncio.aspx?ID=" +Eval("anu_id") %>'
                            class="text11"><%# Eval("anu_titulo") %></asp:HyperLink>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <!--Preço-->
                        <span class="text8">Preço:</span><span class="text10">R$ 
                            <%# Eval("anu_preco") %></span>   
                    </td>
                    </tr>
                    <tr>
                    <td>
                    </td>
                    </tr>
                </table>
            </ItemTemplate>
            <HeaderTemplate>
                <div style="padding-left: 27px;">
                    <span class="text9">Anúncios Recentes</span></div>
                    <br />
            </HeaderTemplate>   
        </asp:DataList>
        </td>
    </tr>
</table>
</div>
    <!--FIM DATALIST-->
</div>
</asp:Content>