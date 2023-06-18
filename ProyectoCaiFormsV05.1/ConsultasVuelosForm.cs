using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;
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
    public partial class ConsultasVuelosForm : Form
    {
        public ConsultasVuelosForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string origen = txtOrigen.Text;
            string destino = txtDestino.Text;

            // Validar código de aeropuerto para el origen
            if (!Validaciones.ValidarCodigoAeropuerto(origen))
            {
                MessageBox.Show("Ciudad de origen sin disponibilidad de productos. Por favor, ingrese otra ciudad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar código de aeropuerto para el destino
            if (!Validaciones.ValidarCodigoAeropuerto(destino))
            {
                MessageBox.Show("Ciudad de destino sin disponibilidad de productos. Por favor, ingrese otra ciudad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaIda = dateFechaIda.Value;
            DateTime? fechaVuelta = dateFechaVuelta.Value;
            int cantidadAdultos = (int)numCantidadAdultos.Value;
            int cantidadMenores = (int)numCantidadMenores.Value;
            int cantidadInfantes = (int)numCantidadInfantes.Value;

            // Validar la fecha de ida
            if (!Validaciones.ValidarFecha(fechaIda.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Ha ingresado una fecha de ida anterior a la fecha de hoy. Por favor, ingrese una fecha de ida mayor o igual a la fecha de hoy.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la fecha de vuelta
            if (fechaVuelta != null && !Validaciones.ValidarFecha(fechaVuelta.Value.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Su fecha de vuelta debe ser mayor o igual a su fecha de ida. Por favor, ingrese nuevamente una fecha de vuelta.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar las fechas de ida y vuelta
            if (!Validaciones.ValidarFechas(fechaIda.ToString("yyyy-MM-dd"), fechaVuelta?.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Su fecha de vuelta debe ser mayor o igual a su fecha de ida. Por favor, ingrese nuevamente una fecha de vuelta.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la cantidad de pasajeros para vuelos
            if (!Validaciones.ValidarCantidadPasajerosVuelo(cantidadAdultos, cantidadMenores, cantidadInfantes))
            {
                MessageBox.Show("La cantidad de pasajeros adultos debe ser igual o mayor a la suma de menores e infantes.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ModuloProductos moduloProductos = new ModuloProductos();
            List<dynamic> vuelosDisponibles = moduloProductos.ConsultarVuelos(origen, destino, fechaIda, fechaVuelta, cantidadAdultos, cantidadMenores, cantidadInfantes);

            VuelosDisponiblesForm vuelosDisponiblesForm = new VuelosDisponiblesForm(vuelosDisponibles);
            vuelosDisponiblesForm.Show();
        }
    }
}