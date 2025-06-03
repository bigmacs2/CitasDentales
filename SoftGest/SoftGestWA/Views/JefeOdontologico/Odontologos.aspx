<%@ Page Language="C#" MasterPageFile="JefeOdontologico.Master" AutoEventWireup="true" CodeBehind="Odontologos.aspx.cs" Inherits="SoftGestWA.Views.JefeOdontologico.Odontologos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="p-0 m-0">
        <div class="card w-100 border-0 shadow-none rounded-0">
            <div class="card-body px-4 py-4">

                <!-- Encabezado y botón -->
                <div class="d-flex justify-content-between align-items-center mb-3">
                    <h3 class="fw-semibold mb-0">Odontólogos</h3>
                    <asp:Button ID="btnNuevo" runat="server" CssClass="btn btn-primary"
                        Text="+ Nuevo Odontólogo" OnClick="btnNuevo_Click" />
                </div>

                <!-- Filtros -->
                <div class="row mb-4">
                    <div class="col-md-4 mb-2">
                        <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control" placeholder="Buscar por nombre o ID" />
                    </div>
                    <div class="col-md-4 mb-2">
                        <asp:DropDownList ID="ddlEspecialidad" runat="server" CssClass="form-select">
                            <asp:ListItem Text="Todos" Value="Todos" />
                            <asp:ListItem Text="General" Value="General" />
                            <asp:ListItem Text="Ortodoncia" Value="Ortodoncia" />
                            <asp:ListItem Text="Endodoncia" Value="Endodoncia" />
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-4 mb-2 text-end">
                        <asp:DropDownList ID="ddlOrden" runat="server" CssClass="form-select w-auto d-inline">
                            <asp:ListItem Text="Nombre (A-Z)" Value="AZ" />
                            <asp:ListItem Text="Nombre (Z-A)" Value="ZA" />
                        </asp:DropDownList>
                    </div>
                </div>

                <!-- Repetidor de odontólogos -->
                <div class="row g-3">
                    <asp:Repeater ID="rptOdontologos" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="card shadow-sm border border-primary border-1">
                                    <div class="card-body">
                                        <div class="d-flex align-items-center mb-3">
                                            <div class="rounded-circle d-flex align-items-center justify-content-center"
                                                 style="width: 40px; height: 40px; background-color: #4f46e5; color: white;">
                                                <%# Eval("Inicial") %>
                                            </div>
                                            <div class="ms-3">
                                                <h6 class="mb-0 fw-bold"><%# Eval("NombreCompleto") %></h6>
                                                <small class="text-muted"><%# Eval("Especialidad") %></small>
                                            </div>
                                        </div>
                                        <p class="mb-1"><strong>Edad:</strong> <%# Eval("Edad") %></p>
                                        <p class="mb-1"><strong>Correo:</strong> <%# Eval("Correo") %></p>
                                        <p class="mb-1"><strong>Teléfono:</strong> <%# Eval("Telefono") %></p>
                                        <asp:Button ID="btnModificar" runat="server" CssClass="btn btn-outline-primary btn-sm mt-2"
                                            Text="Modificar" CommandArgument='<%# Eval("Id") %>' OnClick="btnModificar_Click" />
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

                <!-- Paginación -->
                <nav class="mt-4 d-flex justify-content-center">
                    <ul class="pagination pagination-rounded">
                        <asp:Literal ID="litPaginacion" runat="server" />
                    </ul>
                </nav>
            </div>
        </div>
    </div>

    <!-- MODAL ODONTÓLOGO -->
    <div class="modal fade" id="modalOdontologo" tabindex="-1">
        <div class="modal-dialog modal-lg">
            <div class="modal-content shadow-sm rounded-4">
                <div class="modal-header bg-primary text-white">
                    <h5 class="modal-title">Agregar Odontólogo</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
                </div>
                <div class="modal-body">
                    <asp:HiddenField ID="hfIdOdontologo" runat="server" />
                    <div class="row g-3">
                        <div class="col-md-6">
                            <label class="form-label">Nombres</label>
                            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Apellidos</label>
                            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">DNI</label>
                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" ReadOnly="true" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Teléfono</label>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Correo</label>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Dirección</label>
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Horario (ej. 08:00–17:00)</label>
                            <asp:TextBox ID="txtHorario" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Especialidad</label>
                            <asp:DropDownList ID="ddlEspecialidadModal" runat="server" CssClass="form-select">
                                <asp:ListItem Text="Ortodoncia" />
                                <asp:ListItem Text="Endodoncia" />
                                <asp:ListItem Text="General" />
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                <div class="modal-footer d-flex justify-content-between">
                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" />
                    <asp:Button ID="btnGuardarOdontologo" runat="server" CssClass="btn btn-primary" Text="Guardar Odontólogo" OnClick="btnGuardarOdontologo_Click" />
                </div>
            </div>
        </div>
    </div>

    <!-- Script para reinicializar modales en cada carga -->
    <script type="text/javascript">
        $(document).ready(function () {
            console.log("Documento cargado, reiniciando modales...");
            var modal = new bootstrap.Modal(document.getElementById('modalOdontologo'));
            // No mostramos el modal aquí, solo lo inicializamos
        });

        function showModal() {
            console.log("Intentando mostrar el modal...");
            var modal = new bootstrap.Modal(document.getElementById('modalOdontologo'));
            modal.show();
            console.log("Modal debería estar visible ahora.");
        }
    </script>
</asp:Content>