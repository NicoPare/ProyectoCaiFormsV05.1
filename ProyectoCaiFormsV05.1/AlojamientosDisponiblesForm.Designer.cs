namespace ProyectoCaiFormsV05._1
{
    partial class AlojamientosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAlojamientos;

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
            this.dgvAlojamientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlojamientos
            // 
            this.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlojamientos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlojamientos.Name = "dgvAlojamientos";
            this.dgvAlojamientos.Size = new System.Drawing.Size(800, 450);
            this.dgvAlojamientos.TabIndex = 0;
            // 
            // AlojamientosDisponiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlojamientos);
            this.Name = "AlojamientosDisponiblesForm";
            this.Text = "Alojamientos Disponibles";
            this.Load += new System.EventHandler(this.AlojamientosDisponiblesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}