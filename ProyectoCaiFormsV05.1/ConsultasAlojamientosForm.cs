using ProyectoCaiFormsV05._1.Modulos;
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
    public partial class ConsultasAlojamientosForm : Form
    {
        public ConsultasAlojamientosForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string destino = txtDestino.Text;
            DateTime fechaIngreso = dateFechaIngreso.Value;
            DateTime fechaEgreso = dateFechaEgreso.Value;
            int cantidadAdultos = (int)numCantidadAdultos.Value;
            int cantidadMenores = (int)numCantidadMenores.Value;
            int cantidadInfantes = (int)numCantidadInfantes.Value;
            int calificacion = (int)numCalificacion.Value;

            ModuloProductos moduloProductos = new ModuloProductos();
            var alojamientosDisponibles = moduloProductos.ConsultarAlojamiento(destino, fechaIngreso, fechaEgreso, cantidadAdultos, cantidadMenores, cantidadInfantes, calificacion);

            AlojamientosDisponiblesForm alojamientosForm = new AlojamientosDisponiblesForm(alojamientosDisponibles);
            alojamientosForm.Show();
        }
    }
}