using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCaiFormsV05._1.Entidades;

namespace ProyectoCaiFormsV05._1
{

    public partial class VuelosDisponiblesForm : Form
    {
        private List<dynamic> vuelosDisponibles;
        private List<PresupuestoLineaVuelo> presupuestoLineaVuelo;

        public VuelosDisponiblesForm(List<dynamic> vuelosDisponibles)
        {
            InitializeComponent();
            this.vuelosDisponibles = vuelosDisponibles;
            presupuestoLineaVuelo = new List<PresupuestoLineaVuelo>();
            ConfigureDataGridView();
            PopulateDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvVuelosDisponibles.Columns.Add("Origen", "Origen");
            dgvVuelosDisponibles.Columns.Add("Destino", "Destino");
            dgvVuelosDisponibles.Columns.Add("FechaHoraSalida", "Fecha y Hora de Salida");
            dgvVuelosDisponibles.Columns.Add("FechaHoraArribo", "Fecha y Hora de Arribo");
            dgvVuelosDisponibles.Columns.Add("Aerolinea", "Aerolínea");
            dgvVuelosDisponibles.Columns.Add("Precio", "Precio");
            dgvVuelosDisponibles.Columns.Add("ClaseVuelo", "Clase de Vuelo");
            dgvVuelosDisponibles.Columns.Add("TipoPasajero", "Tipo de Pasajero");
        }

        private void PopulateDataGridView()
        {
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

        private void btnAgregarAlPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvVuelosDisponibles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVuelosDisponibles.SelectedRows[0];
                PresupuestoLineaVuelo lineaVuelo = new PresupuestoLineaVuelo(
                    selectedRow.Cells["Origen"].Value.ToString(),
                    selectedRow.Cells["Destino"].Value.ToString(),
                    DateTime.Parse(selectedRow.Cells["FechaHoraSalida"].Value.ToString()),
                    DateTime.Parse(selectedRow.Cells["FechaHoraArribo"].Value.ToString()),
                    selectedRow.Cells["Aerolinea"].Value.ToString(),
                    decimal.Parse(selectedRow.Cells["Precio"].Value.ToString()),
                    selectedRow.Cells["ClaseVuelo"].Value.ToString(),
                    selectedRow.Cells["TipoPasajero"].Value.ToString()
                );

                presupuestoLineaVuelo.Add(lineaVuelo);
                MessageBox.Show("El vuelo ha sido agregado al presupuesto.", "Vuelo agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para agregar al presupuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            PresupuestoForm presupuestoForm = new PresupuestoForm(presupuestoLineaVuelo/*, lineasAlojamiento*/);
            presupuestoForm.Show();
        }
    }

}