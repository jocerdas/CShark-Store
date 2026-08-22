namespace CapaUI
{
    partial class Tienda
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
            cbxNombreArticulo = new ComboBox();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblCantidad = new Label();
            lblPrecioUnitario = new Label();
            lblPrecioTotal = new Label();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            gbxMetodoPago = new GroupBox();
            rbTransferencia = new RadioButton();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioUnitario = new TextBox();
            txtPrecioTotal = new TextBox();
            txtTotalFacturar = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnFacturar = new Button();
            btnVolver = new Button();
            lblIdVenta = new Label();
            btnVentaNueva = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxMetodoPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(326, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(120, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Facturación";
            // 
            // cbxNombreArticulo
            // 
            cbxNombreArticulo.Font = new Font("Consolas", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbxNombreArticulo.FormattingEnabled = true;
            cbxNombreArticulo.Location = new Point(151, 68);
            cbxNombreArticulo.Name = "cbxNombreArticulo";
            cbxNombreArticulo.Size = new Size(419, 30);
            cbxNombreArticulo.TabIndex = 1;
            cbxNombreArticulo.SelectedIndexChanged += cbxNombreArticulo_SelectedIndexChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(12, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 22);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(151, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 22);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre Del Artículo";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(12, 101);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 22);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(151, 101);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(160, 22);
            lblPrecioUnitario.TabIndex = 5;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioTotal.Location = new Point(360, 101);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(130, 22);
            lblPrecioTotal.TabIndex = 6;
            lblPrecioTotal.Text = "Precio Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(287, 385);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(170, 22);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total a Facturar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 219);
            dataGridView1.TabIndex = 8;
            // 
            // gbxMetodoPago
            // 
            gbxMetodoPago.Controls.Add(rbTransferencia);
            gbxMetodoPago.Controls.Add(rbTarjeta);
            gbxMetodoPago.Controls.Add(rbEfectivo);
            gbxMetodoPago.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMetodoPago.Location = new Point(588, 35);
            gbxMetodoPago.Name = "gbxMetodoPago";
            gbxMetodoPago.Size = new Size(200, 113);
            gbxMetodoPago.TabIndex = 9;
            gbxMetodoPago.TabStop = false;
            gbxMetodoPago.Text = "Métodos de Pago";
            // 
            // rbTransferencia
            // 
            rbTransferencia.AutoSize = true;
            rbTransferencia.Location = new Point(6, 85);
            rbTransferencia.Name = "rbTransferencia";
            rbTransferencia.Size = new Size(158, 26);
            rbTransferencia.TabIndex = 2;
            rbTransferencia.TabStop = true;
            rbTransferencia.Text = "Transferencia";
            rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(6, 55);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(98, 26);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(3, 23);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(108, 26);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(12, 68);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(133, 30);
            txtCodigo.TabIndex = 10;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(12, 128);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(133, 30);
            txtCantidad.TabIndex = 11;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioUnitario.Location = new Point(151, 126);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(203, 30);
            txtPrecioUnitario.TabIndex = 12;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioTotal.Location = new Point(360, 126);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(203, 30);
            txtPrecioTotal.TabIndex = 13;
            // 
            // txtTotalFacturar
            // 
            txtTotalFacturar.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalFacturar.Location = new Point(287, 408);
            txtTotalFacturar.Name = "txtTotalFacturar";
            txtTotalFacturar.Size = new Size(203, 30);
            txtTotalFacturar.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 403);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(133, 35);
            btnAgregar.TabIndex = 15;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(151, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 35);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnFacturar
            // 
            btnFacturar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturar.Location = new Point(507, 403);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(133, 35);
            btnFacturar.TabIndex = 17;
            btnFacturar.Text = "&Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            btnFacturar.Click += btnFacturar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(655, 403);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 35);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "&Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdVenta.Location = new Point(528, 6);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(260, 22);
            lblIdVenta.TabIndex = 19;
            lblIdVenta.Text = "ID de Venta: Sin Generar.";
            // 
            // btnVentaNueva
            // 
            btnVentaNueva.BackColor = Color.LawnGreen;
            btnVentaNueva.Font = new Font("Consolas", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVentaNueva.Location = new Point(12, 6);
            btnVentaNueva.Name = "btnVentaNueva";
            btnVentaNueva.Size = new Size(171, 28);
            btnVentaNueva.TabIndex = 20;
            btnVentaNueva.Text = "&Venta Nueva";
            btnVentaNueva.UseVisualStyleBackColor = false;
            btnVentaNueva.Click += btnVentaNueva_Click;
            // 
            // Tienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnVentaNueva);
            Controls.Add(lblIdVenta);
            Controls.Add(btnVolver);
            Controls.Add(btnFacturar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTotalFacturar);
            Controls.Add(txtPrecioTotal);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(txtCantidad);
            Controls.Add(txtCodigo);
            Controls.Add(gbxMetodoPago);
            Controls.Add(dataGridView1);
            Controls.Add(lblTotal);
            Controls.Add(lblPrecioTotal);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblCantidad);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(cbxNombreArticulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Tienda";
            Text = "Tienda";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbxMetodoPago.ResumeLayout(false);
            gbxMetodoPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cbxNombreArticulo;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCantidad;
        private Label lblPrecioUnitario;
        private Label lblPrecioTotal;
        private Label lblTotal;
        private DataGridView dataGridView1;
        private GroupBox gbxMetodoPago;
        private RadioButton rbTransferencia;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private TextBox txtPrecioUnitario;
        private TextBox txtPrecioTotal;
        private TextBox txtTotalFacturar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnFacturar;
        private Button btnVolver;
        private Label lblIdVenta;
        private Button btnVentaNueva;
    }
}