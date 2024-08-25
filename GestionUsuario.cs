using Proyecto_almacen.Controladores;
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
        private string apellido;
        private string celular;
        private string rol;
        private string estado;

        private string nombreTabla;

        private int idUsuario;

        private DbConexion dbConexion;

        public GestionUsuario()
        {
            InitializeComponent();
            nombreTabla = "Usuario";
            dbConexion = new DbConexion();
        }

        private void AccionCrear(object sender, EventArgs e)
        {
            string[] parametrosUsuario = ObtenerArregloParametros();

            dbConexion.Insertar(nombreTabla, parametrosUsuario);
        }


        /// <summary>
        /// Función que realiza el cambio de las variables
        /// pertenecientes al formulario
        /// </summary>
        private void ObtenerParametros()
        {
            this.nombre = textoNombre.Text;
            this.apellido = textoApellido.Text;
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
            paremetrosUsuario[1] = this.apellido;
            paremetrosUsuario[2] = this.celular;
            paremetrosUsuario[3] = this.rol;
            paremetrosUsuario[4] = this.estado;

            return paremetrosUsuario;
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
