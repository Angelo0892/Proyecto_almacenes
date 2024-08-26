using Proyecto_almacen.Controladores;
using Proyecto_almacen.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_almacen
{
    public partial class GestionUsuario : Form
    {

        private string nombre;
        private string codigo;
        private string celular;
        private string rol;
        private string estado;

        private string nombreTabla;
        private string nombreId;

        private DataTable datosTabla;

        private string idUsuario;

        private DbConexion dbConexion;

        public GestionUsuario()
        {
            InitializeComponent();
            nombreTabla = "Usuario";
            nombreId = "idUsuario";

            dbConexion = new DbConexion();

            LlenarDataGrid();
        }



        private void AccionCrear(object sender, EventArgs e)
        {
            string[] parametrosUsuario = ObtenerArregloParametros();

            dbConexion.Insertar(this.nombreTabla, parametrosUsuario);

            vaciarCampos();
            LlenarDataGrid();
        }

        private void AccionModificar(object sender, EventArgs e)
        {
            string[] parametrosUsuario = ObtenerArregloParametros();
            string[] parametrosColumna = new string[6];

            parametrosColumna[0] = "nombreU";
            parametrosColumna[1] = "codigo";
            parametrosColumna[2] = "celular";
            parametrosColumna[3] = "rol";
            parametrosColumna[4] = "estado";
            parametrosColumna[5] = "idUsuario";

            dbConexion.Moficar(this.nombreTabla, parametrosColumna, parametrosUsuario, this.idUsuario);

            vaciarCampos();
            LlenarDataGrid();
        }

        private void AccionEliminar(object sender, EventArgs e)
        {
            dbConexion.Eliminar(this.nombreTabla, this.nombreId, this.idUsuario);

            vaciarCampos();
            LlenarDataGrid();
        }

        /// <summary>
        /// Función que realiza el cambio de las variables
        /// pertenecientes al formulario
        /// </summary>
        private void ObtenerParametros()
        {
            this.nombre = textoNombre.Text;
            this.codigo = textoCodigo.Text;
            this.celular = textoCelular.Text;
            this.rol = textoRol.Text;
            this.estado = textoEstado.Text;
        }

        /// <summary>
        /// Transformar todos las variables del formulario en un arreglo.
        /// </summary>
        /// <returns>arreglo de tipo string</returns>
        private string[] ObtenerArregloParametros()
        {
            ObtenerParametros();
            string[] paremetrosUsuario = new string [5];

            paremetrosUsuario[0] = this.nombre;
            paremetrosUsuario[1] = this.codigo;
            paremetrosUsuario[2] = this.celular;
            paremetrosUsuario[3] = this.rol;
            paremetrosUsuario[4] = this.estado;

            return paremetrosUsuario;
        }

        private void vaciarCampos()
        {
            this.idUsuario = "";
            textoNombre.Text = "";
            textoCodigo.Text = "";
            textoCelular.Text = "";
            textoRol.Text = "";
            textoEstado.Text = "";
        }


        private void LlenarDataGrid()
        {
            datosTabla = dbConexion.BuscarTabla(nombreTabla);
            datosUsuarios.DataSource = datosTabla;
        }

        private void ObtenerDatosFila(object sender, DataGridViewCellEventArgs e)
        {
            this.idUsuario = datosUsuarios.SelectedCells[0].Value.ToString();
            textoNombre.Text = datosUsuarios.SelectedCells[1].Value.ToString();
            textoCodigo.Text = datosUsuarios.SelectedCells[2].Value.ToString();
            textoCelular.Text = datosUsuarios.SelectedCells[3].Value.ToString();
            textoRol.Text = datosUsuarios.SelectedCells[4].Value.ToString();
            textoEstado.Text = datosUsuarios.SelectedCells[5].Value.ToString();
        }
    }
}
