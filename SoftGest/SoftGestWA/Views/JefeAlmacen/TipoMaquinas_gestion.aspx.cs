using SoftGestWA.TipoMaquinaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftGestWA.Business;
using System.Data.SqlClient;

namespace SoftGestWA.Views.JefeAlmacen
{
    public partial class TipoMaquinas_gestion : System.Web.UI.Page
    {
        //Atributos
        private TipoMaquinaBO tipoMaquinaBO;
        private int? idTipoMaquina;
        private string accion;
        private bool estaModificando;
        private string cabeceraPagina;

        //Constructor
        public TipoMaquinas_gestion()
        {
            this.TipoMaquinaBO = new TipoMaquinaBO();
            this.IdTipoMaquina = null;
            this.Accion = null;
            this.EstaModificando = false;
            this.CabeceraPagina = "Creación de Tipo de Máquina";
        }

        //Propiedades
        public TipoMaquinaBO TipoMaquinaBO { get => tipoMaquinaBO; set => tipoMaquinaBO = value; }
        public int? IdTipoMaquina { get => idTipoMaquina; set => idTipoMaquina = value; }
        public string Accion { get => accion; set => accion = value; }
        public bool EstaModificando { get => estaModificando; set => estaModificando = value; }
        public string CabeceraPagina { get => cabeceraPagina; set => cabeceraPagina = value; }

        //No se usa el Page_Load ya que como esta pag
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Usamos el Page_Init ya que ejecuta solo una vez cuando se abre la pagina (Como si fuera un constructor de la pagina) Depende de la acción pasada si es modificar solo modifica y si es agregar nuevo lo que hará es cargar el objeto a insertar
        protected void Page_Init(object sender, EventArgs e)
        {
            this.IdTipoMaquina = (int?)Session["idTipoMaquina"];
            this.Accion = Request.QueryString["accion"];
            if (this.Accion != null && this.Accion == "modificar")
            {
                this.EstaModificando = true;
                this.CabeceraPagina = "Modificación de Tipo de Máquina";
            }
            else
                this.EstaModificando = false;
            //Si quiere moficiar cargamos los datos de ese objeto para mostrar a la interfaz
            if (this.EstaModificando)
                this.CargarEntidad();
        }
        //Lo que hacemos acá es cargar los datos del objeto para mostrarlo en la interfaz
        private void CargarEntidad()
        {
            tipoMaquinaDTO tipoMaquina = this.tipoMaquinaBO.ObtenerPorId((int)this.IdTipoMaquina);
            txtCodigo.Text = tipoMaquina.idTipoMaquinas.ToString();
            txtNombre.Text = tipoMaquina.nombre;
            txtDescripcion.Text = tipoMaquina.descripcion;
        }

        //Sobreescribimos los clicks
        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TipoMaquinas.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = txtDescripcion.Text;

                lblDebug.Text = "Nombre: " + nombre + " | Desc: " + descripcion;

                if (this.EstaModificando)
                {
                    int r = tipoMaquinaBO.Modificar((int)this.IdTipoMaquina, nombre, descripcion);
                    lblDebug.Text += " | Resultado modificar: " + r;
                }
                else
                {
                    int r = tipoMaquinaBO.Insertar(nombre, descripcion);
                    lblDebug.Text += " | Resultado insertar: " + r;
                }

                Response.Redirect("TipoMaquinas.aspx");
            }
            catch (Exception ex)
            {
                lblError.Text = "Error al guardar: " + ex.Message;
            }
        }


    }
}