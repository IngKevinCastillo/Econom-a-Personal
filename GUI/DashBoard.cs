using Entidades;
using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class DashBoard : Form
    {
        ServiciosUsuario serviciosUsuario;
        ServicioConsultas servicioConsultas;
        Usuario usuarioSesion;
        List<Gasto> Egreso_semana1 = new List<Gasto>();
        List<Gasto> Egreso_semana2 = new List<Gasto>();
        List<Gasto> Egreso_semana3 = new List<Gasto>();
        List<Gasto> Egreso_semana4 = new List<Gasto>();
        List<Ingreso> Ingreso_semana1 = new List<Ingreso>();
        List<Ingreso> Ingreso_semana2 = new List<Ingreso>();
        List<Ingreso> Ingreso_semana3 = new List<Ingreso>();
        List<Ingreso> Ingreso_semana4 = new List<Ingreso>();
        public DashBoard(Usuario usuario)
        {
            InitializeComponent();
            serviciosUsuario = new ServiciosUsuario();
            servicioConsultas = new ServicioConsultas();
            servicioConsultas.RecuperacionDatos(usuario);
            usuarioSesion = usuario;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            cmbIntervalo.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpMes.Format = DateTimePickerFormat.Custom;
            dtpMes.CustomFormat = "MM";
            dtpMes.ShowUpDown = true;

            dtpAño.Format = DateTimePickerFormat.Custom;
            dtpAño.CustomFormat = "yyyy";
            dtpAño.ShowUpDown = true;
        }

        private void GenerarTablaIngresosMes()
        {
            dvlIngresos.Series.Clear();
            dvlIngresos.ChartAreas.Clear();
            dvlIngresos.ChartAreas.Add(new ChartArea());
            String[] semanas = {"SEMANA 1","SEMANA 2","SEMANA 3","SEMANA 4"};
            double[] dinero = {
                Ingreso_semana1.Sum(Ingreso=> Ingreso.Monto),
                Ingreso_semana2.Sum(Ingreso=> Ingreso.Monto),
                Ingreso_semana3.Sum(Ingreso=> Ingreso.Monto),
                Ingreso_semana4.Sum(Ingreso=> Ingreso.Monto)
            };

            dvlIngresos.Palette = ChartColorPalette.Pastel;
            for (int i = 0; i<semanas.Length; i++)
            {
                Series serie = dvlIngresos.Series.Add(semanas[i]);
                serie.Label = dinero[i].ToString();
                serie.Points.Add(dinero[i]);
            }
        }

        private void CargarInfoMes(List<Ingreso>lista)
        {
            Ingreso_semana1.Clear();
            Ingreso_semana2.Clear();
            Ingreso_semana3.Clear();
            Ingreso_semana4.Clear();

            foreach (var ingreso in lista)
            {
                int semanaDelMes = ObtenerSemanaDelMes(ingreso.FechaIngreso);

                switch (semanaDelMes)
                {
                    case 1:
                        Ingreso_semana1.Add(ingreso);
                        break;
                    case 2:
                        Ingreso_semana2.Add(ingreso);
                        break;
                    case 3:
                        Ingreso_semana3.Add(ingreso);
                        break;
                    case 4:
                        Ingreso_semana4.Add(ingreso);
                        break;
                }
            }
        }
        private void GenerarTablaGastoMes(List<Gasto> lista)
        {
            Egreso_semana1.Clear();
            Egreso_semana2.Clear();
            Egreso_semana3.Clear();
            Egreso_semana4.Clear();
            foreach (var gasto in lista)
            {
                int semanaDelMes = ObtenerSemanaDelMes(gasto.FechaGasto);

                switch (semanaDelMes)
                {
                    case 1:
                        Egreso_semana1.Add(gasto);
                        break;
                    case 2:
                        Egreso_semana2.Add(gasto);
                        break;
                    case 3:
                        Egreso_semana3.Add(gasto);
                        break;
                    case 4:
                        Egreso_semana4.Add(gasto);
                        break;
                }
            }

        }
        static int ObtenerSemanaDelMes(DateTime fecha)
        {
            DateTime primerDiaDelMes = new DateTime(fecha.Year, fecha.Month, 1);
            int diasOffset = (int)primerDiaDelMes.DayOfWeek;
            int semanaDelMes = ((fecha.Day + diasOffset - 1) / 7) + 1;
            return Math.Min(semanaDelMes, 4); 
        }
        private void GenerarTablaEgresosAnual()
        {
            dlvEgresos.Series.Clear();
            dlvEgresos.ChartAreas.Clear();
            dlvEgresos.ChartAreas.Add(new ChartArea());
            List<Gasto> gastos = serviciosUsuario.ObtenerGastos().FindAll(egreso => egreso.Usuario.Cedula == usuarioSesion.Cedula);
            Dictionary<string, double> acumuladorPorMes = gastos
                .GroupBy(gasto => gasto.FechaGasto.ToString("MMMM", new CultureInfo("es-ES")))
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Sum(gasto => gasto.Monto));
            List<string> meses = acumuladorPorMes.Keys.ToList();
            List<double> dinero = acumuladorPorMes.Values.ToList();
            dlvEgresos.Palette = ChartColorPalette.Pastel;
            for (int i = 0; i < meses.Count; i++)
            {
                Series serie = dlvEgresos.Series.Add(meses[i]);
                serie.Label = dinero[i].ToString();
                serie.Points.Add(dinero[i]);
            }
        }

        private void GenerarTablaIngresosAnual()
        {
            dvlIngresos.Series.Clear();
            dvlIngresos.ChartAreas.Clear();
            dvlIngresos.ChartAreas.Add(new ChartArea());
            List<Ingreso> ingresos = serviciosUsuario.ObtenerIngresos().FindAll(ingreso => ingreso.Usuario_Ingreso.Cedula == usuarioSesion.Cedula);
            Dictionary<string, double> acumuladorPorMes = ingresos
                .GroupBy(ingreso => ingreso.FechaIngreso.ToString("MMMM", new CultureInfo("es-ES")))
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Sum(ingreso => ingreso.Monto));
            List<string> meses = acumuladorPorMes.Keys.ToList();
            List<double> dinero = acumuladorPorMes.Values.ToList();
            dvlIngresos.Palette = ChartColorPalette.Pastel;
            for (int i = 0; i < meses.Count; i++)
            {
                Series serie = dvlIngresos.Series.Add(meses[i]);
                serie.Label = dinero[i].ToString(); 
                serie.Points.Add(dinero[i]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIntervalo.Text == "ANUAL")
                {
                    txtTotalIngreso.Text = (cargartotalingresosAnual(dtpAño.Value)).ToString();
                    txtTotalEgresos.Text = (cargartotalEgresosAnual(dtpAño.Value)).ToString();
                    txtPromedioIngreso.Text = (cargarPromedioIngresoAnual(dtpAño.Value)).ToString();
                    txtPromedioEgresos.Text = (cargarPromedioEgresoAnual(dtpAño.Value)).ToString();

                }
                if (cmbIntervalo.Text == "MENSUAL")
                {
                    txtTotalIngreso.Text = (cargartotalingresosMes(dtpMes.Value)).ToString();
                    txtTotalEgresos.Text = (cargartotalEgresosMes(dtpAño.Value)).ToString();
                    txtPromedioIngreso.Text = (cargarPromedioIngresoMes(dtpAño.Value)).ToString();
                    txtPromedioEgresos.Text = (cargarPromedioEgresoMes(dtpAño.Value)).ToString();

                }
                if (cmbIntervalo.SelectedItem != null && cmbIntervalo.SelectedItem.ToString() == "ANUAL")
                {
                    GenerarTablaIngresosAnual();
                    GenerarTablaEgresosAnual();
                    lblAño.Enabled = true;
                    dtpAño.Enabled = true;
                    lblMes.Enabled = false;
                    dtpMes.Enabled = false;
                }
                else if (cmbIntervalo.SelectedItem != null && cmbIntervalo.SelectedItem.ToString() == "MENSUAL")
                {
                    int anioSeleccionado = dtpAño.Value.Year;
                    int mesSeleccionado = dtpMes.Value.Month;
                    DateTime fechaCombinada = new DateTime(anioSeleccionado, mesSeleccionado, 1);
                    CargarInfoMes(servicioConsultas.ConsultaIngresosMensuales(fechaCombinada));
                    GenerarTablaGastoMes(servicioConsultas.ConsultaGastosMensuales(fechaCombinada));
                    GenerarTablaIngresosMes();
                    GenerarTablaEgresosMes();
                    lblAño.Enabled = false;
                    dtpAño.Enabled = true;
                    lblMes.Enabled = true;
                    dtpMes.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al procesar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void GenerarTablaEgresosMes()
        {
            dlvEgresos.Series.Clear();
            dlvEgresos.ChartAreas.Clear();
            dlvEgresos.ChartAreas.Add(new ChartArea());
            String[] semanas = { "SEMANA 1", "SEMANA 2", "SEMANA 3", "SEMANA 4" };
            double[] dinero = {
                Egreso_semana1.Sum(Egreso=> Egreso.Monto),
                Egreso_semana2.Sum(Egreso=> Egreso.Monto),
                Egreso_semana3.Sum(Egreso=> Egreso.Monto),
                Egreso_semana4.Sum(Egreso=> Egreso.Monto)
            };

            dvlIngresos.Palette = ChartColorPalette.Pastel;
            for (int i = 0; i < semanas.Length; i++)
            {
                Series serie = dlvEgresos.Series.Add(semanas[i]);
                serie.Label = dinero[i].ToString();
                serie.Points.Add(dinero[i]);
            }
        }

        //MES--------------------------------------------------------------------------
        private double cargarPromedioEgresoMes(DateTime fecha)
        {
            List<Gasto> gastos = serviciosUsuario.ObtenerGastos();
            List<Gasto> total = servicioConsultas.ConsultaGastosMensuales(fecha);
            double promedioGastosoanual = total.Average(gasto => gasto.Monto);
            return promedioGastosoanual;
        }

        private double cargarPromedioIngresoMes(DateTime fecha)
        {
            List<Ingreso> ingresos = serviciosUsuario.ObtenerIngresos();
            List<Ingreso> total = servicioConsultas.ConsultaIngresosMensuales(fecha);
            double promedioIngresoanual = total.Average(ingreso => ingreso.Monto);
            return promedioIngresoanual;
        }

        private double cargartotalEgresosMes(DateTime fecha)
        {
            List<Gasto> ingresos = serviciosUsuario.ObtenerGastos();
            List<Gasto> total = servicioConsultas.ConsultaGastosMensuales(fecha);
            return total.Sum(gasto => gasto.Monto);
        }

        private double cargartotalingresosMes(DateTime fecha)
        {
            List<Ingreso> ingresos = serviciosUsuario.ObtenerIngresos();
            List<Ingreso> total = servicioConsultas.ConsultaIngresosMensuales(fecha);
            return total.Sum(ingreso => ingreso.Monto);
        }
        //----------------------------------------------------------------------------
        //AÑOS -----------------------------------------------------------------------
        private double cargarPromedioEgresoAnual(DateTime fecha)
        {
            List<Gasto> gastos = serviciosUsuario.ObtenerGastos();
            List<Gasto> total = servicioConsultas.ConsultaGastosAnuales(fecha);
            double promedioGastosoanual = total.Average(gasto => gasto.Monto);
            return promedioGastosoanual;
        }

        private double cargarPromedioIngresoAnual(DateTime fecha)
        {
            List<Ingreso> ingresos = serviciosUsuario.ObtenerIngresos();
            List<Ingreso> total = servicioConsultas.ConsultaIngresosAnuales(fecha);
            double promedioIngresoanual = total.Average(ingreso=> ingreso.Monto);
            return promedioIngresoanual;
            
        }

        private double cargartotalingresosAnual(DateTime fecha)
        {
            List<Ingreso> ingresos = serviciosUsuario.ObtenerIngresos();
            List<Ingreso> total = servicioConsultas.ConsultaIngresosAnuales(fecha);
            return total.Sum(ingreso => ingreso.Monto);
        }
        private double cargartotalEgresosAnual(DateTime fecha)
        {
            List<Gasto> ingresos = serviciosUsuario.ObtenerGastos();
            List<Gasto> total = servicioConsultas.ConsultaGastosAnuales(fecha);
            return total.Sum(gasto => gasto.Monto);
        }
        //-------------------------------------------------------------------------------------------------
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

        private void cmbIntervalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIntervalo.SelectedItem != null && cmbIntervalo.SelectedItem.ToString() == "ANUAL")
            {
                lblAño.Enabled = true;
                dtpAño.Enabled = true;
                lblMes.Enabled = false;
                dtpMes.Enabled = false;
            }
            else if (cmbIntervalo.SelectedItem != null && cmbIntervalo.SelectedItem.ToString() == "MENSUAL")
            {
                lblAño.Enabled = true;
                dtpAño.Enabled = true;
                lblMes.Enabled = true;
                dtpMes.Enabled = true;
            }
        }
    }
}

