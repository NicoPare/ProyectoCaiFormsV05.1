using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Entidades
{
    public class PresupuestoLineaAlojamiento
    {
        public string CodCiudad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public string NombreAlojamiento { get; set; }
        public decimal Tarifa { get; set; }
        public string Habitacion { get; set; }
        public int Calificacion { get; set; }

        public PresupuestoLineaAlojamiento(string codCiudad, DateTime fechaIngreso, DateTime fechaEgreso, string nombreAlojamiento, decimal tarifa, string habitacion, int calificacion)
        {
            CodCiudad = codCiudad;
            FechaIngreso = fechaIngreso;
            FechaEgreso = fechaEgreso;
            NombreAlojamiento = nombreAlojamiento;
            Tarifa = tarifa;
            Habitacion = habitacion;
            Calificacion = calificacion;
        }
    }
}
