using ProyectoCaiFormsV05._1.Modulos;

namespace ProyectoCaiFormsV05._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // CARGO DATOS EN Productos.json
            ModuloProductos moduloProductos = new ModuloProductos();

            moduloProductos.ProcesarVuelosYAlojamientos();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}