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

namespace GUI
{
    public partial class frmCrearUsuario : Form
    {
        ServiciosUsuario serviciosUsuario = new ServiciosUsuario();
        Validaciones validaciones = new Validaciones();
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public string GuardarUsuario()
        {
            List<string> errores = new List<string>();

            string nombrePersona = validaciones.ValidarNombre(txtNombre.Text);
            if (nombrePersona != txtNombre.Text) errores.Add(nombrePersona);

            string apellidoPersona = validaciones.ValidarApellido(txtApellido.Text);
            if (apellidoPersona != txtApellido.Text) errores.Add(apellidoPersona);

            string correoPersona = validaciones.ValidarCorreo(txtCorreoElectronico.Text);
            if (correoPersona != txtCorreoElectronico.Text) errores.Add(correoPersona);

            string nombreUsuario = validaciones.ValidarNombreUsuario(txtNombreUsuario.Text);
            if (nombreUsuario != txtNombreUsuario.Text) errores.Add(nombreUsuario);

            string contraseñaUsuario = validaciones.ValidarContraseña(txtClaveNuevo.Text);

            if (contraseñaUsuario != txtClaveNuevo.Text) errores.Add(contraseñaUsuario);

            if (errores.Count > 0)
            {
                return string.Join("\n", errores);
            }
            return serviciosUsuario.AgregarUsuario(new Usuario
            { 
                Cedula = txtCedula.Text,
                P_Nombre = txtNombre.Text,
                S_Nombre = txtSegNonbre.Text,
                P_Apellido = txtApellido.Text,
                S_Apellido = txtSegApellido.Text,
                CorreoPersona = txtCorreoElectronico.Text,
                NombreUsuario = txtNombreUsuario.Text,
                ContraseñaUsuario = txtClaveNuevo.Text,
                
            });
        }
        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnCrearUsuarioNuevo_Click(object sender, EventArgs e)
        {
            var message = GuardarUsuario();
            MessageBox.Show(message);
            limpiarDatos();
        }
        private void btnCrearUsuarioNuevo_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle myRectangle = btnCrearUsuarioNuevo.ClientRectangle;
            myRectangle.Inflate(0, 16);
            buttonPath.AddEllipse(myRectangle);
            btnCrearUsuarioNuevo.Region = new Region(buttonPath);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbrirFormulario(new Inicio());
            this.Close();
        }
        private void limpiarDatos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtSegNonbre.Text = "";
            txtApellido.Text = "";
            txtSegApellido.Text = "";
            txtCorreoElectronico.Text = "";
            txtNombreUsuario.Text = "";
            txtClaveNuevo.Text = "";
        }

        private void AbrirFormulario(Inicio inicio)
        {
            inicio.ShowDialog();
        }

        private void frmCrearUsuario_Paint(object sender, PaintEventArgs e)
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

        private void frmCrearUsuario_MouseMove(object sender, MouseEventArgs e)
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

        private void label6_MouseMove(object sender, MouseEventArgs e)
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

        private void txtPasswordNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUserNameNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
