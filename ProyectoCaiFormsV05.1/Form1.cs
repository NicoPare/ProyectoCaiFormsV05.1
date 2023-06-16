namespace ProyectoCaiFormsV05._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultarVuelos_Click(object sender, EventArgs e)
        {
            ConsultasVuelosForm consultasVuelosForm = new ConsultasVuelosForm();
            consultasVuelosForm.Show();
        }

        private void btnConsultarAlojamientos_Click(object sender, EventArgs e)
        {
            ConsultasAlojamientosForm consultasAlojamientosForm = new ConsultasAlojamientosForm();
            consultasAlojamientosForm.Show();
        }
    }
}