
namespace WindowsFormsApp83
{
    partial class frmNumeros
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.generarButton = new System.Windows.Forms.Button();
            this.numerosListBox = new System.Windows.Forms.ListBox();
            this.estadisticasButton = new System.Windows.Forms.Button();
            this.reiniciarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generarButton
            // 
            this.generarButton.Location = new System.Drawing.Point(38, 16);
            this.generarButton.Name = "generarButton";
            this.generarButton.Size = new System.Drawing.Size(100, 54);
            this.generarButton.TabIndex = 0;
            this.generarButton.Text = "Generar";
            this.generarButton.UseVisualStyleBackColor = true;
            this.generarButton.Click += new System.EventHandler(this.generarButton_Click);
            // 
            // numerosListBox
            // 
            this.numerosListBox.FormattingEnabled = true;
            this.numerosListBox.Location = new System.Drawing.Point(38, 88);
            this.numerosListBox.Name = "numerosListBox";
            this.numerosListBox.Size = new System.Drawing.Size(100, 355);
            this.numerosListBox.TabIndex = 1;
            // 
            // estadisticasButton
            // 
            this.estadisticasButton.Enabled = false;
            this.estadisticasButton.Location = new System.Drawing.Point(38, 461);
            this.estadisticasButton.Name = "estadisticasButton";
            this.estadisticasButton.Size = new System.Drawing.Size(100, 54);
            this.estadisticasButton.TabIndex = 0;
            this.estadisticasButton.Text = "Estadísticas";
            this.estadisticasButton.UseVisualStyleBackColor = true;
            this.estadisticasButton.Click += new System.EventHandler(this.estadisticasButton_Click);
            // 
            // reiniciarButton
            // 
            this.reiniciarButton.Location = new System.Drawing.Point(38, 521);
            this.reiniciarButton.Name = "reiniciarButton";
            this.reiniciarButton.Size = new System.Drawing.Size(100, 54);
            this.reiniciarButton.TabIndex = 0;
            this.reiniciarButton.Text = "Reiniciar";
            this.reiniciarButton.UseVisualStyleBackColor = true;
            // 
            // frmNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 586);
            this.Controls.Add(this.numerosListBox);
            this.Controls.Add(this.reiniciarButton);
            this.Controls.Add(this.estadisticasButton);
            this.Controls.Add(this.generarButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(194, 625);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(194, 625);
            this.Name = "frmNumeros";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generarButton;
        private System.Windows.Forms.ListBox numerosListBox;
        private System.Windows.Forms.Button estadisticasButton;
        private System.Windows.Forms.Button reiniciarButton;
    }
}

