using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Entidades
{
    public class Alojamiento
    {
        public string CodHotel { get; set; }
        public string NombreAlojamiento { get; set; }
        public string CodCiudad { get; set; }
        public string Direccion { get; set; }
        public int Calificacion { get; set; }
        public List<HabitacionAlojamiento> HabitacionAlojamiento { get; set; }
    }
}
