using Entidades;
using Logica;
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
    public partial class EditarEgreso : Form
    {
        Gasto gasto_Usuario;
        ServiciosUsuario serviciosUsuario;
        ServiciosCategoria serviciosCategoria;
        public EditarEgreso(Gasto gasto)
        {
            serviciosUsuario = new ServiciosUsuario();
            serviciosCategoria = new ServiciosCategoria();
            InitializeComponent();
            gasto_Usuario = gasto;
            serviciosUsuario.RecuperacionDatos(gasto.Usuario);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditarEgreso_Load(object sender, EventArgs e)
        {
            CargarEgreso();
            CargarComboBox();
        }
        void CargarComboBox()
        {
            cmbCategoriaEgreso.Items.Clear();
            List<Categoria> categorias = serviciosCategoria.ObtenerCategorias().FindAll(categoria => categoria.CedulaUsuario == gasto_Usuario.Usuario.Cedula);
            foreach (var item in categorias)
            {
                cmbCategoriaEgreso.Items.Add(item.Nombre_Categoria);
            }
        }

        private void CargarEgreso()
        {
            txtCantidadEgreso.Text = gasto_Usuario.Monto.ToString();
            txtDescripcionEgreso.Text = gasto_Usuario.DescripcionGasto;
            cmbCategoriaEgreso.Text = gasto_Usuario.Categoria_Gasto.Nombre_Categoria;
            cmbPrioridadEgreso.Text = gasto_Usuario.PrioridadGasto;
            Fechaegreso.Text = gasto_Usuario.FechaGasto.ToString();
        }

        private void btnEditarEgreso_Click(object sender, EventArgs e)
        {
            editarEgreso();
        }

        private void editarEgreso()
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea editar el registro?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gasto_Usuario.Monto = double.TryParse(txtCantidadEgreso.Text, out double cantidadIngreso) ? cantidadIngreso : 0;
                    gasto_Usuario.DescripcionGasto = txtDescripcionEgreso.Text;
                    gasto_Usuario.Categoria_Gasto.Nombre_Categoria = cmbCategoriaEgreso.Text;
                    gasto_Usuario.PrioridadGasto = cmbPrioridadEgreso.Text;
                    gasto_Usuario.FechaGasto = Fechaegreso.Value;
                    var message = serviciosUsuario.EditarEgreso(gasto_Usuario);
                    if (message == true)
                    {
                        MessageBox.Show("Editado exitosamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("edicion candelada");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
