using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;

namespace ProyectoCaiFormsV05._1.Archivos
{
    internal static class AlojamientosArchivo
    {

        static List<Alojamiento> todos;

        static AlojamientosArchivo()
        {
            //si existe el archivo...
            if (File.Exists("Alojamiento.json"))            
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("Alojamiento.json");                

                //esta linea convierte el texto
                todos = JsonConvert.DeserializeObject<List<Alojamiento>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Alojamiento>();
            }
        }

        
        public static List<Alojamiento> ObtenerTodas()
        {
            return todos.ToList();
        }

    }
}