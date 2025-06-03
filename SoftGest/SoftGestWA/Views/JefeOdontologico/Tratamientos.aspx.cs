using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace SoftGestWA.Views.JefeOdontologico
{
    public partial class Tratamientos : System.Web.UI.Page
    {
        private static List<TratamientoDTO> tratamientosFull = new List<TratamientoDTO>
        {
            new TratamientoDTO { Id = 1, Nombre = "Examen dental", Descripcion = "Evaluación inicial de la salud bucal", Duracion = 30, Costo = 50.00m, Especialidad = "Diagnóstico" },
            new TratamientoDTO { Id = 2, Nombre = "Limpieza dental", Descripcion = "Limpieza profunda de dientes y encías", Duracion = 45, Costo = 80.00m, Especialidad = "Profilaxis" },
            new TratamientoDTO { Id = 3, Nombre = "Evaluación", Descripcion = "Revisión detallada para diagnóstico", Duracion = 60, Costo = 100.00m, Especialidad = "Diagnóstico" },
            new TratamientoDTO { Id = 4, Nombre = "Ortodoncia", Descripcion = "Corrección de alineación dental", Duracion = 120, Costo = 300.00m, Especialidad = "Ortodoncia" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                CargarTratamientos();

            if (IsPostBack && Request["__EVENTTARGET"] == "cargarModal")
            {
                string idStr = Request["__EVENTARGUMENT"];
                if (int.TryParse(idStr, out int id))
                {
                    var tratamiento = tratamientosFull.FirstOrDefault(t => t.Id == id);
                    if (tratamiento != null)
                    {
                        hfIdTratamiento.Value = tratamiento.Id.ToString();
                        txtNombre.Text = tratamiento.Nombre;
                        txtDescripcion.Text = tratamiento.Descripcion;
                        txtDuracion.Text = tratamiento.Duracion.ToString();
                        txtCosto.Text = tratamiento.Costo.ToString("F2");
                        ddlModalEspecialidad.SelectedValue = tratamiento.Especialidad;

                        ScriptManager.RegisterStartupScript(this, GetType(), "mostrarModal", "var modal = new bootstrap.Modal(document.getElementById('ModalTratamiento')); modal.show();", true);
                    }
                }
            }
        }


        private void CargarTratamientos(string filtro = "", string especialidad = "")
        {
            var resultados = tratamientosFull;

            if (!string.IsNullOrEmpty(filtro))
                resultados = resultados.Where(t => t.Nombre.ToLower().Contains(filtro.ToLower())).ToList();

            if (!string.IsNullOrEmpty(especialidad))
                resultados = resultados.Where(t => t.Especialidad == especialidad).ToList();

            gvTratamientos.DataSource = resultados;
            gvTratamientos.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            string especialidad = ddlEspecialidad.SelectedValue;
            CargarTratamientos(filtro, especialidad);
        }

        protected void gvTratamientos_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvTratamientos.PageIndex = e.NewPageIndex;
            btnFiltrar_Click(sender, e);
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = string.IsNullOrEmpty(hfIdTratamiento.Value) ? 0 : int.Parse(hfIdTratamiento.Value);

            var tratamiento = new TratamientoDTO
            {
                Id = id == 0 ? tratamientosFull.Max(t => t.Id) + 1 : id,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Duracion = int.Parse(txtDuracion.Text),
                Costo = decimal.Parse(txtCosto.Text),
                Especialidad = ddlModalEspecialidad.SelectedValue
            };

            if (id == 0)
                tratamientosFull.Add(tratamiento);
            else
            {
                var original = tratamientosFull.FirstOrDefault(t => t.Id == id);
                if (original != null)
                {
                    original.Nombre = tratamiento.Nombre;
                    original.Descripcion = tratamiento.Descripcion;
                    original.Duracion = tratamiento.Duracion;
                    original.Costo = tratamiento.Costo;
                    original.Especialidad = tratamiento.Especialidad;
                }
            }

            CargarTratamientos();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoTratamiento.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            var boton = (System.Web.UI.WebControls.Button)sender;
            string id = boton.CommandArgument;
            Response.Redirect("EditarTratamiento.aspx?id=" + id);
        }

        public class TratamientoDTO
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public int Duracion { get; set; }
            public decimal Costo { get; set; }
            public string Especialidad { get; set; }
        }
    }
}