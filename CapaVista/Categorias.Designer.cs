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
            this.btn_actualizarcategoria = new System.Windows.Forms.Button();
            this.btn_modregistrocategoria = new System.Windows.Forms.Button();
            this.btn_eliminarcategoria = new System.Windows.Forms.Button();
            this.btn_ayudacategoria = new System.Windows.Forms.Button();
            this.txt_idCategoria = new System.Windows.Forms.TextBox();
            this.btn_guardarregistrocategoria = new System.Windows.Forms.Button();
            this.btn_reportecategoria = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 84);
            this.panel1.TabIndex = 0;
            // 
            // lbl_mantenimientoequipos
            // 
            this.lbl_mantenimientoequipos.AutoSize = true;
            this.lbl_mantenimientoequipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientoequipos.ForeColor = System.Drawing.Color.White;
            this.lbl_mantenimientoequipos.Location = new System.Drawing.Point(261, 21);
            this.lbl_mantenimientoequipos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mantenimientoequipos.Name = "lbl_mantenimientoequipos";
            this.lbl_mantenimientoequipos.Size = new System.Drawing.Size(195, 32);
            this.lbl_mantenimientoequipos.TabIndex = 3;
            this.lbl_mantenimientoequipos.Text = "CATEGORIAS";
            this.lbl_mantenimientoequipos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // salir_equipo
            // 
            this.salir_equipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_equipo.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_equipo.Location = new System.Drawing.Point(3, 10);
            this.salir_equipo.Name = "salir_equipo";
            this.salir_equipo.Size = new System.Drawing.Size(71, 63);
            this.salir_equipo.TabIndex = 12;
            this.salir_equipo.UseVisualStyleBackColor = true;
            this.salir_equipo.Click += new System.EventHandler(this.salir_equipo_Click);
            // 
            // btn_actualizarcategoria
            // 
            this.btn_actualizarcategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarcategoria.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarcategoria.Location = new System.Drawing.Point(231, 3);
            this.btn_actualizarcategoria.Name = "btn_actualizarcategoria";
            this.btn_actualizarcategoria.Size = new System.Drawing.Size(105, 107);
            this.btn_actualizarcategoria.TabIndex = 15;
            this.btn_actualizarcategoria.UseVisualStyleBackColor = true;
            // 
            // btn_modregistrocategoria
            // 
            this.btn_modregistrocategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modregistrocategoria.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modregistrocategoria.Location = new System.Drawing.Point(118, 3);
            this.btn_modregistrocategoria.Name = "btn_modregistrocategoria";
            this.btn_modregistrocategoria.Size = new System.Drawing.Size(108, 107);
            this.btn_modregistrocategoria.TabIndex = 14;
            this.btn_modregistrocategoria.UseVisualStyleBackColor = true;
            this.btn_modregistrocategoria.Click += new System.EventHandler(this.btn_modregistrocategoria_Click);
            // 
            // btn_eliminarcategoria
            // 
            this.btn_eliminarcategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarcategoria.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarcategoria.Location = new System.Drawing.Point(342, 3);
            this.btn_eliminarcategoria.Name = "btn_eliminarcategoria";
            this.btn_eliminarcategoria.Size = new System.Drawing.Size(107, 107);
            this.btn_eliminarcategoria.TabIndex = 16;
            this.btn_eliminarcategoria.UseVisualStyleBackColor = true;
            this.btn_eliminarcategoria.Click += new System.EventHandler(this.btn_eliminarcategoria_Click);
            // 
            // btn_ayudacategoria
            // 
            this.btn_ayudacategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudacategoria.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudacategoria.Location = new System.Drawing.Point(454, 3);
            this.btn_ayudacategoria.Name = "btn_ayudacategoria";
            this.btn_ayudacategoria.Size = new System.Drawing.Size(93, 107);
            this.btn_ayudacategoria.TabIndex = 17;
            this.btn_ayudacategoria.UseVisualStyleBackColor = true;
            // 
            // txt_idCategoria
            // 
            this.txt_idCategoria.Location = new System.Drawing.Point(227, 133);
            this.txt_idCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_idCategoria.Name = "txt_idCategoria";
            this.txt_idCategoria.ReadOnly = true;
            this.txt_idCategoria.Size = new System.Drawing.Size(178, 20);
            this.txt_idCategoria.TabIndex = 14;
            // 
            // btn_guardarregistrocategoria
            // 
            this.btn_guardarregistrocategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardarregistrocategoria.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btn_guardarregistrocategoria.Location = new System.Drawing.Point(21, 3);
            this.btn_guardarregistrocategoria.Name = "btn_guardarregistrocategoria";
            this.btn_guardarregistrocategoria.Size = new System.Drawing.Size(93, 107);
            this.btn_guardarregistrocategoria.TabIndex = 14;
            this.btn_guardarregistrocategoria.UseVisualStyleBackColor = true;
            this.btn_guardarregistrocategoria.Click += new System.EventHandler(this.btn_guardarregistrocategoria_Click);
            // 
            // btn_reportecategoria
            // 
            this.btn_reportecategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reportecategoria.Image = global::CapaVista.Properties.Resources.reporte_registro;
            this.btn_reportecategoria.Location = new System.Drawing.Point(553, 3);
            this.btn_reportecategoria.Name = "btn_reportecategoria";
            this.btn_reportecategoria.Size = new System.Drawing.Size(93, 107);
            this.btn_reportecategoria.TabIndex = 18;
            this.btn_reportecategoria.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(227, 168);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(178, 20);
            this.txt_nombre.TabIndex = 16;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(227, 203);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(178, 64);
            this.txt_descripcion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id de Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre de Categoria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_categorias);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.btn_reportecategoria);
            this.panel2.Controls.Add(this.btn_guardarregistrocategoria);
            this.panel2.Controls.Add(this.txt_idCategoria);
            this.panel2.Controls.Add(this.btn_ayudacategoria);
            this.panel2.Controls.Add(this.btn_eliminarcategoria);
            this.panel2.Controls.Add(this.btn_modregistrocategoria);
            this.panel2.Controls.Add(this.btn_actualizarcategoria);
            this.panel2.Location = new System.Drawing.Point(8, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 504);
            this.panel2.TabIndex = 13;
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categorias.Location = new System.Drawing.Point(100, 285);
            this.dgv_categorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.RowHeadersWidth = 62;
            this.dgv_categorias.RowTemplate.Height = 28;
            this.dgv_categorias.Size = new System.Drawing.Size(434, 217);
            this.dgv_categorias.TabIndex = 30;
            this.dgv_categorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categorias_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descripcion";
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(684, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btn_actualizarcategoria;
        private System.Windows.Forms.Button btn_modregistrocategoria;
        private System.Windows.Forms.Button btn_eliminarcategoria;
        private System.Windows.Forms.Button btn_ayudacategoria;
        private System.Windows.Forms.TextBox txt_idCategoria;
        private System.Windows.Forms.Button btn_guardarregistrocategoria;
        private System.Windows.Forms.Button btn_reportecategoria;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_categorias;
    }
}