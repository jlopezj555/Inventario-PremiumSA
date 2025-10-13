
namespace CapaVista
{
    partial class Mantenimiento_de_Usuarios
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
            this.panel_mantenimientou = new System.Windows.Forms.Panel();
            this.salir_usuario = new System.Windows.Forms.Button();
            this.lbl_mantenimientousuarios = new System.Windows.Forms.Label();
            this.panel_menumantenimientou = new System.Windows.Forms.Panel();
            this.btn_cambiarContrasena = new System.Windows.Forms.Button();
            this.labelContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txt_usuarioLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_idUsuario = new System.Windows.Forms.Label();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.txt_Departamento = new System.Windows.Forms.TextBox();
            this.lbl_contacto = new System.Windows.Forms.Label();
            this.txt_puestoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_correoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.txt_telefonoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_nombreusuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reporteusuario = new System.Windows.Forms.Button();
            this.btn_ayudausuario = new System.Windows.Forms.Button();
            this.btn_eliminarusuario = new System.Windows.Forms.Button();
            this.btn_actualizarusuario = new System.Windows.Forms.Button();
            this.btn_modregistrousuario = new System.Windows.Forms.Button();
            this.panel_mantenimientou.SuspendLayout();
            this.panel_menumantenimientou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mantenimientou
            // 
            this.panel_mantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mantenimientou.Controls.Add(this.salir_usuario);
            this.panel_mantenimientou.Controls.Add(this.lbl_mantenimientousuarios);
            this.panel_mantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_mantenimientou.Location = new System.Drawing.Point(49, 12);
            this.panel_mantenimientou.Name = "panel_mantenimientou";
            this.panel_mantenimientou.Size = new System.Drawing.Size(807, 74);
            this.panel_mantenimientou.TabIndex = 0;
            // 
            // salir_usuario
            // 
            this.salir_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_usuario.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_usuario.Location = new System.Drawing.Point(3, 3);
            this.salir_usuario.Name = "salir_usuario";
            this.salir_usuario.Size = new System.Drawing.Size(71, 63);
            this.salir_usuario.TabIndex = 15;
            this.salir_usuario.UseVisualStyleBackColor = true;
            this.salir_usuario.Click += new System.EventHandler(this.salir_usuario_Click);
            // 
            // lbl_mantenimientousuarios
            // 
            this.lbl_mantenimientousuarios.AutoSize = true;
            this.lbl_mantenimientousuarios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientousuarios.ForeColor = System.Drawing.Color.White;
            this.lbl_mantenimientousuarios.Location = new System.Drawing.Point(196, 16);
            this.lbl_mantenimientousuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mantenimientousuarios.Name = "lbl_mantenimientousuarios";
            this.lbl_mantenimientousuarios.Size = new System.Drawing.Size(444, 32);
            this.lbl_mantenimientousuarios.TabIndex = 2;
            this.lbl_mantenimientousuarios.Text = "MANTENIMIENTO DE USUARIOS";
            // 
            // panel_menumantenimientou
            // 
            this.panel_menumantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menumantenimientou.Controls.Add(this.btn_cambiarContrasena);
            this.panel_menumantenimientou.Controls.Add(this.labelContra);
            this.panel_menumantenimientou.Controls.Add(this.txtContra);
            this.panel_menumantenimientou.Controls.Add(this.txt_usuarioLogin);
            this.panel_menumantenimientou.Controls.Add(this.label1);
            this.panel_menumantenimientou.Controls.Add(this.lbl_idUsuario);
            this.panel_menumantenimientou.Controls.Add(this.txt_idUsuario);
            this.panel_menumantenimientou.Controls.Add(this.txt_Departamento);
            this.panel_menumantenimientou.Controls.Add(this.lbl_contacto);
            this.panel_menumantenimientou.Controls.Add(this.txt_puestoUsuario);
            this.panel_menumantenimientou.Controls.Add(this.lbl_direccion);
            this.panel_menumantenimientou.Controls.Add(this.txt_correoUsuario);
            this.panel_menumantenimientou.Controls.Add(this.lbl_correo);
            this.panel_menumantenimientou.Controls.Add(this.txt_telefonoUsuario);
            this.panel_menumantenimientou.Controls.Add(this.lbl_telefono);
            this.panel_menumantenimientou.Controls.Add(this.dgv_usuarios);
            this.panel_menumantenimientou.Controls.Add(this.txt_nombreUsuario);
            this.panel_menumantenimientou.Controls.Add(this.lbl_nombreusuario);
            this.panel_menumantenimientou.Controls.Add(this.panel1);
            this.panel_menumantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_menumantenimientou.Location = new System.Drawing.Point(42, 83);
            this.panel_menumantenimientou.Name = "panel_menumantenimientou";
            this.panel_menumantenimientou.Size = new System.Drawing.Size(814, 421);
            this.panel_menumantenimientou.TabIndex = 1;
            // 
            // btn_cambiarContrasena
            // 
            this.btn_cambiarContrasena.Image = global::CapaVista.Properties.Resources.images_convertido_a_25x25;
            this.btn_cambiarContrasena.Location = new System.Drawing.Point(335, 243);
            this.btn_cambiarContrasena.Name = "btn_cambiarContrasena";
            this.btn_cambiarContrasena.Size = new System.Drawing.Size(35, 25);
            this.btn_cambiarContrasena.TabIndex = 21;
            this.btn_cambiarContrasena.UseVisualStyleBackColor = true;
            this.btn_cambiarContrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cambiarContrasena_MouseDown);
            this.btn_cambiarContrasena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cambiarContrasena_MouseUp);
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.ForeColor = System.Drawing.Color.White;
            this.labelContra.Location = new System.Drawing.Point(15, 246);
            this.labelContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(115, 22);
            this.labelContra.TabIndex = 20;
            this.labelContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(145, 248);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(185, 20);
            this.txtContra.TabIndex = 19;
            // 
            // txt_usuarioLogin
            // 
            this.txt_usuarioLogin.Location = new System.Drawing.Point(145, 218);
            this.txt_usuarioLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txt_usuarioLogin.Name = "txt_usuarioLogin";
            this.txt_usuarioLogin.Size = new System.Drawing.Size(185, 20);
            this.txt_usuarioLogin.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario";
            // 
            // lbl_idUsuario
            // 
            this.lbl_idUsuario.AutoSize = true;
            this.lbl_idUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_idUsuario.Location = new System.Drawing.Point(59, 151);
            this.lbl_idUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idUsuario.Name = "lbl_idUsuario";
            this.lbl_idUsuario.Size = new System.Drawing.Size(131, 22);
            this.lbl_idUsuario.TabIndex = 16;
            this.lbl_idUsuario.Text = "Id de Usuario";
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.Location = new System.Drawing.Point(194, 155);
            this.txt_idUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.Size = new System.Drawing.Size(137, 20);
            this.txt_idUsuario.TabIndex = 15;
            // 
            // txt_Departamento
            // 
            this.txt_Departamento.Location = new System.Drawing.Point(145, 314);
            this.txt_Departamento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Departamento.Name = "txt_Departamento";
            this.txt_Departamento.Size = new System.Drawing.Size(185, 20);
            this.txt_Departamento.TabIndex = 14;
            // 
            // lbl_contacto
            // 
            this.lbl_contacto.AutoSize = true;
            this.lbl_contacto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contacto.ForeColor = System.Drawing.Color.White;
            this.lbl_contacto.Location = new System.Drawing.Point(0, 314);
            this.lbl_contacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contacto.Name = "lbl_contacto";
            this.lbl_contacto.Size = new System.Drawing.Size(141, 22);
            this.lbl_contacto.TabIndex = 13;
            this.lbl_contacto.Text = "Departamento";
            // 
            // txt_puestoUsuario
            // 
            this.txt_puestoUsuario.Location = new System.Drawing.Point(146, 283);
            this.txt_puestoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_puestoUsuario.Name = "txt_puestoUsuario";
            this.txt_puestoUsuario.Size = new System.Drawing.Size(185, 20);
            this.txt_puestoUsuario.TabIndex = 12;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.White;
            this.lbl_direccion.Location = new System.Drawing.Point(57, 283);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(73, 22);
            this.lbl_direccion.TabIndex = 11;
            this.lbl_direccion.Text = "Puesto";
            // 
            // txt_correoUsuario
            // 
            this.txt_correoUsuario.Location = new System.Drawing.Point(145, 374);
            this.txt_correoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correoUsuario.Name = "txt_correoUsuario";
            this.txt_correoUsuario.Size = new System.Drawing.Size(185, 20);
            this.txt_correoUsuario.TabIndex = 10;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.White;
            this.lbl_correo.Location = new System.Drawing.Point(59, 370);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(73, 22);
            this.lbl_correo.TabIndex = 9;
            this.lbl_correo.Text = "Correo";
            // 
            // txt_telefonoUsuario
            // 
            this.txt_telefonoUsuario.Location = new System.Drawing.Point(145, 345);
            this.txt_telefonoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefonoUsuario.Name = "txt_telefonoUsuario";
            this.txt_telefonoUsuario.Size = new System.Drawing.Size(185, 20);
            this.txt_telefonoUsuario.TabIndex = 8;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_telefono.Location = new System.Drawing.Point(45, 345);
            this.lbl_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(88, 22);
            this.lbl_telefono.TabIndex = 7;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(376, 155);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.RowHeadersWidth = 62;
            this.dgv_usuarios.Size = new System.Drawing.Size(409, 239);
            this.dgv_usuarios.TabIndex = 6;
            this.dgv_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellClick);
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(145, 187);
            this.txt_nombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(185, 20);
            this.txt_nombreUsuario.TabIndex = 5;
            // 
            // lbl_nombreusuario
            // 
            this.lbl_nombreusuario.AutoSize = true;
            this.lbl_nombreusuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreusuario.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreusuario.Location = new System.Drawing.Point(50, 183);
            this.lbl_nombreusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreusuario.Name = "lbl_nombreusuario";
            this.lbl_nombreusuario.Size = new System.Drawing.Size(83, 22);
            this.lbl_nombreusuario.TabIndex = 4;
            this.lbl_nombreusuario.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_reporteusuario);
            this.panel1.Controls.Add(this.btn_ayudausuario);
            this.panel1.Controls.Add(this.btn_eliminarusuario);
            this.panel1.Controls.Add(this.btn_actualizarusuario);
            this.panel1.Controls.Add(this.btn_modregistrousuario);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(109, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 120);
            this.panel1.TabIndex = 2;
            // 
            // btn_reporteusuario
            // 
            this.btn_reporteusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reporteusuario.Image = global::CapaVista.Properties.Resources.reporte_registro;
            this.btn_reporteusuario.Location = new System.Drawing.Point(541, 3);
            this.btn_reporteusuario.Name = "btn_reporteusuario";
            this.btn_reporteusuario.Size = new System.Drawing.Size(93, 107);
            this.btn_reporteusuario.TabIndex = 9;
            this.btn_reporteusuario.UseVisualStyleBackColor = true;
            // 
            // btn_ayudausuario
            // 
            this.btn_ayudausuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudausuario.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudausuario.Location = new System.Drawing.Point(425, 3);
            this.btn_ayudausuario.Name = "btn_ayudausuario";
            this.btn_ayudausuario.Size = new System.Drawing.Size(93, 107);
            this.btn_ayudausuario.TabIndex = 8;
            this.btn_ayudausuario.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarusuario
            // 
            this.btn_eliminarusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarusuario.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarusuario.Location = new System.Drawing.Point(294, 3);
            this.btn_eliminarusuario.Name = "btn_eliminarusuario";
            this.btn_eliminarusuario.Size = new System.Drawing.Size(107, 107);
            this.btn_eliminarusuario.TabIndex = 7;
            this.btn_eliminarusuario.UseVisualStyleBackColor = true;
            this.btn_eliminarusuario.Click += new System.EventHandler(this.btn_eliminarusuario_Click);
            // 
            // btn_actualizarusuario
            // 
            this.btn_actualizarusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarusuario.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarusuario.Location = new System.Drawing.Point(169, 3);
            this.btn_actualizarusuario.Name = "btn_actualizarusuario";
            this.btn_actualizarusuario.Size = new System.Drawing.Size(105, 107);
            this.btn_actualizarusuario.TabIndex = 6;
            this.btn_actualizarusuario.UseVisualStyleBackColor = true;
            this.btn_actualizarusuario.Click += new System.EventHandler(this.btn_actualizarusuario_Click);
            // 
            // btn_modregistrousuario
            // 
            this.btn_modregistrousuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modregistrousuario.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modregistrousuario.Location = new System.Drawing.Point(36, 3);
            this.btn_modregistrousuario.Name = "btn_modregistrousuario";
            this.btn_modregistrousuario.Size = new System.Drawing.Size(108, 107);
            this.btn_modregistrousuario.TabIndex = 4;
            this.btn_modregistrousuario.UseVisualStyleBackColor = true;
            this.btn_modregistrousuario.Click += new System.EventHandler(this.btn_modregistrousuario_Click);
            // 
            // Mantenimiento_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(903, 487);
            this.Controls.Add(this.panel_menumantenimientou);
            this.Controls.Add(this.panel_mantenimientou);
            this.Name = "Mantenimiento_de_Usuarios";
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.Mantenimiento_de_Usuarios_Load);
            this.panel_mantenimientou.ResumeLayout(false);
            this.panel_mantenimientou.PerformLayout();
            this.panel_menumantenimientou.ResumeLayout(false);
            this.panel_menumantenimientou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mantenimientou;
        private System.Windows.Forms.Label lbl_mantenimientousuarios;
        private System.Windows.Forms.Panel panel_menumantenimientou;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nombreusuario;
        private System.Windows.Forms.TextBox txt_Departamento;
        private System.Windows.Forms.Label lbl_contacto;
        private System.Windows.Forms.TextBox txt_puestoUsuario;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_correoUsuario;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_telefonoUsuario;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Button btn_reporteusuario;
        private System.Windows.Forms.Button btn_ayudausuario;
        private System.Windows.Forms.Button btn_eliminarusuario;
        private System.Windows.Forms.Button btn_actualizarusuario;
        private System.Windows.Forms.Button btn_modregistrousuario;
        private System.Windows.Forms.Button salir_usuario;
        private System.Windows.Forms.Label lbl_idUsuario;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private System.Windows.Forms.TextBox txt_usuarioLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btn_cambiarContrasena;
    }
}