using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            BdComun.ObtenerConexion();
            MessageBox.Show("Conectado");
        }
    }
}
