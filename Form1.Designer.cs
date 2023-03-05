namespace ejemploclases_proj_2_parcial2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbedad = new System.Windows.Forms.ComboBox();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario_mas_Aumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Aumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpaumento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalaumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btncalcularuamento = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitulo.Location = new System.Drawing.Point(257, 24);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(547, 46);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Calculo de Aumento al Empleado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(277, 124);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(244, 27);
            this.txtnombre.TabIndex = 1;
            // 
            // cbedad
            // 
            this.cbedad.FormattingEnabled = true;
            this.cbedad.Location = new System.Drawing.Point(706, 135);
            this.cbedad.Name = "cbedad";
            this.cbedad.Size = new System.Drawing.Size(244, 28);
            this.cbedad.TabIndex = 2;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Location = new System.Drawing.Point(277, 197);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(244, 27);
            this.dtpinicio.TabIndex = 3;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(1037, 544);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(126, 69);
            this.btnagregar.TabIndex = 4;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Edad,
            this.Fecha_Inicio,
            this.Salario,
            this.Salario_mas_Aumento,
            this.Fecha_Aumento});
            this.dgvdetalle.Location = new System.Drawing.Point(48, 440);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            this.dgvdetalle.RowHeadersWidth = 51;
            this.dgvdetalle.RowTemplate.Height = 29;
            this.dgvdetalle.Size = new System.Drawing.Size(800, 342);
            this.dgvdetalle.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            this.Edad.Width = 125;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.HeaderText = "Fecha_Inicio";
            this.Fecha_Inicio.MinimumWidth = 6;
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            this.Fecha_Inicio.Width = 125;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.MinimumWidth = 6;
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            this.Salario.Width = 125;
            // 
            // Salario_mas_Aumento
            // 
            this.Salario_mas_Aumento.HeaderText = "Salario_mas_Aumento";
            this.Salario_mas_Aumento.MinimumWidth = 6;
            this.Salario_mas_Aumento.Name = "Salario_mas_Aumento";
            this.Salario_mas_Aumento.ReadOnly = true;
            this.Salario_mas_Aumento.Width = 125;
            // 
            // Fecha_Aumento
            // 
            this.Fecha_Aumento.HeaderText = "Fecha_Aumento";
            this.Fecha_Aumento.MinimumWidth = 6;
            this.Fecha_Aumento.Name = "Fecha_Aumento";
            this.Fecha_Aumento.ReadOnly = true;
            this.Fecha_Aumento.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(706, 203);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(244, 27);
            this.txtsalario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(629, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(127, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(629, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Aumento";
            // 
            // dtpaumento
            // 
            this.dtpaumento.Location = new System.Drawing.Point(277, 271);
            this.dtpaumento.Name = "dtpaumento";
            this.dtpaumento.Size = new System.Drawing.Size(244, 27);
            this.dtpaumento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(572, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Aumento";
            // 
            // txttotalaumento
            // 
            this.txttotalaumento.Location = new System.Drawing.Point(706, 273);
            this.txttotalaumento.Name = "txttotalaumento";
            this.txttotalaumento.Size = new System.Drawing.Size(244, 27);
            this.txttotalaumento.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(338, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "Detalle de Registro";
            // 
            // btncalcularuamento
            // 
            this.btncalcularuamento.Location = new System.Drawing.Point(1037, 441);
            this.btncalcularuamento.Name = "btncalcularuamento";
            this.btncalcularuamento.Size = new System.Drawing.Size(126, 69);
            this.btncalcularuamento.TabIndex = 16;
            this.btncalcularuamento.Text = "Calcular Aumento";
            this.btncalcularuamento.UseVisualStyleBackColor = true;
            this.btncalcularuamento.Click += new System.EventHandler(this.btncalcularuamento_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(1037, 646);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(126, 69);
            this.btnmodificar.TabIndex = 17;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 834);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btncalcularuamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotalaumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpaumento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.cbedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltitulo;
        private TextBox txtnombre;
        private ComboBox cbedad;
        private DateTimePicker dtpinicio;
        private Button btnagregar;
        private DataGridView dgvdetalle;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn Salario_mas_Aumento;
        private DataGridViewTextBoxColumn Fecha_Aumento;
        private Label label1;
        private TextBox txtsalario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpaumento;
        private Label label6;
        private TextBox txttotalaumento;
        private Label label7;
        private Button btncalcularuamento;
        private Button btnmodificar;
    }
}