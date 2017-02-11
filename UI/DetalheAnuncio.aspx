<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetalheAnuncio.aspx.cs" Inherits="UI.DetalheAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="assets/css/slideshow.css" />
    <style type="text/css">
        .slideshow
        {
            float: left;
            margin: 50px;
        }
    </style>
    <script type="text/javascript" src="assets/js/mootools-1.3.2-core.js"></script>
    <script type="text/javascript" src="assets/js/mootools-1.3.2.1-more.js"></script>
    <script type="text/javascript" src="assets/js/slideshow.js"></script>
    <script type="text/javascript" src="assets/js/slideshow.push.js"></script>
    <script type="text/javascript">
    function inicializaImagens(param) {
        window.addEvent('domready', function () {
        var data = param;
        new Slideshow.Push('push', data, {
            height: 300, hu: 'assets/images/anuncios',
            transition: 'back:in:out', width: 400
        });
        });
    }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Detalhes do Anúncio
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <div style="padding-left: 40px;">
            <br />
            <div style="padding-left: 50px;">
                <h1>
                    <!--TITULO-->
                    <asp:Label ID="lblTitulo" runat="server" Text="Label"></asp:Label> </h1>
            </div>
            <table width="100%" border="0">
                <tr>
                    <td width="600px" align="center" style="padding-left: 50px;">
                        <!--SLIDES-->
                        <div id="push" class="slideshow">
                        </div>
                    </td>
                    <td width="360px">
                        <table width="300px" border="0" style="background-color: #fdeace">
                            <tr height="30px">
                                <td colspan="3">
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="3">
                                    <span class="text1">Contactar o anunciante</span>
                                </td>
                            </tr>
                            <tr height="12px">
                                <td colspan="3">
                                </td>
                            </tr>
                            <tr>
                                <td width="30px">
                                </td>
                                <td align="center">
                                    <span class="text3">
                                        <!--NOME-->
                                        <asp:Label ID="lblNome" runat="server"></asp:Label></span>
                                </td>
                                <td width="30px">
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td align="center">
                                    <table>
                                        <tr>
                                            <td>
                                                <!--IMAGEM-->
                                                <asp:Image ID="Image1" ImageUrl="~/images/phone_icon.png" 
                                                    runat="server" />
                                            </td>
                                            <td>
                                                <span class="text2">
                                                    <!--(11) 1111-1111-->
                                                    <asp:Label ID="lblTelefone" runat="server"></asp:Label>
                                                </span>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td align="center">
                                    <table>
                                        <tr>
                                            <td>
                                                <!--IMAGEM-->
                                                <asp:Image ID="Image2" ImageUrl="~/images/email_icon.png" 
                                                    runat="server" />
                                            </td>
                                            <td style="padding-left: 7px;">
                                                <span class="text2">
                                                    <!--EMAIL-->
                                                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                                                </span>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr height="20px">
                                <td colspan="3">
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                                <td>
                                    Atenção:<br />
                                    <ul class="b">
                                        <li><span class="text4">Analise bem o anúncio antes de fechar 
                                            negócio</span></li>
                                        <li><span class="text4">Somente pague adiantado se tiver certeza da 
                                            veracidade do anúncio</span></li>
                                    </ul>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr height="30px">
                                <td colspan="3">
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <br />
            <div style="padding-left: 30px; padding-right: 30px;">
                <span style="position: absolute; right: 400px;" class="text6">
                    <!--Publicado em:01/01/2001-->
                    <asp:Label ID="lblDataCadastro" runat="server"></asp:Label></span>
                <br />
                <span class="text5">R$ <!--xx-->
                    <asp:Label ID="lblPreco" runat="server"></asp:Label>
                </span>&nbsp;&nbsp;&nbsp;(Produto <b>
                    <!--NOVO/USADO-->
                    <asp:Label ID="lblTipo" runat="server"></asp:Label></b>)
                <br />
                <br />
                <div style="border-bottom: 1px solid black;">
                    <h3>
                        Descrição do Anúncio</h3>
                </div>
                <p>
                    <!--Descricao-->
                    <asp:Label ID="lblDescricao" runat="server"></asp:Label></p>
            </div>
            <br />
            <br />
        </div>
    </div>
</asp:Content>