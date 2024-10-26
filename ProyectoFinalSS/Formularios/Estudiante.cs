using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void cargarCursosDisponibles()
        {
            DataTable dtSeguimiento = new DataTable();
            dtSeguimiento.Columns.Add("Id del curso", typeof(int));
            dtSeguimiento.Columns.Add("Nombre del curso", typeof(string));
            dtSeguimiento.Columns.Add("Descripción del curso", typeof(string));
            dtSeguimiento.Columns.Add("Titulo a otorgar", typeof(string));

            using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
            {
                string Query = "EXEC [dbo].[SP_GET_COURSES_AVAILABLE] @ID_STUDENT";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_STUDENT", this.Id);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string nombre = reader["NOMBRE"].ToString();
                            string descripcion = reader["DESCRIPCION"].ToString();
                            string titulo = reader["TITULO_A_OTORGAR"].ToString();
                            dtSeguimiento.Rows.Add(id, nombre, descripcion, titulo);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            dataGridView1.DataSource = dtSeguimiento;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarCursosDisponibles();
        }
    }
}
