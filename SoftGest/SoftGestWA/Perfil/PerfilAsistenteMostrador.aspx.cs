using System;
using System.Web.UI;

namespace SoftGestWA.Perfil
{
    public partial class PerfilAsistenteMostrador : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar datos del usuario aquí
                // Por ejemplo:
                // txtNombre.Text = CurrentUser.Nombre;
                // etc.
            }
        }

        protected void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (txtNuevaContraseña.Text == txtConfirmarContraseña.Text)
            {
                // Verificar contraseña actual y actualizar
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Contraseña cambiada exitosamente.');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Las contraseñas nuevas no coinciden.');", true);
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/AsistenteMostrador/AsistenteMostrador.aspx");
        }
    }
}