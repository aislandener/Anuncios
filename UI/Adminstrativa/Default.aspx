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
    <!--LISTVIEW-->
        <!--COPIE A LIST VIEW DO BUSCARANUNCIO.ASPX-->
        <!--FICAMOS ASSIM COM POUCOS AJUSTES-->
    <br />
    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2">
        <LayoutTemplate>
            <table width="100%" id="tableListView" runat="server" 
                style="padding: 0px; margin: 0px" border="0" cellpadding="0" 
                cellspacing="0">
                <tr id="Tr1" runat="server" style="background-color: #0fb7d1; 
                color: White; font-weight: bold;" align="center">
                <td style="border: 1px solid white;">
                    <!--será colocado um botão-->
                </td>
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
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="smallButtonCSS"
                    PostBackUrl='<%# "~/Administrativa/EditarAnuncio.aspx?ID="+ Eval("anu_id") %>'> 
                    Editar</asp:LinkButton>
            </td>
            <td style="padding-top: 3px; padding-bottom: 3px;" align="center">
                <!--IMAGEM-->
                <asp:Image ID="Image1" ImageUrl='<%# "~/assets/images/anuncios/lv_" + 
                        Eval("anu_foto1") %>' runat="server" />
            </td>
            <td style="padding-left: 30px;">
                <b><!--TITULO-->
                    <strong><%# Eval("anu_titulo") %></strong> 
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
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="smallButtonCSS"
                    PostBackUrl='<%# "~/Administrativa/EditarAnuncio.aspx?ID="+ Eval("anu_id") %>'> 
                    Editar</asp:LinkButton>
            </td>
            <td style="padding-top: 3px; padding-bottom: 3px;" align="center">
                <!--IMAGEM-->
                <asp:Image ID="Image1" ImageUrl='<%# "~/assets/images/anuncios/lv_" + 
                        Eval("anu_foto1") %>' runat="server" />
            </td>
            <td style="padding-left: 30px;">
                <b><!--TITULO-->
                    <strong><%# Eval("anu_titulo") %></strong> 
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
    
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:anuncios %>" SelectCommand="BuscarDadosAdm" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtBusca" Name="texto" PropertyName="Text" Type="String" />
                <asp:SessionParameter Name="userID" SessionField="Perfil" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:anuncios %>" SelectCommand="BuscarDadosAdm" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtBusca" DefaultValue="listarTodos" Name="texto" PropertyName="Text" Type="String" />
                <asp:SessionParameter DefaultValue="" Name="userID" SessionField="Perfil" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>

    <!--FIM LISTVIEW-->

    </div>
</asp:Content>
