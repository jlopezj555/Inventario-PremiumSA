namespace CapaVista
{
    partial class Estado_de_equipos
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
            this.salir_equipo = new System.Windows.Forms.Button();
            this.lbl_mantenimientoequipos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_estados = new System.Windows.Forms.DataGridView();
            this.txt_descripcionestado = new System.Windows.Forms.TextBox();
            this.txt_nombreestado = new System.Windows.Forms.TextBox();
            this.txt_idEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ayudastado = new System.Windows.Forms.Button();
            this.btn_eliminarestado = new System.Windows.Forms.Button();
            this.btn_actualizarestado = new System.Windows.Forms.Button();
            this.btn_guardarregistroestado = new System.Windows.Forms.Button();
            this.btn_modregistroestado = new System.Windows.Forms.Button();
            this.panel_mantenimientou.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estados)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mantenimientou
            // 
            this.panel_mantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mantenimientou.Controls.Add(this.salir_equipo);
            this.panel_mantenimientou.Controls.Add(this.lbl_mantenimientoequipos);
            this.panel_mantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_mantenimientou.Location = new System.Drawing.Point(12, 11);
            this.panel_mantenimientou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_mantenimientou.Name = "panel_mantenimientou";
            this.panel_mantenimientou.Size = new System.Drawing.Size(999, 91);
            this.panel_mantenimientou.TabIndex = 3;
            // 
            // salir_equipo
            // 
            this.salir_equipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_equipo.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_equipo.Location = new System.Drawing.Point(4, 4);
            this.salir_equipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salir_equipo.Name = "salir_equipo";
            this.salir_equipo.Size = new System.Drawing.Size(95, 78);
            this.salir_equipo.TabIndex = 11;
            this.salir_equipo.UseVisualStyleBackColor = true;
            this.salir_equipo.Click += new System.EventHandler(this.salir_equipo_Click);
            // 
            // lbl_mantenimientoequipos
            // 
            this.lbl_mantenimientoequipos.AutoSize = true;
            this.lbl_mantenimientoequipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientoequipos.ForeColor = System.Drawing.Color.White;
            this.lbl_mantenimientoequipos.Location = new System.Drawing.Point(311, 17);
            this.lbl_mantenimientoequipos.Name = "lbl_mantenimientoequipos";
            this.lbl_mantenimientoequipos.Size = new System.Drawing.Size(386, 39);
            this.lbl_mantenimientoequipos.TabIndex = 2;
            this.lbl_mantenimientoequipos.Text = "ESTADO DE EQUIPOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_estados);
            this.panel1.Controls.Add(this.txt_descripcionestado);
            this.panel1.Controls.Add(this.txt_nombreestado);
            this.panel1.Controls.Add(this.txt_idEstado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 630);
            this.panel1.TabIndex = 4;
            // 
            // dgv_estados
            // 
            this.dgv_estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estados.Location = new System.Drawing.Point(223, 347);
            this.dgv_estados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_estados.Name = "dgv_estados";
            this.dgv_estados.RowHeadersWidth = 62;
            this.dgv_estados.RowTemplate.Height = 28;
            this.dgv_estados.Size = new System.Drawing.Size(587, 278);
            this.dgv_estados.TabIndex = 33;
            this.dgv_estados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estados_CellClick);
            // 
            // txt_descripcionestado
            // 
            this.txt_descripcionestado.Location = new System.Drawing.Point(388, 303);
            this.txt_descripcionestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_descripcionestado.Name = "txt_descripcionestado";
            this.txt_descripcionestado.Size = new System.Drawing.Size(292, 22);
            this.txt_descripcionestado.TabIndex = 32;
            // 
            // txt_nombreestado
            // 
            this.txt_nombreestado.Location = new System.Drawing.Point(388, 247);
            this.txt_nombreestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombreestado.Name = "txt_nombreestado";
            this.txt_nombreestado.Size = new System.Drawing.Size(292, 22);
            this.txt_nombreestado.TabIndex = 31;
            // 
            // txt_idEstado
            // 
            this.txt_idEstado.Location = new System.Drawing.Point(387, 191);
            this.txt_idEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idEstado.Name = "txt_idEstado";
            this.txt_idEstado.ReadOnly = true;
            this.txt_idEstado.Size = new System.Drawing.Size(292, 22);
            this.txt_idEstado.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre de estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id de estado";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_ayudastado);
            this.panel2.Controls.Add(this.btn_eliminarestado);
            this.panel2.Controls.Add(this.btn_actualizarestado);
            this.panel2.Controls.Add(this.btn_guardarregistroestado);
            this.panel2.Controls.Add(this.btn_modregistroestado);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(149, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 146);
            this.panel2.TabIndex = 3;
            // 
            // btn_ayudastado
            // 
            this.btn_ayudastado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudastado.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudastado.Location = new System.Drawing.Point(601, 4);
            this.btn_ayudastado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ayudastado.Name = "btn_ayudastado";
            this.btn_ayudastado.Size = new System.Drawing.Size(124, 132);
            this.btn_ayudastado.TabIndex = 8;
            this.btn_ayudastado.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarestado
            // 
            this.btn_eliminarestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarestado.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarestado.Location = new System.Drawing.Point(452, 4);
            this.btn_eliminarestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminarestado.Name = "btn_eliminarestado";
            this.btn_eliminarestado.Size = new System.Drawing.Size(143, 132);
            this.btn_eliminarestado.TabIndex = 7;
            this.btn_eliminarestado.UseVisualStyleBackColor = true;
            this.btn_eliminarestado.Click += new System.EventHandler(this.btn_eliminarestado_Click);
            // 
            // btn_actualizarestado
            // 
            this.btn_actualizarestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarestado.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarestado.Location = new System.Drawing.Point(305, 4);
            this.btn_actualizarestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_actualizarestado.Name = "btn_actualizarestado";
            this.btn_actualizarestado.Size = new System.Drawing.Size(140, 132);
            this.btn_actualizarestado.TabIndex = 6;
            this.btn_actualizarestado.UseVisualStyleBackColor = true;
            // 
            // btn_guardarregistroestado
            // 
            this.btn_guardarregistroestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardarregistroestado.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btn_guardarregistroestado.Location = new System.Drawing.Point(21, 4);
            this.btn_guardarregistroestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardarregistroestado.Name = "btn_guardarregistroestado";
            this.btn_guardarregistroestado.Size = new System.Drawing.Size(124, 132);
            this.btn_guardarregistroestado.TabIndex = 5;
            this.btn_guardarregistroestado.UseVisualStyleBackColor = true;
            this.btn_guardarregistroestado.Click += new System.EventHandler(this.btn_guardarregistroestado_Click);
            // 
            // btn_modregistroestado
            // 
            this.btn_modregistroestado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modregistroestado.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modregistroestado.Location = new System.Drawing.Point(153, 4);
            this.btn_modregistroestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modregistroestado.Name = "btn_modregistroestado";
            this.btn_modregistroestado.Size = new System.Drawing.Size(144, 132);
            this.btn_modregistroestado.TabIndex = 4;
            this.btn_modregistroestado.UseVisualStyleBackColor = true;
            this.btn_modregistroestado.Click += new System.EventHandler(this.btn_modregistroestado_Click);
            // 
            // Estado_de_equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1023, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_mantenimientou);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Estado_de_equipos";
            this.Text = "Estado_de_equipos";
            this.panel_mantenimientou.ResumeLayout(false);
            this.panel_mantenimientou.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estados)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mantenimientou;
        private System.Windows.Forms.Button salir_equipo;
        private System.Windows.Forms.Label lbl_mantenimientoequipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ayudastado;
        private System.Windows.Forms.Button btn_eliminarestado;
        private System.Windows.Forms.Button btn_actualizarestado;
        private System.Windows.Forms.Button btn_guardarregistroestado;
        private System.Windows.Forms.Button btn_modregistroestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idEstado;
        private System.Windows.Forms.TextBox txt_nombreestado;
        private System.Windows.Forms.TextBox txt_descripcionestado;
        private System.Windows.Forms.DataGridView dgv_estados;
    }
}