namespace CapaUI
{
    partial class Inicio
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
            btnRTienda = new Button();
            lblMenu = new Label();
            btnRMantUsuarios = new Button();
            btnRMantArticulos = new Button();
            btnRInventario = new Button();
            btnCerrarSesion = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnRTienda
            // 
            btnRTienda.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRTienda.Location = new Point(39, 64);
            btnRTienda.Name = "btnRTienda";
            btnRTienda.Size = new Size(282, 42);
            btnRTienda.TabIndex = 0;
            btnRTienda.Text = "&Tienda";
            btnRTienda.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(109, 20);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(150, 22);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "Menú de Inicio";
            // 
            // btnRMantUsuarios
            // 
            btnRMantUsuarios.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRMantUsuarios.Location = new Point(39, 124);
            btnRMantUsuarios.Name = "btnRMantUsuarios";
            btnRMantUsuarios.Size = new Size(282, 42);
            btnRMantUsuarios.TabIndex = 2;
            btnRMantUsuarios.Text = "&Mantenimiento Usuarios";
            btnRMantUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRMantArticulos
            // 
            btnRMantArticulos.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRMantArticulos.Location = new Point(39, 186);
            btnRMantArticulos.Name = "btnRMantArticulos";
            btnRMantArticulos.Size = new Size(282, 42);
            btnRMantArticulos.TabIndex = 3;
            btnRMantArticulos.Text = "Mantenimiento &Artículos";
            btnRMantArticulos.UseVisualStyleBackColor = true;
            // 
            // btnRInventario
            // 
            btnRInventario.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRInventario.Location = new Point(39, 250);
            btnRInventario.Name = "btnRInventario";
            btnRInventario.Size = new Size(282, 42);
            btnRInventario.TabIndex = 4;
            btnRInventario.Text = "&Inventario";
            btnRInventario.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(39, 317);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(282, 42);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "&Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(39, 382);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(282, 42);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 440);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRInventario);
            Controls.Add(btnRMantArticulos);
            Controls.Add(btnRMantUsuarios);
            Controls.Add(lblMenu);
            Controls.Add(btnRTienda);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRTienda;
        private Label lblMenu;
        private Button btnRMantUsuarios;
        private Button btnRMantArticulos;
        private Button btnRInventario;
        private Button btnCerrarSesion;
        private Button btnSalir;
    }
}