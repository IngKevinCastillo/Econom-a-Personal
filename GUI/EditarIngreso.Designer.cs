namespace GUI
{
    partial class EditarIngreso
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
            this.btnEditarIngreso = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Fechaingreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionIngreso = new System.Windows.Forms.TextBox();
            this.txtCantidadIngreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditarIngreso
            // 
            this.btnEditarIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditarIngreso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditarIngreso.FlatAppearance.BorderSize = 0;
            this.btnEditarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarIngreso.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarIngreso.Location = new System.Drawing.Point(297, 314);
            this.btnEditarIngreso.Name = "btnEditarIngreso";
            this.btnEditarIngreso.Size = new System.Drawing.Size(237, 67);
            this.btnEditarIngreso.TabIndex = 25;
            this.btnEditarIngreso.Text = "EDITAR";
            this.btnEditarIngreso.UseVisualStyleBackColor = false;
            this.btnEditarIngreso.Click += new System.EventHandler(this.btnRegistrarEgreso_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(758, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(53, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "CANTIDAD";
            // 
            // Fechaingreso
            // 
            this.Fechaingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechaingreso.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.Fechaingreso.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.Fechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaingreso.Location = new System.Drawing.Point(58, 221);
            this.Fechaingreso.Name = "Fechaingreso";
            this.Fechaingreso.Size = new System.Drawing.Size(308, 35);
            this.Fechaingreso.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(53, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 28);
            this.label6.TabIndex = 45;
            this.label6.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(431, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "DESCRIPCION DEL INGRESO";
            // 
            // txtDescripcionIngreso
            // 
            this.txtDescripcionIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcionIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcionIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionIngreso.Location = new System.Drawing.Point(436, 136);
            this.txtDescripcionIngreso.Name = "txtDescripcionIngreso";
            this.txtDescripcionIngreso.Size = new System.Drawing.Size(308, 35);
            this.txtDescripcionIngreso.TabIndex = 43;
            // 
            // txtCantidadIngreso
            // 
            this.txtCantidadIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadIngreso.Location = new System.Drawing.Point(58, 136);
            this.txtCantidadIngreso.Name = "txtCantidadIngreso";
            this.txtCantidadIngreso.Size = new System.Drawing.Size(308, 35);
            this.txtCantidadIngreso.TabIndex = 42;
            // 
            // EditarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fechaingreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionIngreso);
            this.Controls.Add(this.txtCantidadIngreso);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditarIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarIngreso";
            this.Text = "EditarIngreso";
            this.Load += new System.EventHandler(this.EditarIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditarIngreso;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Fechaingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionIngreso;
        private System.Windows.Forms.TextBox txtCantidadIngreso;
    }
}