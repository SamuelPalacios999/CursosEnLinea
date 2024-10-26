using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSS.Formularios
{
    public partial class Catedratico : Form
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Nombre_Usuario { set; get; }
        public int Edad { set; get; }
        public string Tipo_Usuario { get; set; }
        public Catedratico(int id, string nombre, string apellido, string nombre_Usuario, int edad, string tipo_Usuario)
        {
            InitializeComponent();
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nombre_Usuario = nombre_Usuario;
            this.Edad = edad;
            this.Tipo_Usuario = tipo_Usuario;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
