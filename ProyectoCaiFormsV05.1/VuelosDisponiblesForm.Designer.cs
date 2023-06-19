namespace ProyectoCaiFormsV05._1
{
    
    partial class VuelosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvVuelosDisponibles;
        private System.Windows.Forms.Button btnAgregarAlPresupuesto;
        private System.Windows.Forms.Button btnVerPresupuesto;

        private void InitializeComponent()
        {
            this.dgvVuelosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlPresupuesto = new System.Windows.Forms.Button();
            this.btnVerPresupuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosDisponibles)).BeginInit();
            this.SuspendLayout();
            
            // dgvVuelosDisponibles
            
            this.dgvVuelosDisponibles.AllowUserToAddRows = false;
            this.dgvVuelosDisponibles.AllowUserToDeleteRows = false;
            this.dgvVuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelosDisponibles.Location = new System.Drawing.Point(12, 12);
            this.dgvVuelosDisponibles.Name = "dgvVuelosDisponibles";
            this.dgvVuelosDisponibles.ReadOnly = true;
            this.dgvVuelosDisponibles.Size = new System.Drawing.Size(600, 300);
            this.dgvVuelosDisponibles.TabIndex = 0;
            
            // btnAgregarAlPresupuesto
            
            this.btnAgregarAlPresupuesto.Location = new System.Drawing.Point(12, 328);
            this.btnAgregarAlPresupuesto.Name = "btnAgregarAlPresupuesto";
            this.btnAgregarAlPresupuesto.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarAlPresupuesto.TabIndex = 1;
            this.btnAgregarAlPresupuesto.Text = "Agregar al Presupuesto";
            this.btnAgregarAlPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarAlPresupuesto.Click += new System.EventHandler(this.btnAgregarAlPresupuesto_Click);
            
            // btnVerPresupuesto
            
            this.btnVerPresupuesto.Location = new System.Drawing.Point(168, 328);
            this.btnVerPresupuesto.Name = "btnVerPresupuesto";
            this.btnVerPresupuesto.Size = new System.Drawing.Size(150, 30);
            this.btnVerPresupuesto.TabIndex = 2;
            this.btnVerPresupuesto.Text = "Ver Presupuesto";
            this.btnVerPresupuesto.UseVisualStyleBackColor = true;
            this.btnVerPresupuesto.Click += new System.EventHandler(this.btnVerPresupuesto_Click);
            
            // VuelosDisponiblesForm
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 371);
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.btnAgregarAlPresupuesto);
            this.Controls.Add(this.dgvVuelosDisponibles);
            this.Name = "VuelosDisponiblesForm";
            this.Text = "Vuelos Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelosDisponibles)).EndInit();
            this.ResumeLayout(false);
        }
    }


}