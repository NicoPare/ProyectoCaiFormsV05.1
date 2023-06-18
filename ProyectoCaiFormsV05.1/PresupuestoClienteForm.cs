using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCaiFormsV05._1.Entidades;
using ProyectoCaiFormsV05._1.Modulos;

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
            string documentoText = txtDocumento.Text;
            DateTime fechaNacimiento = dateFechaNacimiento.Value;
            string mail = txtMail.Text;
            string celular = txtCelular.Text;

            int documento;
            if (!int.TryParse(documentoText, out documento))
            {
                MessageBox.Show("El campo 'documento' debe ser un número entero válido.");
                return;
            }

            // Crear un objeto Cliente con los datos ingresados
            Cliente nuevoCliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                TipoDocumento = tipoDocumento,
                Documento = documento,
                Email = mail
                // Agrega aquí los demás campos que desees incluir en el cliente
            };

            // Llamar al método "GenerarNuevoCliente" de la clase "ModuloCliente"
            ModuloCliente.GenerarNuevoCliente(nuevoCliente);


            // Cierra el formulario "PresupuestoClienteForm"
            this.Close();
        }

    }

}
