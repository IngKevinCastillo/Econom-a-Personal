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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Reflection.Emit;

namespace GUI
{

    public partial class ConsultaIngreso : Form
    {
        private Size originalSize;
        ServiciosUsuario serviciosUsuario;
        ServicioConsultas servicioconsultas;
        double monto;
        Usuario UsuarioSesion;
        public ConsultaIngreso( Usuario usuario)
        {
            InitializeComponent();
            originalSize = pictureBox1.Size;

            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            serviciosUsuario = new ServiciosUsuario();
            serviciosUsuario.RecuperacionDatos(usuario);
            servicioconsultas = new ServicioConsultas();
            servicioconsultas.RecuperacionDatos(usuario);
            UsuarioSesion = usuario;
        }
        private void ConsultaIngreso_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = serviciosUsuario.ObtenerIngresoCuenta().Count.ToString();
            txtCantidad.ReadOnly = true;
            lblFiltros.ForeColor = Color.Black;
            lblCantidad.ForeColor = Color.Black;
            lblTotal.ForeColor = Color.Black;
            cmbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;dgvIngreso.MultiSelect = false;dgvIngreso.ReadOnly = true;
            dgvIngreso.Rows.Clear();txtMontoIngresos.ReadOnly = true;
            cargarTabla(serviciosUsuario.ObtenerIngresoCuenta());
            monto = servicioconsultas.ingresostotales(serviciosUsuario.ObtenerIngresoCuenta());
            cargarMontoIngresos();
            dgvIngreso.DefaultCellStyle.ForeColor = Color.Black;

        }
        private void cargarTabla(List<Ingreso> tabla)
        {
            if (tabla == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato Registrado");
                return;
            }
            dgvIngreso.AutoGenerateColumns = false;
            foreach (Ingreso ingreso in tabla)
            {
                dgvIngreso.Rows.Add(
                    ingreso.IdIngreso,
                    ingreso.DescripcionIngreso,
                    ingreso.FechaIngreso.ToString("dd-MM-yyyy"),
                    ingreso.Monto
                );
            }
        }

        private void ConsultaPorRango()
        {
            dgvIngreso.Rows.Clear();
            List<Ingreso> ingresos = servicioconsultas.ConsultaIngresoPorRango(dtpFechaInicioIngreso.Value, dtpFechaFinalIngreso.Value);
            if (ingresos == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato En La Fecha");
                return;
            }
            if (dtpFechaInicioIngreso.Value > dtpFechaFinalIngreso.Value)
            {
                MessageBox.Show("LA FECHA INICIAL NO PUEDE SER MAYOR A LA FINAL");
            }
            else
            {
                cargarTabla(ingresos);
                monto = servicioconsultas.ingresostotales(ingresos);
                cargarMontoIngresos();
                txtCantidad.Text = ingresos.Count.ToString();
            }
        }

        private void btnMostrarTodosIngresos_Click(object sender, EventArgs e)
        {
            Normalidad();
            MostrarTodosLosIngresos();
            txtCantidad.Text = serviciosUsuario.ObtenerIngresoCuenta().Count.ToString();
            lblFechaFinal.Enabled = false;
            dtpFechaFinalIngreso.Enabled = false;
            dtpFechaInicioIngreso.ShowUpDown = false;
            lblFecha.Enabled = false;
            lblInicial.Enabled = false;
            dtpFechaInicioIngreso.Enabled = false;
        }
        private void MostrarTodosLosIngresos()
        {
            dgvIngreso.Rows.Clear();
            cargarTabla(serviciosUsuario.ObtenerIngresoCuenta());
            monto = 0.0;monto = servicioconsultas.ingresostotales(serviciosUsuario.ObtenerIngresoCuenta());
            cargarMontoIngresos();
        }

        private void txtMontoIngresos_TextChanged(object sender, EventArgs e)
        {
            cargarMontoIngresos();
        }

