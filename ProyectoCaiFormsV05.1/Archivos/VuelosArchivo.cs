using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ProyectoCaiFormsV05._1.Entidades;

namespace ProyectoCaiFormsV05._1.Archivos
{
    internal static class VuelosArchivo
    {

        static List<Vuelo> todos;

        static VuelosArchivo()
        {
            //si existe el archivo...
            //if (File.Exists("Vuelo.json"))
            if (File.Exists("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Vuelo.json"))
            {
                //lee TODO el contenido del archivo.
                //string contenidoDelArchivo = File.ReadAllText("Vuelo.json");
                string contenidoDelArchivo = File.ReadAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Vuelo.json");

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                todos = JsonConvert.DeserializeObject<List<Vuelo>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Vuelo>();
            }
        }


        //Estilo 1: este modulo devuelve una lista de todos los vuelos
        //y el resto del sistema trabaja con eso.
        public static List<Vuelo> ObtenerTodas()
        {
            return todos.ToList();
        }

    }
}
