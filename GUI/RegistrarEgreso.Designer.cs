namespace GUI
{
    partial class RegistrarEgreso
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
            this.btnRegistrarEgreso = new System.Windows.Forms.Button();
            this.txtCantidadEgreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionEgreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaEgreso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrioridadEgreso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Fechaegreso = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarEgreso
            // 
            this.btnRegistrarEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarEgreso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegistrarEgreso.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEgreso.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEgreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarEgreso.Location = new System.Drawing.Point(382, 558);
            this.btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            this.btnRegistrarEgreso.Size = new System.Drawing.Size(237, 67);
            this.btnRegistrarEgreso.TabIndex = 11;
            this.btnRegistrarEgreso.Text = "REGISTRAR";
            this.btnRegistrarEgreso.UseVisualStyleBackColor = false;
            this.btnRegistrarEgreso.Click += new System.EventHandler(this.btnRegistrarEgreso_Click);
            this.btnRegistrarEgreso.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRegistrarEgreso_Paint);
            // 
            // txtCantidadEgreso
            // 
            this.txtCantidadEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEgreso.Location = new System.Drawing.Point(147, 263);
            this.txtCantidadEgreso.Name = "txtCantidadEgreso";
            this.txtCantidadEgreso.Size = new System.Drawing.Size(308, 35);
            this.txtCantidadEgreso.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(149, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(592, 75);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registrar Egreso";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDescripcionEgreso
            // 
            this.txtDescripcionEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcionEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcionEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEgreso.Location = new System.Drawing.Point(507, 263);
            this.txtDescripcionEgreso.Name = "txtDescripcionEgreso";
            this.txtDescripcionEgreso.Size = new System.Drawing.Size(308, 35);
            this.txtDescripcionEgreso.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(502, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "DESCRIPCION DEL EGRESO";
            // 
            // cmbCategoriaEgreso
            // 
            this.cmbCategoriaEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategoriaEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCategoriaEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaEgreso.FormattingEnabled = true;
            this.cmbCategoriaEgreso.Location = new System.Drawing.Point(151, 361);
            this.cmbCategoriaEgreso.Name = "cmbCategoriaEgreso";
            this.cmbCategoriaEgreso.Size = new System.Drawing.Size(308, 37);
            this.cmbCategoriaEgreso.TabIndex = 16;
            this.cmbCategoriaEgreso.SelectedIndexChanged += new System.EventHandler(this.cbbCategoriaEgreso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(146, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "CATEGORIA EGRESO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(503, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "PRIORIDAD EGRESO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(143, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "CANTIDAD";
            // 
            // cmbPrioridadEgreso
            // 
            this.cmbPrioridadEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPrioridadEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPrioridadEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridadEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridadEgreso.FormattingEnabled = true;
            this.cmbPrioridadEgreso.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbPrioridadEgreso.Location = new System.Drawing.Point(507, 361);
            this.cmbPrioridadEgreso.Name = "cmbPrioridadEgreso";
            this.cmbPrioridadEgreso.Size = new System.Drawing.Size(308, 37);
            this.cmbPrioridadEgreso.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(146, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "FECHA";
            // 
            // Fechaegreso
            // 
            this.Fechaegreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechaegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaegreso.Location = new System.Drawing.Point(147, 459);
            this.Fechaegreso.Name = "Fechaegreso";
            this.Fechaegreso.Size = new System.Drawing.Size(308, 31);
            this.Fechaegreso.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.pay_1570917;
            this.pictureBox3.Location = new System.Drawing.Point(67, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 144);
            this.panel1.TabIndex = 45;
            // 
            // RegistrarEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Fechaegreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPrioridadEgreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoriaEgreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionEgreso);
            this.Controls.Add(this.btnRegistrarEgreso);
            this.Controls.Add(this.txtCantidadEgreso);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarEgreso";
            this.Text = "RegistrarEgreso";
            this.Load += new System.EventHandler(this.RegistrarEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarEgreso;
        private System.Windows.Forms.TextBox txtCantidadEgreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionEgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaEgreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrioridadEgreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Fechaegreso;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}