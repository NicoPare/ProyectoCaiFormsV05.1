namespace ProyectoCaiFormsV05._1
{
    partial class ConsultasAlojamientosForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dateFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.dateFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadAdultos = new System.Windows.Forms.Label();
            this.numCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadMenores = new System.Windows.Forms.Label();
            this.numCantidadMenores = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadInfantes = new System.Windows.Forms.Label();
            this.numCantidadInfantes = new System.Windows.Forms.NumericUpDown();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.numCalificacion = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(234, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Ingrese los siguientes datos para consultar disponibilidad de alojamientos:";

            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(12, 35);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(45, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";

            this.txtDestino.Location = new System.Drawing.Point(90, 32);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(200, 20);
            this.txtDestino.TabIndex = 2;

            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(12, 61);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(80, 13);
            this.lblFechaIngreso.TabIndex = 3;
            this.lblFechaIngreso.Text = "Fecha ingreso:";

            this.dateFechaIngreso.Location = new System.Drawing.Point(90, 58);
            this.dateFechaIngreso.Name = "dateFechaIngreso";
            this.dateFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dateFechaIngreso.TabIndex = 4;

            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Location = new System.Drawing.Point(12, 87);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(76, 13);
            this.lblFechaEgreso.TabIndex = 5;
            this.lblFechaEgreso.Text = "Fecha egreso:";

            this.dateFechaEgreso.Location = new System.Drawing.Point(90, 84);
            this.dateFechaEgreso.Name = "dateFechaEgreso";
            this.dateFechaEgreso.Size = new System.Drawing.Size(200, 20);
            this.dateFechaEgreso.TabIndex = 6;

            this.lblCantidadAdultos.AutoSize = true;
            this.lblCantidadAdultos.Location = new System.Drawing.Point(12, 113);
            this.lblCantidadAdultos.Name = "lblCantidadAdultos";
            this.lblCantidadAdultos.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadAdultos.TabIndex = 7;
            this.lblCantidadAdultos.Text = "Cantidad adultos:";

            this.numCantidadAdultos.Location = new System.Drawing.Point(110, 111);
            this.numCantidadAdultos.Name = "numCantidadAdultos";
            this.numCantidadAdultos.Size = new System.Drawing.Size(45, 20);
            this.numCantidadAdultos.TabIndex = 8;

            this.lblCantidadMenores.AutoSize = true;
            this.lblCantidadMenores.Location = new System.Drawing.Point(161, 113);
            this.lblCantidadMenores.Name = "lblCantidadMenores";
            this.lblCantidadMenores.Size = new System.Drawing.Size(95, 13);
            this.lblCantidadMenores.TabIndex = 9;
            this.lblCantidadMenores.Text = "Cantidad menores:";

            this.numCantidadMenores.Location = new System.Drawing.Point(262, 111);
            this.numCantidadMenores.Name = "numCantidadMenores";
            this.numCantidadMenores.Size = new System.Drawing.Size(45, 20);
            this.numCantidadMenores.TabIndex = 10;

            this.lblCantidadInfantes.AutoSize = true;
            this.lblCantidadInfantes.Location = new System.Drawing.Point(12, 139);
            this.lblCantidadInfantes.Name = "lblCantidadInfantes";
            this.lblCantidadInfantes.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadInfantes.TabIndex = 11;
            this.lblCantidadInfantes.Text = "Cantidad infantes:";

            this.numCantidadInfantes.Location = new System.Drawing.Point(110, 137);
            this.numCantidadInfantes.Name = "numCantidadInfantes";
            this.numCantidadInfantes.Size = new System.Drawing.Size(45, 20);
            this.numCantidadInfantes.TabIndex = 12;

            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(161, 139);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(62, 13);
            this.lblCalificacion.TabIndex = 13;
            this.lblCalificacion.Text = "Calificación:";

            this.numCalificacion.Location = new System.Drawing.Point(229, 137);
            this.numCalificacion.Name = "numCalificacion";
            this.numCalificacion.Size = new System.Drawing.Size(45, 20);
            this.numCalificacion.TabIndex = 14;

            this.btnBuscar.Location = new System.Drawing.Point(215, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(/*304*/ 500, 450 /*205*/);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.numCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.numCantidadInfantes);
            this.Controls.Add(this.lblCantidadInfantes);
            this.Controls.Add(this.numCantidadMenores);
            this.Controls.Add(this.lblCantidadMenores);
            this.Controls.Add(this.numCantidadAdultos);
            this.Controls.Add(this.lblCantidadAdultos);
            this.Controls.Add(this.dateFechaEgreso);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.dateFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblMensaje);
            this.Name = "ConsultasAlojamientosForm";
            this.Text = "Consultas de Alojamientos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dateFechaIngreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.DateTimePicker dateFechaEgreso;
        private System.Windows.Forms.Label lblCantidadAdultos;
        private System.Windows.Forms.NumericUpDown numCantidadAdultos;
        private System.Windows.Forms.Label lblCantidadMenores;
        private System.Windows.Forms.NumericUpDown numCantidadMenores;
        private System.Windows.Forms.Label lblCantidadInfantes;
        private System.Windows.Forms.NumericUpDown numCantidadInfantes;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.NumericUpDown numCalificacion;
        private System.Windows.Forms.Button btnBuscar;
    }
}