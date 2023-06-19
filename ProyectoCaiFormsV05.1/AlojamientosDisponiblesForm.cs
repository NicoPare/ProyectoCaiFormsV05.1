using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCaiFormsV05._1
{

    public partial class AlojamientosDisponiblesForm : Form
    {
        private List<dynamic> alojamientosDisponibles;
        private List<PresupuestoLineaAlojamiento> presupuestoLineaAlojamiento;

        

        public AlojamientosDisponiblesForm(List<dynamic> alojamientosDisponibles)
        {
            InitializeComponent();
            this.alojamientosDisponibles = alojamientosDisponibles;
            presupuestoLineaAlojamiento = new List<PresupuestoLineaAlojamiento>();
            ConfigureDataGridView();
            PopulateDataGridView();

        }

        private void ConfigureDataGridView()
        {
            dgvAlojamientosDisponibles.Columns.Add("CodCiudad", "CodCiudad");
            dgvAlojamientosDisponibles.Columns.Add("FechaIngreso", "FechaIngreso");
            dgvAlojamientosDisponibles.Columns.Add("FechaEgreso", "FechaEgreso");
            dgvAlojamientosDisponibles.Columns.Add("NombreAlojamiento", "NombreAlojamiento");
            dgvAlojamientosDisponibles.Columns.Add("Tarifa", "Tarifa");
            dgvAlojamientosDisponibles.Columns.Add("NombreHabitacion", "NombreHabitacion");
            dgvAlojamientosDisponibles.Columns.Add("Calificacion", "Calificacion");
        }

        private void PopulateDataGridView()
        {
            foreach (var alojamiento in alojamientosDisponibles)
            {
                dgvAlojamientosDisponibles.Rows.Add(
                    alojamiento.CodCiudad,
                    alojamiento.FechaIngreso.ToString("dd/MM/yyy"),
                    alojamiento.FechaSalida.ToString("dd/MM/yyy"),
                    alojamiento.NombreAlojamiento,
                    alojamiento.Tarifa,
                    alojamiento.NombreHabitacion,
                    alojamiento.Calificacion
                    );
            }

        }

        public void btnAgregarAlPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvAlojamientosDisponibles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAlojamientosDisponibles.SelectedRows[0];
                PresupuestoLineaAlojamiento lineaAlojamiento = new PresupuestoLineaAlojamiento(
                    selectedRow.Cells["CodCiudad"].Value.ToString(),
                    DateTime.Parse(selectedRow.Cells["FechaIngreso"].Value.ToString()),
                    DateTime.Parse(selectedRow.Cells["FechaEgreso"].Value.ToString()),
                    selectedRow.Cells["NombreAlojamiento"].Value.ToString(),
                    decimal.Parse(selectedRow.Cells["Tarifa"].Value.ToString()),
                    selectedRow.Cells["NombreHabitacion"].Value.ToString(),
                    int.Parse(selectedRow.Cells["Calificacion"].Value.ToString())
                );

                presupuestoLineaAlojamiento.Add(lineaAlojamiento);
                MessageBox.Show("El alojamiento ha sido agregado al presupuesto.", "Alojamiento agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para agregar al presupuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public List<PresupuestoLineaAlojamiento> ObtenerLineasAlojamientoPresupuesto()
        {
            return presupuestoLineaAlojamiento;
        }



    }


}



    
    


