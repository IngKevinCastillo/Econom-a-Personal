using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        bool ExpanciondeBarra = false;
        ServiciosUsuario Servicios;
        public Usuario usuario { get; set; }
        public Menu()
        {
            InitializeComponent();
            OcultarTodosLosPaneles();
            Servicios = new ServiciosUsuario();
 
            //ExpancionTimer.Start();
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private void AlternarPanel(Panel panel)
        {
            if (panel.Visible)
            {
                panel.Visible = false;
                panelPrincipal.Controls.Clear();
            }
            else
            {
                OcultarTodosLosPaneles();  
                panel.Visible = true;    
            }
        }

        private void OcultarTodosLosPaneles()
        {
            panel3.Visible = false;
            panel8.Visible = false;
        }

        private void AbrirFormulario(Login login)
        {
            login.ShowDialog();
        }


        //-----------------------------------------------------------------------------------------------------------
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 30;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }
        //------------------------------------------------------------------------------------------------------
        private void MostrarSubFormulario(Form subFormulario)
        {
            panelPrincipal.Controls.Clear();

            subFormulario.TopLevel = false;
            subFormulario.FormBorderStyle = FormBorderStyle.None;
            subFormulario.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(subFormulario);
            panelPrincipal.Tag = subFormulario;

            subFormulario.Show();
        }
        //------------------------------------------------------------------------------------------------------
 
        private void btnConsultaIngresos_Click(object sender, EventArgs e)
        {
            Form consultaingreso = new ConsultaIngreso(usuario);
            MostrarSubFormulario(consultaingreso);
        }

        private void btnConsultaEgresos_Click(object sender, EventArgs e)
        {
            Form consultagasto = new ConsultaGasto(usuario);
            MostrarSubFormulario(consultagasto);
        }
        //---------------------------------------------------------------------------

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            AlternarPanel(panel3);
        }

        private void btnRegistraIngresos_Click(object sender, EventArgs e)
        {
            Form registrarIngreso = new RegistrarIngreso { usuario = this.usuario };
            MostrarSubFormulario(registrarIngreso);
        }

        private void btnRegistrarEgresos_Click(object sender, EventArgs e)
        {
            Form registrarEgreso = new RegistrarEgreso { usuario = this.usuario };
            MostrarSubFormulario(registrarEgreso);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AlternarPanel(panel8);
        }

        private void btnConsultaIngreso_Click(object sender, EventArgs e)
        {
            Form consultaingreso = new ConsultaIngreso(usuario);
            MostrarSubFormulario(consultaingreso);
        }

        private void btnConsultaEgreso_Click(object sender, EventArgs e)
        {
            Form consultagasto = new ConsultaGasto(usuario);
            MostrarSubFormulario(consultagasto);
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void panelPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AlternarPanel(panel3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form registrarIngreso = new RegistrarIngreso { usuario = this.usuario };
            MostrarSubFormulario(registrarIngreso);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form registrarEgreso = new RegistrarEgreso { usuario = this.usuario };
            MostrarSubFormulario(registrarEgreso);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AlternarPanel(panel8);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form consultaingreso = new ConsultaIngreso(usuario);
            MostrarSubFormulario(consultaingreso);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form consultagasto = new ConsultaGasto(usuario);
            MostrarSubFormulario(consultagasto);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form registrarIngreso = new RegistrarIngreso { usuario = this.usuario };
            MostrarSubFormulario(registrarIngreso);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form registrarEgreso = new RegistrarEgreso { usuario = this.usuario };
            MostrarSubFormulario(registrarEgreso);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form consultaingreso = new ConsultaIngreso(usuario);
            MostrarSubFormulario(consultaingreso);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form consultagasto = new ConsultaGasto(usuario);
            MostrarSubFormulario(consultagasto);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AlternarPanel(panel3);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            AlternarPanel(panel8);
        }

        private void panel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Cerrar Sesion?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    AbrirFormulario(new Login());
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox3_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form dashboardingresos = new DashBoard(usuario);
            MostrarSubFormulario(dashboardingresos);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form dashboardingresos = new DashBoard(usuario);
            MostrarSubFormulario(dashboardingresos);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Maximized;
        }

        private void btnRegistraIngresos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form dashboardingresos = new DashBoard(usuario);
            MostrarSubFormulario(dashboardingresos);
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            Form gestionDeCategoria = new GestionDeCategorias(usuario);
            MostrarSubFormulario(gestionDeCategoria);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form gestionDeCategoria = new GestionDeCategorias(usuario);
            MostrarSubFormulario(gestionDeCategoria);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form gestionDeCategoria = new GestionDeCategorias(usuario);
            MostrarSubFormulario(gestionDeCategoria);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
        }
    }
}
