using SoftGestWA.TipoMaquinaWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftGestWA.Business;

namespace SoftGestWA.Views.JefeAlmacen
{
    public partial class TipoMaquinas : System.Web.UI.Page
    {
        //Atributos llamando a nuestro BO
        private TipoMaquinaBO tipoMaquinaBO;
        private BindingList<tipoMaquinaDTO> listaTipoMaquinas;

        //Constructor
        public TipoMaquinas()
        {
            this.TipoMaquinaBO = new TipoMaquinaBO();
            this.ListaTipoMaquinas = this.TipoMaquinaBO.ListarTodos();
        }

        //Propiedades
        public TipoMaquinaBO TipoMaquinaBO { get => tipoMaquinaBO; set => tipoMaquinaBO = value; }
        public BindingList<tipoMaquinaDTO> ListaTipoMaquinas { get => listaTipoMaquinas; set => listaTipoMaquinas = value; }

        //Se podría usar un Page_Init: ejecuta solo una vez cuando se abre la pagina (Como si fuera un constructor)
        //Se ejecuta cada vez que se ejecute algún botón o algún evento
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvTipoMaquinas_listado.DataSource = ListaTipoMaquinas; //Sacado de .aspx
            dgvTipoMaquinas_listado.DataBind();
        }

        //Métodos
        protected void lbEliminar_Click(object sender, EventArgs e)
        {
            int idTipoMaquinas = Int32.Parse(((LinkButton)sender).CommandArgument);
            this.TipoMaquinaBO.Eliminar(idTipoMaquinas);
            Response.Redirect("TipoMaquinas.aspx"); //Para que una ves se elimine nos rediriga y se vea como algo que solo desapareció
        }

        protected void lbModificar_Click(object sender, EventArgs e)
        {
            int idTipoMaquinas = Int32.Parse(((LinkButton)sender).CommandArgument);
            Session["idTipoMaquina"] = idTipoMaquinas;
            Response.Redirect("TipoMaquinas_gestion.aspx?accion=modificar"); //Colocamos a dónde se va a redirigir sería a x_gestion
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TipoMaquinas_gestion.aspx");
        }
    }
}