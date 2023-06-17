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

            // Validar código de ciudad para el destino
            if (!Validaciones.ValidarCodigoCiudad(destino))
            {
                MessageBox.Show("Ciudad sin disponibilidad de productos. Por favor, ingrese otra ciudad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la fecha de ingreso
            if (!Validaciones.ValidarFecha(fechaIngreso.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Ha ingresado una fecha de ingreso anterior a la fecha de hoy, por favor ingrese una fecha de ingreso mayor o igual a la fecha de hoy.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la fecha de egreso
            if (!Validaciones.ValidarFecha(fechaEgreso.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Su fecha de egreso debe ser mayor o igual a su fecha de ingreso. Por favor, ingrese nuevamente una fecha de egreso.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar las fechas de ingreso y egreso
            if (!Validaciones.ValidarFechas(fechaIngreso.ToString("yyyy-MM-dd"), fechaEgreso.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Su fecha de egreso debe ser mayor o igual a su fecha de ingreso. Por favor, ingrese nuevamente una fecha de egreso.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la calificación
            if (!Validaciones.ValidarCalificacion(calificacion))
            {
                MessageBox.Show("Calificación fuera del rango correspondiente. Por favor, ingrese una calificación entre 1 y 5.", "Error de calificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar la cantidad de pasajeros adultos
            if (!Validaciones.ValidarCantidadPasajerosAdultos(cantidadAdultos))
            {
                MessageBox.Show("Debe ingresar al menos un pasajero adulto.", "Error de cantidad de pasajeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModuloProductos moduloProductos = new ModuloProductos();
            var alojamientosDisponibles = moduloProductos.ConsultarAlojamiento(destino, fechaIngreso, fechaEgreso, cantidadAdultos, cantidadMenores, cantidadInfantes, calificacion);

            AlojamientosDisponiblesForm alojamientosForm = new AlojamientosDisponiblesForm(alojamientosDisponibles);
            alojamientosForm.Show();
        }
    }
}