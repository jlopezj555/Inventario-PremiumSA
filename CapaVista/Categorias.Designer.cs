namespace CapaVista
{
    partial class Categorias
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_mantenimientoequipos = new System.Windows.Forms.Label();
            this.salir_equipo = new System.Windows.Forms.Button();
            this.btn_actualizarequipo = new System.Windows.Forms.Button();
            this.btn_modregistroequipo = new System.Windows.Forms.Button();
            this.btn_eliminarequipo = new System.Windows.Forms.Button();
            this.btn_ayudaequipo = new System.Windows.Forms.Button();
            this.txt_idCategoria = new System.Windows.Forms.TextBox();
            this.btn_guardarregistroequipo = new System.Windows.Forms.Button();
            this.btn_reporteequipo = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_Descripción = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_mantenimientoequipos);
            this.panel1.Controls.Add(this.salir_equipo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 130);
            this.panel1.TabIndex = 0;
            // 
            // lbl_mantenimientoequipos
            // 
            this.lbl_mantenimientoequipos.AutoSize = true;
            this.lbl_mantenimientoequipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientoequipos.ForeColor = System.Drawing.Color.White;
            this.lbl_mantenimientoequipos.Location = new System.Drawing.Point(391, 32);
            this.lbl_mantenimientoequipos.Name = "lbl_mantenimientoequipos";
            this.lbl_mantenimientoequipos.Size = new System.Drawing.Size(293, 46);
            this.lbl_mantenimientoequipos.TabIndex = 3;
            this.lbl_mantenimientoequipos.Text = "CATEGORIAS";
            this.lbl_mantenimientoequipos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salir_equipo
            // 
            this.salir_equipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_equipo.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_equipo.Location = new System.Drawing.Point(4, 16);
            this.salir_equipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salir_equipo.Name = "salir_equipo";
            this.salir_equipo.Size = new System.Drawing.Size(106, 97);
            this.salir_equipo.TabIndex = 12;
            this.salir_equipo.UseVisualStyleBackColor = true;
            this.salir_equipo.Click += new System.EventHandler(this.salir_equipo_Click);
            // 
            // btn_actualizarequipo
            // 
            this.btn_actualizarequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarequipo.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarequipo.Location = new System.Drawing.Point(347, 5);
            this.btn_actualizarequipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_actualizarequipo.Name = "btn_actualizarequipo";
            this.btn_actualizarequipo.Size = new System.Drawing.Size(158, 165);
            this.btn_actualizarequipo.TabIndex = 15;
            this.btn_actualizarequipo.UseVisualStyleBackColor = true;
            // 
            // btn_modregistroequipo
            // 
            this.btn_modregistroequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modregistroequipo.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modregistroequipo.Location = new System.Drawing.Point(177, 5);
            this.btn_modregistroequipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modregistroequipo.Name = "btn_modregistroequipo";
            this.btn_modregistroequipo.Size = new System.Drawing.Size(162, 165);
            this.btn_modregistroequipo.TabIndex = 14;
            this.btn_modregistroequipo.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarequipo
            // 
            this.btn_eliminarequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarequipo.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarequipo.Location = new System.Drawing.Point(513, 5);
            this.btn_eliminarequipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_eliminarequipo.Name = "btn_eliminarequipo";
            this.btn_eliminarequipo.Size = new System.Drawing.Size(160, 165);
            this.btn_eliminarequipo.TabIndex = 16;
            this.btn_eliminarequipo.UseVisualStyleBackColor = true;
            // 
            // btn_ayudaequipo
            // 
            this.btn_ayudaequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudaequipo.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudaequipo.Location = new System.Drawing.Point(681, 5);
            this.btn_ayudaequipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ayudaequipo.Name = "btn_ayudaequipo";
            this.btn_ayudaequipo.Size = new System.Drawing.Size(140, 165);
            this.btn_ayudaequipo.TabIndex = 17;
            this.btn_ayudaequipo.UseVisualStyleBackColor = true;
            // 
            // txt_idCategoria
            // 
            this.txt_idCategoria.Location = new System.Drawing.Point(341, 205);
            this.txt_idCategoria.Name = "txt_idCategoria";
            this.txt_idCategoria.Size = new System.Drawing.Size(265, 26);
            this.txt_idCategoria.TabIndex = 14;
            // 
            // btn_guardarregistroequipo
            // 
            this.btn_guardarregistroequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardarregistroequipo.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btn_guardarregistroequipo.Location = new System.Drawing.Point(31, 5);
            this.btn_guardarregistroequipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardarregistroequipo.Name = "btn_guardarregistroequipo";
            this.btn_guardarregistroequipo.Size = new System.Drawing.Size(140, 165);
            this.btn_guardarregistroequipo.TabIndex = 14;
            this.btn_guardarregistroequipo.UseVisualStyleBackColor = true;
            // 
            // btn_reporteequipo
            // 
            this.btn_reporteequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reporteequipo.Image = global::CapaVista.Properties.Resources.reporte_registro;
            this.btn_reporteequipo.Location = new System.Drawing.Point(829, 5);
            this.btn_reporteequipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reporteequipo.Name = "btn_reporteequipo";
            this.btn_reporteequipo.Size = new System.Drawing.Size(140, 165);
            this.btn_reporteequipo.TabIndex = 18;
            this.btn_reporteequipo.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(341, 259);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(265, 26);
            this.txt_nombre.TabIndex = 16;
            // 
            // txt_Descripción
            // 
            this.txt_Descripción.Location = new System.Drawing.Point(341, 312);
            this.txt_Descripción.Name = "txt_Descripción";
            this.txt_Descripción.Size = new System.Drawing.Size(265, 26);
            this.txt_Descripción.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id de Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre de Categoria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_categorias);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Descripción);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.btn_reporteequipo);
            this.panel2.Controls.Add(this.btn_guardarregistroequipo);
            this.panel2.Controls.Add(this.txt_idCategoria);
            this.panel2.Controls.Add(this.btn_ayudaequipo);
            this.panel2.Controls.Add(this.btn_eliminarequipo);
            this.panel2.Controls.Add(this.btn_modregistroequipo);
            this.panel2.Controls.Add(this.btn_actualizarequipo);
            this.panel2.Location = new System.Drawing.Point(12, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 775);
            this.panel2.TabIndex = 13;
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Location = new System.Drawing.Point(246, 358);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.RowHeadersWidth = 62;
            this.dgv_categorias.RowTemplate.Height = 28;
            this.dgv_categorias.Size = new System.Drawing.Size(575, 402);
            this.dgv_categorias.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descripcion";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1026, 935);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button salir_equipo;
        private System.Windows.Forms.Label lbl_mantenimientoequipos;
        private System.Windows.Forms.Button btn_actualizarequipo;
        private System.Windows.Forms.Button btn_modregistroequipo;
        private System.Windows.Forms.Button btn_eliminarequipo;
        private System.Windows.Forms.Button btn_ayudaequipo;
        private System.Windows.Forms.TextBox txt_idCategoria;
        private System.Windows.Forms.Button btn_guardarregistroequipo;
        private System.Windows.Forms.Button btn_reporteequipo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_Descripción;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_categorias;
    }
}