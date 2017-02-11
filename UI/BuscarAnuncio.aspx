<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="BuscarAnuncio.aspx.cs" Inherits="UI.BuscaAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
    var linkMenu = "buscarAnuncio";
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<div class="conteudo">
    <table width="100%" style="background-color: #cfcfcf;" border="0">
        <tr height="80px">
            <td width="450px" style="padding-left: 10px">
                <asp:TextBox ID="txtBusca" CssClass="unwatermarked" runat="server"></asp:TextBox>
                <ajaxToolkit:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1"  WatermarkText="Digite o produto, marca ou modelo" WatermarkCssClass="watermarked" TargetControlID="txtBusca" runat="server" />
            </td>
            <td width="100px">
                <asp:Button ID="btnPesquisa" CssClass="buttonCSS"  runat="server" Text="Buscar" OnClick="btnPesquisa_Click" />
            </td>
            <td align="right" style="padding-right: 15px;">
                <asp:LinkButton ID="lnkAnunciar" CssClass="bigButtonCSS" PostBackUrl="~/Cadastro.aspx" runat="server">Anunciar Grátis</asp:LinkButton>
            </td>
        </tr>
    </table>
    <!--LISTVIEW-->
    <br />
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2">
        <LayoutTemplate>
            <table width="100%" id="tableListView" runat="server" 
                style="padding: 0px; margin: 0px" border="0" cellpadding="0" 
                cellspacing="0">
                <tr id="Tr1" runat="server" style="background-color: #0fb7d1; 
                color: White; font-weight: bold;" align="center">
                <td width="100px" style="padding-top: 7px; padding-bottom: 7px; 
                border: 1px solid white;">
                    Foto
                </td>
                <td style="border: 1px solid white;">
                    Anuncio
                </td>
                <td style="border: 1px solid white;">
                    Tipo
                </td>
                <td style="border: 1px solid white;">
                    Preço (R$)
                </td>
                </tr>
                <tr id="itemPlaceholder" runat="server">
                </tr>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr style="background-color: #ffffff; padding-top: 15px;">
            <td style="padding-top: 3px; padding-bottom: 3px;" align="center">
                <!--IMAGEM-->
                <asp:Image ID="Image1" ImageUrl='<%# "~/assets/images/anuncios/lv_" + 
                        Eval("anu_foto1") %>' runat="server" />
            </td>
            <td style="padding-left: 30px;">
                <b><!--TITULO-->
                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/DetalheAnuncio.aspx?ID=" 
                            + Eval("anu_id") %>' runat="server"><%# Eval("anu_titulo") %>
                    </asp:HyperLink>
                </b>

            </td>
            <td>
                <!--TIPO-->
                <%# Eval("anu_tipo") %>
            </td>
            <td style="padding-left: 10px;">
            <!--PRECO-->
                <span class="text10"><%# Eval("anu_preco") %></span>
            </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: #ededed; padding-top: 15px;">
            <td style="padding-top: 3px; padding-bottom: 3px;" align="center">
                <!--IMAGEM-->
                <asp:Image ID="Image1" ImageUrl='<%# "~/assets/images/anuncios/lv_" + 
                        Eval("anu_foto1") %>' runat="server" />
            </td>
            <td style="padding-left: 30px;">
                <b><!--TITULO-->
                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/DetalheAnuncio.aspx?ID=" 
                            + Eval("anu_id") %>' runat="server"><%# Eval("anu_titulo") %>
                    </asp:HyperLink>
                </b>
            </td>
            <td>
                <!--TIPO-->
                <%# Eval("anu_tipo") %>
            </td>
            <td style="padding-left: 10px;">
            <!--PRECO-->
                <span class="text10"><%# Eval("anu_preco") %></span>
            </td>
            </tr>
        </AlternatingItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:anuncios %>" SelectCommand="BuscarDados" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtBusca" Name="texto" PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <!--FIM LISTVIEW-->
    <!--DATAPAGER-->
    <div align="right">
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
            <asp:NumericPagerField />
            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
        </Fields>
    </asp:DataPager>
    </div>
    <!--FIM DATAPAGER-->
    <!--CONTADOR-->
        <div align="right">
            <asp:Label ID="lblContador" CssClass="text8" runat="server"></asp:Label>
        </div>
    <!--FIM CONTADOR-->
</div>
</asp:Content>