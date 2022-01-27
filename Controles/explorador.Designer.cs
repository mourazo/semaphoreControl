namespace Controles
{
    partial class explorador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_fichero = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tb_fichero
            // 
            this.tb_fichero.Location = new System.Drawing.Point(13, 16);
            this.tb_fichero.Name = "tb_fichero";
            this.tb_fichero.Size = new System.Drawing.Size(254, 20);
            this.tb_fichero.TabIndex = 0;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar.Location = new System.Drawing.Point(273, 10);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(70, 31);
            this.bt_buscar.TabIndex = 1;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.Bt_buscar_Click);
            // 
            // abrir
            // 
            this.abrir.FileName = "openFileDialog1";
            // 
            // explorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_fichero);
            this.Name = "explorador";
            this.Size = new System.Drawing.Size(357, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fichero;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.OpenFileDialog abrir;
    }
}
