namespace GranjaPorcinaa
{
    partial class ForVentas
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
            this.texNomCom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texIdCer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateVenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texPresio = new System.Windows.Forms.TextBox();
            this.butModificar = new System.Windows.Forms.Button();
            this.butLimpiar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.dgvventa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.SuspendLayout();
            // 
            // texNomCom
            // 
            this.texNomCom.Location = new System.Drawing.Point(176, 94);
            this.texNomCom.Name = "texNomCom";
            this.texNomCom.Size = new System.Drawing.Size(200, 23);
            this.texNomCom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre del Comprador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio:";
            // 
            // texIdCer
            // 
            this.texIdCer.Location = new System.Drawing.Point(176, 51);
            this.texIdCer.Name = "texIdCer";
            this.texIdCer.Size = new System.Drawing.Size(200, 23);
            this.texIdCer.TabIndex = 8;
            this.texIdCer.TextChanged += new System.EventHandler(this.texId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id Porcino:";
            // 
            // dateVenta
            // 
            this.dateVenta.Location = new System.Drawing.Point(176, 165);
            this.dateVenta.Name = "dateVenta";
            this.dateVenta.Size = new System.Drawing.Size(200, 23);
            this.dateVenta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ventas ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de la venta:";
            // 
            // texPresio
            // 
            this.texPresio.Location = new System.Drawing.Point(176, 130);
            this.texPresio.Name = "texPresio";
            this.texPresio.Size = new System.Drawing.Size(200, 23);
            this.texPresio.TabIndex = 14;
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(121, 201);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(75, 23);
            this.butModificar.TabIndex = 22;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butLimpiar
            // 
            this.butLimpiar.Location = new System.Drawing.Point(211, 201);
            this.butLimpiar.Name = "butLimpiar";
            this.butLimpiar.Size = new System.Drawing.Size(75, 23);
            this.butLimpiar.TabIndex = 21;
            this.butLimpiar.Text = "Limpiar";
            this.butLimpiar.UseVisualStyleBackColor = true;
            this.butLimpiar.Click += new System.EventHandler(this.butLimpiar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(301, 201);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(75, 23);
            this.butEliminar.TabIndex = 20;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(31, 201);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 19;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // dgvventa
            // 
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Location = new System.Drawing.Point(31, 230);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.RowTemplate.Height = 25;
            this.dgvventa.Size = new System.Drawing.Size(345, 150);
            this.dgvventa.TabIndex = 23;
            this.dgvventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ForVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 392);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butLimpiar);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.texPresio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texNomCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texIdCer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateVenta);
            this.Name = "ForVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.ForVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox texNomCom;
        private Label label3;
        private Label label2;
        private TextBox texIdCer;
        private Label label1;
        private DateTimePicker dateVenta;
        private Label label4;
        private Label label5;
        private TextBox texPresio;
        private Button butModificar;
        private Button butLimpiar;
        private Button butEliminar;
        private Button butAgregar;
        private DataGridView dgvventa;
    }
}