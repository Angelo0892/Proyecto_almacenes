using Proyecto_almacen.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_almacen
{
    public partial class ReporteLog : Form
    {
        private DbConexion dbConexion;

        private string nombreId;

        private string fecha;
        private string tabla;
        private string idUsuario;

        public ReporteLog()
        {
            InitializeComponent();

            dbConexion = new DbConexion();
            nombreId = "idUsuario";
        }

        private void AccionBuscar(object sender, EventArgs e)
        {
            ObtenerDatosFromulario();
            LlenarDataGrid(this.fecha, this.tabla, this.idUsuario);

            BusquedaListaOpciones();
        }

        private void ObtenerDatosFromulario()
        {
            this.fecha = textoFecha.Text;
            this.tabla = textoTabla.Text;
            this.idUsuario = textoIdUsuario.Text;
        }

        private void LlenarDataGrid(string fecha, string tabla, string idUsuario)
        {
            DateTime cambiarFecha = DateTime.ParseExact(fecha, "dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            fecha = cambiarFecha.ToString("yyyy-MM-dd");

            DataTable datosTabla = new DataTable();

            string[] columnas = new string[6];

            columnas[0] = "nombreU";
            columnas[1] = "tabla";
            columnas[2] = "fecha";
            columnas[3] = "hora";
            columnas[4] = "operacion";
            columnas[5] = "logO";

            string[] nombreTablas = new string[2];


            nombreTablas[0] = "Logs";
            nombreTablas[1] = "Usuario";

            

            int[] arregloBusqueda = BusquedaListaOpciones();

            string[] nombreColumnas = new string[arregloBusqueda[0]];
            string[] columnasBuscar = new string[arregloBusqueda[0]];

            for (int i = 0; i < arregloBusqueda[0]; i++)
            {
                switch (arregloBusqueda[i + 1])
                {
                    case 0:
                        nombreColumnas[i] = "Usuario.idUsuario";
                        columnasBuscar[i] = idUsuario;
                        break;
                    case 1:
                        nombreColumnas[i] = "tabla";
                        columnasBuscar[i] = tabla;
                        break;
                    case 2:
                        nombreColumnas[i] = "fecha";
                        columnasBuscar[i] = fecha;
                        break;
                }
            }

            if (Advertencia())
            {
                datosTabla = dbConexion.BuscarDosTablas(this.nombreId, columnas, nombreTablas, nombreColumnas, columnasBuscar);
                reportesLog.DataSource = datosTabla;

                reportesLog.Columns["Fecha"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }
        }

        private void ObtenerDatosFila(object sender, DataGridViewCellEventArgs e)
        {
            datoNombreU.Text = reportesLog.SelectedCells[0].Value.ToString();
            datoTabla.Text = reportesLog.SelectedCells[1].Value.ToString();
            datoFecha.Text = reportesLog.SelectedCells[2].Value.ToString();
            datoHora.Text = reportesLog.SelectedCells[3].Value.ToString();
            datoOperacion.Text = reportesLog.SelectedCells[4].Value.ToString();
            datoOperacionLog.Text = reportesLog.SelectedCells[4].Value.ToString();
        }

        private int[] BusquedaListaOpciones()
        {
            int cantidad = 1;
            int conteo = 1;

            int[] arregloBusqueda;

            foreach (int posicion in ListaOpciones.CheckedIndices)
            {
                cantidad++;
            }

            arregloBusqueda = new int[cantidad];

            arregloBusqueda[0] = cantidad - 1;

            foreach (int posicion in ListaOpciones.CheckedIndices)
            {
                arregloBusqueda[conteo] = posicion;
                conteo++;
            }

            return arregloBusqueda;
        } 

        private bool Advertencia()
        {
            
            if (string.IsNullOrEmpty(this.idUsuario))
            {
                this.idUsuario = "0";
            }

            bool esNumero = int.TryParse(this.idUsuario, out int number);
            if (!esNumero)
            {
                MessageBox.Show("Advertencia:\n" +
                "* No utilice numeros o letras donde no sea necesario"
                , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return esNumero;
        }
    }
}
