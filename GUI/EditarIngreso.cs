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
    public partial class EditarIngreso : Form
    {
        Ingreso Ingreso_Usuario;
        ServiciosUsuario serviciosUsuario;
        public EditarIngreso(Ingreso ingreso)
        {
            serviciosUsuario = new ServiciosUsuario();
            InitializeComponent();
            Ingreso_Usuario = ingreso;
            serviciosUsuario.RecuperacionDatos(ingreso.Usuario_Ingreso);

        }

        private void EditarIngreso_Load(object sender, EventArgs e)
        {
            cargarIngreso();
        }

        private void cargarIngreso()
        {
            txtCantidadIngreso.Text = Ingreso_Usuario.Monto.ToString();
            txtDescripcionIngreso.Text = Ingreso_Usuario.DescripcionIngreso;
            Fechaingreso.Text = Ingreso_Usuario.FechaIngreso.ToString();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            editarIngreso();
        }

        private void editarIngreso()
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea editar el registro?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Ingreso_Usuario.Monto = double.TryParse(txtCantidadIngreso.Text, out double cantidadIngreso) ? cantidadIngreso : 0;
                    Ingreso_Usuario.DescripcionIngreso = txtDescripcionIngreso.Text;
                    Ingreso_Usuario.FechaIngreso = Fechaingreso.Value;
                    var message = serviciosUsuario.EditarIngreso(Ingreso_Usuario);
                    if (message = true)
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
