using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Entidades
{
    public class Presupuesto
    {
        public string CodPresupuesto { get; set; }
        public List<dynamic> AlojamientosSeleccionados { get; set; }
        public List<dynamic> VuelosSeleccionados { get; set; }
    }
}
