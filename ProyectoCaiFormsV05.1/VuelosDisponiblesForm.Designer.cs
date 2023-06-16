namespace ProyectoCaiFormsV05._1
{
    partial class VuelosDisponiblesForm
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
            this.dgvVuelosDisponibles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVuelosDisponibles
            // 
            this.dgvVuelosDisponibles.AllowUserToAddRows = false;
            this.dgvVuelosDisponibles.AllowUserToDeleteRows = false;
            this.dgvVuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelosDisponibles.Location = new System.Drawing.Point(12, 12);
            this.dgvVuelosDisponibles.Name = "dgvVuelosDisponibles";
            this.dgvVuelosDisponibles.ReadOnly = true;
            this.dgvVuelosDisponibles.Size = new System.Drawing.Size(600, 400);
            this.dgvVuelosDisponibles.TabIndex = 0;
            // 
            // VuelosDisponiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 424);
            this.Controls.Add(this.dgvVuelosDisponibles);
            this.Name = "VuelosDisponiblesForm";
            this.Text = "Vuelos Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvVuelosDisponibles;
    }
}