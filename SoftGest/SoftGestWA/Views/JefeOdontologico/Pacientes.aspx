<%@ Page Language="C#" MasterPageFile="JefeOdontologico.Master" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="SoftGestWA.Views.JefeOdontologico.Pacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="p-0 m-0">
        <div class="card w-100 border-0 shadow-none rounded-0">
            <div class="card-body px-4 py-4">

                <!-- Encabezado y botón -->
                <div class="d-flex justify-content-between align-items-center mb-3">
                    <h3 class="fw-semibold mb-0">Pacientes</h3>
                    <asp:Button ID="btnNuevo" runat="server" CssClass="btn btn-primary"
                        Text="+ Nuevo Paciente" OnClick="btnNuevo_Click" />
                </div>

                <!-- Filtro de búsqueda -->
                <div class="row mb-4">
                    <div class="col-md-4 mb-2">
                        <asp:TextBox ID="txtBuscarDni" runat="server" CssClass="form-control" placeholder="Buscar por DNI" />
                    </div>
                </div>

                <!-- Repetidor de pacientes -->
                <div class="row g-3">
                    <asp:Repeater ID="rptPacientes" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="card shadow-sm border border-primary border-1">
                                    <div class="card-body">
                                        <h6 class="mb-2 fw-bold"><%# Eval("NombreCompleto") %></h6>
                                        <p class="mb-1"><strong>DNI:</strong> <%# Eval("Dni") %></p>
                                        <p class="mb-1"><strong>Teléfono:</strong> <%# Eval("Telefono") %></p>
                                        <p class="mb-1"><strong>Correo:</strong> <%# Eval("Correo") %></p>
                                        <p class="mb-1"><strong>Dirección:</strong> <%# Eval("Direccion") %></p>
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

    <!-- MODAL PACIENTE -->
    <div class="modal fade" id="modalPaciente" tabindex="-1">
        <div class="modal-dialog modal-lg">
            <div class="modal-content shadow-sm rounded-4">
                <div class="modal-header" style="background-color: #4f46e5; color: white;">
                    <h5 class="modal-title">Registrar Nuevo Paciente</h5>
                </div>
                <div class="modal-body">
                    <asp:HiddenField ID="hfIdPaciente" runat="server" />
                    <div class="row g-3">
                        <div class="col-md-6">
                            <label class="form-label">Nombre Completo</label>
                            <asp:TextBox ID="txtNombreCompleto" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">DNI</label>
                            <asp:TextBox ID="txtDni" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Teléfono</label>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-6">
                            <label class="form-label">Correo Electrónico</label>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email" />
                        </div>
                        <div class="col-md-12">
                            <label class="form-label">Dirección</label>
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
                <div class="modal-footer d-flex justify-content-between">
                    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-secondary" Text="Cancelar" OnClick="btnCancelar_Click" />
                    <asp:Button ID="btnGuardarPaciente" runat="server" CssClass="btn btn-primary" Text="Guardar Paciente" OnClick="btnGuardarPaciente_Click" />
                </div>
            </div>
        </div>
    </div>

    <!-- Script para reinicializar modales -->
    <script type="text/javascript">
        $(document).ready(function () {
            var modal = new bootstrap.Modal(document.getElementById('modalPaciente'));
        });

        function showModal() {
            var modal = new bootstrap.Modal(document.getElementById('modalPaciente'));
            modal.show();
        }
    </script>

</asp:Content>

