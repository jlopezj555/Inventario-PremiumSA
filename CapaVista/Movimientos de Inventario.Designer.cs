
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tipomov = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbl_fechamov = new System.Windows.Forms.Label();
            this.lbl_observacion = new System.Windows.Forms.Label();
            this.lbl_empleadomov = new System.Windows.Forms.Label();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.panel_mantenimientou = new System.Windows.Forms.Panel();
            this.salir_movinventario = new System.Windows.Forms.Button();
            this.lbl_movimientoinventario = new System.Windows.Forms.Label();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.panel_menumantenimientou.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_mantenimientou.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menumantenimientou
            // 
            this.panel_menumantenimientou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menumantenimientou.Controls.Add(this.dgvMovimientos);
            this.panel_menumantenimientou.Controls.Add(this.panel2);
            this.panel_menumantenimientou.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_menumantenimientou.Location = new System.Drawing.Point(25, 115);
            this.panel_menumantenimientou.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_menumantenimientou.Name = "panel_menumantenimientou";
            this.panel_menumantenimientou.Size = new System.Drawing.Size(986, 892);
            this.panel_menumantenimientou.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbEquipo);
            this.panel2.Controls.Add(this.cmbUsuario);
            this.panel2.Controls.Add(this.cmbTipoMovimiento);
            this.panel2.Controls.Add(this.lbl_tipomov);
            this.panel2.Controls.Add(this.btnRegistrarMovimiento);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.lbl_fechamov);
            this.panel2.Controls.Add(this.lbl_observacion);
            this.panel2.Controls.Add(this.lbl_empleadomov);
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(78, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 213);
            this.panel2.TabIndex = 15;
            // 
            // lbl_tipomov
            // 
            this.lbl_tipomov.AutoSize = true;
            this.lbl_tipomov.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipomov.ForeColor = System.Drawing.Color.White;
            this.lbl_tipomov.Location = new System.Drawing.Point(122, 24);
            this.lbl_tipomov.Name = "lbl_tipomov";
            this.lbl_tipomov.Size = new System.Drawing.Size(125, 28);
            this.lbl_tipomov.TabIndex = 4;
            this.lbl_tipomov.Text = "ID Equipo";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(312, 156);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(245, 22);
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
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarMovimiento.Image = global::CapaVista.Properties.Resources.guardar_registro1;
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(636, 30);
            this.btnRegistrarMovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(124, 132);
            this.btnRegistrarMovimiento.TabIndex = 5;
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
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
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(311, 114);
            this.cmbTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(246, 24);
            this.cmbTipoMovimiento.TabIndex = 32;
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Location = new System.Drawing.Point(78, 237);
            this.dgvMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.RowHeadersWidth = 62;
            this.dgvMovimientos.Size = new System.Drawing.Size(866, 278);
            this.dgvMovimientos.TabIndex = 6;
            this.dgvMovimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimientos_CellClick);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(312, 75);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(246, 24);
            this.cmbUsuario.TabIndex = 33;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(312, 30);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(246, 24);
            this.cmbEquipo.TabIndex = 34;
            // 
            // Movimientos_de_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1033, 652);
            this.Controls.Add(this.panel_menumantenimientou);
            this.Controls.Add(this.panel_mantenimientou);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Movimientos_de_Inventario";
            this.Text = "Movimientos de Inventario";
            this.panel_menumantenimientou.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_mantenimientou.ResumeLayout(false);
            this.panel_mantenimientou.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
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
    }
}