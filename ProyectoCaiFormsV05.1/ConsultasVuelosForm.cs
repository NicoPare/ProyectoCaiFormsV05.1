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
            DateTime fechaIda = dateFechaIda.Value;
            DateTime? fechaVuelta = dateFechaVuelta.Value;
            int cantidadAdultos = (int)numCantidadAdultos.Value;
            int cantidadMenores = (int)numCantidadMenores.Value;
            int cantidadInfantes = (int)numCantidadInfantes.Value;

            ModuloProductos moduloProductos = new ModuloProductos();
            List<dynamic> vuelosDisponibles = moduloProductos.ConsultarVuelos(origen, destino, fechaIda, fechaVuelta, cantidadAdultos, cantidadMenores, cantidadInfantes);

            VuelosDisponiblesForm vuelosDisponiblesForm = new VuelosDisponiblesForm(vuelosDisponibles);
            vuelosDisponiblesForm.Show();
        }
    }
}