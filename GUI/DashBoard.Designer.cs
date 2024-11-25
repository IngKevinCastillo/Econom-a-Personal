namespace GUI
{
    partial class DashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbIntervalo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPromedioIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPromedioEgresos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTotalEgresos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dvlIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlvEgresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpMes = new System.Windows.Forms.DateTimePicker();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvlIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Enabled = false;
            this.lblMes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Black;
            this.lblMes.Location = new System.Drawing.Point(102, 234);
            this.lblMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(64, 28);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "MES:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Enabled = false;
            this.lblAño.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.Black;
            this.lblAño.Location = new System.Drawing.Point(506, 232);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(64, 28);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "AÑO:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-28, -32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1674, 222);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::GUI.Properties.Resources.inflation_10402101;
            this.pictureBox3.Location = new System.Drawing.Point(74, 54);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 112);
            this.label2.TabIndex = 42;
            this.label2.Text = "REPORTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::GUI.Properties.Resources.search_4398568;
            this.pictureBox1.Location = new System.Drawing.Point(1300, 263);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbIntervalo
            // 
            this.cmbIntervalo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIntervalo.ForeColor = System.Drawing.Color.Black;
            this.cmbIntervalo.FormattingEnabled = true;
            this.cmbIntervalo.Items.AddRange(new object[] {
            "MENSUAL",
            "ANUAL"});
            this.cmbIntervalo.Location = new System.Drawing.Point(922, 266);
            this.cmbIntervalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIntervalo.Name = "cmbIntervalo";
            this.cmbIntervalo.Size = new System.Drawing.Size(344, 36);
            this.cmbIntervalo.TabIndex = 9;
            this.cmbIntervalo.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(916, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "INTERVALO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.txtTotalIngreso);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(45, 368);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 205);
            this.panel2.TabIndex = 11;
            // 
            // txtTotalIngreso
            // 
            this.txtTotalIngreso.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngreso.ForeColor = System.Drawing.Color.Black;
            this.txtTotalIngreso.Location = new System.Drawing.Point(26, 78);
            this.txtTotalIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalIngreso.Name = "txtTotalIngreso";
            this.txtTotalIngreso.Size = new System.Drawing.Size(271, 41);
            this.txtTotalIngreso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL INGRESOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.txtPromedioIngreso);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(747, 368);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 205);
            this.panel3.TabIndex = 12;
            // 
            // txtPromedioIngreso
            // 
            this.txtPromedioIngreso.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioIngreso.ForeColor = System.Drawing.Color.Black;
            this.txtPromedioIngreso.Location = new System.Drawing.Point(22, 78);
            this.txtPromedioIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPromedioIngreso.Name = "txtPromedioIngreso";
            this.txtPromedioIngreso.Size = new System.Drawing.Size(271, 41);
            this.txtPromedioIngreso.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "PROMEDIO INGRESOS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.txtPromedioEgresos);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(1101, 368);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 205);
            this.panel4.TabIndex = 12;
            // 
            // txtPromedioEgresos
            // 
            this.txtPromedioEgresos.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedioEgresos.ForeColor = System.Drawing.Color.Black;
            this.txtPromedioEgresos.Location = new System.Drawing.Point(24, 78);
            this.txtPromedioEgresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPromedioEgresos.Name = "txtPromedioEgresos";
            this.txtPromedioEgresos.Size = new System.Drawing.Size(271, 41);
            this.txtPromedioEgresos.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "PROMEDIO EGRESOS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(121)))), ((int)(((byte)(43)))));
            this.panel5.Controls.Add(this.txtTotalEgresos);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(394, 368);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 205);
            this.panel5.TabIndex = 13;
            // 
            // txtTotalEgresos
            // 
            this.txtTotalEgresos.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEgresos.ForeColor = System.Drawing.Color.Black;
            this.txtTotalEgresos.Location = new System.Drawing.Point(24, 78);
            this.txtTotalEgresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalEgresos.Name = "txtTotalEgresos";
            this.txtTotalEgresos.Size = new System.Drawing.Size(271, 41);
            this.txtTotalEgresos.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(62, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "TOTAL EGRESOS";
            // 
            // dvlIngresos
            // 
            chartArea3.Name = "ChartArea1";
            this.dvlIngresos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.dvlIngresos.Legends.Add(legend3);
            this.dvlIngresos.Location = new System.Drawing.Point(28, 657);
            this.dvlIngresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvlIngresos.Name = "dvlIngresos";
            this.dvlIngresos.Size = new System.Drawing.Size(698, 426);
            this.dvlIngresos.TabIndex = 14;
            this.dvlIngresos.Text = "chart1";
            // 
            // dlvEgresos
            // 
            chartArea4.Name = "ChartArea1";
            this.dlvEgresos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.dlvEgresos.Legends.Add(legend4);
            this.dlvEgresos.Location = new System.Drawing.Point(750, 657);
            this.dlvEgresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dlvEgresos.Name = "dlvEgresos";
            this.dlvEgresos.Size = new System.Drawing.Size(684, 426);
            this.dlvEgresos.TabIndex = 15;
            this.dlvEgresos.Text = "chart2";
            // 
            // dtpMes
            // 
            this.dtpMes.Enabled = false;
            this.dtpMes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMes.Location = new System.Drawing.Point(108, 268);
            this.dtpMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpMes.Name = "dtpMes";
            this.dtpMes.Size = new System.Drawing.Size(344, 36);
            this.dtpMes.TabIndex = 11;
            // 
            // dtpAño
            // 
            this.dtpAño.Enabled = false;
            this.dtpAño.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAño.Location = new System.Drawing.Point(512, 268);
            this.dtpAño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.Size = new System.Drawing.Size(344, 36);
            this.dtpAño.TabIndex = 12;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 1100);
            this.Controls.Add(this.dtpAño);
            this.Controls.Add(this.dlvEgresos);
            this.Controls.Add(this.dtpMes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvlIngresos);
            this.Controls.Add(this.cmbIntervalo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvlIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlvEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbIntervalo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalIngreso;
        private System.Windows.Forms.TextBox txtPromedioIngreso;
        private System.Windows.Forms.TextBox txtPromedioEgresos;
        private System.Windows.Forms.TextBox txtTotalEgresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart dvlIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart dlvEgresos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpAño;
        private System.Windows.Forms.DateTimePicker dtpMes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}