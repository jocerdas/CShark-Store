namespace CapaUI
{
    partial class MantenimientoArticulos
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
            lblTitulo = new Label();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblEstado = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            chkActivo = new CheckBox();
            dgvArticulos = new DataGridView();
            btnSeleccionar = new Button();
            btnCrear = new Button();
            btnModificar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(251, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento de Artículos";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(9, 47);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 22);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(148, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 22);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(432, 47);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 22);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(571, 47);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 22);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(674, 47);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 22);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(9, 72);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(133, 30);
            txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(148, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 30);
            txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(432, 72);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(133, 30);
            txtPrecio.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(571, 72);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(93, 30);
            txtStock.TabIndex = 9;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActivo.Location = new Point(674, 76);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(89, 26);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(12, 118);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.Size = new Size(781, 272);
            dgvArticulos.TabIndex = 11;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionar.Location = new Point(12, 403);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(164, 35);
            btnSeleccionar.TabIndex = 12;
            btnSeleccionar.Text = "&Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(209, 403);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(164, 35);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "&Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(421, 403);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(164, 35);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(624, 403);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(164, 35);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "&Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // MantenimientoArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(btnSeleccionar);
            Controls.Add(dgvArticulos);
            Controls.Add(chkActivo);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblEstado);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MantenimientoArticulos";
            Text = "Mantenimiento De Articulos";
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblEstado;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private CheckBox chkActivo;
        private DataGridView dgvArticulos;
        private Button btnSeleccionar;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnVolver;
    }
}