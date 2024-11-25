namespace GUI
{
    partial class RegistrarIngreso
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
            this.btnGuardarIngreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionIngreso = new System.Windows.Forms.TextBox();
            this.txtCantidadIngreso = new System.Windows.Forms.TextBox();
            this.Fechaingreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarIngreso
            // 
            this.btnGuardarIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarIngreso.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardarIngreso.FlatAppearance.BorderSize = 0;
            this.btnGuardarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarIngreso.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarIngreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardarIngreso.Location = new System.Drawing.Point(542, 758);
            this.btnGuardarIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarIngreso.Name = "btnGuardarIngreso";
            this.btnGuardarIngreso.Size = new System.Drawing.Size(336, 94);
            this.btnGuardarIngreso.TabIndex = 5;
            this.btnGuardarIngreso.Text = "REGISTRAR";
            this.btnGuardarIngreso.UseVisualStyleBackColor = false;
            this.btnGuardarIngreso.Click += new System.EventHandler(this.btnGuardarIngreso_Click);
            this.btnGuardarIngreso.Paint += new System.Windows.Forms.PaintEventHandler(this.btnGuardarIngreso_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 112);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registrar Ingreso";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(756, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "DESCRIPCION DEL INGRESO";
            // 
            // txtDescripcionIngreso
            // 
            this.txtDescripcionIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcionIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcionIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionIngreso.Location = new System.Drawing.Point(764, 477);
            this.txtDescripcionIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcionIngreso.Name = "txtDescripcionIngreso";
            this.txtDescripcionIngreso.Size = new System.Drawing.Size(461, 48);
            this.txtDescripcionIngreso.TabIndex = 17;
            // 
            // txtCantidadIngreso
            // 
            this.txtCantidadIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCantidadIngreso.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidadIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadIngreso.Location = new System.Drawing.Point(196, 477);
            this.txtCantidadIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadIngreso.Name = "txtCantidadIngreso";
            this.txtCantidadIngreso.Size = new System.Drawing.Size(461, 48);
            this.txtCantidadIngreso.TabIndex = 16;
            // 
            // Fechaingreso
            // 
            this.Fechaingreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fechaingreso.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.Fechaingreso.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.Fechaingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechaingreso.Location = new System.Drawing.Point(196, 608);
            this.Fechaingreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fechaingreso.Name = "Fechaingreso";
            this.Fechaingreso.Size = new System.Drawing.Size(460, 48);
            this.Fechaingreso.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(189, 560);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 42);
            this.label6.TabIndex = 24;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(189, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 42);
            this.label5.TabIndex = 35;
            this.label5.Text = "CANTIDAD";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.charity_3782269;
            this.pictureBox3.Location = new System.Drawing.Point(111, 55);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
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
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1557, 222);
            this.panel1.TabIndex = 46;
            // 
            // RegistrarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1450, 1100);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fechaingreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionIngreso);
            this.Controls.Add(this.txtCantidadIngreso);
            this.Controls.Add(this.btnGuardarIngreso);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarIngreso";
            this.Text = "RegistrarIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionIngreso;
        private System.Windows.Forms.TextBox txtCantidadIngreso;
        private System.Windows.Forms.DateTimePicker Fechaingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}