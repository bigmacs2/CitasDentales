<%@ Page Title="" Language="C#" MasterPageFile="~/Views/AsistenteMostrador/AsistenteMostrador.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SoftGestWA.Home" %>
<%@ Import Namespace="System.Web.Services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Citas Programadas</h3>
    <p>Selecciona un día para ver las citas programadas por odontólogo.</p>

    <!-- Selector de Fecha -->
    <div class="mb-3">
        <label for="fechaSeleccionada" class="form-label">Seleccionar Día:</label>
        <asp:TextBox ID="fechaSeleccionada" runat="server" TextMode="Date" CssClass="form-control w-25 d-inline-block" OnTextChanged="fechaSeleccionada_TextChanged" AutoPostBack="true"></asp:TextBox>
        <asp:Button ID="btnCargarCitas" runat="server" Text="Cargar Citas" CssClass="btn btn-primary ms-2" OnClick="btnCargarCitas_Click" />
    </div>

    <!-- Calendario -->
    <div class="table-responsive">
        <table class="table table-bordered" id="calendarioTable">
            <thead>
                <asp:PlaceHolder ID="phOdontologosHeader" runat="server"></asp:PlaceHolder>
            </thead>
            <tbody>
                <asp:PlaceHolder ID="phCalendarioBody" runat="server"></asp:PlaceHolder>
            </tbody>
        </table>
    </div>

    <!-- Modal para registrar nueva cita -->
    <div class="modal fade" id="nuevaCitaModal" tabindex="-1" aria-labelledby="nuevaCitaModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="nuevaCitaModalLabel">Registrar Nueva Cita</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="mb-3">
                        <label for="ddlPaciente" class="form-label">Nombre del Paciente</label>
                        <asp:DropDownList ID="ddlPaciente" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="txtFechaHora" class="form-label">Fecha y Hora</label>
                        <asp:TextBox ID="txtFechaHora" runat="server" CssClass="form-control" ReadOnly="true" ClientIDMode="Static"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="ddlTratamiento" class="form-label">Tratamiento</label>
                        <asp:DropDownList ID="ddlTratamiento" runat="server" CssClass="form-select" ClientIDMode="Static"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="txtDuracion" class="form-label">Duración de la Cita (minutos)</label>
                        <asp:TextBox ID="txtDuracion" runat="server" CssClass="form-control" ReadOnly="true" ClientIDMode="Static"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtObservaciones" class="form-label">Observaciones</label>
                        <asp:TextBox ID="txtObservaciones" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                    <asp:Button ID="btnAñadirCita" runat="server" Text="Añadir Cita" CssClass="btn btn-primary" OnClick="btnAñadirCita_Click" />
                </div>
            </div>
        </div>
    </div>

    <!-- Scripts para hacer las celdas clicables y manejar el tratamiento -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function () {
            console.log("Script cargado correctamente");

            // Seleccionar todas las celdas del tbody, excepto la primera columna (Hora)
            var cells = document.querySelectorAll('#calendarioTable tbody td:not(:first-child)');
            console.log("Celdas encontradas:", cells.length);

            cells.forEach(function (cell, index) {
                // Verificar si la celda está vacía (sin contenido visible)
                if (!cell.innerHTML.trim()) {
                    console.log("Celda vacía encontrada en índice:", index);
                    cell.classList.add('clickable');
                    cell.style.cursor = 'pointer'; // Añadir cursor para indicar que es clicable
                    cell.addEventListener('click', function () {
                        console.log("Celda clicada:", this);
                        var row = this.parentElement;
                        var horaCell = row.cells[0].innerText;
                        var odontologoHeader = document.querySelector('#calendarioTable thead th:nth-child(' + (this.cellIndex + 1) + ')');
                        var odontologo = odontologoHeader ? odontologoHeader.innerText : 'Odontólogo desconocido';
                        var fecha = document.querySelector('#<%= fechaSeleccionada.ClientID %>').value;
                        console.log("Fecha:", fecha, "Hora:", horaCell, "Odontólogo:", odontologo);
                        document.getElementById('txtFechaHora').value = fecha + ' ' + horaCell + ' (' + odontologo + ')';
                        var myModal = new bootstrap.Modal(document.getElementById('nuevaCitaModal'));
                        myModal.show();
                    });
                } else {
                    console.log("Celda con contenido en índice:", index, "Contenido:", cell.innerHTML);
                }
            });

            // Manejar cambio en ddlTratamiento sin postback
            document.getElementById('ddlTratamiento').addEventListener('change', function () {
                var tratamiento = this.options[this.selectedIndex].text; // Usar el texto en lugar del valor
                console.log("Tratamiento seleccionado:", tratamiento);
                if (tratamiento) {
                    <%= Page.ClientScript.GetCallbackEventReference(this, "tratamiento", "UpdateDuracion", "null") %>;
                } else {
                    document.getElementById('txtDuracion').value = '';
                }
            });

            function UpdateDuracion(duracion) {
                console.log("Duración recibida:", duracion);
                document.getElementById('txtDuracion').value = duracion;
            }
        });
    </script>
</asp:Content>
