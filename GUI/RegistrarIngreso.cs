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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegistrarIngreso : Form
    {
        ServiciosUsuario ServiciosUsuario;
        Validaciones validaciones;
        public Usuario usuario {  get; set; }

        public RegistrarIngreso()
        {
            InitializeComponent();
            ServiciosUsuario = new ServiciosUsuario();
            validaciones = new Validaciones();
        }

        private void btnGuardarIngreso_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle myRectangle = btnGuardarIngreso.ClientRectangle;
            myRectangle.Inflate(0, 16);
            buttonPath.AddEllipse(myRectangle);
            btnGuardarIngreso.Region = new Region(buttonPath);
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {
            var message = GuardarIngreso();
            MessageBox.Show(message.ToString());
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            txtCantidadIngreso.Text = "";
            txtDescripcionIngreso.Text = "";
        }

        private string GuardarIngreso() =>
            !validaciones.ValidacionDescripcion(txtDescripcionIngreso.Text)
                ? "NO PUEDE TENER UN ESPACIO AL INICIO.\nNO PUEDE ESTAR VACÍO.\nNI TENER CARACTERES ESPECIALES APARTE DEL -."
                : !validaciones.ValidacionSoloNumeros(txtCantidadIngreso.Text)
                    ? "LA CANTIDAD SOLO DEBE SER NÚMEROS"
                    : ServiciosUsuario.RegistrarIngreso(new Ingreso
                    {
                        Usuario_Ingreso = usuario,
                        DescripcionIngreso = txtDescripcionIngreso.Text,
                        FechaIngreso = Fechaingreso.Value,
                        Monto = double.Parse(txtCantidadIngreso.Text),
                    });


        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            int borderRadius = 20;

            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                graphicsPath.AddArc(pictureBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                graphicsPath.AddArc(pictureBox.Width - borderRadius, pictureBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                graphicsPath.AddArc(0, pictureBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                graphicsPath.CloseFigure();

                pictureBox.Region = new Region(graphicsPath);

                using (Pen pen = new Pen(Color.Black, 2))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
        }
    }
}
