namespace GranjaPorcinaa
{
    partial class ForVacunas
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
            this.dateVacuna = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.texIdcer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texNomVacuna = new System.Windows.Forms.TextBox();
            this.butModificar = new System.Windows.Forms.Button();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvvacuna = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // dateVacuna
            // 
            this.dateVacuna.Location = new System.Drawing.Point(163, 135);
            this.dateVacuna.Name = "dateVacuna";
            this.dateVacuna.Size = new System.Drawing.Size(200, 23);
            this.dateVacuna.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Porcino:";
            // 
            // texIdcer
            // 
            this.texIdcer.Location = new System.Drawing.Point(163, 54);
            this.texIdcer.Name = "texIdcer";
            this.texIdcer.Size = new System.Drawing.Size(200, 23);
            this.texIdcer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de la vacuna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de la vacuna:";
            // 
            // texNomVacuna
            // 
            this.texNomVacuna.Location = new System.Drawing.Point(163, 97);
            this.texNomVacuna.Name = "texNomVacuna";
            this.texNomVacuna.Size = new System.Drawing.Size(200, 23);
            this.texNomVacuna.TabIndex = 5;
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(108, 176);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(75, 23);
            this.butModificar.TabIndex = 18;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(198, 176);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 17;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(288, 176);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(75, 23);
            this.butEliminar.TabIndex = 16;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(18, 176);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 15;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Vacunacion ";
            // 
            // dgvvacuna
            // 
            this.dgvvacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvacuna.Location = new System.Drawing.Point(18, 211);
            this.dgvvacuna.Name = "dgvvacuna";
            this.dgvvacuna.RowTemplate.Height = 25;
            this.dgvvacuna.Size = new System.Drawing.Size(345, 150);
            this.dgvvacuna.TabIndex = 20;
            this.dgvvacuna.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ForVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 373);
            this.Controls.Add(this.dgvvacuna);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.texNomVacuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texIdcer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateVacuna);
            this.Name = "ForVacunas";
            this.Text = "ForVacunas";
            this.Load += new System.EventHandler(this.ForVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateVacuna;
        private Label label1;
        private TextBox texIdcer;
        private Label label2;
        private Label label3;
        private TextBox texNomVacuna;
        private Button butModificar;
        private Button butLimpiar;
        private Button butEliminar;
        private Button butAgregar;
        private Label label4;
        private DataGridView dgvvacuna;
    }
}