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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double p1 = double.Parse(txtP1.Text);
            double p2 = double.Parse(txtP2.Text);
            double p3 = double.Parse(txtP3.Text);
            double pf = Math.Round((p1+p2+p3)/3,1);
            int matriculaA = int.Parse(txtMatriculaA.Text);
            int codigoC = int.Parse(txtCodigoC.Text);
            int codigoP = int.Parse(txtCodigoP.Text);

            int row;

            MySqlCommand comando = new MySqlCommand("update iopim.parciales set codigoP= " + codigoP + ", p1= " + p1 + ", p2= " + p2 + ", p3= " + p3 + ", promedioF= " + pf + ", matriculaA= " + matriculaA + ", codigoCu= " + codigoC + " where matriculaA= " + matriculaA + ";", BdComun.ObtenerConexion());

            row = comando.ExecuteNonQuery();

            if (row > 0)
            {
                MessageBox.Show($"Se actualizaron los datos del alumno con {matriculaA}");
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
