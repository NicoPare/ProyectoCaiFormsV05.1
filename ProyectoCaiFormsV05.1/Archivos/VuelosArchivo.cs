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
            if (File.Exists("Vuelo.json"))            
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("Vuelo.json");

                //esta linea convierte el texto
                todos = JsonConvert.DeserializeObject<List<Vuelo>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Vuelo>();
            }
        }


        
        public static List<Vuelo> ObtenerTodas()
        {
            return todos.ToList();
        }

    }
}
