namespace ProyectoCaiFormsV05._1
{
    partial class Form1
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
            this.btnConsultarVuelos = new System.Windows.Forms.Button();
            this.btnConsultarAlojamientos = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnConsultarVuelos.Location = new System.Drawing.Point(50, 50);
            this.btnConsultarVuelos.Name = "btnConsultarVuelos";
            this.btnConsultarVuelos.Size = new System.Drawing.Size(200, 30);
            this.btnConsultarVuelos.Text = "Consultar disponibilidad de vuelos";
            this.btnConsultarVuelos.UseVisualStyleBackColor = true;
            this.btnConsultarVuelos.Click += new System.EventHandler(this.btnConsultarVuelos_Click);

            this.btnConsultarAlojamientos.Location = new System.Drawing.Point(50, 100);
            this.btnConsultarAlojamientos.Name = "btnConsultarAlojamientos";
            this.btnConsultarAlojamientos.Size = new System.Drawing.Size(200, 30);
            this.btnConsultarAlojamientos.Text = "Consultar disponibilidad de alojamientos";
            this.btnConsultarAlojamientos.UseVisualStyleBackColor = true;
            this.btnConsultarAlojamientos.Click += new System.EventHandler(this.btnConsultarAlojamientos_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnConsultarVuelos);
            this.Controls.Add(this.btnConsultarAlojamientos);
            this.Name = "Form1";
            this.Text = "Formulario principal";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnConsultarVuelos;
        private System.Windows.Forms.Button btnConsultarAlojamientos;
    }
}