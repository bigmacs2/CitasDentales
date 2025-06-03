<%@ Page Title="Gestión de Tratamientos" Language="C#" MasterPageFile="JefeOdontologico.Master" AutoEventWireup="true" CodeBehind="Tratamientos.aspx.cs" Inherits="SoftGestWA.Views.JefeOdontologico.Tratamientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .container-box {
            background: #ffffff;
            border-radius: 12px;
            box-shadow: 0 4px 16px rgba(0, 0, 0, 0.05);
            padding: 2rem;
            margin-top: 40px;
        }

        .header-title {
            font-size: 1.8rem;
            font-weight: 600;
            color: #333333;
        }

        .header-subtitle {
            font-size: 1rem;
            color: #666666;
            margin-bottom: 1.5rem;
        }

        .btn-edit {
            background-color: #ffc107;
            border: none;
            color: white;
            font-weight: 500;
        }

        .btn-edit:hover {
            background-color: #e0a800;
        }

        .table th {
            background-color: #4f46e5;
            color: white;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="container-box">
            <div class="d-flex justify-content-between align-items-center mb-3">
                <div>
                    <div class="header-title">Gestión de Tratamientos</div>
                    <div class="header-subtitle">Lista de tratamientos ofrecidos por la clínica SisaDent</div>
                </div>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar Tratamiento"
                CssClass="btn btn-primary" OnClientClick="abrirModalAgregar(); return false;" />

            </div>

            <div class="row mb-3">
                <div class="col-md-4">
                    <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" Placeholder="Buscar por nombre..." />
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="ddlEspecialidad" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Todas las especialidades" Value="" />
                        <asp:ListItem Text="Ortodoncia" Value="Ortodoncia" />
                        <asp:ListItem Text="Profilaxis" Value="Profilaxis" />
                        <asp:ListItem Text="Diagnóstico" Value="Diagnóstico" />
                    </asp:DropDownList>
                </div>
                <div class="col-md-4">
                    <asp:Button ID="btnFiltrar" runat="server" CssClass="btn btn-secondary w-100" Text="Aplicar filtros" OnClick="btnFiltrar_Click" />
                </div>
            </div>

            <asp:GridView ID="gvTratamientos" runat="server" 
                AllowPaging="True" PageSize="5" OnPageIndexChanging="gvTratamientos_PageIndexChanging"
                AutoGenerateColumns="False" CssClass="table table-hover text-center" GridLines="None"
                EmptyDataText="No hay tratamientos registrados.">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                    <asp:BoundField DataField="Duracion" HeaderText="Duración (min)" />
                    <asp:BoundField DataField="Costo" HeaderText="Costo" DataFormatString="S/. {0:N2}" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                           <asp:Button ID="btnEditar" runat="server" Text="Editar"
                            CssClass="btn btn-edit" OnClientClick='<%# Eval("Id", "abrirModalEditar({0}); return false;") %>' />

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <!-- Modal Bootstrap para agregar/editar tratamiento -->
<div class="modal fade" id="ModalTratamiento" tabindex="-1" aria-labelledby="ModalLabel" aria-hidden="true">
    <div class="modal-dialog modal-lg">
        <div class="modal-content">
            <div class="modal-header bg-primary text-white">
                <h5 class="modal-title" id="ModalLabel">Agregar / Editar Tratamiento</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Cerrar"></button>
            </div>
            <div class="modal-body">
                <asp:HiddenField ID="hfIdTratamiento" runat="server" />
                <div class="mb-3">
                    <label>Nombre</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label>Descripción</label>
                    <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" />
                </div>
                <div class="mb-3">
                    <label>Duración (minutos)</label>
                    <asp:TextBox ID="txtDuracion" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label>Costo (S/.)</label>
                    <asp:TextBox ID="txtCosto" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label>Especialidad</label>
                    <asp:DropDownList ID="ddlModalEspecialidad" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Ortodoncia" Value="Ortodoncia" />
                        <asp:ListItem Text="Profilaxis" Value="Profilaxis" />
                        <asp:ListItem Text="Diagnóstico" Value="Diagnóstico" />
                    </asp:DropDownList>
                </div>
            </div>
            <div class="modal-footer">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</button>
            </div>
        </div>
    </div>
</div>
    <script>
    function abrirModalAgregar() {
        document.getElementById('<%= hfIdTratamiento.ClientID %>').value = '';
        document.getElementById('<%= txtNombre.ClientID %>').value = '';
        document.getElementById('<%= txtDescripcion.ClientID %>').value = '';
        document.getElementById('<%= txtDuracion.ClientID %>').value = '';
        document.getElementById('<%= txtCosto.ClientID %>').value = '';
        document.getElementById('<%= ddlModalEspecialidad.ClientID %>').selectedIndex = 0;

        var modal = new bootstrap.Modal(document.getElementById('ModalTratamiento'));
        modal.show();
    }

    function abrirModalEditar(id) {
        __doPostBack('cargarModal', id);
    }
    </script>
</asp:Content>