using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PanelPpal : Form
    {
        public PanelPpal()
        {
            InitializeComponent();
        }

        private void PanelPpal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            pnPpal.Dock = DockStyle.Fill;

            Form inicio = new Inicio();
            MostrarSubFormulario(inicio);
        }

        private void MostrarSubFormulario(Form subFormulario)
        {
            pnPpal.Controls.Clear();

            subFormulario.TopLevel = false;
            subFormulario.FormBorderStyle = FormBorderStyle.None;
            subFormulario.Dock = DockStyle.Fill;

            pnPpal.Controls.Add(subFormulario);
            pnPpal.Tag = subFormulario;

            subFormulario.Show();
        }
    }
}
