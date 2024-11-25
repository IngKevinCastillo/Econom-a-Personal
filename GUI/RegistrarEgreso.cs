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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RegistrarEgreso : Form
    {
        ServiciosUsuario serviciosUsuario;
        ServiciosCategoria serviciosCategoria;
        Validaciones validaciones;
        public Usuario usuario {  get; set; }
        public RegistrarEgreso()
        {
            InitializeComponent();
            serviciosUsuario = new ServiciosUsuario();
            serviciosCategoria = new ServiciosCategoria();
            validaciones = new Validaciones();
        }

        private void btnRegistrarEgreso_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath buttonPath = new GraphicsPath();
            Rectangle myRectangle = btnRegistrarEgreso.ClientRectangle;
            myRectangle.Inflate(0, 16);
            buttonPath.AddEllipse(myRectangle);
            btnRegistrarEgreso.Region = new Region(buttonPath);
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            var message = GuardarEgreso();
            MessageBox.Show(message);
            limpiarDatos();

        }

        private string GuardarEgreso() =>
   cmbPrioridadEgreso.SelectedIndex == -1
       ? "Debe seleccionar una prioridad."
       : cmbCategoriaEgreso.SelectedIndex == -1
           ? "Debe seleccionar una categoría."
           : !validaciones.ValidacionDescripcion(txtDescripcionEgreso.Text)
               ? "NO PUEDE TENER UN ESPACIO AL INICIO.\nNO PUEDE ESTAR VACÍO.\nNI TENER CARACTERES ESPECIALES APARTE DEL -."
               : !validaciones.ValidacionSoloNumeros(txtCantidadEgreso.Text)
                   ? "LA CANTIDAD SOLO DEBE SER NÚMEROS"
                   : serviciosUsuario.RegistrarGasto(new Gasto
                   {
                       Usuario = usuario,
                       DescripcionGasto = txtDescripcionEgreso.Text,
                       PrioridadGasto = cmbPrioridadEgreso.Text,
                       Categoria_Gasto = serviciosCategoria.BuscarCategoriaNombre(cmbCategoriaEgreso.Text),
                       FechaGasto = Fechaegreso.Value,
                       Monto = double.Parse(txtCantidadEgreso.Text),
                   });


        private void limpiarDatos()
        {
            txtCantidadEgreso.Text = "";
            txtDescripcionEgreso.Text = "";
            cmbCategoriaEgreso.Text = "";
            cmbPrioridadEgreso.Text = "";
        }

        private void cbbCategoriaEgreso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarEgreso_Load(object sender, EventArgs e)
        {
            CargarComboBox();
           
        }
        void CargarComboBox()
        {
            cmbCategoriaEgreso.Items.Clear();
            List<Categoria> categorias = serviciosCategoria.ObtenerCategorias().FindAll(categoria => categoria.CedulaUsuario == usuario.Cedula);
            foreach (var item in categorias)
            {
                cmbCategoriaEgreso.Items.Add(item.Nombre_Categoria);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
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
