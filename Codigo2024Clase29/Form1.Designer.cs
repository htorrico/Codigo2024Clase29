namespace Codigo2024Clase29
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
            Cliente = new Label();
            label1 = new Label();
            txtCliente = new TextBox();
            dtpFecha = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvDetalle = new DataGridView();
            btnAgregar = new Button();
            label4 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label2 = new Label();
            txtProducto = new TextBox();
            btnGrabar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // Cliente
            // 
            Cliente.AutoSize = true;
            Cliente.Location = new Point(49, 77);
            Cliente.Name = "Cliente";
            Cliente.Size = new Size(55, 20);
            Cliente.TabIndex = 0;
            Cliente.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 77);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(140, 77);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(215, 27);
            txtCliente.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(445, 75);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(Cliente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Location = new Point(71, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(855, 192);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Principales";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDetalle);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtProducto);
            groupBox2.Location = new Point(71, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(855, 331);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Detalle";
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(35, 98);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(689, 188);
            dgvDetalle.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(745, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(563, 56);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(629, 53);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(95, 27);
            txtPrecio.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 56);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(445, 50);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(95, 27);
            txtCantidad.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 53);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(126, 53);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(215, 27);
            txtProducto.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(404, 617);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(94, 29);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 700);
            Controls.Add(btnGrabar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Cliente;
        private Label label1;
        private TextBox txtCliente;
        private DateTimePicker dtpFecha;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvDetalle;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label2;
        private TextBox txtProducto;
        private Button btnGrabar;
    }
}
