using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftGestWA.Views.AsistenteMostrador
{
    public partial class pacientes : System.Web.UI.Page
    {
        private int PageSize = 6;
        private static List<PacienteDTO> Pacientes = new List<PacienteDTO>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializarPacientes();
                int pagina = string.IsNullOrEmpty(Request.QueryString["pagina"]) ? 1 : int.Parse(Request.QueryString["pagina"]);
                CargarPacientes(pagina);
            }
        }

        private void InicializarPacientes()
        {
            if (Pacientes.Count == 0)
            {
                Pacientes.Add(new PacienteDTO { Id = 1, NombreCompleto = "Carlos Salazar", Dni = "12345678", Telefono = "987654321", Correo = "carlos@correo.com", Direccion = "Av. Siempre Viva 123" });
                Pacientes.Add(new PacienteDTO { Id = 2, NombreCompleto = "Ana Torres", Dni = "87654321", Telefono = "989898989", Correo = "ana@correo.com", Direccion = "Calle Luna 456" });
                Pacientes.Add(new PacienteDTO { Id = 3, NombreCompleto = "Luis Ramírez", Dni = "11223344", Telefono = "977776666", Correo = "luis@correo.com", Direccion = "Jr. Marte 789" });
                Pacientes.Add(new PacienteDTO { Id = 4, NombreCompleto = "Elena Campos", Dni = "44332211", Telefono = "955112233", Correo = "elena@correo.com", Direccion = "Pasaje Sol 222" });
                Pacientes.Add(new PacienteDTO { Id = 5, NombreCompleto = "Renzo Pérez", Dni = "99887766", Telefono = "911223344", Correo = "renzo@correo.com", Direccion = "Av. Estrella 101" });
                Pacientes.Add(new PacienteDTO { Id = 6, NombreCompleto = "Martha León", Dni = "66778899", Telefono = "999111222", Correo = "martha@correo.com", Direccion = "Calle Flora 321" });
                Pacientes.Add(new PacienteDTO { Id = 7, NombreCompleto = "Jorge Delgado", Dni = "77889900", Telefono = "988776655", Correo = "jorge@correo.com", Direccion = "Jr. Saturno 898" });
            }
        }

        private void CargarPacientes(int paginaActual)
        {
            string filtroDni = txtBuscarDni.Text.Trim();
            var lista = string.IsNullOrEmpty(filtroDni)
                ? Pacientes
                : Pacientes.Where(p => p.Dni.Contains(filtroDni)).ToList();

            PagedDataSource paged = new PagedDataSource();
            paged.DataSource = lista;
            paged.AllowPaging = true;
            paged.PageSize = PageSize;
            paged.CurrentPageIndex = paginaActual - 1;

            rptPacientes.DataSource = paged;
            rptPacientes.DataBind();

            GenerarPaginacion(paged.PageCount, paginaActual);
        }

        private void GenerarPaginacion(int totalPaginas, int paginaActual)
        {
            System.Text.StringBuilder html = new System.Text.StringBuilder();

            html.Append("<div class='paginacion d-flex justify-content-center'>");

            if (paginaActual > 1)
                html.Append($"<a href='?pagina={paginaActual - 1}'>&lsaquo; Previous</a>");
            else
                html.Append("<span>&lsaquo; Previous</span>");

            for (int i = 1; i <= totalPaginas; i++)
            {
                if (i == paginaActual)
                    html.Append($"<a class='active'>{i}</a>");
                else
                    html.Append($"<a href='?pagina={i}'>{i}</a>");
            }

            if (paginaActual < totalPaginas)
                html.Append($"<a href='?pagina={paginaActual + 1}'>Next &rsaquo;</a>");
            else
                html.Append("<span>Next &rsaquo;</span>");

            html.Append("</div>");

            litPaginacion.Text = html.ToString();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "modal", "showModal();", true);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            var paciente = Pacientes.FirstOrDefault(p => p.Id == id);

            if (paciente != null)
            {
                hfIdPaciente.Value = paciente.Id.ToString();
                txtNombreCompleto.Text = paciente.NombreCompleto;
                txtDni.Text = paciente.Dni;
                txtTelefono.Text = paciente.Telefono;
                txtCorreo.Text = paciente.Correo;
                txtDireccion.Text = paciente.Direccion;

                ScriptManager.RegisterStartupScript(this, this.GetType(), "modal", "showModal();", true);
            }
        }

        protected void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            int id = string.IsNullOrEmpty(hfIdPaciente.Value) ? 0 : int.Parse(hfIdPaciente.Value);
            string nombre = txtNombreCompleto.Text.Trim();
            string dni = txtDni.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string direccion = txtDireccion.Text.Trim();

            if (id == 0)
            {
                int nuevoId = Pacientes.Count > 0 ? Pacientes.Max(p => p.Id) + 1 : 1;
                Pacientes.Add(new PacienteDTO
                {
                    Id = nuevoId,
                    NombreCompleto = nombre,
                    Dni = dni,
                    Telefono = telefono,
                    Correo = correo,
                    Direccion = direccion
                });
            }
            else
            {
                var paciente = Pacientes.FirstOrDefault(p => p.Id == id);
                if (paciente != null)
                {
                    paciente.NombreCompleto = nombre;
                    paciente.Dni = dni;
                    paciente.Telefono = telefono;
                    paciente.Correo = correo;
                    paciente.Direccion = direccion;
                }
            }

            ScriptManager.RegisterStartupScript(this, this.GetType(), "modal", "$('#modalPaciente').modal('hide');", true);
            CargarPacientes(1);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "modal", "$('#modalPaciente').modal('hide');", true);
        }

        private void LimpiarCampos()
        {
            hfIdPaciente.Value = "";
            txtNombreCompleto.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
        }

        public class PacienteDTO
        {
            public int Id { get; set; }
            public string NombreCompleto { get; set; }
            public string Dni { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
        }
    }
}