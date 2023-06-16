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

            // Configurar las columnas del DataGridView
            dgvVuelosDisponibles.Columns.Add("Origen", "Origen");
            dgvVuelosDisponibles.Columns.Add("Destino", "Destino");
            dgvVuelosDisponibles.Columns.Add("FechaHoraSalida", "Fecha y Hora de Salida");
            dgvVuelosDisponibles.Columns.Add("FechaHoraArribo", "Fecha y Hora de Arribo");
            dgvVuelosDisponibles.Columns.Add("Aerolinea", "Aerolínea");
            dgvVuelosDisponibles.Columns.Add("Precio", "Precio");
            dgvVuelosDisponibles.Columns.Add("ClaseVuelo", "Clase de Vuelo");
            dgvVuelosDisponibles.Columns.Add("TipoPasajero", "Tipo de Pasajero");

            // Mostrar los vuelos disponibles en el DataGridView
            foreach (var vuelo in vuelosDisponibles)
            {
                foreach (var tarifa in vuelo.Tarifas)
                {
                    dgvVuelosDisponibles.Rows.Add(
                        vuelo.Origen,
                        vuelo.Destino,
                        vuelo.FechaHoraSalida,
                        vuelo.FechaHoraArribo,
                        vuelo.Aerolinea,
                        tarifa.Precio,
                        tarifa.ClaseVuelo,
                        tarifa.TipoPasajero
                    );
                }
            }
        }
    }
}
