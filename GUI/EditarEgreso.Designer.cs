namespace GUI
{
    partial class EditarEgreso
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
            this.Fechaegreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPrioridadEgreso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategoriaEgreso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionEgreso = new System.Windows.Forms.TextBox();
            this.btnEditarEgreso = new System.Windows.Forms.Button();
            this.txtCantidadEgreso = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fechaegreso
            // 
            this.Fechaegreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechaegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaegreso.Location = new System.Drawing.Point(102, 425);
            this.Fechaegreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fechaegreso.Name = "Fechaegreso";
            this.Fechaegreso.Size = new System.Drawing.Size(460, 43);
            this.Fechaegreso.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(100, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 42);
            this.label6.TabIndex = 33;
            this.label6.Text = "FECHA";
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
            this.cmbPrioridadEgreso.Location = new System.Drawing.Point(642, 274);
            this.cmbPrioridadEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPrioridadEgreso.Name = "cmbPrioridadEgreso";
            this.cmbPrioridadEgreso.Size = new System.Drawing.Size(460, 48);
            this.cmbPrioridadEgreso.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(96, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 42);
            this.label5.TabIndex = 31;
            this.label5.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(636, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "PRIORIDAD EGRESO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(100, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "CATEGORIA EGRESO";
            // 
            // cmbCategoriaEgreso
            // 
            this.cmbCategoriaEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategoriaEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCategoriaEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaEgreso.FormattingEnabled = true;
            this.cmbCategoriaEgreso.Location = new System.Drawing.Point(108, 274);
            this.cmbCategoriaEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoriaEgreso.Name = "cmbCategoriaEgreso";
            this.cmbCategoriaEgreso.Size = new System.Drawing.Size(460, 48);
            this.cmbCategoriaEgreso.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(634, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "DESCRIPCION DEL EGRESO";
            // 
            // txtDescripcionEgreso
            // 
            this.txtDescripcionEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcionEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcionEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEgreso.Location = new System.Drawing.Point(642, 123);
            this.txtDescripcionEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcionEgreso.Name = "txtDescripcionEgreso";
            this.txtDescripcionEgreso.Size = new System.Drawing.Size(461, 48);
            this.txtDescripcionEgreso.TabIndex = 26;
            // 
            // btnEditarEgreso
            // 
            this.btnEditarEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditarEgreso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditarEgreso.FlatAppearance.BorderSize = 0;
            this.btnEditarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEgreso.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEgreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarEgreso.Location = new System.Drawing.Point(430, 543);
            this.btnEditarEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarEgreso.Name = "btnEditarEgreso";
            this.btnEditarEgreso.Size = new System.Drawing.Size(356, 103);
            this.btnEditarEgreso.TabIndex = 25;
            this.btnEditarEgreso.Text = "EDITAR";
            this.btnEditarEgreso.UseVisualStyleBackColor = false;
            this.btnEditarEgreso.Click += new System.EventHandler(this.btnEditarEgreso_Click);
            // 
            // txtCantidadEgreso
            // 
            this.txtCantidadEgreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadEgreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadEgreso.Location = new System.Drawing.Point(102, 123);
            this.txtCantidadEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadEgreso.Name = "txtCantidadEgreso";
            this.txtCantidadEgreso.Size = new System.Drawing.Size(461, 48);
            this.txtCantidadEgreso.TabIndex = 24;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1120, 18);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 46);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // EditarEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Fechaegreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPrioridadEgreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoriaEgreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionEgreso);
            this.Controls.Add(this.btnEditarEgreso);
            this.Controls.Add(this.txtCantidadEgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditarEgreso";
            this.Text = "EditarEgreso";
            this.Load += new System.EventHandler(this.EditarEgreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fechaegreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPrioridadEgreso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoriaEgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionEgreso;
        private System.Windows.Forms.Button btnEditarEgreso;
        private System.Windows.Forms.TextBox txtCantidadEgreso;
        private System.Windows.Forms.Button btnCerrar;
    }
}