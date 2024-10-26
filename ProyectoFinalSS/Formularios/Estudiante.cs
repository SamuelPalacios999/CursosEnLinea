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
            cargarCursosDisponibles();
            cargarCursosAsignados();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cargarCursosDisponibles()
        {
            DataTable dtDisponibles = new DataTable();
            dtDisponibles.Columns.Add("Codigo Curso", typeof(int));
            dtDisponibles.Columns.Add("Nombre del curso", typeof(string));
            dtDisponibles.Columns.Add("Descripción del curso", typeof(string));
            dtDisponibles.Columns.Add("Titulo a otorgar", typeof(string));

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
                            dtDisponibles.Rows.Add(id, nombre, descripcion, titulo);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            gridCursosDisp.DataSource = dtDisponibles;
            gridCursosDisp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarCursosDisponibles();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = 0;
                string estado = "ASIGNADO";
                int porcentaje = 0;
                using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
                {
                    if (gridCursosDisp.SelectedRows.Count > 0)
                    {
                        var filaSeleccionada = gridCursosDisp.SelectedRows[0];
                        codigo = (int)filaSeleccionada.Cells["Codigo Curso"].Value;
                    }
                    else if (gridCursosDisp.SelectedCells.Count > 0)
                    {
                        var celdaSeleccionada = gridCursosDisp.SelectedCells[0];
                        var filaSeleccionada = gridCursosDisp.Rows[celdaSeleccionada.RowIndex];
                        codigo = (int)filaSeleccionada.Cells["Codigo Curso"].Value;
                    }
                    if (codigo > 0)
                    {
                        string Query = "EXEC [dbo].[SP_INSERT_STUDENT_TO_THE_COURSE] @ID_COURSE, @ID_STUDENT, @STATUS_COURSE, @PERCENTAGE";
                        using (SqlCommand cmd = new SqlCommand(Query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID_COURSE", codigo);
                            cmd.Parameters.AddWithValue("@ID_STUDENT", this.Id);
                            cmd.Parameters.AddWithValue("@STATUS_COURSE", estado);
                            cmd.Parameters.AddWithValue("@PERCENTAGE", porcentaje);
                            int lineas = cmd.ExecuteNonQuery();

                            if (lineas > 0)
                            {
                                MessageBox.Show("Curso asignado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se actualizó ningun curso. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {           
                        MessageBox.Show("No seleccionó ningún curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    cargarCursosDisponibles();
                    cargarCursosAsignados();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarCursosAsignados();
        }
        
        private void cargarCursosAsignados()
        {
            DataTable dtAsignados = new DataTable();
            dtAsignados.Columns.Add("Curso", typeof(string));
            dtAsignados.Columns.Add("Descripcion", typeof(string));
            dtAsignados.Columns.Add("Estado", typeof(string));
            dtAsignados.Columns.Add("Porcentaje", typeof(string));

            using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
            {
                string Query = "EXEC [dbo].[SP_GET_COURSES_BY_STUDENT] @ID_STUDENT";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_STUDENT", this.Id);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string curso = reader["CURSO"].ToString();
                            string descripcion = reader["DESCRIPCION"].ToString();
                            string estado = reader["ESTADO"].ToString();
                            int porcentaje = (int)reader["PORCENTAJE_DEL_CURSO"];
                            dtAsignados.Rows.Add(curso, descripcion, estado, porcentaje);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            gridAsignados.DataSource = dtAsignados;
            gridAsignados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
