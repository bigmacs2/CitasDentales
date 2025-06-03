using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using SoftGestWA.TipoMaquinaWS;

namespace SoftGestWA.Business
{
    public class TipoMaquinaBO
    {

        private TipoMaquinaClient client;

        public TipoMaquinaBO()
        {
            client = new TipoMaquinaClient();  // Instancia el cliente generado del servicio
        }

        public BindingList<tipoMaquinaDTO> ListarTodos()
        {
            var request = new listarTodosTipoMaquinaRequest();  // Crear instancia del request (aunque esté vacío)
            var resultado = client.listarTodosTipoMaquina();

            if (resultado == null)
                return new BindingList<tipoMaquinaDTO>();

            return new BindingList<tipoMaquinaDTO>(resultado.ToList());
        }


        public tipoMaquinaDTO ObtenerPorId(int id)
        {
            return client.obtenerPorIdTipoMaquina(id);
        }

        public int Insertar(string nombre, string descripcion)
        {
            return client.insertarTipoMaquina(nombre, descripcion);
        }

        public int Modificar(int id, string nombre, string descripcion)
        {
            return client.modificarTipoMaquina(id, nombre, descripcion);
        }

        public int Eliminar(int id)
        {
            return client.eliminarTipoMaquina(id);
        }

    }
}