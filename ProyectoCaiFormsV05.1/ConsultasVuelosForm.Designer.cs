namespace ProyectoCaiFormsV05._1
{
    partial class ConsultasVuelosForm
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblFechaIda = new System.Windows.Forms.Label();
            this.dateFechaIda = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVuelta = new System.Windows.Forms.Label();
            this.dateFechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadAdultos = new System.Windows.Forms.Label();
            this.numCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadMenores = new System.Windows.Forms.Label();
            this.numCantidadMenores = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadInfantes = new System.Windows.Forms.Label();
            this.numCantidadInfantes = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadMenores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadInfantes)).BeginInit();
            this.SuspendLayout();

            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(20, 20);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(250, 13);
            this.lblMensaje.Text = "Ingrese los siguientes datos para consultar vuelos:";

            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(20, 50);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.Text = "Origen";

            this.txtOrigen.Location = new System.Drawing.Point(120, 50);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(200, 20);

            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(20, 80);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.Text = "Destino";

            this.txtDestino.Location = new System.Drawing.Point(120, 80);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(200, 20);

            this.lblFechaIda.AutoSize = true;
            this.lblFechaIda.Location = new System.Drawing.Point(20, 110);
            this.lblFechaIda.Name = "lblFechaIda";
            this.lblFechaIda.Size = new System.Drawing.Size(52, 13);
            this.lblFechaIda.Text = "Fecha ida";

            this.dateFechaIda.Location = new System.Drawing.Point(120, 110);
            this.dateFechaIda.Name = "dateFechaIda";
            this.dateFechaIda.Size = new System.Drawing.Size(200, 20);

            this.lblFechaVuelta.AutoSize = true;
            this.lblFechaVuelta.Location = new System.Drawing.Point(20, 140);
            this.lblFechaVuelta.Name = "lblFechaVuelta";
            this.lblFechaVuelta.Size = new System.Drawing.Size(70, 13);
            this.lblFechaVuelta.Text = "Fecha vuelta";

            this.dateFechaVuelta.Location = new System.Drawing.Point(120, 140);
            this.dateFechaVuelta.Name = "dateFechaVuelta";
            this.dateFechaVuelta.Size = new System.Drawing.Size(200, 20);

            this.lblCantidadAdultos.AutoSize = true;
            this.lblCantidadAdultos.Location = new System.Drawing.Point(20, 170);
            this.lblCantidadAdultos.Name = "lblCantidadAdultos";
            this.lblCantidadAdultos.Size = new System.Drawing.Size(86, 13);
            this.lblCantidadAdultos.Text = "Cantidad adultos";

            this.numCantidadAdultos.Location = new System.Drawing.Point(120, 170);
            this.numCantidadAdultos.Name = "numCantidadAdultos";
            this.numCantidadAdultos.Size = new System.Drawing.Size(50, 20);

            this.lblCantidadMenores.AutoSize = true;
            this.lblCantidadMenores.Location = new System.Drawing.Point(20, 200);
            this.lblCantidadMenores.Name = "lblCantidadMenores";
            this.lblCantidadMenores.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadMenores.Text = "Cantidad menores";

            this.numCantidadMenores.Location = new System.Drawing.Point(120, 200);
            this.numCantidadMenores.Name = "numCantidadMenores";
            this.numCantidadMenores.Size = new System.Drawing.Size(50, 20);

            this.lblCantidadInfantes.AutoSize = true;
            this.lblCantidadInfantes.Location = new System.Drawing.Point(20, 230);
            this.lblCantidadInfantes.Name = "lblCantidadInfantes";
            this.lblCantidadInfantes.Size = new System.Drawing.Size(86, 13);
            this.lblCantidadInfantes.Text = "Cantidad infantes";

            this.numCantidadInfantes.Location = new System.Drawing.Point(120, 230);
            this.numCantidadInfantes.Name = "numCantidadInfantes";
            this.numCantidadInfantes.Size = new System.Drawing.Size(50, 20);

            this.btnBuscar.Location = new System.Drawing.Point(120, 260);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 310);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblFechaIda);
            this.Controls.Add(this.dateFechaIda);
            this.Controls.Add(this.lblFechaVuelta);
            this.Controls.Add(this.dateFechaVuelta);
            this.Controls.Add(this.lblCantidadAdultos);
            this.Controls.Add(this.numCantidadAdultos);
            this.Controls.Add(this.lblCantidadMenores);
            this.Controls.Add(this.numCantidadMenores);
            this.Controls.Add(this.lblCantidadInfantes);
            this.Controls.Add(this.numCantidadInfantes);
            this.Controls.Add(this.btnBuscar);
            this.Name = "ConsultasVuelosForm";
            this.Text = "Consultar disponibilidad de vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadMenores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadInfantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblFechaIda;
        private System.Windows.Forms.DateTimePicker dateFechaIda;
        private System.Windows.Forms.Label lblFechaVuelta;
        private System.Windows.Forms.DateTimePicker dateFechaVuelta;
        private System.Windows.Forms.Label lblCantidadAdultos;
        private System.Windows.Forms.NumericUpDown numCantidadAdultos;
        private System.Windows.Forms.Label lblCantidadMenores;
        private System.Windows.Forms.NumericUpDown numCantidadMenores;
        private System.Windows.Forms.Label lblCantidadInfantes;
        private System.Windows.Forms.NumericUpDown numCantidadInfantes;
        private System.Windows.Forms.Button btnBuscar;
    }
}