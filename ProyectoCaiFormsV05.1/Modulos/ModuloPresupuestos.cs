using ProyectoCaiFormsV05._1.Archivos;
using ProyectoCaiFormsV05._1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Modulos
{
    public static class ModuloPresupuestos
    {

        public static List<Presupuesto> CrearPresupuesto(List<PresupuestoLineaVuelo> presupuestoLineaVuelo, Cliente cliente)
        {

            //Me traigo el último cliente agregado para asignarlo al presupuesto por crear
            List<Cliente> clientesExistentes = ClientesArchivo.ObtenerTodas();
            int ultimoCodigoCliente = ModuloCliente.ObtenerUltimoCodigoCliente(clientesExistentes);
            int nuevoCodigoCliente = ultimoCodigoCliente + 1;

            List<Presupuesto> presupuestos = PresupuestosArchivo.ObtenerTodas();

            string codPresupuesto = GenerateUniqueCode();
            Presupuesto presupuesto = new Presupuesto
            {
                CodPresupuesto = codPresupuesto,            
                CodCliente = nuevoCodigoCliente,
                PresupuestoLineaVuelo = presupuestoLineaVuelo,
                PresupuestoLineaAlojamiento = null
            };

            presupuestos.Add(presupuesto);

            return presupuestos;
        }


        private static string GenerateUniqueCode()
        {
            const string prefix = "P-";
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int maxLength = 10;
            var random = new Random();
            var code = new StringBuilder(prefix);

            for (int i = 0; i < maxLength - prefix.Length; i++)
            {
                int index = random.Next(0, characters.Length);
                code.Append(characters[index]);
            }

            return code.ToString();
        }

    }
}
