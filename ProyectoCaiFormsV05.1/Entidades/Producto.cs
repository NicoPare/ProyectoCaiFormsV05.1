using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Entidades
{
    public class Producto
    {
        public string CodProducto { get; set; }
        public Vuelo Vuelo { get; set; }
        public Alojamiento Alojamiento { get; set; }

        public Producto(string codProducto, Vuelo vuelo, Alojamiento alojamiento)
        {
            CodProducto = codProducto;
            Vuelo = vuelo;
            Alojamiento = alojamiento;
        }

    }
}
