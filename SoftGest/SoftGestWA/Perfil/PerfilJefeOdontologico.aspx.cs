using System;
using System.Web.UI;

namespace SoftGestWA.Perfil
{
    public partial class PerfilJefeOdontologicoPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cargar datos del usuario aquí
                // Por ejemplo:
                // txtNombre.Text = CurrentUser.Nombre;
                // etc.
                txtNombre.Text = "Jefe Odontológico Ejemplo";
                txtCorreo.Text = "jefeodontologico@ejemplo.com";
                txtTelefono.Text = "+123 456 7890";
                txtDireccion.Text = "Calle Principal 123, Ciudad";
                txtCallePrincipal.Text = "Calle Principal 123";
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
            Response.Redirect("~/Views/JefeOdontologico/JefeOdontologico.aspx");
        }
    }
}