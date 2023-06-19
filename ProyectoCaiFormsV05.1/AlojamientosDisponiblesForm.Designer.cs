namespace ProyectoCaiFormsV05._1
{
 
    partial class AlojamientosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAlojamientosDisponibles;
        private System.Windows.Forms.Button btnAgregarAlPresupuesto;
        //private System.Windows.Forms.Button btnVerPresupuesto;


        private void InitializeComponent()
        {
            this.dgvAlojamientosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlPresupuesto = new System.Windows.Forms.Button();
            //this.btnVerPresupuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientosDisponibles)).BeginInit();
            this.SuspendLayout();

            
            // dgvAlojamientosDisponibles
            
            this.dgvAlojamientosDisponibles.AllowUserToAddRows = false;
            this.dgvAlojamientosDisponibles.AllowUserToDeleteRows = false;
            this.dgvAlojamientosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamientosDisponibles.Location = new System.Drawing.Point(12, 12);
            this.dgvAlojamientosDisponibles.Name = "dgvAlojamientosDisponibles";
            this.dgvAlojamientosDisponibles.ReadOnly = true;
            this.dgvAlojamientosDisponibles.Size = new System.Drawing.Size(600, 300);
            this.dgvAlojamientosDisponibles.TabIndex = 0;

            
            // btnAgregarAlPresupuesto
            
            this.btnAgregarAlPresupuesto.Location = new System.Drawing.Point(12, 328);
            this.btnAgregarAlPresupuesto.Name = "btnAgregarAlPresupuesto";
            this.btnAgregarAlPresupuesto.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarAlPresupuesto.TabIndex = 1;
            this.btnAgregarAlPresupuesto.Text = "Agregar al Presupuesto";
            this.btnAgregarAlPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarAlPresupuesto.Click += new System.EventHandler(this.btnAgregarAlPresupuesto_Click);

            
            // dgvAlojamientosDisponibles
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 371);            
            this.Controls.Add(this.btnAgregarAlPresupuesto);
            //this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.dgvAlojamientosDisponibles);
            this.Name = "AlojamientosDisponiblesForm";
            this.Text = "Alojamientos Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientosDisponibles)).EndInit();
            this.ResumeLayout(false);


        }


    }

}