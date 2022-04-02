namespace GranjaPorcinaa
{
    partial class ForCerditos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texNumcorral = new System.Windows.Forms.TextBox();
            this.texpeso = new System.Windows.Forms.TextBox();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.dgvCerditos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerditos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ceditos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de corral: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre del cerdito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(166, 41);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(200, 23);
            this.texNombre.TabIndex = 6;
            // 
            // texNumcorral
            // 
            this.texNumcorral.Location = new System.Drawing.Point(166, 75);
            this.texNumcorral.Name = "texNumcorral";
            this.texNumcorral.Size = new System.Drawing.Size(200, 23);
            this.texNumcorral.TabIndex = 7;
            // 
            // texpeso
            // 
            this.texpeso.Location = new System.Drawing.Point(166, 104);
            this.texpeso.Name = "texpeso";
            this.texpeso.Size = new System.Drawing.Size(200, 23);
            this.texpeso.TabIndex = 8;
            // 
            // dateIngreso
            // 
            this.dateIngreso.Location = new System.Drawing.Point(166, 134);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(200, 23);
            this.dateIngreso.TabIndex = 9;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(166, 164);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dateNacimiento.TabIndex = 10;
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(12, 193);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 11;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(104, 193);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(75, 23);
            this.butModificar.TabIndex = 12;
            this.butModificar.Text = "Modificar ";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(197, 193);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 13;
            this.butLimpiar.Text = "Limpiar ";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(291, 193);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(75, 23);
            this.butEliminar.TabIndex = 14;
            this.butEliminar.Text = "Eliminar ";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // dgvCerditos
            // 
            this.dgvCerditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCerditos.Location = new System.Drawing.Point(12, 222);
            this.dgvCerditos.Name = "dgvCerditos";
            this.dgvCerditos.RowTemplate.Height = 25;
            this.dgvCerditos.Size = new System.Drawing.Size(354, 150);
            this.dgvCerditos.TabIndex = 15;
            this.dgvCerditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ForCerditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 393);
            this.Controls.Add(this.dgvCerditos);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.dateIngreso);
            this.Controls.Add(this.texpeso);
            this.Controls.Add(this.texNumcorral);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForCerditos";
            this.Text = "Cerditos";
            this.Load += new System.EventHandler(this.ForCerditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCerditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox texNombre;
        private TextBox texNumcorral;
        private TextBox texpeso;
        private DateTimePicker dateIngreso;
        private DateTimePicker dateNacimiento;
        private Button butAgregar;
        private Button butModificar;
        private Button butLimpiar;
        private Button butEliminar;
        private DataGridView dgvCerditos;
    }
}