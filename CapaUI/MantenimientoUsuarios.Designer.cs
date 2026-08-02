namespace CapaUI
{
    partial class MantenimientoUsuarios
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
            lblCedula = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblUsuario = new Label();
            lblContrasena = new Label();
            gbxRol = new GroupBox();
            rbCliente = new RadioButton();
            rbEjecutivo = new RadioButton();
            rbAdministrador = new RadioButton();
            dgvUsuarios = new DataGridView();
            lblNuevos = new Label();
            lblConteo = new Label();
            lblEstado = new Label();
            mskCedula = new MaskedTextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            chkActivo = new CheckBox();
            chkNuevo = new CheckBox();
            btnNuevos = new Button();
            btnGuardar = new Button();
            btnVolver = new Button();
            gbxRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(266, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento de Usuarios";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(12, 44);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 22);
            lblCedula.TabIndex = 1;
            lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(152, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 22);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(375, 44);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(100, 22);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "Apellidos";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 124);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 22);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(152, 124);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(110, 22);
            lblContrasena.TabIndex = 5;
            lblContrasena.Text = "Contraseña";
            // 
            // gbxRol
            // 
            gbxRol.Controls.Add(rbCliente);
            gbxRol.Controls.Add(rbEjecutivo);
            gbxRol.Controls.Add(rbAdministrador);
            gbxRol.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxRol.Location = new Point(528, 105);
            gbxRol.Name = "gbxRol";
            gbxRol.Size = new Size(250, 95);
            gbxRol.TabIndex = 7;
            gbxRol.TabStop = false;
            gbxRol.Text = "Roles";
            // 
            // rbCliente
            // 
            rbCliente.AutoSize = true;
            rbCliente.Location = new Point(141, 61);
            rbCliente.Name = "rbCliente";
            rbCliente.Size = new Size(98, 26);
            rbCliente.TabIndex = 2;
            rbCliente.TabStop = true;
            rbCliente.Text = "Cliente";
            rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbEjecutivo
            // 
            rbEjecutivo.AutoSize = true;
            rbEjecutivo.Location = new Point(8, 61);
            rbEjecutivo.Name = "rbEjecutivo";
            rbEjecutivo.Size = new Size(118, 26);
            rbEjecutivo.TabIndex = 1;
            rbEjecutivo.TabStop = true;
            rbEjecutivo.Text = "Ejecutivo";
            rbEjecutivo.UseVisualStyleBackColor = true;
            // 
            // rbAdministrador
            // 
            rbAdministrador.AutoSize = true;
            rbAdministrador.Location = new Point(8, 29);
            rbAdministrador.Name = "rbAdministrador";
            rbAdministrador.Size = new Size(158, 26);
            rbAdministrador.TabIndex = 0;
            rbAdministrador.TabStop = true;
            rbAdministrador.Text = "Administrador";
            rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 206);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(776, 229);
            dgvUsuarios.TabIndex = 8;
            // 
            // lblNuevos
            // 
            lblNuevos.AutoSize = true;
            lblNuevos.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevos.Location = new Point(12, 458);
            lblNuevos.Name = "lblNuevos";
            lblNuevos.Size = new Size(170, 22);
            lblNuevos.TabIndex = 9;
            lblNuevos.Text = "Usuarios Nuevos:";
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConteo.Location = new Point(188, 458);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(20, 22);
            lblConteo.TabIndex = 10;
            lblConteo.Text = "0";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(375, 109);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 22);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado";
            // 
            // mskCedula
            // 
            mskCedula.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCedula.Location = new Point(12, 69);
            mskCedula.Mask = "0-0000-0000";
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(124, 30);
            mskCedula.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(152, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 30);
            txtNombre.TabIndex = 13;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.Location = new Point(375, 69);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(403, 30);
            txtApellidos.TabIndex = 14;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(12, 149);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(124, 30);
            txtUsuario.TabIndex = 15;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(152, 149);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(203, 30);
            txtContrasena.TabIndex = 16;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActivo.Location = new Point(375, 134);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(89, 26);
            chkActivo.TabIndex = 17;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkNuevo
            // 
            chkNuevo.AutoSize = true;
            chkNuevo.Enabled = false;
            chkNuevo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkNuevo.Location = new Point(375, 174);
            chkNuevo.Name = "chkNuevo";
            chkNuevo.Size = new Size(79, 26);
            chkNuevo.TabIndex = 18;
            chkNuevo.Text = "Nuevo";
            chkNuevo.UseVisualStyleBackColor = true;
            // 
            // btnNuevos
            // 
            btnNuevos.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevos.Location = new Point(231, 454);
            btnNuevos.Name = "btnNuevos";
            btnNuevos.Size = new Size(264, 30);
            btnNuevos.TabIndex = 19;
            btnNuevos.Text = "&Mostrar Usuarios Nuevos";
            btnNuevos.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(596, 454);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(156, 30);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(632, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(156, 30);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "&Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // MantenimientoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevos);
            Controls.Add(chkNuevo);
            Controls.Add(chkActivo);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(mskCedula);
            Controls.Add(lblEstado);
            Controls.Add(lblConteo);
            Controls.Add(lblNuevos);
            Controls.Add(dgvUsuarios);
            Controls.Add(gbxRol);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MantenimientoUsuarios";
            Text = "Mantenimiento De Usuarios";
            gbxRol.ResumeLayout(false);
            gbxRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCedula;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblUsuario;
        private Label lblContrasena;
        private GroupBox gbxRol;
        private RadioButton rbCliente;
        private RadioButton rbEjecutivo;
        private RadioButton rbAdministrador;
        private DataGridView dgvUsuarios;
        private Label lblNuevos;
        private Label lblConteo;
        private Label lblEstado;
        private MaskedTextBox mskCedula;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private CheckBox chkActivo;
        private CheckBox chkNuevo;
        private Button btnNuevos;
        private Button btnGuardar;
        private Button btnVolver;
    }
}