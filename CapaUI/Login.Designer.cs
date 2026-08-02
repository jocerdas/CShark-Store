namespace CapaUI
{
    partial class Login
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
            lblTituloLogin = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnIniciarSesion = new Button();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloLogin.Location = new Point(105, 9);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(130, 22);
            lblTituloLogin.TabIndex = 0;
            lblTituloLogin.Text = "CShark-Store";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(33, 58);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 22);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(33, 160);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(110, 22);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(33, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(33, 194);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(282, 30);
            textBox2.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(12, 256);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(171, 37);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "&Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(219, 256);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(140, 37);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "&Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 318);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIniciarSesion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblTituloLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLogin;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnIniciarSesion;
        private Button btnRegistrarse;
    }
}