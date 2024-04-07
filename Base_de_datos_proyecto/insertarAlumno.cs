using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Base_de_datos_proyecto
{
    public partial class insertarAlumno : Form
    {
        public insertarAlumno()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreA.Text;
            int matricula = int.Parse(txtMatriculaA.Text);
            string fechaNac = txtFechaNac.Text;

            int row;

            MySqlCommand comando = new MySqlCommand("insert into alumno values(" + matricula + ", '" + nombre + "','" + fechaNac + "')", BdComun.ObtenerConexion());

            row=comando.ExecuteNonQuery();

            if (row > 0)
            {
                MessageBox.Show($"Se insertó al alumno {nombre}");
            }
            else
            {
                MessageBox.Show("No se ejecuto el comando");
            }

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmConsulta();
            frm1.Show();
            this.Close();
        }
    }
}
