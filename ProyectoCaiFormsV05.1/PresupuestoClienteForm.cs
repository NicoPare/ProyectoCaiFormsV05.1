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
    public partial class PresupuestoClienteForm : Form
    {
        public PresupuestoClienteForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string paisResidencia = txtPaisResidencia.Text;
            string tipoDocumento = txtTipoDocumento.Text;
            string documento = txtDocumento.Text;
            DateTime fechaNacimiento = dateFechaNacimiento.Value;
            string mail = txtMail.Text;
            string celular = txtCelular.Text;

            // Aquí puedes realizar la lógica necesaria con los datos ingresados por el usuario

            // Cierra el formulario "PresupuestoClienteForm"
            this.Close();
        }

    }

}
