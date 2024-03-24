<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="reporte.aspx.cs" Inherits="Examen_2_2024.reporte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">
        <h1>Reporte de Encuestas</h1>
    </div>
    
    <div class="text-center">
        <br />
        <br />
        <br />
        <asp:Label ID="lblEncuestas" runat="server" Text="Cantidad de Encuestas Realizadas: "></asp:Label>
        <asp:Label ID="lblCantidadEncuestas" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblCarroPropio" runat="server" Text="Cantidad de Personas con Carro Propio: "></asp:Label>
        <asp:Label ID="lblCantidadCarroPropio" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblSinCarro" runat="server" Text="Cantidad de Personas sin Carro Propio: "></asp:Label>
        <asp:Label ID="lblCantidadSinCarro" runat="server" Text=""></asp:Label>
        <br />
    </div>
</asp:Content>