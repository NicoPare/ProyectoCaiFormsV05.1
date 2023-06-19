namespace ProyectoCaiFormsV05._1
{
    /*
    partial class AlojamientosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAlojamientos;
        private System.Windows.Forms.Button btnAgregarAlPresupuesto;//adicion



        private void InitializeComponent()
        {
            this.dgvAlojamientos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlPresupuesto = new System.Windows.Forms.Button();//adicion
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
            // 
            // btnAgregarAlPresupuesto
            // 
            this.btnAgregarAlPresupuesto.Location = new System.Drawing.Point(12, 460);
            this.btnAgregarAlPresupuesto.Name = "btnAgregarAlPresupuesto";
            this.btnAgregarAlPresupuesto.Size = new System.Drawing.Size(120, 30);
            this.btnAgregarAlPresupuesto.TabIndex = 1;
            this.btnAgregarAlPresupuesto.Text = "Agregar al Presupuesto";
            this.btnAgregarAlPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarAlPresupuesto.Click += new System.EventHandler(this.btnAgregarAlPresupuesto_Click);

            // ... código existente ...

            this.Controls.Add(this.btnAgregarAlPresupuesto); // Agregado




        }



    }
    */

    /*
    partial class AlojamientosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAlojamientos;
        private System.Windows.Forms.Button btnAgregarAlPresupuesto;

        private void InitializeComponent()
        {

            this.dgvAlojamientos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlPresupuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientos)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvAlojamientos
            // 
            this.dgvAlojamientos.AllowUserToAddRows = false;
            this.dgvAlojamientos.AllowUserToDeleteRows = false;
            this.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamientos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlojamientos.Name = "dgvAlojamientos";
            this.dgvAlojamientos.ReadOnly = true;
            this.dgvAlojamientos.Size = new System.Drawing.Size(600, 300);
            this.dgvAlojamientos.TabIndex = 0;
            // 
            // AlojamientosDisponiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 371);
            //this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.btnAgregarAlPresupuesto);
            this.Controls.Add(this.dgvAlojamientos);
            this.Name = "dgvAlojamientos";
            this.Text = "Alojamientos Disponibles";
            this.Load += new System.EventHandler(this.AlojamientosDisponiblesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientos)).EndInit();
            this.ResumeLayout(false);

            // 
            // btnAgregarAlPresupuesto
            // 
            this.btnAgregarAlPresupuesto.Location = new System.Drawing.Point(12, 328);
            this.btnAgregarAlPresupuesto.Name = "btnAgregarAlPresupuesto";
            this.btnAgregarAlPresupuesto.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarAlPresupuesto.TabIndex = 1;
            this.btnAgregarAlPresupuesto.Text = "Agregar al Presupuesto";
            this.btnAgregarAlPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarAlPresupuesto.Click += new System.EventHandler(this.btnAgregarAlPresupuesto_Click);

        }

    }*/



    //NUEVO CODIGO
    partial class AlojamientosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAlojamientosDisponibles;
        private System.Windows.Forms.Button btnAgregarAlPresupuesto;


        private void InitializeComponent()
        {
            this.dgvAlojamientosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnAgregarAlPresupuesto = new System.Windows.Forms.Button();            
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientosDisponibles)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvAlojamientosDisponibles
            // 
            this.dgvAlojamientosDisponibles.AllowUserToAddRows = false;
            this.dgvAlojamientosDisponibles.AllowUserToDeleteRows = false;
            this.dgvAlojamientosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlojamientosDisponibles.Location = new System.Drawing.Point(12, 12);
            this.dgvAlojamientosDisponibles.Name = "dgvAlojamientosDisponibles";
            this.dgvAlojamientosDisponibles.ReadOnly = true;
            this.dgvAlojamientosDisponibles.Size = new System.Drawing.Size(600, 300);
            this.dgvAlojamientosDisponibles.TabIndex = 0;

            // 
            // btnAgregarAlPresupuesto
            // 
            this.btnAgregarAlPresupuesto.Location = new System.Drawing.Point(12, 328);
            this.btnAgregarAlPresupuesto.Name = "btnAgregarAlPresupuesto";
            this.btnAgregarAlPresupuesto.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarAlPresupuesto.TabIndex = 1;
            this.btnAgregarAlPresupuesto.Text = "Agregar al Presupuesto";
            this.btnAgregarAlPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarAlPresupuesto.Click += new System.EventHandler(this.btnAgregarAlPresupuesto_Click);

            // 
            // dgvAlojamientosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 371);            
            this.Controls.Add(this.btnAgregarAlPresupuesto);
            this.Controls.Add(this.dgvAlojamientosDisponibles);
            this.Name = "AlojamientosDisponiblesForm";
            this.Text = "Alojamientos Disponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlojamientosDisponibles)).EndInit();
            this.ResumeLayout(false);


        }


    }

}