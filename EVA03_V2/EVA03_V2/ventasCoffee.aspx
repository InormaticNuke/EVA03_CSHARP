<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ventasCoffee.aspx.cs" Inherits="EVA03_V2.ventasCoffee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Formulario de Compras</h2>

        <asp:PlaceHolder ID="PlaceHolder1" runat="server">

            <div class="container">

                <div class="form-group">

                    <asp:Label ID="NamLb" runat="server" Text="Name del Vendedor"></asp:Label>
                    <asp:TextBox ID="txtNombreV" runat="server" CssClass="form-control"></asp:TextBox>

                </div>

                <br />

                <div class="form-group">

                    <asp:Label ID="NamLbC" runat="server" Text="Name del cafe"></asp:Label>
                    <asp:TextBox ID="txtNombreC" runat="server" CssClass="form-control"></asp:TextBox>

                </div>

                <br />

                <div class="form-group">

                    <asp:Label ID="tipoLb" runat="server" Text="Tipo de Cafe"></asp:Label>
                    <asp:DropDownList ID="TipoDDL" runat="server" CssClass="form-control">
                        <asp:ListItem Text=""></asp:ListItem>
                        <asp:ListItem Text="RPG" Value="rpg"></asp:ListItem>
                        <asp:ListItem Text="Indie" Value="indie"></asp:ListItem>
                        <asp:ListItem Text="Rol" Value="rol"></asp:ListItem>
                        <asp:ListItem Text="Metroidvania" Value="metroidvania"></asp:ListItem>
                    </asp:DropDownList>

                </div>

                <br />

                <div class="form-group">

                    <asp:Label ID="CantLb" runat="server" Text="Cantidad"></asp:Label>
                    <asp:TextBox ID="txtCant" runat="server" CssClass="form-control" Type="number"></asp:TextBox>

                </div>

                <br />

                <div class="form-group">

                    <asp:Label ID="PreicioLb" runat="server" Text="Monto total"></asp:Label>
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>

                </div>

                <br />

                <div class="form-group">

                    <asp:Label ID="fechaLbl" runat="server" Text="Fecha de Compra"></asp:Label>
                    <asp:TextBox ID="txtFecha" runat="server" type="date" CssClass="form-control"></asp:TextBox>

                </div>

                <br />

                <asp:Button ID="btnEnviar" runat="server" Text="Comprar" OnClick="btnEnviar_Click" CssClass="btn btn-primary"/>

            </div>

        </asp:PlaceHolder>


    <div>
        <br />
        <br />
        <h2>Boleta de compra</h2>
        <br />
        <asp:Label ID="lblResultado" runat="server"></asp:Label>
    </div>


</asp:Content>