        private void cargarMontoIngresos()
        {
            txtMontoIngresos.Text = monto.ToString();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = originalSize;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cmbFiltros.SelectedItem == null)
            {
                MessageBox.Show("Error. Seleccione una opcion de filtro.");
                return;
            }
            else
            {
                if (cmbFiltros.SelectedItem.ToString() == "Filtro Por Rango")
                {
                    ConsultaPorRango();
                }
                else if (cmbFiltros.SelectedItem.ToString() == "Filtrar Por Año")
                {
                    ConsultarPorAño();
                }
                else if (cmbFiltros.SelectedItem.ToString() == "Filtrar Por Dia")
                {
                    ConsultaPorDia();
                }
                else
                {
                    ConsultaPorRango();
                }
                lblFechaFinal.Enabled = false;
                dtpFechaFinalIngreso.Enabled = false;
                dtpFechaInicioIngreso.ShowUpDown = false;
                lblFecha.Enabled = false;
                lblInicial.Enabled = false;
                dtpFechaInicioIngreso.Enabled = false;
                cmbFiltros.Text = "";
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(originalSize.Width + 10, originalSize.Height + 10);

        }
        public void ConsultaPorDia()
        {
            dgvIngreso.Rows.Clear();
            List<Ingreso> ingresos = servicioconsultas.ConsultaIngresoPorDia(dtpFechaInicioIngreso.Value);
            if (ingresos == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato En La Fecha"); return;
            }
            cargarTabla(ingresos);
            monto = servicioconsultas.ingresostotales(ingresos);
            cargarMontoIngresos();
            txtCantidad.Text = ingresos.Count.ToString();
        }
        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltros.SelectedItem.ToString() == "Filtro Por Rango")
                {
                    Normalidad();
                    lblFechaFinal.Enabled = true;
                    dtpFechaFinalIngreso.Enabled = true;
                    lblFecha.Enabled = true;
                    lblInicial.Enabled = true;
                    dtpFechaInicioIngreso.Enabled = true;
                }
                else if (cmbFiltros.SelectedItem.ToString() == "Filtrar Por Año")
                {
                    Normalidad();
                    dtpFechaInicioIngreso.Format = DateTimePickerFormat.Custom;
                    dtpFechaInicioIngreso.CustomFormat = "yyyy";
                    dtpFechaInicioIngreso.ShowUpDown = true; lblFechaFinal.Enabled = false; dtpFechaFinalIngreso.Enabled = false;
                    dtpFechaInicioIngreso.Enabled = true;
                }
                else if (cmbFiltros.SelectedItem.ToString() == "Filtrar Por Dia")
                {
                    Normalidad();
                    lblFechaFinal.Enabled = false;
                    dtpFechaFinalIngreso.Enabled = false;
                    lblFecha.Enabled = true;
                    lblInicial.Enabled = true;
                    dtpFechaInicioIngreso.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        public void Normalidad()
        {
            dtpFechaInicioIngreso.Format = DateTimePickerFormat.Long;
            dtpFechaInicioIngreso.CustomFormat = null;
            dtpFechaInicioIngreso.ShowUpDown = false;
        }

        private void ConsultarPorAño()
        {
            dgvIngreso.Rows.Clear();
            List<Ingreso> ingresos = servicioconsultas.ConsultaIngresosAnuales(dtpFechaInicioIngreso.Value);
            if (ingresos == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato En La Fecha"); return;
            }
            cargarTabla(ingresos);
            monto = servicioconsultas.ingresostotales(ingresos);
            cargarMontoIngresos();
            txtCantidad.Text = ingresos.Count.ToString();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Reporte_Ingresos";
            guardar.DefaultExt = "pdf";
            guardar.Filter = "Archivos PDF (*.pdf)|*.pdf";

            string paginaHTMLL_Texto = Properties.Resources.index.ToString();
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@CLIENTE", UsuarioSesion.P_Nombre + " " + UsuarioSesion.P_Apellido);
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@DOCUMENTO", UsuarioSesion.Cedula);
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                if (row.Cells["ID_Ingreso"].Value != null &&
                    row.Cells["Descripcion_Ingreso"].Value != null &&
                    row.Cells["Fecha_Ingreso"].Value != null &&
                    row.Cells["Monto_Ingreso"].Value != null)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID_Ingreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Descripcion_Ingreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Fecha_Ingreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Monto_Ingreso"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }
            }
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@FILAS", filas);
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@TOTAL", monto.ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                string fileName = guardar.FileName;
                if (!fileName.EndsWith(".pdf"))
                {
                    fileName += ".pdf";
                }
                try
                {
                    using (FileStream cadena = new FileStream(fileName, FileMode.Create))
                    {
                        Document pdfDocumento = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter escritor = PdfWriter.GetInstance(pdfDocumento, cadena);
                        pdfDocumento.Open();
                        pdfDocumento.Add(new Phrase(""));
                        try
                        {
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_para_una_aplicación_de_economía_personal, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(80, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfDocumento.LeftMargin, pdfDocumento.Top - 60);
                            pdfDocumento.Add(img);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al agregar la imagen: " + ex.Message);
                        }
                        using (StringReader lector = new StringReader(paginaHTMLL_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(escritor, pdfDocumento, lector);
                        }

                        pdfDocumento.Close();
                    }
                    MessageBox.Show("PDF generado exitosamente.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message);
                }
            }
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

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
            
        }

        private void EliminarIngreso()
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el Ingreso?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string codigo = dgvIngreso.CurrentRow.Cells[0].Value.ToString();
                    var message = serviciosUsuario.EliminarIngreso(codigo);
                    if (message == true)
                    {
                        MessageBox.Show("eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("eliminacion cancelada");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvIngreso.Rows.Clear(); cargarTabla(serviciosUsuario.ObtenerIngresoCuenta());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarIngreso();
            dgvIngreso.Rows.Clear(); cargarTabla(serviciosUsuario.ObtenerIngresoCuenta());
        }

        private void EditarIngreso()
        { 
            string idingreso = dgvIngreso.CurrentRow.Cells[0].Value.ToString();
            Ingreso ingreso = serviciosUsuario.BuscarIngreso(idingreso);
            AbrirFormularioEditarIngreso(new EditarIngreso(ingreso));
            serviciosUsuario.RecuperacionDatos(ingreso.Usuario_Ingreso);
            dgvIngreso.Rows.Clear(); cargarTabla(serviciosUsuario.ObtenerIngresoCuenta());
        }
        private void AbrirFormularioEditarIngreso(EditarIngreso editarIngreso)
        {
            editarIngreso.ShowDialog();
        }
    }
}
