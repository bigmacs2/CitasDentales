//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.UI;
//using System.Web.UI.WebControls;
////using SoftGestWA.TipoTratamientoServiceReference; // Namespace de la referencia SOAP

//namespace SoftGestWA
//{
//    //public partial class Home : System.Web.UI.Page
//    //{
//    //    protected void Page_Load(object sender, EventArgs e)
//    //    {
//    //        if (!IsPostBack)
//    //        {
//    //            // Establecer la fecha por defecto como hoy
//    //            fechaSeleccionada.Text = DateTime.Today.ToString("yyyy-MM-dd");
//    //            CargarCitas();
//    //        }
//    //    }

//    //    protected void btnCargarCitas_Click(object sender, EventArgs e)
//    //    {
//    //        CargarCitas();
//    //    }

//    //    private void CargarCitas()
//    //    {
//    //        try
//    //        {
//    //            using (var client = new TipoTratamientoServiceClient())
//    //            {
//    //                // Obtener la fecha seleccionada
//    //                string fecha = fechaSeleccionada.Text; // Formato: yyyy-MM-dd
//    //                var citas = client.listarCitasPorDia(fecha);

//    //                // Limpiar los PlaceHolders
//    //                for (int hour = 9; hour <= 18; hour++)
//    //                {
//    //                    for (int minute = 0; minute < 60; minute += 30)
//    //                    {
//    //                        if (hour == 18 && minute > 0) continue;
//    //                        var ph = (PlaceHolder)FindControl($"phCita_{hour}_{minute}");
//    //                        ph.Controls.Clear();
//    //                    }
//    //                }

//    //                // Asignar citas a los bloques correspondientes
//    //                if (citas != null)
//    //                {
//    //                    foreach (var cita in citas)
//    //                    {
//    //                        DateTime fechaHora = DateTime.Parse(cita.fechaHora);
//    //                        if (fechaHora.Date == DateTime.Parse(fecha).Date)
//    //                        {
//    //                            int hour = fechaHora.Hour;
//    //                            int minute = fechaHora.Minute - (fechaHora.Minute % 30); // Redondear al intervalo de 30 minutos
//    //                            if (hour >= 9 && hour < 18)
//    //                            {
//    //                                var ph = (PlaceHolder)FindControl($"phCita_{hour}_{minute}");
//    //                                if (ph != null)
//    //                                {
//    //                                    string colorClass = GetColorClass(cita.tipoTratamiento);
//    //                                    LiteralControl citaHtml = new LiteralControl(
//    //                                        $"<span class='badge {colorClass}' style='width: 100%; padding: 10px;'>{cita.paciente} - {cita.tipoTratamiento}</span>"
//    //                                    );
//    //                                    ph.Controls.Add(citaHtml);
//    //                                }
//    //                            }
//    //                        }
//    //                    }
//    //                }
//    //            }
//    //        }
//    //        catch (Exception ex)
//    //        {
//    //            // Mostrar error (puedes usar un control para esto)
//    //            Response.Write($"<p>Error al cargar citas: {ex.Message}</p>");
//    //        }
//    //    }

