using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nombre_Usuario = nombre_Usuario;
            this.Edad = edad;
            this.Tipo_Usuario = tipo_Usuario;
            cargarCursos();
            cargarSeguimiento();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if 
            (
                (txtNombre.Text == null || txtNombre.Text == "") ||
                (txtDescripcion.Text == null || txtDescripcion.Text == "") ||
                (txtDiploma.Text == null || txtDiploma.Text == "")
            )
            {
                MessageBox.Show("Favor llenar todos los datos del formulario", "Datos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try {
                int codigo = 0;
                using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
                {
                    if (gridCursos.SelectedRows.Count > 0)
                    {
                        var filaSeleccionada = gridCursos.SelectedRows[0];
                        codigo = (int)filaSeleccionada.Cells["Codigo Curso"].Value;
                    }
                    else if (gridCursos.SelectedCells.Count > 0)
                    {
                        var celdaSeleccionada = gridCursos.SelectedCells[0];
                        var filaSeleccionada = gridCursos.Rows[celdaSeleccionada.RowIndex];
                        codigo = (int)filaSeleccionada.Cells["Codigo Curso"].Value;
                    }
                    if (codigo > 0)
                    {
                        string Query = "EXEC [dbo].[SP_UPDATE_COURSE] @ID_COURSE, @NOMBRE, @DESCRIPCION, @TITULO_A_OTORGAR";
                        using (SqlCommand cmd = new SqlCommand(Query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID_COURSE", codigo);
                            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
                            cmd.Parameters.AddWithValue("@TITULO_A_OTORGAR", txtDiploma.Text);
                            int lineas = cmd.ExecuteNonQuery();

                            if (lineas > 0)
                            {
                                MessageBox.Show("Curso actualizado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se actualizó ningun curso. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        string Query = "EXEC [dbo].[SP_INSERT_COURSE] @NOMBRE, @DESCRIPCION, @TITULO_A_OTORGAR, @ID_CATEDRATICO";
                        using (SqlCommand cmd = new SqlCommand(Query, con))
                        {
                            cmd.Parameters.AddWithValue("@NOMBRE", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
                            cmd.Parameters.AddWithValue("@TITULO_A_OTORGAR", txtDiploma.Text);
                            cmd.Parameters.AddWithValue("@ID_CATEDRATICO", this.Id);
                            int lineas = cmd.ExecuteNonQuery();

                            if (lineas > 0)
                            {
                                MessageBox.Show("Curso guardado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se insertó ningún curso. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    limpiarCampos();
                    cargarCursos();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtDiploma.Clear();
            gridCursos.ClearSelection();
        }

        private void cargarCursos()
        {
            DataTable dtCursos = new DataTable();
            dtCursos.Columns.Add("Codigo Curso", typeof(int));
            dtCursos.Columns.Add("Nombre", typeof(string));
            dtCursos.Columns.Add("Descripción", typeof(string));
            dtCursos.Columns.Add("Diploma", typeof(string));

            using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
            {
                string Query = "EXEC [dbo].[SP_GET_COURSES_BY_CATEDRATICO] @ID_CATEDRATICO";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_CATEDRATICO", this.Id);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string nombre = reader["nombre"].ToString();
                            string descripcion = reader["descripcion"].ToString();
                            string diploma = reader["titulo_a_otorgar"].ToString();
                            dtCursos.Rows.Add(id, nombre, descripcion, diploma);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            gridCursos.DataSource = dtCursos;
            gridCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCursos.ClearSelection();
            gridCursos.CurrentCell = null;
        }

        private void gridCursos_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = gridCursos.Rows[e.RowIndex];
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = filaSeleccionada.Cells["Descripción"].Value.ToString();
                txtDiploma.Text = filaSeleccionada.Cells["Diploma"].Value.ToString();
            }
        }
        private void Catedratico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gridCursos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridCursos.ClearSelection();
            limpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void cargarSeguimiento()
        {
            DataTable dtSeguimiento = new DataTable();
            dtSeguimiento.Columns.Add("Nombre Estudiante", typeof(string));
            dtSeguimiento.Columns.Add("Apellido Estudiante", typeof(string));
            dtSeguimiento.Columns.Add("Curso", typeof(string));
            dtSeguimiento.Columns.Add("Porcentaje", typeof(string));
            dtSeguimiento.Columns.Add("Estado", typeof(string));

            using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
            {   
                string Query = "EXEC [dbo].[SP_GET_STUDENTS_BY_CATEDRATICO] @ID_CATEDRATICO";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@ID_CATEDRATICO", this.Id);
                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            
                            string nombre = reader["NOMBRE_ESTUDIANTE"].ToString();
                            string apellido = reader["APELLIDO_ESTUDIANTE"].ToString();
                            string curso = reader["CURSO"].ToString();
                            string porcentaje = reader["PORCENTAJE"].ToString() + "%";
                            string estado = reader["ESTADO"].ToString();
                            dtSeguimiento.Rows.Add(nombre, apellido, curso, porcentaje, estado);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            gridSeguimiento.DataSource = dtSeguimiento;
            gridSeguimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarSeguimiento();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridSeguimiento.DataSource is DataTable dtSeguimiento)
            {
                var sortedData = dtSeguimiento.AsEnumerable()
                    .OrderBy(column => int.Parse(column["Porcentaje"].ToString().Replace("%", "")))
                    .CopyToDataTable();

                gridSeguimiento.DataSource = sortedData;
            }
        }
    }
}
