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
                string ciudad = alojamiento.CodCiudad;
                DateTime fechaEntrada = alojamiento.FechaIngreso;
                DateTime fechaEgreso = alojamiento.FechaSalida;
                string nombre = alojamiento.NombreAlojamiento;
                decimal precioPorNoche = alojamiento.Tarifa;                

                ListViewItem item = new ListViewItem(ciudad);
                item.SubItems.Add(ciudad);
                item.SubItems.Add(precioPorNoche.ToString("C"));

                lstAlojamientos.Items.Add(item);
            }
        }
    }
}