//    //    private string GetColorClass(string tipoTratamiento)
//    //    {
//    //        // Asignar colores según el tipo de tratamiento
//    //        switch (tipoTratamiento?.ToLower())
//    //        {
//    //            case "examen dental":
//    //                return "bg-primary text-white";
//    //            case "limpieza dental":
//    //                return "bg-success text-white";
//    //            case "consulta":
//    //                return "bg-info text-dark";
//    //            case "evaluación":
//    //                return "bg-warning text-dark";
//    //            case "revisión":
//    //                return "bg-danger text-white";
//    //            default:
//    //                return "bg-secondary text-white";
//    //        }
//    //    }
//    //}
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoftGestWA
{
    public partial class Home : System.Web.UI.Page, ICallbackEventHandler
    {
        // Diccionario simulado para duraciones por tratamiento
        private Dictionary<string, int> duracionesTratamiento = new Dictionary<string, int>
        {
            { "Examen Dental", 30 },
            { "Limpieza Dental", 45 },
            { "Consulta", 60 },
            { "Evaluación", 30 },
            { "Revisión", 30 }
        };

        private string _callbackResult = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Establecer la fecha por defecto como hoy (09:24 PM, May 29, 2025)
                fechaSeleccionada.Text = DateTime.Now.ToString("yyyy-MM-dd");
                CargarDatosIniciales();
                RenderizarCalendario();
                string cbReference = Page.ClientScript.GetCallbackEventReference(this, "arg", "UpdateDuracion", "context");
                string cbScript = "function CallServer(arg, context) {" + cbReference + ";}";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "CallServer", cbScript, true);
            }
        }

        protected void fechaSeleccionada_TextChanged(object sender, EventArgs e)
        {
            RenderizarCalendario();
        }

        protected void btnCargarCitas_Click(object sender, EventArgs e)
        {
            RenderizarCalendario();
        }

        protected void btnAñadirCita_Click(object sender, EventArgs e)
        {
            // Simular registro de cita (en el futuro, conectar con backend)
            string fechaHora = txtFechaHora.Text;
            string paciente = ddlPaciente.SelectedItem.Text;
            string tratamiento = ddlTratamiento.SelectedItem.Text;
            int duracion = int.Parse(txtDuracion.Text);
            string observaciones = txtObservaciones.Text;

            // Simular actualización del calendario (en el futuro, recargar citas del backend)
            RenderizarCalendario();

            // Cerrar el modal
            ScriptManager.RegisterStartupScript(this, this.GetType(), "closeModal", "$('#nuevaCitaModal').modal('hide');", true);
        }

        private void CargarDatosIniciales()
        {
            // Simular lista de pacientes
            ddlPaciente.Items.Add(new ListItem("Seleccione un paciente", ""));
            ddlPaciente.Items.Add(new ListItem("Juan Pérez", "1"));
            ddlPaciente.Items.Add(new ListItem("María Gómez", "2"));
            ddlPaciente.Items.Add(new ListItem("Pedro López", "3"));

            // Simular lista de tratamientos
            ddlTratamiento.Items.Add(new ListItem("Seleccione un tratamiento", ""));
            ddlTratamiento.Items.Add(new ListItem("Examen Dental", "1"));
            ddlTratamiento.Items.Add(new ListItem("Limpieza Dental", "2"));
            ddlTratamiento.Items.Add(new ListItem("Consulta", "3"));
            ddlTratamiento.Items.Add(new ListItem("Evaluación", "4"));
            ddlTratamiento.Items.Add(new ListItem("Revisión", "5"));
        }

        private void RenderizarCalendario()
        {
            try
            {
                // Limpiar encabezados y cuerpo
                phOdontologosHeader.Controls.Clear();
                phCalendarioBody.Controls.Clear();

                // Simular lista de odontólogos (reemplazar con datos del backend más tarde)
                List<string> odontologos = new List<string> { "Odontólogo 1", "Odontólogo 2", "Odontólogo 3" };

                // Renderizar encabezado una sola vez
                LiteralControl headerRow = new LiteralControl("<tr>");
                headerRow.Text += "<th scope='col' style='width: 100px;'>Hora</th>";
                foreach (var odontologo in odontologos)
                {
                    headerRow.Text += $"<th scope='col'>{odontologo}</th>";
                }
                headerRow.Text += "</tr>";
                phOdontologosHeader.Controls.Add(headerRow);

                // Renderizar filas de 9:00 AM a 6:00 PM con intervalos de 30 minutos
                for (int hour = 9; hour <= 18; hour++)
                {
                    for (int minute = 0; minute < 60; minute += 30)
                    {
                        if (hour == 18 && minute > 0) continue;

                        LiteralControl row = new LiteralControl("<tr>");
                        row.Text += $"<td>{hour:D2}:{minute:D2} {(hour < 12 ? "AM" : "PM")}</td>";

                        foreach (var odontologo in odontologos)
                        {
                            PlaceHolder ph = new PlaceHolder
                            {
                                ID = $"phCita_{hour}_{minute}_{odontologo.Replace(" ", "")}"
                            };
                            row.Text += "<td class='clickable'>";
                            ph.Controls.Clear(); // Preparar para futuras citas
                            row.Text += "</td>";
                            phCalendarioBody.Controls.Add(ph);
                        }

                        row.Text += "</tr>";
                        phCalendarioBody.Controls.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar error
                Response.Write($"<p>Error al renderizar calendario: {ex.Message}</p>");
            }
        }

        #region ICallbackEventHandler Members
        public string GetCallbackResult()
        {
            return _callbackResult;
        }

        public void RaiseCallbackEvent(string eventArgument)
        {
            if (duracionesTratamiento.ContainsKey(eventArgument))
            {
                _callbackResult = duracionesTratamiento[eventArgument].ToString();
            }
            else
            {
                _callbackResult = "30"; // Valor por defecto
            }
        }
        #endregion
    }
}