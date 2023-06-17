namespace ProyectoCaiFormsV05._1
{
    partial class PresupuestoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstPresupuesto;

        private void InitializeComponent()
        {
            this.lstPresupuesto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPresupuesto
            // 
            this.lstPresupuesto.FormattingEnabled = true;
            this.lstPresupuesto.Location = new System.Drawing.Point(12, 12);
            this.lstPresupuesto.Name = "lstPresupuesto";
            this.lstPresupuesto.Size = new System.Drawing.Size(400, 238);
            this.lstPresupuesto.TabIndex = 0;
            // 
            // PresupuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.lstPresupuesto);
            this.Name = "PresupuestoForm";
            this.Text = "Presupuesto";
            this.ResumeLayout(false);
        }
    }

}