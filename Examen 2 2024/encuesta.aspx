<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="encuesta.aspx.cs" Inherits="Examen_2_2024.encuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center">   
    <H1>Encuesta </H1> 
</div>

    <div class="text-center">
    <div>
        <asp:GridView ID="GridView1" runat="server" Height="16px" Width="606px" HorizontalAlign="Center"></asp:GridView>
    </div>

    <div >
        <br />
        ID
        <br />
        Automatico.<br />
&nbsp;<br />
        <br />
        Nombre:<br />
        <asp:TextBox ID="tNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Apellido:
        </div>
        <asp:TextBox ID="tApellido" runat="server" Height="33px" Width="190px"></asp:TextBox>
        <br />
        <br />
        <br />
      Fecha de Nacimiento:<br />
&nbsp;<asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <br />
        <br />
        Edad<br />
        <asp:TextBox ID="tEdad" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        
        Correo:
                
    <br />
        <asp:TextBox ID="tCorreo" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Cuenta con carro:
        <br />
    <asp:RadioButtonList ID="rbCarro" runat="server" style="text-align: center; margin: 0 auto;">
    <asp:ListItem Text="Sí" Value="Si" />
    <asp:ListItem Text="No" Value="No" />
</asp:RadioButtonList>
        <br />
        <br />
    <br />
    <asp:Button ID="Bingresar" runat="server" Height="41px" Text="Ingresar" Width="98px" OnClick="Bingresar_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Bborrar" runat="server" Height="39px" OnClick="Bborrar_Click" Text="Borrar" Width="85px" />
    <br />
    </div>

</asp:Content>
