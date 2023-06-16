namespace ProyectoCaiFormsV05._1
{
    partial class AlojamientosDisponiblesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstAlojamientos = new ListView();
            colNombre = new ColumnHeader();
            colDireccion = new ColumnHeader();
            colPrecioPorNoche = new ColumnHeader();
            SuspendLayout();
            // 
            // lstAlojamientos
            // 
            lstAlojamientos.Columns.AddRange(new ColumnHeader[] { colNombre, colDireccion, colPrecioPorNoche });
            lstAlojamientos.Dock = DockStyle.Fill;
            lstAlojamientos.FullRowSelect = true;
            lstAlojamientos.GridLines = true;
            lstAlojamientos.Location = new Point(0, 0);
            lstAlojamientos.Margin = new Padding(4, 3, 4, 3);
            lstAlojamientos.Name = "lstAlojamientos";
            lstAlojamientos.Size = new Size(612, 346);
            lstAlojamientos.TabIndex = 0;
            lstAlojamientos.UseCompatibleStateImageBehavior = false;
            lstAlojamientos.View = View.Details;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 150;
            // 
            // colDireccion
            // 
            colDireccion.Text = "Dirección";
            colDireccion.Width = 200;
            // 
            // colPrecioPorNoche
            // 
            colPrecioPorNoche.Text = "Precio por noche";
            colPrecioPorNoche.Width = 100;
            // 
            // AlojamientosDisponiblesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 346);
            Controls.Add(lstAlojamientos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AlojamientosDisponiblesForm";
            Text = "Alojamientos Disponibles";
            Load += AlojamientosDisponiblesForm_Load;
            ResumeLayout(false);
        }

        private ListView lstAlojamientos;
        private ColumnHeader colNombre;
        private ColumnHeader colDireccion;
        private ColumnHeader colPrecioPorNoche;
    }
}