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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            string nombreM = txtMateria.Text;
            int row;

            MySqlCommand comando = new MySqlCommand("insert into curso values(0, '" + nombreM + "')", BdComun.ObtenerConexion());

            row=comando.ExecuteNonQuery();

            if (row > 0)
            {
                MessageBox.Show($"Se agrego el curso {nombreM}");
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
