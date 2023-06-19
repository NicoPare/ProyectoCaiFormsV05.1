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
        private Cliente cliente;

        public Cliente GetCliente()
        {
            return cliente;
        }

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


            // Realizar las validaciones utilizando la clase "Validaciones"

            if (!Validaciones.ValidarNombreApellido(nombre, apellido))
            {
                MessageBox.Show("El nombre o apellido ingresado no es válido. Por favor vuelva a intentarlo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validaciones.ValidarPais(paisResidencia))
            {
                MessageBox.Show("El país ingresado no es valido. Por favor, ingrese revisando la ortografía del país ingresado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validaciones.ValidarTipoDocumento(tipoDocumento))
            {
                MessageBox.Show("El tipo de documento no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
            int documento;
            if (!int.TryParse(documentoText, out documento) || !Validaciones.ValidarDocumento(documento.ToString()))
            {
                MessageBox.Show("El número de documento ingresado no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            int documento;
            if (!int.TryParse(documentoText, out documento))
            {
                MessageBox.Show("El campo 'documento' debe ser un número entero válido.");
                return;
            }


            if (!Validaciones.ValidarFechaNacimiento(fechaNacimiento.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("La fecha de nacimiento no es válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validaciones.ValidarCorreoElectronico(mail))
            {
                MessageBox.Show("La direccion de correo electronico no es valida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validaciones.ValidarNumeroCelular(celular))
            {
                MessageBox.Show("El numero de celular no es valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Cliente nuevoCliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                TipoDocumento = tipoDocumento,
                Documento = documento,
                Email = mail
                
            };

            
            ModuloCliente.GenerarNuevoCliente(nuevoCliente);


            // Cierra el formulario "PresupuestoClienteForm"
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }

}
