namespace ProyectoCaiFormsV05._1
{
    partial class AlojamientosDisponiblesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lstAlojamientos;
        private System.Windows.Forms.ColumnHeader colCodCiudad;
        private System.Windows.Forms.ColumnHeader colFechaIngreso;
        private System.Windows.Forms.ColumnHeader colFechaEgreso;
        private System.Windows.Forms.ColumnHeader colNombreAlojamiento;
        private System.Windows.Forms.ColumnHeader colTarifa;
        private System.Windows.Forms.ColumnHeader colHabitacion;
        private System.Windows.Forms.ColumnHeader colCalificacion;

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
            this.lstAlojamientos = new System.Windows.Forms.ListView();
            this.colCodCiudad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaIngreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaEgreso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreAlojamiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTarifa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHabitacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCalificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstAlojamientos
            // 
            this.lstAlojamientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodCiudad,
            this.colFechaIngreso,
            this.colFechaEgreso,
            this.colNombreAlojamiento,
            this.colTarifa,
            this.colHabitacion,
            this.colCalificacion});
            this.lstAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlojamientos.FullRowSelect = true;
            this.lstAlojamientos.GridLines = true;
            this.lstAlojamientos.HideSelection = false;
            this.lstAlojamientos.Location = new System.Drawing.Point(0, 0);
            this.lstAlojamientos.Name = "lstAlojamientos";
            this.lstAlojamientos.Size = new System.Drawing.Size(800, 450);
            this.lstAlojamientos.TabIndex = 0;
            this.lstAlojamientos.UseCompatibleStateImageBehavior = false;
            this.lstAlojamientos.View = System.Windows.Forms.View.Details;
            // 
            // colCodCiudad
            // 
            this.colCodCiudad.Text = "CodCiudad";
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.Text = "Fecha Ingreso";
            // 
            // colFechaEgreso
            // 
            this.colFechaEgreso.Text = "Fecha Egreso";
            // 
            // colNombreAlojamiento
            // 
            this.colNombreAlojamiento.Text = "Nombre Alojamiento";
            // 
            // colTarifa
            // 
            this.colTarifa.Text = "Tarifa habitación por noche";
            // 
            // colHabitacion
            // 
            this.colHabitacion.Text = "Habitación";
            // 
            // colCalificacion
            // 
            this.colCalificacion.Text = "Calificacion";
            // 
            // AlojamientosDisponiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAlojamientos);
            this.Name = "AlojamientosDisponiblesForm";
            this.Text = "Alojamientos Disponibles";
            this.Load += new System.EventHandler(this.AlojamientosDisponiblesForm_Load);
            this.ResumeLayout(false);

        }

        
    }
}