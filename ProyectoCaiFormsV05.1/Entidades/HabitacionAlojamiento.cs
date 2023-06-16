using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Entidades
{
    public class HabitacionAlojamiento
    {
        public string NombreHabitacion { get; set; }
        public decimal Tarifa { get; set; }
        public int CapacidadAdultos { get; set; }
        public int CapacidadMenores { get; set; }
        public int CapacidadInfantes { get; set; }
        public List<DisponibilidadHabitacion> DisponibilidadHabitacion { get; set; }
    }
}
