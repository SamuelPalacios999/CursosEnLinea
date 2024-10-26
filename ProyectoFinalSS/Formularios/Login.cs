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

namespace ProyectoFinalSS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
            {
                string Query = "EXEC dbo.SP_GET_AUTHENTICATION @LOGIN, @PASSWORD";
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@LOGIN", textBox1.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", textBox2.Text);
                    try { 
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            label4.Text = "Autenticación exitosa";
                            if (reader["TIPO_USUARIO"].ToString() == "CATEDRATICO")
                            {
                                Formularios.Catedratico catedratico = new Formularios.Catedratico(
                                    Convert.ToInt32(reader["ID"]),
                                    reader["NOMBRE"].ToString(),
                                    reader["APELLIDO"].ToString(),
                                    reader["NOMBRE_DE_USUARIO"].ToString(),
                                    Convert.ToInt32(reader["EDAD"]),
                                    reader["TIPO_USUARIO"].ToString());
                                catedratico.ShowDialog();
                                reader.Close();
                                this.Close();
                            }
                            if (reader["TIPO_USUARIO"].ToString() == "ESTUDIANTE")
                            {
                                Formularios.Estudiante estudiante = new Formularios.Estudiante(
                                    Convert.ToInt32(reader["ID"]),
                                    reader["NOMBRE"].ToString(),
                                    reader["APELLIDO"].ToString(),
                                    reader["NOMBRE_DE_USUARIO"].ToString(),
                                    Convert.ToInt32(reader["EDAD"]),
                                    reader["TIPO_USUARIO"].ToString());
                                estudiante.ShowDialog();
                                reader.Close();
                                this.Close();
                            }
                        }
                        else {
                            label4.Text = "Credenciales incorrectas.";
                            reader.Close();
                        }
                    } catch (Exception ex) {
                        label4.Text = "Error al autenticar: " + ex.Message;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formularios.Nuevo_Usuario UsuarioNuevo = new Formularios.Nuevo_Usuario();
            UsuarioNuevo.ShowDialog();
        }
    }
}




//this.Hide();
//this.Close();
//Formularios.Estudiante estudiante = new Formularios.Estudiante();
//estudiante.ShowDialog();