namespace GranjaPorcinaa
{
    partial class Forinicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butCerditos = new System.Windows.Forms.Button();
            this.butVacunas = new System.Windows.Forms.Button();
            this.butVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCerditos
            // 
            this.butCerditos.Location = new System.Drawing.Point(2, 53);
            this.butCerditos.Name = "butCerditos";
            this.butCerditos.Size = new System.Drawing.Size(192, 104);
            this.butCerditos.TabIndex = 0;
            this.butCerditos.Text = "Cerditos";
            this.butCerditos.UseVisualStyleBackColor = true;
            this.butCerditos.Click += new System.EventHandler(this.butCerditos_Click);
            // 
            // butVacunas
            // 
            this.butVacunas.Location = new System.Drawing.Point(200, 53);
            this.butVacunas.Name = "butVacunas";
            this.butVacunas.Size = new System.Drawing.Size(179, 104);
            this.butVacunas.TabIndex = 1;
            this.butVacunas.Text = "Vacunas ";
            this.butVacunas.UseVisualStyleBackColor = true;
            this.butVacunas.Click += new System.EventHandler(this.butVacunas_Click);
            // 
            // butVentas
            // 
            this.butVentas.Location = new System.Drawing.Point(385, 53);
            this.butVentas.Name = "butVentas";
            this.butVentas.Size = new System.Drawing.Size(182, 104);
            this.butVentas.TabIndex = 2;
            this.butVentas.Text = "Ventas ";
            this.butVentas.UseVisualStyleBackColor = true;
            this.butVentas.Click += new System.EventHandler(this.butVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "FORMULARIOS";
            // 
            // Forinicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butVentas);
            this.Controls.Add(this.butVacunas);
            this.Controls.Add(this.butCerditos);
            this.Name = "Forinicio";
            this.Text = "Forinicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button butCerditos;
        private Button butVacunas;
        private Button butVentas;
        private Label label1;
    }
}