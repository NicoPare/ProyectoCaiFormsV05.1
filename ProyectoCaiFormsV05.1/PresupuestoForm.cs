using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCaiFormsV05._1
{
    public partial class PresupuestoForm : Form
    {
        private List<PresupuestoLineaVuelo> presupuestoLineaVuelo;

        public PresupuestoForm(List<PresupuestoLineaVuelo> presupuestoLineaVuelo)
        {
            InitializeComponent();
            this.presupuestoLineaVuelo = presupuestoLineaVuelo;
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            foreach (var lineaVuelo in presupuestoLineaVuelo)
            {
                lstPresupuesto.Items.Add(lineaVuelo.ToString());
            }
        }
    }

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

        public PresupuestoLineaVuelo(string origen, string destino, DateTime fechaHoraSalida, DateTime fechaHoraArribo, string aerolinea, decimal precio, string claseVuelo, string tipoPasajero)
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

        public override string ToString()
        {
            return $"Origen: {Origen}, Destino: {Destino}, Fecha de Salida: {FechaHoraSalida}, Fecha de Arribo: {FechaHoraArribo}, Aerolínea: {Aerolinea}, Precio: {Precio}, Clase de Vuelo: {ClaseVuelo}, Tipo de Pasajero: {TipoPasajero}";
        }
    }
}
