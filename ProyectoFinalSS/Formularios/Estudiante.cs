using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSS.Formularios
{
    public partial class Estudiante : Form
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Nombre_Usuario { set; get; }
        public int Edad {  set; get; }
        public string Tipo_Usuario {  get; set; }

        public Estudiante(int id, string nombre, string apellido, string nombre_Usuario, int edad, string tipo_Usuario)
        {
            InitializeComponent();
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nombre_Usuario = nombre_Usuario;
            this.Edad = edad;
            this.Tipo_Usuario = tipo_Usuario;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
