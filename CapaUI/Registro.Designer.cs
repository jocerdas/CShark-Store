namespace CapaUI
{
    partial class Registro
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
            mskCedula = new MaskedTextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnRegistrarse = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Usuario";
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCedula.Location = new Point(12, 49);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(70, 22);
            lblCedula.TabIndex = 1;
            lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(180, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 22);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(429, 49);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(100, 22);
            lblApellidos.TabIndex = 3;
            lblApellidos.Text = "Apellidos";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 127);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 22);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(180, 127);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(110, 22);
            lblContrasena.TabIndex = 5;
            lblContrasena.Text = "Contraseña";
            // 
            // mskCedula
            // 
            mskCedula.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskCedula.Location = new Point(12, 74);
            mskCedula.Mask = "0-0000-0000";
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(126, 30);
            mskCedula.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(180, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 30);
            txtNombre.TabIndex = 7;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.Location = new Point(429, 74);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(214, 30);
            txtApellidos.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(12, 165);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(126, 30);
            txtUsuario.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(180, 165);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(214, 30);
            txtContrasena.TabIndex = 10;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(453, 117);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(150, 42);
            btnRegistrarse.TabIndex = 11;
            btnRegistrarse.Text = "&Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(437, 167);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(183, 42);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "&Volver al Login";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 221);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrarse);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(mskCedula);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblCedula);
            Controls.Add(lblTitulo);
            Name = "Registro";
            Text = "Registro";
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
        private MaskedTextBox mskCedula;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnRegistrarse;
        private Button btnVolver;
    }
}