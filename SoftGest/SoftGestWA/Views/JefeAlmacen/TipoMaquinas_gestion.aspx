<%@ Page Title="" Language="C#" MasterPageFile="~/Views/JefeAlmacen/JefeAlmacen.Master" AutoEventWireup="true" CodeBehind="TipoMaquinas_gestion.aspx.cs" Inherits="SoftGestWA.Views.JefeAlmacen.TipoMaquinas_gestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Tipo de Maquinas - Gestión
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card">

    <div class="card-header">
        <%--<h2>Creación de TipoMaquina</h2>--%>
        <h2>Creación de TipoMaquina</h2>
    </div>

    <div class="card-body">
        <div class="mb-3 row">
            <asp:Label ID="lblIdTipoMaquina" runat="server" Text="Código: " CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-8">
                <asp:TextBox ID="txtCodigo" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="mb-3 row">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre: " CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-8">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="mb-3 row">
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripción: " CssClass="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-8">
                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="2" placeholder="Ingresa la descripción del tipo de máquina..."></asp:TextBox>
            </div>
        </div>
    </div>

    <div class="card-footer">
        <asp:Button ID="btnRegresar" CssClass="float-start btn btn-primary" runat="server" Text="Regresar" OnClick="btnRegresar_Click"/>
        <asp:Button ID="btnGuardar" CssClass="float-end btn btn-secondary" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
    </div>
        <asp:Label ID="lblDebug" runat="server" ForeColor="Blue" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" />

</div>
</asp:Content>
