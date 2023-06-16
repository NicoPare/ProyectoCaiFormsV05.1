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
    public partial class AlojamientosDisponiblesForm : Form
    {
        private List<dynamic> alojamientos;

        public AlojamientosDisponiblesForm(List<dynamic> alojamientos)
        {
            InitializeComponent();
            this.alojamientos = alojamientos;
        }

        private void AlojamientosDisponiblesForm_Load(object sender, EventArgs e)
        {
            foreach (var alojamiento in alojamientos)
            {
                string codCiudad = alojamiento.CodCiudad;
                DateTime fechaIngreso = alojamiento.FechaIngreso;
                DateTime fechaEgreso = alojamiento.FechaSalida;
                string nombreAlojamiento = alojamiento.NombreAlojamiento;
                decimal tarifa = alojamiento.Tarifa;
                string habitacion = alojamiento.NombreHabitacion;
                int calificacion = alojamiento.Calificacion;

                ListViewItem item = new ListViewItem(codCiudad);
                item.SubItems.Add(fechaIngreso.ToString("yyyy-MM-dd"));
                item.SubItems.Add(fechaEgreso.ToString("yyyy-MM-dd"));
                item.SubItems.Add(nombreAlojamiento);
                item.SubItems.Add(tarifa.ToString("C"));
                item.SubItems.Add(habitacion);
                item.SubItems.Add(calificacion.ToString());

                lstAlojamientos.Items.Add(item);
            }
        }
    }
}