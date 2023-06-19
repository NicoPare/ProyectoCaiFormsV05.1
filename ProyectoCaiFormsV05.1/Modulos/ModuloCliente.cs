using ProyectoCaiFormsV05._1.Archivos;
using ProyectoCaiFormsV05._1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Modulos
{
    public static class ModuloCliente
    {

        //Método para crear el CodCliente y crear cliente en la entidad
        public static void GenerarNuevoCliente(Cliente nuevoCliente)
        {
            // obtengo la lista actual de clientes desde "ClientesArchivo.cs"
            List<Cliente> clientesExistentes = ClientesArchivo.ObtenerTodas();

            // obtengo el último código de cliente registrado
            int ultimoCodigoCliente = ObtenerUltimoCodigoCliente(clientesExistentes);

            // incremento el código del último cliente para el nuevo cliente
            int nuevoCodigoCliente = ultimoCodigoCliente + 1;

            // asigno el código de cliente al nuevo cliente
            nuevoCliente.CodCliente = nuevoCodigoCliente;

            // agrego el nuevo cliente a la lista
            clientesExistentes.Add(nuevoCliente);

            // guardo la lista actualizada de clientes en "ClientesArchivo.cs"
            ClientesArchivo.GuardarTodos(clientesExistentes);
        }

        
        public static int ObtenerUltimoCodigoCliente(List<Cliente> clientes)
        {
            int ultimoCodigo = 0;

            foreach (var cliente in clientes)
            {
                if (cliente.CodCliente > ultimoCodigo)
                {
                    ultimoCodigo = cliente.CodCliente;
                }
            }

            return ultimoCodigo;
        }

    }
}
