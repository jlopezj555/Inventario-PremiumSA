
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_menumantenimientou = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_mantenimientou = new System.Windows.Forms.Panel();
            this.lbl_movimientoinventario = new System.Windows.Forms.Label();
            this.btn_ayudamovimiento = new System.Windows.Forms.Button();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.btn_eliminarmovimiento = new System.Windows.Forms.Button();
            this.btn_actualizarmovimiento = new System.Windows.Forms.Button();
            this.btn_modmovimiento = new System.Windows.Forms.Button();
            this.salir_movinventario = new System.Windows.Forms.Button();
            this.panel_menumantenimientou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_mantenimientou.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menumantenimientou
            // 
            this.panel_menumantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menumantenimientou.Controls.Add(this.dgvMovimientos);
            this.panel_menumantenimientou.Controls.Add(this.panel2);
            this.panel_menumantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_menumantenimientou.Location = new System.Drawing.Point(19, 93);
            this.panel_menumantenimientou.Name = "panel_menumantenimientou";
            this.panel_menumantenimientou.Size = new System.Drawing.Size(740, 725);
            this.panel_menumantenimientou.TabIndex = 3;
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimientos.Location = new System.Drawing.Point(42, 322);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersWidth = 62;
            this.dgvMovimientos.Size = new System.Drawing.Size(650, 226);
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
            this.panel2.Location = new System.Drawing.Point(42, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 197);
            this.panel2.TabIndex = 15;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(234, 24);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(186, 21);
            this.cmbEquipo.TabIndex = 34;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(234, 61);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(186, 21);
            this.cmbUsuario.TabIndex = 35;
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(233, 93);
            this.cmbTipoMovimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(186, 21);
            this.cmbTipoMovimiento.TabIndex = 36;
            // 
            // lbl_tipomov
            // 
            this.lbl_tipomov.AutoSize = true;
            this.lbl_tipomov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipomov.ForeColor = System.Drawing.Color.White;
            this.lbl_tipomov.Location = new System.Drawing.Point(92, 20);
            this.lbl_tipomov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipomov.Name = "lbl_tipomov";
            this.lbl_tipomov.Size = new System.Drawing.Size(99, 22);
            this.lbl_tipomov.TabIndex = 4;
            this.lbl_tipomov.Text = "ID Equipo";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(234, 127);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(185, 58);
            this.txtObservaciones.TabIndex = 37;
            // 
            // lbl_fechamov
            // 
            this.lbl_fechamov.AutoSize = true;
            this.lbl_fechamov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechamov.ForeColor = System.Drawing.Color.White;
            this.lbl_fechamov.Location = new System.Drawing.Point(108, 56);
            this.lbl_fechamov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fechamov.Name = "lbl_fechamov";
            this.lbl_fechamov.Size = new System.Drawing.Size(80, 22);
            this.lbl_fechamov.TabIndex = 7;
            this.lbl_fechamov.Text = "Usuario";
            // 
            // lbl_observacion
            // 
            this.lbl_observacion.AutoSize = true;
            this.lbl_observacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacion.ForeColor = System.Drawing.Color.White;
            this.lbl_observacion.Location = new System.Drawing.Point(65, 122);
            this.lbl_observacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_observacion.Name = "lbl_observacion";
            this.lbl_observacion.Size = new System.Drawing.Size(125, 22);
            this.lbl_observacion.TabIndex = 11;
            this.lbl_observacion.Text = "Observación";
            // 
            // lbl_empleadomov
            // 
            this.lbl_empleadomov.AutoSize = true;
            this.lbl_empleadomov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleadomov.ForeColor = System.Drawing.Color.White;
            this.lbl_empleadomov.Location = new System.Drawing.Point(8, 88);
            this.lbl_empleadomov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_empleadomov.Name = "lbl_empleadomov";
            this.lbl_empleadomov.Size = new System.Drawing.Size(187, 22);
            this.lbl_empleadomov.TabIndex = 9;
            this.lbl_empleadomov.Text = "Tipo de Movimiento";
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
            this.panel1.Location = new System.Drawing.Point(97, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 121);
            this.panel1.TabIndex = 16;
            // 
            // panel_mantenimientou
            // 
            this.panel_mantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_mantenimientou.Controls.Add(this.salir_movinventario);
            this.panel_mantenimientou.Controls.Add(this.lbl_movimientoinventario);
            this.panel_mantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_mantenimientou.Location = new System.Drawing.Point(19, 12);
            this.panel_mantenimientou.Name = "panel_mantenimientou";
            this.panel_mantenimientou.Size = new System.Drawing.Size(740, 75);
            this.panel_mantenimientou.TabIndex = 2;
            // 
            // lbl_movimientoinventario
            // 
            this.lbl_movimientoinventario.AutoSize = true;
            this.lbl_movimientoinventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movimientoinventario.ForeColor = System.Drawing.Color.White;
            this.lbl_movimientoinventario.Location = new System.Drawing.Point(232, 16);
            this.lbl_movimientoinventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_movimientoinventario.Name = "lbl_movimientoinventario";
            this.lbl_movimientoinventario.Size = new System.Drawing.Size(357, 32);
            this.lbl_movimientoinventario.TabIndex = 2;
            this.lbl_movimientoinventario.Text = "Movimientos de Inventario";
            // 
            // btn_ayudamovimiento
            // 
            this.btn_ayudamovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayudamovimiento.Image = global::CapaVista.Properties.Resources.ayuda_registro;
            this.btn_ayudamovimiento.Location = new System.Drawing.Point(479, 3);
            this.btn_ayudamovimiento.Name = "btn_ayudamovimiento";
            this.btn_ayudamovimiento.Size = new System.Drawing.Size(93, 107);
            this.btn_ayudamovimiento.TabIndex = 9;
            this.btn_ayudamovimiento.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarMovimiento.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(14, 3);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(93, 107);
            this.btnRegistrarMovimiento.TabIndex = 5;
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // btn_eliminarmovimiento
            // 
            this.btn_eliminarmovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminarmovimiento.Image = global::CapaVista.Properties.Resources.eliminar_usuario;
            this.btn_eliminarmovimiento.Location = new System.Drawing.Point(362, 3);
            this.btn_eliminarmovimiento.Name = "btn_eliminarmovimiento";
            this.btn_eliminarmovimiento.Size = new System.Drawing.Size(106, 107);
            this.btn_eliminarmovimiento.TabIndex = 8;
            this.btn_eliminarmovimiento.UseVisualStyleBackColor = true;
            this.btn_eliminarmovimiento.Click += new System.EventHandler(this.btn_eliminarmovimiento_Click);
            // 
            // btn_actualizarmovimiento
            // 
            this.btn_actualizarmovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizarmovimiento.Image = global::CapaVista.Properties.Resources.actualizar_registro;
            this.btn_actualizarmovimiento.Location = new System.Drawing.Point(243, 3);
            this.btn_actualizarmovimiento.Name = "btn_actualizarmovimiento";
            this.btn_actualizarmovimiento.Size = new System.Drawing.Size(105, 107);
            this.btn_actualizarmovimiento.TabIndex = 7;
            this.btn_actualizarmovimiento.UseVisualStyleBackColor = true;
            this.btn_actualizarmovimiento.Click += new System.EventHandler(this.btn_actualizarmovimiento_Click);
            // 
            // btn_modmovimiento
            // 
            this.btn_modmovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_modmovimiento.Image = global::CapaVista.Properties.Resources.modificar_registro;
            this.btn_modmovimiento.Location = new System.Drawing.Point(118, 3);
            this.btn_modmovimiento.Name = "btn_modmovimiento";
            this.btn_modmovimiento.Size = new System.Drawing.Size(108, 107);
            this.btn_modmovimiento.TabIndex = 6;
            this.btn_modmovimiento.UseVisualStyleBackColor = true;
            this.btn_modmovimiento.Click += new System.EventHandler(this.btn_modmovimiento_Click);
            // 
            // salir_movinventario
            // 
            this.salir_movinventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salir_movinventario.Image = global::CapaVista.Properties.Resources.salir_registro;
            this.salir_movinventario.Location = new System.Drawing.Point(3, 3);
            this.salir_movinventario.Name = "salir_movinventario";
            this.salir_movinventario.Size = new System.Drawing.Size(71, 63);
            this.salir_movinventario.TabIndex = 1;
            this.salir_movinventario.UseVisualStyleBackColor = true;
            this.salir_movinventario.Click += new System.EventHandler(this.salir_movinventario_Click);
            // 
            // Movimientos_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(749, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menumantenimientou);
            this.Controls.Add(this.panel_mantenimientou);
            this.Name = "Movimientos_de_Inventario";
            this.Text = "Movimientos de Inventario";
            this.panel_menumantenimientou.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
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