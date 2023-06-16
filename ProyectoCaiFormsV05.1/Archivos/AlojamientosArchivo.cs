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
            if (File.Exists("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Alojamiento.json"))            
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Alojamiento.json");                

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                todos = JsonConvert.DeserializeObject<List<Alojamiento>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Alojamiento>();
            }
        }

        //Estilo 1: este modulo devuelve una lista de todos los alojamientos
        //y el resto del sistema trabaja con eso.
        public static List<Alojamiento> ObtenerTodas()
        {
            return todos.ToList();
        }

    }
}