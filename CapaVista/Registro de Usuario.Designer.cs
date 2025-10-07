namespace CapaVista
{
    partial class Registro_de_Usuario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.btn_registrarUsuario = new System.Windows.Forms.Button();
            this.salir_registrousuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.agregar_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(399, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de usuario";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(342, 302);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(278, 26);
            this.txt_nombreUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(393, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(342, 365);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(278, 26);
            this.txt_Contraseña.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion de correo";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(342, 442);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(278, 26);
            this.txt_Correo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(378, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "No. de telefono";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(342, 505);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(278, 26);
            this.txt_Telefono.TabIndex = 10;
            // 
            // btn_registrarUsuario
            // 
            this.btn_registrarUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarUsuario.Location = new System.Drawing.Point(342, 569);
            this.btn_registrarUsuario.Name = "btn_registrarUsuario";
            this.btn_registrarUsuario.Size = new System.Drawing.Size(279, 63);
            this.btn_registrarUsuario.TabIndex = 11;
            this.btn_registrarUsuario.Text = "Registrar usuario";
            this.btn_registrarUsuario.UseVisualStyleBackColor = true;
            this.btn_registrarUsuario.Click += new System.EventHandler(this.btn_registrarUsuario_Click);
            // 
            // salir_registrousuario
            // 
            this.salir_registrousuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_registrousuario.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_registrousuario.Location = new System.Drawing.Point(18, 18);
            this.salir_registrousuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salir_registrousuario.Name = "salir_registrousuario";
            this.salir_registrousuario.Size = new System.Drawing.Size(106, 97);
            this.salir_registrousuario.TabIndex = 16;
            this.salir_registrousuario.UseVisualStyleBackColor = true;
            this.salir_registrousuario.Click += new System.EventHandler(this.salir_registrousuario_Click);
            // 
            // Registro_de_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(846, 678);
            this.Controls.Add(this.salir_registrousuario);
            this.Controls.Add(this.btn_registrarUsuario);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro_de_Usuario";
            this.Text = "Registro de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Button btn_registrarUsuario;
        private System.Windows.Forms.Button salir_registrousuario;
    }
}