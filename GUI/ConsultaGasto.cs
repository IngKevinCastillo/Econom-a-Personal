using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class ConsultaGasto : Form
    {
        ServicioConsultas servicioconsultas;
        ServiciosUsuario serviciosusuario;
        double monto;
        Usuario usuarioSesion;
        public ConsultaGasto(Usuario usuario)
        {
            InitializeComponent();
            servicioconsultas = new ServicioConsultas();
            servicioconsultas.RecuperacionDatos(usuario);
            serviciosusuario = new ServiciosUsuario();
            serviciosusuario.RecuperacionDatos(usuario);
            usuarioSesion = usuario;
        }

        private void BuscarGastos_Click(object sender, EventArgs e)
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
                dtpFechaFinalGasto.Enabled = false;
                dtpFechaInicioGasto.ShowUpDown = false;
                lblFecha.Enabled = false;
                lblInicial.Enabled = false;
                dtpFechaInicioGasto.Enabled = false;
                cmbFiltros.Text = "";
            }
        }

        private void ConsultaPorDia()
        {
            dgvGastos.Rows.Clear();
            List<Gasto> gastos = servicioconsultas.ConsultaGastoPorDia(dtpFechaInicioGasto.Value);
            if (gastos == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato En La Fecha"); return;
            }
            cargarTabla(gastos);
            monto = servicioconsultas.gastostotales(gastos);
            cargarMontoGastos();
            txtCantidad.Text = gastos.Count.ToString();
        }

        private void ConsultarPorAño()
        {
            dgvGastos.Rows.Clear();
            List<Gasto> gastos = servicioconsultas.ConsultaGastosAnuales(dtpFechaInicioGasto.Value);
            if (gastos == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato En La Fecha"); return;
            }
            cargarTabla(gastos);
            monto = servicioconsultas.gastostotales(gastos);
            cargarMontoGastos();
            txtCantidad.Text = gastos.Count.ToString();
        }

        private void ConsultaPorRango()
        {
            dgvGastos.Rows.Clear();
            List<Gasto> gastos = servicioconsultas.consultaGastoPorRango(dtpFechaInicioGasto.Value, dtpFechaFinalGasto.Value);
            if (gastos == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato En La Fecha"); return;
            }
            if (dtpFechaInicioGasto.Value > dtpFechaFinalGasto.Value)
            {
                MessageBox.Show("LA FECHA INICIAL NO PUEDE SER MAYOR A LA FINAL");
            }
            else
            {
                cargarTabla(gastos);
                monto = 0.0; monto = servicioconsultas.gastostotales(gastos);
                cargarMontoGastos();
                txtCantidad.Text = gastos.Count.ToString();
            }
        }

        private void btnMostrarTodosGastos_Click(object sender, EventArgs e)
        {
            Normalidad();
            mostrarTodosLosGastos();
            txtCantidad.Text = serviciosusuario.ObtenerGastosCuenta().Count.ToString();
            lblFechaFinal.Enabled = false;
            dtpFechaFinalGasto.Enabled = false;
            dtpFechaInicioGasto.ShowUpDown = false;
            lblFecha.Enabled = false;
            lblInicial.Enabled = false;
            dtpFechaInicioGasto.Enabled = false;
        }

        private void mostrarTodosLosGastos()
        {
            cargarTabla(serviciosusuario.ObtenerGastosCuenta());
            monto = 0.0; monto = servicioconsultas.gastostotales(serviciosusuario.ObtenerGastosCuenta());
            cargarMontoGastos();
        }

        private void ConsultaGasto_Load(object sender, EventArgs e)
        {
            txtCantidad.ReadOnly = true;
            txtCantidad.Text = serviciosusuario.ObtenerGastosCuenta().Count.ToString();
            cmbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;dgvGastos.MultiSelect = false;dgvGastos.ReadOnly = true;
            dgvGastos.Rows.Clear();txtGastosTotales.ReadOnly = true;
            cargarTabla(serviciosusuario.ObtenerGastosCuenta());
            monto = 0.0; monto = servicioconsultas.gastostotales(serviciosusuario.ObtenerGastosCuenta());
            cargarMontoGastos();
            dgvGastos.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void txtGastosTotales_TextChanged(object sender, EventArgs e)
        {
            cargarMontoGastos();
        }
        private void cargarMontoGastos()
        {
            txtGastosTotales.Text = monto.ToString();
        }
        private void cargarTabla(List<Gasto> tabla)
        {
            if (tabla == null)
            {
                MessageBox.Show("No Se Encontro Ningun Dato Registrado");
                return;
            }
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.Rows.Clear();
            foreach (Gasto gastos in tabla)
            {
                dgvGastos.Rows.Add(
                    gastos.IdGasto,
                    gastos.DescripcionGasto,
                    gastos.PrioridadGasto,
                    gastos.FechaGasto.ToString("dd-MM-yyyy"),
                    gastos.Monto,
                    gastos.Categoria_Gasto.Nombre_Categoria
                );
            }
        }
        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFiltros.SelectedItem.ToString() == "Filtro Por Rango")
                {
                    Normalidad();
                    lblFechaFinal.Enabled = true;
                    dtpFechaFinalGasto.Enabled = true;
                    lblFecha.Enabled = true;
                    lblInicial.Enabled = true;
                    dtpFechaInicioGasto.Enabled = true;
                }
                else if (cmbFiltros.SelectedItem.ToString() == "Filtrar Por Año")
                {
                    Normalidad();
                    dtpFechaInicioGasto.Format = DateTimePickerFormat.Custom;
                    dtpFechaInicioGasto.CustomFormat = "yyyy";
                    dtpFechaInicioGasto.ShowUpDown = true; lblFechaFinal.Enabled = false; dtpFechaFinalGasto.Enabled = false;
                    dtpFechaInicioGasto.Enabled = true;
                }
                else if (cmbFiltros.SelectedItem.ToString() == "Filtrar Por Dia")
                {
                    Normalidad();
                    lblFechaFinal.Enabled = false;
                    dtpFechaFinalGasto.Enabled = false;
                    lblFecha.Enabled = true;
                    lblInicial.Enabled = true;
                    dtpFechaInicioGasto.Enabled = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Normalidad()
        {
            dtpFechaInicioGasto.Format = DateTimePickerFormat.Long;
            dtpFechaInicioGasto.CustomFormat = null;
            dtpFechaInicioGasto.ShowUpDown = false;
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Reporte_Egresos";
            guardar.DefaultExt = "pdf";
            guardar.Filter = "Archivos PDF (*.pdf)|*.pdf";

            string paginaHTMLL_Texto = Properties.Resources.index_G.ToString();
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@CLIENTE", usuarioSesion.P_Nombre + " " + usuarioSesion.P_Apellido);
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@DOCUMENTO", usuarioSesion.Cedula);
            paginaHTMLL_Texto = paginaHTMLL_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;

            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                if (row.Cells["ID_Egreso"].Value != null &&
                    row.Cells["Descripcion_Egreso"].Value != null &&
                    row.Cells["Prioridad_Egreso"].Value != null &&
                    row.Cells["Fecha_Egreso"].Value != null &&
                    row.Cells["Monto_Egreso"].Value != null &&
                    row.Cells["Categoria_Egreso"].Value != null)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["ID_Egreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Descripcion_Egreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Prioridad_Egreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Fecha_Egreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Categoria_Egreso"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Monto_Egreso"].Value.ToString() + "</td>";
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
                catch (Exception ex)
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

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            ElimianrGasto();
        }

        private void ElimianrGasto()
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el Ingreso?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string codigo = dgvGastos.CurrentRow.Cells[0].Value.ToString();
                    var message = serviciosusuario.EliminarGasto(codigo);
                    if (message == true)
                    {
                        MessageBox.Show("eliminado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("eliminacion candelada");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvGastos.Rows.Clear(); cargarTabla(serviciosusuario.ObtenerGastosCuenta());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string idGasto = dgvGastos.CurrentRow.Cells[0].Value.ToString();
            Gasto gasto = serviciosusuario.BuscarGasto(idGasto);
            AbrirFormularioEditarEgreso(new EditarEgreso(gasto));
            serviciosusuario.RecuperacionDatos(gasto.Usuario);
            dgvGastos.Rows.Clear(); cargarTabla(serviciosusuario.ObtenerGastosCuenta());
        }

        private void AbrirFormularioEditarEgreso(EditarEgreso editarEgreso)
        {
            editarEgreso.ShowDialog();
        }
    }
}
