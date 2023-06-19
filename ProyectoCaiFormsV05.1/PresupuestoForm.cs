using ProyectoCaiFormsV05._1.Archivos;
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
    public partial class PresupuestoForm : Form
    {
        private List<PresupuestoLineaVuelo> presupuestoLineaVuelo;
        //private List<PresupuestoLineaAlojamiento> presupuestoLineaAlojamientos;//adicion


        private List<Presupuesto> presupuestos;

        public PresupuestoForm(List<PresupuestoLineaVuelo> presupuestoLineaVuelo)
        {
            InitializeComponent();
            this.presupuestoLineaVuelo = presupuestoLineaVuelo;
            //this.presupuestoLineaAlojamientos = presupuestoLineaAlojamientos;//adicion
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Codigo", "Código línea presupuesto");
            dataGridView1.Columns.Add("Origen", "Origen");
            dataGridView1.Columns.Add("Destino", "Destino");
            dataGridView1.Columns.Add("FechaHoraSalida", "Fecha de Salida");
            dataGridView1.Columns.Add("FechaHoraArribo", "Fecha de Arribo");
            dataGridView1.Columns.Add("Aerolinea", "Aerolínea");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("ClaseVuelo", "Clase de Vuelo");
            dataGridView1.Columns.Add("TipoPasajero", "Tipo de Pasajero");

            foreach (var lineaVuelo in presupuestoLineaVuelo)
            {
                string codigo = GenerateUniqueCode();
                dataGridView1.Rows.Add(codigo, lineaVuelo.Origen, lineaVuelo.Destino, lineaVuelo.FechaHoraSalida,
                    lineaVuelo.FechaHoraArribo, lineaVuelo.Aerolinea, lineaVuelo.Precio, lineaVuelo.ClaseVuelo, lineaVuelo.TipoPasajero);
            }            

        }



        private string GenerateUniqueCode()
        {
            const string prefix = "PLV-";
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int maxLength = 15;
            var random = new Random();
            var code = new StringBuilder(prefix);

            for (int i = 0; i < maxLength - prefix.Length; i++)
            {
                int index = random.Next(0, characters.Length);
                code.Append(characters[index]);
            }

            return code.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            PresupuestoClienteForm presupuestoClienteForm = new PresupuestoClienteForm();
            presupuestoClienteForm.FormClosed += PresupuestoClienteForm_FormClosed;
            presupuestoClienteForm.ShowDialog();
        }

        //Creo Presupuesto luego de que se Guarde el cliente en PresupuestoClienteForm
        private void PresupuestoClienteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PresupuestoClienteForm presupuestoClienteForm = (PresupuestoClienteForm)sender;

            if (presupuestoClienteForm.DialogResult == DialogResult.OK)
            {
                Cliente nuevoCliente = presupuestoClienteForm.GetCliente();
                presupuestos = ModuloPresupuestos.CrearPresupuesto(presupuestoLineaVuelo, nuevoCliente);
                PresupuestosArchivo.GuardarTodos(presupuestos);
            }
        }


    }


}
