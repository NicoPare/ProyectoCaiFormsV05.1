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

        public static void GenerarNuevoCliente(Cliente nuevoCliente)
        {
            // Obtener la lista actual de clientes desde "ClientesArchivo.cs"
            List<Cliente> clientesExistentes = ClientesArchivo.ObtenerTodas();

            // Obtener el último código de cliente registrado
            int ultimoCodigoCliente = ObtenerUltimoCodigoCliente(clientesExistentes);

            // Incrementar el código del cliente para el nuevo cliente
            int nuevoCodigoCliente = ultimoCodigoCliente + 1;

            // Asignar el código de cliente al nuevo cliente
            nuevoCliente.CodCliente = nuevoCodigoCliente;

            // Agregar el nuevo cliente a la lista
            clientesExistentes.Add(nuevoCliente);

            // Guardar la lista actualizada de clientes en "ClientesArchivo.cs"
            ClientesArchivo.GuardarTodos(clientesExistentes);
        }

        private static int ObtenerUltimoCodigoCliente(List<Cliente> clientes)
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
