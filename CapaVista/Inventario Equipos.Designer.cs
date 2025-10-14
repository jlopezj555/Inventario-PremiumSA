namespace CapaVista
{
    partial class Inventario_Equipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_menumantenimientou = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigoInventario = new System.Windows.Forms.TextBox();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lbl_descripcionequipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reporteequipo = new System.Windows.Forms.Button();
            this.btn_ayudaequipo = new System.Windows.Forms.Button();
            this.btn_eliminarinventario = new System.Windows.Forms.Button();
            this.btn_actualizarinventario = new System.Windows.Forms.Button();
            this.btn_guardarinventario = new System.Windows.Forms.Button();
            this.btn_modificarinventario = new System.Windows.Forms.Button();
            this.panel_mantenimientou = new System.Windows.Forms.Panel();
            this.salir_equipo = new System.Windows.Forms.Button();
            this.lbl_mantenimientoequipos = new System.Windows.Forms.Label();
            this.cmb_idEquipo = new System.Windows.Forms.ComboBox();
            this.Id_Equipo = new System.Windows.Forms.Label();
            this.panel_menumantenimientou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_mantenimientou.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menumantenimientou
            // 
            this.panel_menumantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menumantenimientou.Controls.Add(this.cmb_idEquipo);
            this.panel_menumantenimientou.Controls.Add(this.label3);
            this.panel_menumantenimientou.Controls.Add(this.txtStockActual);
            this.panel_menumantenimientou.Controls.Add(this.label2);
            this.panel_menumantenimientou.Controls.Add(this.txt_codigoInventario);
            this.panel_menumantenimientou.Controls.Add(this.dgv_inventario);
            this.panel_menumantenimientou.Controls.Add(this.txtStockMinimo);
            this.panel_menumantenimientou.Controls.Add(this.lbl_descripcionequipo);
            this.panel_menumantenimientou.Controls.Add(this.Id_Equipo);
            this.panel_menumantenimientou.Controls.Add(this.panel1);
            this.panel_menumantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_menumantenimientou.Location = new System.Drawing.Point(13, 122);
            this.panel_menumantenimientou.Margin = new System.Windows.Forms.Padding(4);
            this.panel_menumantenimientou.Name = "panel_menumantenimientou";
            this.panel_menumantenimientou.Size = new System.Drawing.Size(1133, 722);
            this.panel_menumantenimientou.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(185, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "Stock Actual";
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(349, 312);
            this.txtStockActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(246, 22);
            this.txtStockActual.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Codigo de Inventario";
            // 
            // txt_codigoInventario
            // 
            this.txt_codigoInventario.Location = new System.Drawing.Point(347, 192);
            this.txt_codigoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigoInventario.Name = "txt_codigoInventario";
            this.txt_codigoInventario.Size = new System.Drawing.Size(246, 22);
            this.txt_codigoInventario.TabIndex = 27;
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inventario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inventario.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgv_inventario.Location = new System.Drawing.Point(16, 352);
            this.dgv_inventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.RowHeadersWidth = 62;
            this.dgv_inventario.Size = new System.Drawing.Size(1060, 335);
            this.dgv_inventario.TabIndex = 23;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(349, 275);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(246, 22);
            this.txtStockMinimo.TabIndex = 16;
            // 
            // lbl_descripcionequipo
            // 
            this.lbl_descripcionequipo.AutoSize = true;
            this.lbl_descripcionequipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionequipo.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcionequipo.Location = new System.Drawing.Point(176, 269);
            this.lbl_descripcionequipo.Name = "lbl_descripcionequipo";
            this.lbl_descripcionequipo.Size = new System.Drawing.Size(167, 28);
            this.lbl_descripcionequipo.TabIndex = 15;
            this.lbl_descripcionequipo.Text = "Stock Mínimo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_reporteequipo);
            this.panel1.Controls.Add(this.btn_ayudaequipo);
            this.panel1.Controls.Add(this.btn_eliminarinventario);
            this.panel1.Controls.Add(this.btn_actualizarinventario);
            this.panel1.Controls.Add(this.btn_guardarinventario);
            this.panel1.Controls.Add(this.btn_modificarinventario);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(110, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 148);
            this.panel1.TabIndex = 2;
            // 
            // btn_reporteequipo
            // 
            this.btn_reporteequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_reporteequipo.Image = global::CapaVista.Properties.Resources.reporte_registro;
            this.btn_reporteequipo.Location = new System.Drawing.Point(733, 4);
            this.btn_reporteequipo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reporteequipo.Name = "btn_reporteequipo";
            this.btn_reporteequipo.Size = new System.Drawing.Size(124, 132);
            this.btn_reporteequipo.TabIndex = 9;
            this.btn_reporteequipo.UseVisualStyleBackColor = true;
            // 
            // btn_ayudaequipo
            // 
            this.btn_ayudaequipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudaequipo.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudaequipo.Location = new System.Drawing.Point(602, 4);
            this.btn_ayudaequipo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ayudaequipo.Name = "btn_ayudaequipo";
            this.btn_ayudaequipo.Size = new System.Drawing.Size(124, 132);
            this.btn_ayudaequipo.TabIndex = 8;
            this.btn_ayudaequipo.UseVisualStyleBackColor = true;
            this.btn_ayudaequipo.Click += new System.EventHandler(this.btn_ayudaequipo_Click);
            // 
            // btn_eliminarinventario
            // 
            this.btn_eliminarinventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarinventario.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarinventario.Location = new System.Drawing.Point(452, 4);
            this.btn_eliminarinventario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminarinventario.Name = "btn_eliminarinventario";
            this.btn_eliminarinventario.Size = new System.Drawing.Size(142, 132);
            this.btn_eliminarinventario.TabIndex = 7;
            this.btn_eliminarinventario.UseVisualStyleBackColor = true;
            this.btn_eliminarinventario.Click += new System.EventHandler(this.btn_eliminarequipo_Click);
            // 
            // btn_actualizarinventario
            // 
            this.btn_actualizarinventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarinventario.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarinventario.Location = new System.Drawing.Point(305, 4);
            this.btn_actualizarinventario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizarinventario.Name = "btn_actualizarinventario";
            this.btn_actualizarinventario.Size = new System.Drawing.Size(140, 132);
            this.btn_actualizarinventario.TabIndex = 6;
            this.btn_actualizarinventario.UseVisualStyleBackColor = true;
            this.btn_actualizarinventario.Click += new System.EventHandler(this.btn_actualizarequipo_Click);
            // 
            // btn_guardarinventario
            // 
            this.btn_guardarinventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardarinventario.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btn_guardarinventario.Location = new System.Drawing.Point(22, 4);
            this.btn_guardarinventario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardarinventario.Name = "btn_guardarinventario";
            this.btn_guardarinventario.Size = new System.Drawing.Size(124, 132);
            this.btn_guardarinventario.TabIndex = 5;
            this.btn_guardarinventario.UseVisualStyleBackColor = true;
            this.btn_guardarinventario.Click += new System.EventHandler(this.btn_guardarregistroequipo_Click);
            // 
            // btn_modificarinventario
            // 
            this.btn_modificarinventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modificarinventario.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modificarinventario.Location = new System.Drawing.Point(154, 4);
            this.btn_modificarinventario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modificarinventario.Name = "btn_modificarinventario";
            this.btn_modificarinventario.Size = new System.Drawing.Size(144, 132);
            this.btn_modificarinventario.TabIndex = 4;
            this.btn_modificarinventario.UseVisualStyleBackColor = true;
            this.btn_modificarinventario.Click += new System.EventHandler(this.btn_modregistroequipo_Click);
            // 
            // panel_mantenimientou
            // 
            this.panel_mantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mantenimientou.Controls.Add(this.salir_equipo);
            this.panel_mantenimientou.Controls.Add(this.lbl_mantenimientoequipos);
            this.panel_mantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_mantenimientou.Location = new System.Drawing.Point(13, 13);
            this.panel_mantenimientou.Margin = new System.Windows.Forms.Padding(4);
            this.panel_mantenimientou.Name = "panel_mantenimientou";
            this.panel_mantenimientou.Size = new System.Drawing.Size(1133, 91);
            this.panel_mantenimientou.TabIndex = 7;
            // 
            // salir_equipo
            // 
            this.salir_equipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_equipo.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_equipo.Location = new System.Drawing.Point(4, 4);
            this.salir_equipo.Margin = new System.Windows.Forms.Padding(4);
            this.salir_equipo.Name = "salir_equipo";
            this.salir_equipo.Size = new System.Drawing.Size(94, 78);
            this.salir_equipo.TabIndex = 11;
            this.salir_equipo.UseVisualStyleBackColor = true;
            this.salir_equipo.Click += new System.EventHandler(this.salir_equipo_Click_1);
            // 
            // lbl_mantenimientoequipos
            // 
            this.lbl_mantenimientoequipos.AutoSize = true;
            this.lbl_mantenimientoequipos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mantenimientoequipos.ForeColor = System.Drawing.Color.White;
            this.lbl_mantenimientoequipos.Location = new System.Drawing.Point(272, 20);
            this.lbl_mantenimientoequipos.Name = "lbl_mantenimientoequipos";
            this.lbl_mantenimientoequipos.Size = new System.Drawing.Size(459, 39);
            this.lbl_mantenimientoequipos.TabIndex = 2;
            this.lbl_mantenimientoequipos.Text = "INVENTARIO DE EQUIPOS";
            // 
            // cmb_idEquipo
            // 
            this.cmb_idEquipo.FormattingEnabled = true;
            this.cmb_idEquipo.Location = new System.Drawing.Point(347, 230);
            this.cmb_idEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_idEquipo.Name = "cmb_idEquipo";
            this.cmb_idEquipo.Size = new System.Drawing.Size(246, 24);
            this.cmb_idEquipo.TabIndex = 31;
            // 
            // Id_Equipo
            // 
            this.Id_Equipo.AutoSize = true;
            this.Id_Equipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Equipo.ForeColor = System.Drawing.Color.White;
            this.Id_Equipo.Location = new System.Drawing.Point(204, 226);
            this.Id_Equipo.Name = "Id_Equipo";
            this.Id_Equipo.Size = new System.Drawing.Size(125, 28);
            this.Id_Equipo.TabIndex = 9;
            this.Id_Equipo.Text = "ID Equipo";
            // 
            // Inventario_Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1167, 748);
            this.Controls.Add(this.panel_mantenimientou);
            this.Controls.Add(this.panel_menumantenimientou);
            this.Name = "Inventario_Equipos";
            this.Text = "Inventario_Equipos";
            this.panel_menumantenimientou.ResumeLayout(false);
            this.panel_menumantenimientou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_mantenimientou.ResumeLayout(false);
            this.panel_mantenimientou.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menumantenimientou;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigoInventario;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label lbl_descripcionequipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reporteequipo;
        private System.Windows.Forms.Button btn_ayudaequipo;
        private System.Windows.Forms.Button btn_eliminarinventario;
        private System.Windows.Forms.Button btn_actualizarinventario;
        private System.Windows.Forms.Button btn_guardarinventario;
        private System.Windows.Forms.Button btn_modificarinventario;
        private System.Windows.Forms.Panel panel_mantenimientou;
        private System.Windows.Forms.Button salir_equipo;
        private System.Windows.Forms.Label lbl_mantenimientoequipos;
        private System.Windows.Forms.ComboBox cmb_idEquipo;
        private System.Windows.Forms.Label Id_Equipo;
    }
}