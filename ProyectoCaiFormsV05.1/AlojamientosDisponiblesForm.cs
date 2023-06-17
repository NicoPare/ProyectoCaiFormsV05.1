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
            dgvAlojamientos.Columns.Add("colCodCiudad", "CodCiudad");
            dgvAlojamientos.Columns.Add("colFechaIngreso", "Fecha Ingreso");
            dgvAlojamientos.Columns.Add("colFechaEgreso", "Fecha Egreso");
            dgvAlojamientos.Columns.Add("colNombreAlojamiento", "Nombre Alojamiento");
            dgvAlojamientos.Columns.Add("colTarifa", "Tarifa habitación por noche");
            dgvAlojamientos.Columns.Add("colHabitacion", "Habitación");
            dgvAlojamientos.Columns.Add("colCalificacion", "Calificacion");

            foreach (var alojamiento in alojamientos)
            {
                string codCiudad = alojamiento.CodCiudad;
                DateTime fechaIngreso = alojamiento.FechaIngreso;
                DateTime fechaEgreso = alojamiento.FechaSalida;
                string nombreAlojamiento = alojamiento.NombreAlojamiento;
                decimal tarifa = alojamiento.Tarifa;
                string habitacion = alojamiento.NombreHabitacion;
                int calificacion = alojamiento.Calificacion;

                dgvAlojamientos.Rows.Add(codCiudad, fechaIngreso.ToString("yyyy-MM-dd"), fechaEgreso.ToString("yyyy-MM-dd"),
                    nombreAlojamiento, tarifa.ToString("C"), habitacion, calificacion.ToString());
            }
        }
        


    }
    


}