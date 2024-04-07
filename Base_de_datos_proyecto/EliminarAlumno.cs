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
    public partial class EliminarAlumno : Form
    {
        public EliminarAlumno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matriculaA = int.Parse(txtMatricula.Text);
            int row;

            MySqlCommand comando = new MySqlCommand("delete from iopim.parciales where matriculaA = '" + matriculaA + "'", BdComun.ObtenerConexion());
            MySqlCommand comando2 = new MySqlCommand("delete from iopim.alumno where matricula = '" + matriculaA + "'", BdComun.ObtenerConexion());
            
            row = comando.ExecuteNonQuery() + comando2.ExecuteNonQuery();

            if(row > 0)
            {
                MessageBox.Show($"Se elimino al alumno con matricula {matriculaA}");
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
