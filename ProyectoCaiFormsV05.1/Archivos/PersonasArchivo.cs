using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;

namespace ProyectoCaiFormsV05._1.Archivos
{
    internal static class PersonasArchivo
    {
        static List<Persona> todos;

        static PersonasArchivo()
        {
            //si existe el archivo...
            if (File.Exists("Persona.json"))
            {
                //lee TODO el contenido del archivo.
                string contenidoDelArchivo = File.ReadAllText("Persona.json");

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                todos = JsonConvert.DeserializeObject<List<Persona>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Persona>();
            }
        }


    }
}