<%@ Page Title="" Language="C#" MasterPageFile="~/Views/JefeAlmacen/JefeAlmacen.Master" AutoEventWireup="true" CodeBehind="TipoMaquinas.aspx.cs" Inherits="SoftGestWA.Views.JefeAlmacen.TipoMaquinas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Tipo de Maquinas
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <h2>Mantenimiento de Tipo de Maquinas</h2>
    <div class="container row">
        <asp:GridView ID="dgvTipoMaquinas_listado" runat="server" AllowPaging="false" AutoGenerateColumns="false" CssClass="table table-hover table-responsive table-striped">
            <Columns>
                <asp:BoundField HeaderText="Código" DataField="idTipoMaquinas" /> 
                <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="descripcion" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" Text="<i class='fa-solid fa-edit' ps-2></i>" CommandArgument='<%# Eval("idTipoMaquinas") %>' OnClick="lbModificar_Click"/>
                        <asp:LinkButton runat="server" Text="<i class='fa-solid fa-trash' ps-2></i>" CommandArgument='<%# Eval("idTipoMaquinas") %>' OnClick="lbEliminar_Click" OnClientClick="return confirm('¿Estás seguro de que deseas eliminar este tipo de máquina?')" />                            
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="container row">
        <div class="text-end">
            <asp:Button ID="btnInsertar" CssClass="float-start btn btn-primary" runat="server" Text="Insertar" OnClick="btnInsertar_Click"/>        
        </div>
    </div>
</div>
</asp:Content>
