namespace GUI
{
    partial class PanelPpal
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
            this.pnPpal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnPpal
            // 
            this.pnPpal.Location = new System.Drawing.Point(-3, -1);
            this.pnPpal.Name = "pnPpal";
            this.pnPpal.Size = new System.Drawing.Size(807, 454);
            this.pnPpal.TabIndex = 0;
            // 
            // PanelPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnPpal);
            this.Name = "PanelPpal";
            this.Text = "PanelPpal";
            this.Load += new System.EventHandler(this.PanelPpal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPpal;
    }
}