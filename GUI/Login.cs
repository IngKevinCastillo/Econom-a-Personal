using Entidades;
using Entity;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI
{
    public partial class Login : Form
    {
        ServiciosUsuario serviciosUsuario = new ServiciosUsuario();
        Validaciones validaciones = new Validaciones();
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private void Login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }
        private void iniciarSesion()
        {
            List<string> errores = new List<string>();
            string nombreUsuario = validaciones.ValidarNombreUsuario(txtUserName.Text);
            if (nombreUsuario != txtUserName.Text) errores.Add(nombreUsuario);

            //string contraseñaUsuario = validaciones.ValidarContraseña(txtPassword.Text);
            //if (contraseñaUsuario != txtPassword.Text) errores.Add(contraseñaUsuario);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores));
            }
            else
            {
                if (serviciosUsuario.validarUsuario(txtUserName.Text, txtPassword.Text) == false)
                {
                    MessageBox.Show("USUARIO NO ENCONTRADO");
                }
                else
                {
                    Usuario usuarioIniciado = serviciosUsuario.BuscarUsuarioNombre(txtUserName.Text);
                    this.Hide();
                    AbrirFormulario(new Menu { usuario = serviciosUsuario.BuscarUsuarioNombre(txtUserName.Text) });
                    this.Close();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario(new Inicio());
        }

        private void AbrirFormulario(Inicio inicio)
        {
            this.Hide();
            this.Close();
            inicio.ShowDialog();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
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

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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

        private void btnIniciarSesion_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle myRectangle = btnIniciarSesion.ClientRectangle;
            myRectangle.Inflate(0, 16);
            buttonPath.AddEllipse(myRectangle);
            btnIniciarSesion.Region = new Region(buttonPath);

            
        }
        private void AbrirFormulario(Menu menu)
        {
            menu.ShowDialog();

        }
        private void chbMostrarContraceña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarContraceña.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio());
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
