using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftGestWA.Views.JefeOdontologico
{
    public partial class Odontologos : System.Web.UI.Page
    {
        private int PageSize = 6;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int pagina = string.IsNullOrEmpty(Request.QueryString["pagina"]) ? 1 : int.Parse(Request.QueryString["pagina"]);
                CargarOdontologos(pagina);
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtHorario.Text = "";
            ddlEspecialidadModal.SelectedIndex = 0;
            hfIdOdontologo.Value = "";

            // Mostrar modal con depuración
            ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);

            // Simular carga de datos
            var odontologos = new List<dynamic>
            {
                new { Id = 1, Inicial = "M", NombreCompleto = "María Torres", Especialidad = "Ortodoncia", Edad = 38, Correo = "maria.torres@clinicadental.com", Telefono = "987654321" },
                new { Id = 2, Inicial = "J", NombreCompleto = "Juan Pérez", Especialidad = "Endodoncia", Edad = 45, Correo = "juan.perez@clinicadental.com", Telefono = "987123456" },
                new { Id = 3, Inicial = "L", NombreCompleto = "Lucía Ramírez", Especialidad = "General", Edad = 33, Correo = "lucia.ramirez@clinicadental.com", Telefono = "986789012" },
                new { Id = 4, Inicial = "A", NombreCompleto = "Andrés Mejía", Especialidad = "Ortodoncia", Edad = 41, Correo = "andres.mejia@clinicadental.com", Telefono = "985654123" },
                new { Id = 5, Inicial = "S", NombreCompleto = "Sandra León", Especialidad = "General", Edad = 29, Correo = "sandra.leon@clinicadental.com", Telefono = "984123654" },
                new { Id = 6, Inicial = "P", NombreCompleto = "Pedro Salas", Especialidad = "Endodoncia", Edad = 50, Correo = "pedro.salas@clinicadental.com", Telefono = "983654789" },
                new { Id = 7, Inicial = "C", NombreCompleto = "Carla Rojas", Especialidad = "Ortodoncia", Edad = 36, Correo = "carla.rojas@clinicadental.com", Telefono = "982321654" },
                new { Id = 8, Inicial = "R", NombreCompleto = "Renzo Gamarra", Especialidad = "General", Edad = 39, Correo = "renzo.gamarra@clinicadental.com", Telefono = "981123789" },
                new { Id = 9, Inicial = "E", NombreCompleto = "Elena Vega", Especialidad = "Endodoncia", Edad = 43, Correo = "elena.vega@clinicadental.com", Telefono = "980987654" },
                new { Id = 10, Inicial = "D", NombreCompleto = "Diego Castro", Especialidad = "General", Edad = 35, Correo = "diego.castro@clinicadental.com", Telefono = "979456321" }
            };

            var odontologo = odontologos.FirstOrDefault(o => o.Id == id);
            if (odontologo != null)
            {
                hfIdOdontologo.Value = odontologo.Id.ToString();
                txtNombres.Text = odontologo.NombreCompleto.Split(' ')[0];
                txtApellidos.Text = odontologo.NombreCompleto.Split(' ').Length > 1 ? odontologo.NombreCompleto.Split(' ')[1] : "";
                txtDni.Text = "DNI-" + odontologo.Id;
                txtTelefono.Text = odontologo.Telefono;
                txtCorreo.Text = odontologo.Correo;
                txtDireccion.Text = "Dirección simulada";
                txtHorario.Text = "08:00–17:00";
                ddlEspecialidadModal.SelectedValue = odontologo.Especialidad;

                // Mostrar modal con depuración
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
            }
        }

        protected void btnGuardarOdontologo_Click(object sender, EventArgs e)
        {
            // Lógica para guardar o actualizar (simulación)
            string id = hfIdOdontologo.Value;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;
            string horario = txtHorario.Text;
            string especialidad = ddlEspecialidadModal.SelectedValue;

            // Simular éxito y cerrar modal
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hideModal", "$('#modalOdontologo').modal('hide');", true);
            int pagina = string.IsNullOrEmpty(Request.QueryString["pagina"]) ? 1 : int.Parse(Request.QueryString["pagina"]);
            CargarOdontologos(pagina); // Recargar la lista
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar modal
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hideModal", "$('#modalOdontologo').modal('hide');", true);
        }

        private void CargarOdontologos(int paginaActual)
        {
            var odontologos = new List<dynamic>
            {
                new { Id = 1, Inicial = "M", NombreCompleto = "María Torres", Especialidad = "Ortodoncia", Edad = 38, Correo = "maria.torres@clinicadental.com", Telefono = "987654321" },
                new { Id = 2, Inicial = "J", NombreCompleto = "Juan Pérez", Especialidad = "Endodoncia", Edad = 45, Correo = "juan.perez@clinicadental.com", Telefono = "987123456" },
                new { Id = 3, Inicial = "L", NombreCompleto = "Lucía Ramírez", Especialidad = "General", Edad = 33, Correo = "lucia.ramirez@clinicadental.com", Telefono = "986789012" },
                new { Id = 4, Inicial = "A", NombreCompleto = "Andrés Mejía", Especialidad = "Ortodoncia", Edad = 41, Correo = "andres.mejia@clinicadental.com", Telefono = "985654123" },
                new { Id = 5, Inicial = "S", NombreCompleto = "Sandra León", Especialidad = "General", Edad = 29, Correo = "sandra.leon@clinicadental.com", Telefono = "984123654" },
                new { Id = 6, Inicial = "P", NombreCompleto = "Pedro Salas", Especialidad = "Endodoncia", Edad = 50, Correo = "pedro.salas@clinicadental.com", Telefono = "983654789" },
                new { Id = 7, Inicial = "C", NombreCompleto = "Carla Rojas", Especialidad = "Ortodoncia", Edad = 36, Correo = "carla.rojas@clinicadental.com", Telefono = "982321654" },
                new { Id = 8, Inicial = "R", NombreCompleto = "Renzo Gamarra", Especialidad = "General", Edad = 39, Correo = "renzo.gamarra@clinicadental.com", Telefono = "981123789" },
                new { Id = 9, Inicial = "E", NombreCompleto = "Elena Vega", Especialidad = "Endodoncia", Edad = 43, Correo = "elena.vega@clinicadental.com", Telefono = "980987654" },
                new { Id = 10, Inicial = "D", NombreCompleto = "Diego Castro", Especialidad = "General", Edad = 35, Correo = "diego.castro@clinicadental.com", Telefono = "979456321" }
            };

            PagedDataSource pagedData = new PagedDataSource();
            pagedData.DataSource = odontologos;
            pagedData.AllowPaging = true;
            pagedData.PageSize = PageSize;
            pagedData.CurrentPageIndex = paginaActual - 1;

            rptOdontologos.DataSource = pagedData;
            rptOdontologos.DataBind();

            GenerarPaginacion(pagedData.PageCount, paginaActual);
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
    }
}