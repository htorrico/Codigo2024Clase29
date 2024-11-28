namespace Codigo2024Clase29
{
    partial class frmListadoFactura
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
            Buscar = new Button();
            dgvCabecera = new DataGridView();
            label1 = new Label();
            txtCliente = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCabecera).BeginInit();
            SuspendLayout();
            // 
            // Buscar
            // 
            Buscar.Location = new Point(466, 99);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(94, 29);
            Buscar.TabIndex = 0;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += Buscar_Click;
            // 
            // dgvCabecera
            // 
            dgvCabecera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCabecera.Location = new Point(111, 151);
            dgvCabecera.Name = "dgvCabecera";
            dgvCabecera.RowHeadersWidth = 51;
            dgvCabecera.Size = new Size(579, 188);
            dgvCabecera.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 99);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(201, 99);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(243, 27);
            txtCliente.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(596, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmListadoFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 634);
            Controls.Add(button1);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Controls.Add(dgvCabecera);
            Controls.Add(Buscar);
            Name = "frmListadoFactura";
            Text = "frmListadoFactura";
            ((System.ComponentModel.ISupportInitialize)dgvCabecera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Buscar;
        private DataGridView dgvCabecera;
        private Label label1;
        private TextBox txtCliente;
        private Button button1;
    }
}