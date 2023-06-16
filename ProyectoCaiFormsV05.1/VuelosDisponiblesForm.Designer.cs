namespace ProyectoCaiFormsV05._1
{
    partial class VuelosDisponiblesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstVuelosDisponibles;

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
            this.lstVuelosDisponibles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVuelosDisponibles
            // 
            this.lstVuelosDisponibles.FormattingEnabled = true;
            this.lstVuelosDisponibles.ItemHeight = 16;
            this.lstVuelosDisponibles.Location = new System.Drawing.Point(12, 12);
            this.lstVuelosDisponibles.Name = "lstVuelosDisponibles";
            this.lstVuelosDisponibles.Size = new System.Drawing.Size(600, 388);
            this.lstVuelosDisponibles.TabIndex = 0;
            // 
            // VuelosDisponiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.lstVuelosDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VuelosDisponiblesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelos Disponibles";
            this.ResumeLayout(false);

        }
    }
}