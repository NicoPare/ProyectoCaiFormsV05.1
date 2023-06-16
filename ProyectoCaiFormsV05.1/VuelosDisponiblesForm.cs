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
    public partial class VuelosDisponiblesForm : Form
    {
        public VuelosDisponiblesForm(List<dynamic> vuelosDisponibles)
        {
            InitializeComponent();

            // Mostrar los vuelos disponibles en la lista
            foreach (var vuelo in vuelosDisponibles)
            {
                string vueloInfo = $"Código de vuelo: {vuelo.CodVuelo}\n" +
                    $"Origen: {vuelo.Origen}\n" +
                    $"Destino: {vuelo.Destino}\n" +
                    $"Fecha y hora de salida: {vuelo.FechaHoraSalida}\n" +
                    $"Fecha y hora de arribo: {vuelo.FechaHoraArribo}\n" +
                    $"Aerolínea: {vuelo.Aerolinea}\n" +
                    "Tarifas:\n";

                foreach (var tarifa in vuelo.Tarifas)
                {
                    string tarifaInfo = $"  Precio: {tarifa.Precio}\n" +
                        $"  Clase de vuelo: {tarifa.ClaseVuelo}\n" +
                        $"  Tipo de pasajero: {tarifa.TipoPasajero}\n";
                    vueloInfo += tarifaInfo;
                }

                lstVuelosDisponibles.Items.Add(vueloInfo);
                lstVuelosDisponibles.Items.Add("=====================================");
            }
        }
    }
}
