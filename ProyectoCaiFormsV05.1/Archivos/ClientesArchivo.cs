using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;

namespace ProyectoCaiFormsV05._1.Archivos
{
    internal static class ClientesArchivo
    {
        static List<Cliente> todos;

        static ClientesArchivo()
        {
            //si existe el archivo...
            //if (File.Exists("Cliente.json"))
            if(File.Exists("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Cliente.json"))
            {
                //lee TODO el contenido del archivo.
                //string contenidoDelArchivo = File.ReadAllText("Cliente.json");
                string contenidoDelArchivo = File.ReadAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Cliente.json");

                //esta linea convierte el texto
                //de vuelta a objetos de tipo PersonaEnt;

                todos = JsonConvert.DeserializeObject<List<Cliente>>(contenidoDelArchivo);
            }
            else
            {
                todos = new List<Cliente>();
            }
        }

        public static List<Cliente> ObtenerTodas()
        {
            return todos.ToList();
        }

        public static void GuardarTodos(List<Cliente> clientes)
        {
            string contenido = JsonConvert.SerializeObject(clientes);
            //File.WriteAllText("Cliente.json", contenido);
            File.WriteAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Cliente.json", contenido);
        }

    }
}