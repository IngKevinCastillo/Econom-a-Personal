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

    public partial class AgregarCategoria : Form
    {
        ServiciosCategoria serviciosCategoria;
        Usuario usuarioIniciado;
        public AgregarCategoria(Usuario usuario)
        {
            InitializeComponent();
            serviciosCategoria = new ServiciosCategoria();
            usuarioIniciado = usuario;
        }

        private void btnGuardarIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            List<Categoria> categorias = serviciosCategoria.ObtenerCategorias().FindAll(categoria => categoria.CedulaUsuario == usuarioIniciado.Cedula);
            if (categorias.Any(categoria => categoria.Nombre_Categoria.Equals(txtNombreCategoria.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("La categoría ya existe. Por favor, ingrese un nombre diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var message = serviciosCategoria.RegistrarCategoria(new Categoria
            {
                Nombre_Categoria = txtNombreCategoria.Text,
                CedulaUsuario = usuarioIniciado.Cedula
            });

            MessageBox.Show(message);
            this.Close();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
