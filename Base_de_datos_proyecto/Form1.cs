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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ialumno = new insertarAlumno();
            ialumno.Show();
            this.Hide();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ccal = new Materia1();
            ccal.Show();
            this.Hide();
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ac = new Curso();
            ac.Show();
            this.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("select distinct alumno.nombre, parciales.p1, parciales.p2, parciales.p3, parciales.promediof, curso.materia from alumno, parciales, curso where alumno.matricula = parciales.matriculaA and curso.codigoM = parciales.codigoCu order by alumno.nombre asc;", BdComun.ObtenerConexion());
            DataSet ds;

            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            ds = new DataSet();
            data.Fill(ds);
            grdConsultar.DataSource = ds.Tables[0];
        }

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ea = new EliminarAlumno();
            ea.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ad = new Actualizar();
            ad.Show();
            this.Hide();
        }
    }
}
