using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Entidades;
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
        private List<dynamic> seleccionados;

        public PresupuestoForm(List<dynamic> seleccionados)
        {
            InitializeComponent();
            this.seleccionados = seleccionados;
        }

        private void PresupuestoForm_Load(object sender, EventArgs e)
        {
            dgvPresupuesto.Columns.Add("colCodigo", "Código");
            dgvPresupuesto.Columns.Add("colTipo", "Tipo");
            dgvPresupuesto.Columns.Add("colDetalle", "Detalle");

            Random random = new Random();

            foreach (var seleccionado in seleccionados)
            {
                string codigo = random.Next(1000, 9999).ToString();
                string tipo = seleccionado is Vuelo ? "Vuelo" : "Alojamiento";
                string detalle = JsonConvert.SerializeObject(seleccionado);

                dgvPresupuesto.Rows.Add(codigo, tipo, detalle);
            }
        }

        private void btnFinalizarPresupuesto_Click(object sender, EventArgs e)
        {
            List<dynamic> presupuesto = new List<dynamic>();

            foreach (DataGridViewRow row in dgvPresupuesto.Rows)
            {
                string tipo = row.Cells["colTipo"].Value.ToString();
                string detalle = row.Cells["colDetalle"].Value.ToString();

                if (tipo == "Vuelo")
                {
                    presupuesto.Add(JsonConvert.DeserializeObject<Vuelo>(detalle));
                }
                else if (tipo == "Alojamiento")
                {
                    presupuesto.Add(JsonConvert.DeserializeObject<Alojamiento>(detalle));
                }
            }

            string presupuestoJson = JsonConvert.SerializeObject(presupuesto, Formatting.Indented);

            File.WriteAllText("Presupuesto.json", presupuestoJson);

            MessageBox.Show("Presupuesto finalizado y guardado en Presupuesto.json.");
            this.Close();
        }
    }
}
