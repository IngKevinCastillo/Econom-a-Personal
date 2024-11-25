namespace GUI
{
    partial class ConsultaGasto
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
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnMostrarTodosGastos = new System.Windows.Forms.Button();
            this.txtGastosTotales = new System.Windows.Forms.TextBox();
            this.dtpFechaFinalGasto = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioGasto = new System.Windows.Forms.DateTimePicker();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.ID_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDescargarPDF = new System.Windows.Forms.PictureBox();
            this.BuscarGastos = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarGasto = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarPDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            this.SuspendLayout();
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
            this.lblFechaFinal.TabIndex = 16;
            this.lblFechaFinal.Text = "FECHA FINAL";
            // 
            // btnMostrarTodosGastos
            // 
            this.btnMostrarTodosGastos.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMostrarTodosGastos.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodosGastos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMostrarTodosGastos.Location = new System.Drawing.Point(1078, 1015);
            this.btnMostrarTodosGastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrarTodosGastos.Name = "btnMostrarTodosGastos";
            this.btnMostrarTodosGastos.Size = new System.Drawing.Size(340, 63);
            this.btnMostrarTodosGastos.TabIndex = 14;
            this.btnMostrarTodosGastos.Text = "Mostrar Todo";
            this.btnMostrarTodosGastos.UseVisualStyleBackColor = false;
            this.btnMostrarTodosGastos.Click += new System.EventHandler(this.btnMostrarTodosGastos_Click);
            // 
            // txtGastosTotales
            // 
            this.txtGastosTotales.BackColor = System.Drawing.SystemColors.Window;
            this.txtGastosTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGastosTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastosTotales.Location = new System.Drawing.Point(188, 1023);
            this.txtGastosTotales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGastosTotales.Name = "txtGastosTotales";
            this.txtGastosTotales.Size = new System.Drawing.Size(258, 48);
            this.txtGastosTotales.TabIndex = 13;
            this.txtGastosTotales.TextChanged += new System.EventHandler(this.txtGastosTotales_TextChanged);
            // 
            // dtpFechaFinalGasto
            // 
            this.dtpFechaFinalGasto.CalendarMonthBackground = System.Drawing.Color.LightGreen;
            this.dtpFechaFinalGasto.Enabled = false;
            this.dtpFechaFinalGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalGasto.Location = new System.Drawing.Point(860, 332);
            this.dtpFechaFinalGasto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFinalGasto.Name = "dtpFechaFinalGasto";
            this.dtpFechaFinalGasto.Size = new System.Drawing.Size(500, 40);
            this.dtpFechaFinalGasto.TabIndex = 12;
            // 
            // dtpFechaInicioGasto
            // 
            this.dtpFechaInicioGasto.CalendarMonthBackground = System.Drawing.Color.LightGreen;
            this.dtpFechaInicioGasto.Enabled = false;
            this.dtpFechaInicioGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioGasto.Location = new System.Drawing.Point(312, 332);
            this.dtpFechaInicioGasto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicioGasto.Name = "dtpFechaInicioGasto";
            this.dtpFechaInicioGasto.Size = new System.Drawing.Size(500, 40);
            this.dtpFechaInicioGasto.TabIndex = 11;
            // 
            // dgvGastos
            // 
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Egreso,
            this.Descripcion_Egreso,
            this.Prioridad_Egreso,
            this.Fecha_Egreso,
            this.Monto_Egreso,
            this.Categoria_Egreso});
            this.dgvGastos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvGastos.GridColor = System.Drawing.Color.ForestGreen;
            this.dgvGastos.Location = new System.Drawing.Point(18, 426);
            this.dgvGastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGastos.RowHeadersWidth = 62;
            this.dgvGastos.Size = new System.Drawing.Size(1564, 535);
            this.dgvGastos.TabIndex = 10;
            // 
            // ID_Egreso
            // 
            this.ID_Egreso.HeaderText = "Codigo";
            this.ID_Egreso.MinimumWidth = 8;
            this.ID_Egreso.Name = "ID_Egreso";
            this.ID_Egreso.ReadOnly = true;
            // 
            // Descripcion_Egreso
            // 
            this.Descripcion_Egreso.HeaderText = "Descripcion";
            this.Descripcion_Egreso.MinimumWidth = 8;
            this.Descripcion_Egreso.Name = "Descripcion_Egreso";
            this.Descripcion_Egreso.ReadOnly = true;
            this.Descripcion_Egreso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Prioridad_Egreso
            // 
            this.Prioridad_Egreso.HeaderText = "Prioridad";
            this.Prioridad_Egreso.MinimumWidth = 8;
            this.Prioridad_Egreso.Name = "Prioridad_Egreso";
            this.Prioridad_Egreso.ReadOnly = true;
            // 
            // Fecha_Egreso
            // 
            this.Fecha_Egreso.HeaderText = "Fecha";
            this.Fecha_Egreso.MinimumWidth = 8;
            this.Fecha_Egreso.Name = "Fecha_Egreso";
            this.Fecha_Egreso.ReadOnly = true;
            // 
            // Monto_Egreso
            // 
            this.Monto_Egreso.HeaderText = "Monto";
            this.Monto_Egreso.MinimumWidth = 8;
            this.Monto_Egreso.Name = "Monto_Egreso";
            this.Monto_Egreso.ReadOnly = true;
            // 
            // Categoria_Egreso
            // 
            this.Categoria_Egreso.HeaderText = "Categoria";
            this.Categoria_Egreso.MinimumWidth = 8;
            this.Categoria_Egreso.Name = "Categoria_Egreso";
            this.Categoria_Egreso.ReadOnly = true;
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
            this.lblInicial.TabIndex = 20;
            this.lblInicial.Text = "INICIAL";
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
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "FECHA";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Filtro Por Rango",
            "Filtrar Por Año",
            "Filtrar Por Dia"});
            this.cmbFiltros.Location = new System.Drawing.Point(454, 1023);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(247, 48);
            this.cmbFiltros.TabIndex = 18;
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
            this.label1.Size = new System.Drawing.Size(1001, 112);
            this.label1.TabIndex = 21;
            this.label1.Text = "Consulta De Gastos";
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargarPDF.Image = global::GUI.Properties.Resources.pdf_document_4033705;
            this.btnDescargarPDF.Location = new System.Drawing.Point(736, 1011);
            this.btnDescargarPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(78, 69);
            this.btnDescargarPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDescargarPDF.TabIndex = 22;
            this.btnDescargarPDF.TabStop = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // BuscarGastos
            // 
            this.BuscarGastos.BackColor = System.Drawing.SystemColors.Control;
            this.BuscarGastos.Image = global::GUI.Properties.Resources.search_4398568;
            this.BuscarGastos.Location = new System.Drawing.Point(1374, 332);
            this.BuscarGastos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarGastos.Name = "BuscarGastos";
            this.BuscarGastos.Size = new System.Drawing.Size(45, 43);
            this.BuscarGastos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuscarGastos.TabIndex = 17;
            this.BuscarGastos.TabStop = false;
            this.BuscarGastos.Click += new System.EventHandler(this.BuscarGastos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.crisis_10401862;
            this.pictureBox3.Location = new System.Drawing.Point(96, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
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
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1770, 222);
            this.panel1.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 988);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 44;
            this.label2.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 989);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "FILTROS";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(44, 1022);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(134, 48);
            this.txtCantidad.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 992);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "CANTIDAD";
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.Image = global::GUI.Properties.Resources.delete_13170203;
            this.btnEliminarGasto.Location = new System.Drawing.Point(843, 1011);
            this.btnEliminarGasto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(78, 69);
            this.btnEliminarGasto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarGasto.TabIndex = 54;
            this.btnEliminarGasto.TabStop = false;
            this.btnEliminarGasto.Click += new System.EventHandler(this.btnEliminarGasto_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::GUI.Properties.Resources.draw_10941010;
            this.btnEditar.Location = new System.Drawing.Point(945, 1011);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 69);
            this.btnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditar.TabIndex = 55;
            this.btnEditar.TabStop = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ConsultaGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 1100);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminarGasto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDescargarPDF);
            this.Controls.Add(this.lblInicial);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.BuscarGastos);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.btnMostrarTodosGastos);
            this.Controls.Add(this.txtGastosTotales);
            this.Controls.Add(this.dtpFechaFinalGasto);
            this.Controls.Add(this.dtpFechaInicioGasto);
            this.Controls.Add(this.dgvGastos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultaGasto";
            this.Text = "ConsultaGasto";
            this.Load += new System.EventHandler(this.ConsultaGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarPDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnMostrarTodosGastos;
        private System.Windows.Forms.TextBox txtGastosTotales;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalGasto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioGasto;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.PictureBox BuscarGastos;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnDescargarPDF;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnEliminarGasto;
        private System.Windows.Forms.PictureBox btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_Egreso;
    }
}