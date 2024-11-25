namespace GUI
{
    partial class ConsultaIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.dtpFechaInicioIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtMontoIngresos = new System.Windows.Forms.TextBox();
            this.btnMostrarTodosIngresos = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblInicial = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDescargarPDF = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnEliminarIngreso = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            this.ID_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngreso.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIngreso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Ingreso,
            this.Descripcion_Ingreso,
            this.Fecha_Ingreso,
            this.Monto_Ingreso});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngreso.GridColor = System.Drawing.Color.ForestGreen;
            this.dgvIngreso.Location = new System.Drawing.Point(18, 426);
            this.dgvIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.ReadOnly = true;
            this.dgvIngreso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIngreso.RowHeadersWidth = 62;
            this.dgvIngreso.Size = new System.Drawing.Size(1503, 558);
            this.dgvIngreso.TabIndex = 0;
            // 
            // dtpFechaInicioIngreso
            // 
            this.dtpFechaInicioIngreso.CalendarMonthBackground = System.Drawing.Color.LightGreen;
            this.dtpFechaInicioIngreso.Enabled = false;
            this.dtpFechaInicioIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioIngreso.Location = new System.Drawing.Point(312, 332);
            this.dtpFechaInicioIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicioIngreso.Name = "dtpFechaInicioIngreso";
            this.dtpFechaInicioIngreso.Size = new System.Drawing.Size(500, 40);
            this.dtpFechaInicioIngreso.TabIndex = 3;
            // 
            // dtpFechaFinalIngreso
            // 
            this.dtpFechaFinalIngreso.CalendarMonthBackground = System.Drawing.Color.LightGreen;
            this.dtpFechaFinalIngreso.Enabled = false;
            this.dtpFechaFinalIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalIngreso.Location = new System.Drawing.Point(860, 332);
            this.dtpFechaFinalIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFinalIngreso.Name = "dtpFechaFinalIngreso";
            this.dtpFechaFinalIngreso.Size = new System.Drawing.Size(500, 40);
            this.dtpFechaFinalIngreso.TabIndex = 4;
            // 
            // txtMontoIngresos
            // 
            this.txtMontoIngresos.BackColor = System.Drawing.SystemColors.Window;
            this.txtMontoIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoIngresos.Location = new System.Drawing.Point(206, 1022);
            this.txtMontoIngresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMontoIngresos.Name = "txtMontoIngresos";
            this.txtMontoIngresos.Size = new System.Drawing.Size(258, 48);
            this.txtMontoIngresos.TabIndex = 5;
            this.txtMontoIngresos.TextChanged += new System.EventHandler(this.txtMontoIngresos_TextChanged);
            // 
            // btnMostrarTodosIngresos
            // 
            this.btnMostrarTodosIngresos.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMostrarTodosIngresos.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodosIngresos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarTodosIngresos.Location = new System.Drawing.Point(1092, 1022);
            this.btnMostrarTodosIngresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrarTodosIngresos.Name = "btnMostrarTodosIngresos";
            this.btnMostrarTodosIngresos.Size = new System.Drawing.Size(340, 63);
            this.btnMostrarTodosIngresos.TabIndex = 6;
            this.btnMostrarTodosIngresos.Text = "Mostrar Todo";
            this.btnMostrarTodosIngresos.UseVisualStyleBackColor = false;
            this.btnMostrarTodosIngresos.Click += new System.EventHandler(this.btnMostrarTodosIngresos_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Enabled = false;
            this.lblFecha.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(423, 274);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 42);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "FECHA";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Enabled = false;
            this.lblFechaFinal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFinal.Location = new System.Drawing.Point(998, 274);
            this.lblFechaFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(238, 42);
            this.lblFechaFinal.TabIndex = 9;
            this.lblFechaFinal.Text = "FECHA FINAL";
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.BackColor = System.Drawing.Color.Transparent;
            this.lblInicial.Enabled = false;
            this.lblInicial.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.ForeColor = System.Drawing.Color.Black;
            this.lblInicial.Location = new System.Drawing.Point(548, 274);
            this.lblInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(158, 42);
            this.lblInicial.TabIndex = 12;
            this.lblInicial.Text = "INICIAL";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Filtro Por Rango",
            "Filtrar Por Año",
            "Filtrar Por Dia"});
            this.cmbFiltros.Location = new System.Drawing.Point(482, 1025);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(247, 48);
            this.cmbFiltros.TabIndex = 11;
            this.cmbFiltros.SelectedIndexChanged += new System.EventHandler(this.cmbFiltros_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(219, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1107, 112);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consulta De Ingresos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::GUI.Properties.Resources.search_4398568;
            this.pictureBox1.Location = new System.Drawing.Point(1371, 332);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.Image = global::GUI.Properties.Resources.pdf_document_4033705;
            this.btnDescargarPDF.Location = new System.Drawing.Point(754, 1015);
            this.btnDescargarPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(78, 69);
            this.btnDescargarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDescargarPDF.TabIndex = 23;
            this.btnDescargarPDF.TabStop = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.inflation_10402101;
            this.pictureBox3.Location = new System.Drawing.Point(96, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1770, 222);
            this.panel1.TabIndex = 44;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(44, 1022);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(134, 48);
            this.txtCantidad.TabIndex = 49;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(56, 994);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(123, 25);
            this.lblCantidad.TabIndex = 50;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(280, 991);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(97, 29);
            this.lblTotal.TabIndex = 51;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(538, 992);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(122, 29);
            this.lblFiltros.TabIndex = 52;
            this.lblFiltros.Text = "FILTROS";
            // 
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.Image = global::GUI.Properties.Resources.delete_13170203;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(860, 1015);
            this.btnEliminarIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(78, 69);
            this.btnEliminarIngreso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarIngreso.TabIndex = 53;
            this.btnEliminarIngreso.TabStop = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::GUI.Properties.Resources.draw_10941010;
            this.btnEditar.Location = new System.Drawing.Point(963, 1015);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 69);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditar.TabIndex = 54;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ID_Ingreso
            // 
            this.ID_Ingreso.HeaderText = "Codigo";
            this.ID_Ingreso.MinimumWidth = 8;
            this.ID_Ingreso.Name = "ID_Ingreso";
            this.ID_Ingreso.ReadOnly = true;
            // 
            // Descripcion_Ingreso
            // 
            this.Descripcion_Ingreso.HeaderText = "Descripcion";
            this.Descripcion_Ingreso.MinimumWidth = 8;
            this.Descripcion_Ingreso.Name = "Descripcion_Ingreso";
            this.Descripcion_Ingreso.ReadOnly = true;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha";
            this.Fecha_Ingreso.MinimumWidth = 8;
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.ReadOnly = true;
            // 
            // Monto_Ingreso
            // 
            this.Monto_Ingreso.HeaderText = "Monto";
            this.Monto_Ingreso.MinimumWidth = 8;
            this.Monto_Ingreso.Name = "Monto_Ingreso";
            this.Monto_Ingreso.ReadOnly = true;
            // 
            // ConsultaIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 1100);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminarIngreso);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDescargarPDF);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMostrarTodosIngresos);
            this.Controls.Add(this.txtMontoIngresos);
            this.Controls.Add(this.dtpFechaFinalIngreso);
            this.Controls.Add(this.dtpFechaInicioIngreso);
            this.Controls.Add(this.dgvIngreso);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultaIngreso";
            this.Text = "ConsultaIngreso";
            this.Load += new System.EventHandler(this.ConsultaIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalIngreso;
        private System.Windows.Forms.TextBox txtMontoIngresos;
        private System.Windows.Forms.Button btnMostrarTodosIngresos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnDescargarPDF;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.PictureBox btnEliminarIngreso;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Ingreso;
    }
}