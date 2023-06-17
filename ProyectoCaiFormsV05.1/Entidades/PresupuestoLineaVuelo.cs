using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCaiFormsV05._1.Entidades
{
    public class PresupuestoLineaVuelo
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraArribo { get; set; }
        public string Aerolinea { get; set; }
        public decimal Precio { get; set; }
        public string ClaseVuelo { get; set; }
        public string TipoPasajero { get; set; }

        public PresupuestoLineaVuelo(string origen, string destino, DateTime fechaHoraSalida, DateTime fechaHoraArribo,
            string aerolinea, decimal precio, string claseVuelo, string tipoPasajero)
        {
            Origen = origen;
            Destino = destino;
            FechaHoraSalida = fechaHoraSalida;
            FechaHoraArribo = fechaHoraArribo;
            Aerolinea = aerolinea;
            Precio = precio;
            ClaseVuelo = claseVuelo;
            TipoPasajero = tipoPasajero;
        }
    }
}
