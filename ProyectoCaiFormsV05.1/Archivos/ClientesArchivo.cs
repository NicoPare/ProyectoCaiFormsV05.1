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
            if (File.Exists("Cliente.json"))            
            {
                //lee TODO el contenido del archivo.                
                string contenidoDelArchivo = File.ReadAllText("Cliente.json");

                //esta linea convierte el texto
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
            File.WriteAllText("Cliente.json", contenido);            
        }

    }
}