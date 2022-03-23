<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmJobs.aspx.cs" Inherits="ClienteWeb.frmJobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Tabla Trabajo</h3>
    <br />
    <p> Id: <asp:TextBox runat="server" Id="txtId"/></p>
    <p> Name: <asp:TextBox runat="server" Id="txtName"/></p>
    <p> min: <asp:TextBox runat="server" Id="txtmin"/></p>
    <p> max: <asp:TextBox runat="server" Id="txtmax"/></p>
    
    <p>
        
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click"/>
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click"/>
        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" OnClick="btnBuscar_Click"/>

    </p>
    <p>
        <asp:GridView runat="server" Id="jbJobs"></asp:GridView>
    </p>
</asp:Content>
