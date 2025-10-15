
namespace CapaVista
{
    partial class Movimientos_de_Inventario
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
            this.panel_menumantenimientou = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ayudamovimiento = new System.Windows.Forms.Button();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.btn_eliminarmovimiento = new System.Windows.Forms.Button();
            this.btn_actualizarmovimiento = new System.Windows.Forms.Button();
            this.btn_modmovimiento = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.lbl_tipomov = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbl_fechamov = new System.Windows.Forms.Label();
            this.lbl_observacion = new System.Windows.Forms.Label();
            this.lbl_empleadomov = new System.Windows.Forms.Label();
            this.panel_mantenimientou = new System.Windows.Forms.Panel();
            this.salir_movinventario = new System.Windows.Forms.Button();
            this.lbl_movimientoinventario = new System.Windows.Forms.Label();
            this.panel_menumantenimientou.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_mantenimientou.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menumantenimientou
            // 
            this.panel_menumantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menumantenimientou.Controls.Add(this.dgvMovimientos);
            this.panel_menumantenimientou.Controls.Add(this.panel2);
            this.panel_menumantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_menumantenimientou.Location = new System.Drawing.Point(25, 114);
            this.panel_menumantenimientou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_menumantenimientou.Name = "panel_menumantenimientou";
            this.panel_menumantenimientou.Size = new System.Drawing.Size(986, 892);
            this.panel_menumantenimientou.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ayudamovimiento);
            this.panel1.Controls.Add(this.btnRegistrarMovimiento);
            this.panel1.Controls.Add(this.btn_eliminarmovimiento);
            this.panel1.Controls.Add(this.btn_actualizarmovimiento);
            this.panel1.Controls.Add(this.btn_modmovimiento);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(129, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 148);
            this.panel1.TabIndex = 16;
            // 
            // btn_ayudamovimiento
            // 
            this.btn_ayudamovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudamovimiento.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudamovimiento.Location = new System.Drawing.Point(639, 4);
            this.btn_ayudamovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ayudamovimiento.Name = "btn_ayudamovimiento";
            this.btn_ayudamovimiento.Size = new System.Drawing.Size(124, 132);
            this.btn_ayudamovimiento.TabIndex = 8;
            this.btn_ayudamovimiento.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarMovimiento.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(19, 4);
            this.btnRegistrarMovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(124, 132);
            this.btnRegistrarMovimiento.TabIndex = 5;
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // btn_eliminarmovimiento
            // 
            this.btn_eliminarmovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarmovimiento.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarmovimiento.Location = new System.Drawing.Point(483, 4);
            this.btn_eliminarmovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminarmovimiento.Name = "btn_eliminarmovimiento";
            this.btn_eliminarmovimiento.Size = new System.Drawing.Size(141, 132);
            this.btn_eliminarmovimiento.TabIndex = 7;
            this.btn_eliminarmovimiento.UseVisualStyleBackColor = true;
            this.btn_eliminarmovimiento.Click += new System.EventHandler(this.btn_eliminarmovimiento_Click);
            // 
            // btn_actualizarmovimiento
            // 
            this.btn_actualizarmovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarmovimiento.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarmovimiento.Location = new System.Drawing.Point(324, 4);
            this.btn_actualizarmovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_actualizarmovimiento.Name = "btn_actualizarmovimiento";
            this.btn_actualizarmovimiento.Size = new System.Drawing.Size(140, 132);
            this.btn_actualizarmovimiento.TabIndex = 6;
            this.btn_actualizarmovimiento.UseVisualStyleBackColor = true;
            this.btn_actualizarmovimiento.Click += new System.EventHandler(this.btn_actualizarmovimiento_Click);
            // 
            // btn_modmovimiento
            // 
            this.btn_modmovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modmovimiento.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modmovimiento.Location = new System.Drawing.Point(157, 4);
            this.btn_modmovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modmovimiento.Name = "btn_modmovimiento";
            this.btn_modmovimiento.Size = new System.Drawing.Size(144, 132);
            this.btn_modmovimiento.TabIndex = 4;
            this.btn_modmovimiento.UseVisualStyleBackColor = true;
            this.btn_modmovimiento.Click += new System.EventHandler(this.btn_modmovimiento_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(56, 396);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersWidth = 62;
            this.dgvMovimientos.Size = new System.Drawing.Size(867, 278);
            this.dgvMovimientos.TabIndex = 6;
            this.dgvMovimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbEquipo);
            this.panel2.Controls.Add(this.cmbUsuario);
            this.panel2.Controls.Add(this.cmbTipoMovimiento);
            this.panel2.Controls.Add(this.lbl_tipomov);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.lbl_fechamov);
            this.panel2.Controls.Add(this.lbl_observacion);
            this.panel2.Controls.Add(this.lbl_empleadomov);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(56, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 242);
            this.panel2.TabIndex = 15;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(312, 30);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(247, 24);
            this.cmbEquipo.TabIndex = 34;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(312, 75);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(247, 24);
            this.cmbUsuario.TabIndex = 33;
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(311, 114);
            this.cmbTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(247, 24);
            this.cmbTipoMovimiento.TabIndex = 32;
            // 
            // lbl_tipomov
            // 
            this.lbl_tipomov.AutoSize = true;
            this.lbl_tipomov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipomov.ForeColor = System.Drawing.Color.White;
            this.lbl_tipomov.Location = new System.Drawing.Point(123, 25);
            this.lbl_tipomov.Name = "lbl_tipomov";
            this.lbl_tipomov.Size = new System.Drawing.Size(125, 28);
            this.lbl_tipomov.TabIndex = 4;
            this.lbl_tipomov.Text = "ID Equipo";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(312, 156);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(245, 70);
            this.txtObservaciones.TabIndex = 12;
            // 
            // lbl_fechamov
            // 
            this.lbl_fechamov.AutoSize = true;
            this.lbl_fechamov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechamov.ForeColor = System.Drawing.Color.White;
            this.lbl_fechamov.Location = new System.Drawing.Point(144, 69);
            this.lbl_fechamov.Name = "lbl_fechamov";
            this.lbl_fechamov.Size = new System.Drawing.Size(103, 28);
            this.lbl_fechamov.TabIndex = 7;
            this.lbl_fechamov.Text = "Usuario";
            // 
            // lbl_observacion
            // 
            this.lbl_observacion.AutoSize = true;
            this.lbl_observacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacion.ForeColor = System.Drawing.Color.White;
            this.lbl_observacion.Location = new System.Drawing.Point(87, 150);
            this.lbl_observacion.Name = "lbl_observacion";
            this.lbl_observacion.Size = new System.Drawing.Size(160, 28);
            this.lbl_observacion.TabIndex = 11;
            this.lbl_observacion.Text = "Observación";
            // 
            // lbl_empleadomov
            // 
            this.lbl_empleadomov.AutoSize = true;
            this.lbl_empleadomov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleadomov.ForeColor = System.Drawing.Color.White;
            this.lbl_empleadomov.Location = new System.Drawing.Point(11, 108);
            this.lbl_empleadomov.Name = "lbl_empleadomov";
            this.lbl_empleadomov.Size = new System.Drawing.Size(236, 28);
            this.lbl_empleadomov.TabIndex = 9;
            this.lbl_empleadomov.Text = "Tipo de Movimiento";
            // 
            // panel_mantenimientou
            // 
            this.panel_mantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mantenimientou.Controls.Add(this.salir_movinventario);
            this.panel_mantenimientou.Controls.Add(this.lbl_movimientoinventario);
            this.panel_mantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_mantenimientou.Location = new System.Drawing.Point(25, 15);
            this.panel_mantenimientou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_mantenimientou.Name = "panel_mantenimientou";
            this.panel_mantenimientou.Size = new System.Drawing.Size(986, 92);
            this.panel_mantenimientou.TabIndex = 2;
            // 
            // salir_movinventario
            // 
            this.salir_movinventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_movinventario.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_movinventario.Location = new System.Drawing.Point(4, 4);
            this.salir_movinventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salir_movinventario.Name = "salir_movinventario";
            this.salir_movinventario.Size = new System.Drawing.Size(95, 78);
            this.salir_movinventario.TabIndex = 11;
            this.salir_movinventario.UseVisualStyleBackColor = true;
            this.salir_movinventario.Click += new System.EventHandler(this.salir_movinventario_Click);
            // 
            // lbl_movimientoinventario
            // 
            this.lbl_movimientoinventario.AutoSize = true;
            this.lbl_movimientoinventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movimientoinventario.ForeColor = System.Drawing.Color.White;
            this.lbl_movimientoinventario.Location = new System.Drawing.Point(309, 20);
            this.lbl_movimientoinventario.Name = "lbl_movimientoinventario";
            this.lbl_movimientoinventario.Size = new System.Drawing.Size(451, 39);
            this.lbl_movimientoinventario.TabIndex = 2;
            this.lbl_movimientoinventario.Text = "Movimientos de Inventario";
            // 
            // Movimientos_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1033, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menumantenimientou);
            this.Controls.Add(this.panel_mantenimientou);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Movimientos_de_Inventario";
            this.Text = "Movimientos de Inventario";
            this.panel_menumantenimientou.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_mantenimientou.ResumeLayout(false);
            this.panel_mantenimientou.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menumantenimientou;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lbl_observacion;
        private System.Windows.Forms.Label lbl_empleadomov;
        private System.Windows.Forms.Label lbl_fechamov;
        private System.Windows.Forms.Label lbl_tipomov;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.Panel panel_mantenimientou;
        private System.Windows.Forms.Label lbl_movimientoinventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button salir_movinventario;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ayudamovimiento;
        private System.Windows.Forms.Button btn_eliminarmovimiento;
        private System.Windows.Forms.Button btn_actualizarmovimiento;
        private System.Windows.Forms.Button btn_modmovimiento;
    }
}