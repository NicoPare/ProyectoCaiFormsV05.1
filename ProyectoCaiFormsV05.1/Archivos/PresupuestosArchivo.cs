using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Archivos
{
    internal static class PresupuestosArchivo
    {
        static List<Presupuesto> todos;

        static PresupuestosArchivo()
        {
            //si existe el archivo...
            if (File.Exists("Presupuestos.json"))
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("Presupuestos.json");                

                //esta linea convierte el texto
                todos = JsonConvert.DeserializeObject<List<Presupuesto>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Presupuesto>();
            }
        }

        public static List<Presupuesto> ObtenerTodas()
        {
            return todos.ToList();
        }

        public static void GuardarTodos(List<Presupuesto> presupuestos)
        {
            string contenido = JsonConvert.SerializeObject(presupuestos);
            File.WriteAllText("Cliente.json", contenido);            
        }

    }
}
