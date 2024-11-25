using Entidades;
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
    public partial class GestionDeCategorias : Form
    {
        ServiciosCategoria serviciosCategoria;
        ServiciosUsuario serviciosUsuario;
        Usuario UsuarioSesion;
        public GestionDeCategorias(Usuario usuarioSesion)
        {
            InitializeComponent();
            serviciosCategoria = new ServiciosCategoria();
            serviciosUsuario = new ServiciosUsuario();
            UsuarioSesion = usuarioSesion;
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            var mesage = BuscarCategoria();
            MessageBox.Show(mesage);
        }

        private string BuscarCategoria()
        {
            List<Categoria> categoriasDeUsuario = serviciosCategoria.ObtenerCategorias().FindAll(categoria => categoria.CedulaUsuario == UsuarioSesion.Cedula);
            Categoria categoriaEncontrada = categoriasDeUsuario.Find(categoria => categoria.Nombre_Categoria == txtCategoriaBuscar.Text);
            if (categoriaEncontrada == null)
            {
                return "Categoria No encontrada.";
            }
            else
            {
                foreach (DataGridViewRow row in dgvListaCategoria.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == categoriaEncontrada.Id_Categoria)
                    {
                        row.Selected = true;
                        dgvListaCategoria.CurrentCell = row.Cells[0];
                        break;
                    }
                }
                return "Categoria Encontrada.";
            }
        }

        private void GestionDeCategorias_Load(object sender, EventArgs e)
        {
            dgvListaCategoria.Rows.Clear();
            cargarcategorias(serviciosCategoria.ObtenerCategorias());
            dgvListaCategoria.DefaultCellStyle.ForeColor = Color.Black;
            dgvListaCategoria.DefaultCellStyle.BackColor = Color.White;
            dgvListaCategoria.EnableHeadersVisualStyles = false;
            dgvListaCategoria.MultiSelect = false;
            dgvListaCategoria.Columns[0].ReadOnly = true;
        }

        private void cargarcategorias(List<Categoria> tabla)
        {
            List<Categoria> categoriasDeUsuario = tabla.FindAll(categoria => categoria.CedulaUsuario == UsuarioSesion.Cedula);
            dgvListaCategoria.Rows.Clear();
            dgvListaCategoria.AutoGenerateColumns = false;
            foreach (Categoria categoria in categoriasDeUsuario)
            {
                dgvListaCategoria.Rows.Add(
                    categoria.Id_Categoria,
                    categoria.Nombre_Categoria
                );
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            eliminarcategoria();
        }
        private void eliminarcategoria()
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la categoria?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string codigo = dgvListaCategoria.CurrentRow.Cells[0].Value.ToString();
                    serviciosCategoria.EliminarCategoria(codigo);
                    cargarcategorias(serviciosCategoria.ObtenerCategorias());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AgregarCategoria(UsuarioSesion));
            cargarcategorias(serviciosCategoria.ObtenerCategorias());
        }

        private void AbrirFormulario(AgregarCategoria agregarCategoria)
        {
            agregarCategoria.ShowDialog();
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
