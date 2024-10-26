using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalSS.Formularios
{
    public partial class Nuevo_Usuario : Form
    {
        public Nuevo_Usuario()
        {
            InitializeComponent();
            comboBox1.Items.Add("ESTUDIANTE");
            comboBox1.Items.Add("CATEDRATICO");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validateInfo = verificacionDeCampos();
            if (validateInfo)
            {
                using (SqlConnection con = DataBase.ConnectDataBase.ConnectionDataBase())
                {
                    string Query = "EXEC [dbo].[SP_INSERT_USER] @NOMBRE, @APELLIDO, @NOMBRE_DE_USUARIO, @CONTRA, @EDAD, @TIPO_USUARIO";
                    using (SqlCommand cmd = new SqlCommand(Query, con))
                    {
                        cmd.Parameters.AddWithValue("@NOMBRE", textBox1.Text);
                        cmd.Parameters.AddWithValue("@APELLIDO", textBox2.Text);
                        cmd.Parameters.AddWithValue("@NOMBRE_DE_USUARIO", textBox3.Text);
                        cmd.Parameters.AddWithValue("@CONTRA", textBox4.Text);
                        cmd.Parameters.AddWithValue("@EDAD", numericUpDown1.Text);
                        cmd.Parameters.AddWithValue("@TIPO_USUARIO", comboBox1.Text);
                        try {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    MessageBox.Show("Usuario guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LimpiarCampos();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al guardar el nuevo usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        } catch (Exception ex){
                            MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        public bool verificacionDeCampos()
        {
            bool camposValidos = true;

            if (
                (textBox1.Text == null || textBox1.Text == "") || 
                (textBox2.Text == null || textBox2.Text == "") ||
                (textBox3.Text == null || textBox3.Text == "") ||
                (textBox4.Text == null || textBox4.Text == "") ||
                (numericUpDown1.Text == null || numericUpDown1.Text == "") ||
                (comboBox1.Text == null || comboBox1.Text == "")
                )
            {
                MessageBox.Show("Favor llenar todos los datos del formulario :)", "Datos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                camposValidos = false;
            }

            return camposValidos;
        }

        public void LimpiarCampos()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            comboBox1.Text = string.Empty;
            numericUpDown1.Text = string.Empty;
        }
    }
}
