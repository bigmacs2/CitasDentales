using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftGestWA.Views.JefeOdontologico
{
    public partial class Asistentes : System.Web.UI.Page
    {
        private int PageSize = 6;
        private static List<dynamic> listaAsistentes = new List<dynamic>
        {
            new { Id = 1, NombreCompleto = "Carlos Medina", Dni = "12345678", Telefono = "987654321", Correo = "carlos@correo.com", Direccion = "Av. Lima 123" },
            new { Id = 2, NombreCompleto = "Ana López", Dni = "87654321", Telefono = "988888888", Correo = "ana@correo.com", Direccion = "Calle Sol 456" },
            new { Id = 3, NombreCompleto = "Luis Ramos", Dni = "11223344", Telefono = "977777666", Correo = "luis@correo.com", Direccion = "Jr. Marte 789" },
            new { Id = 4, NombreCompleto = "Elena Campos", Dni = "44332211", Telefono = "955112233", Correo = "elena@correo.com", Direccion = "Pasaje Sol 222" },
            new { Id = 5, NombreCompleto = "Renzo Pérez", Dni = "99887766", Telefono = "911223344", Correo = "renzo@correo.com", Direccion = "Av. Estrella 101" },
            new { Id = 6, NombreCompleto = "Martha León", Dni = "66778899", Telefono = "999111222", Correo = "martha@correo.com", Direccion = "Calle Flora 321" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int pagina = string.IsNullOrEmpty(Request.QueryString["pagina"]) ? 1 : int.Parse(Request.QueryString["pagina"]);
                CargarAsistentes(pagina);
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);

            var asistente = listaAsistentes.FirstOrDefault(a => a.Id == id);
            if (asistente != null)
            {
                hfIdAsistente.Value = asistente.Id.ToString();
                txtNombreCompleto.Text = asistente.NombreCompleto;
                txtDni.Text = asistente.Dni;
                txtTelefono.Text = asistente.Telefono;
                txtCorreo.Text = asistente.Correo;
                txtDireccion.Text = asistente.Direccion;
                ddlHorario.SelectedValue = "08:00-17:00";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "showModal", "showModal();", true);
            }
        }

        protected void btnGuardarAsistente_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hideModal", "$('#modalAsistente').modal('hide');", true);
            int pagina = string.IsNullOrEmpty(Request.QueryString["pagina"]) ? 1 : int.Parse(Request.QueryString["pagina"]);
            CargarAsistentes(pagina);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hideModal", "$('#modalAsistente').modal('hide');", true);
        }

        private void LimpiarCampos()
        {
            hfIdAsistente.Value = "";
            txtNombreCompleto.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
        }

        private void CargarAsistentes(int paginaActual)
        {
            string filtro = txtBuscar.Text.Trim();
            var resultado = string.IsNullOrEmpty(filtro) ? listaAsistentes : listaAsistentes.Where(a => a.Dni.Contains(filtro)).ToList();

            PagedDataSource pagedData = new PagedDataSource();
            pagedData.DataSource = resultado;
            pagedData.AllowPaging = true;
            pagedData.PageSize = PageSize;
            pagedData.CurrentPageIndex = paginaActual - 1;

            rptAsistentes.DataSource = pagedData;
            rptAsistentes.DataBind();

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