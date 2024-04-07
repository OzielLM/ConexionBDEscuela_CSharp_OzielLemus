
namespace Base_de_datos_proyecto
{
    partial class frmConsulta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materia1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materia2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materia3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lstConsultar = new System.Windows.Forms.ListBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(520, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.nuevoAlumnoToolStripMenuItem});
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.insertarToolStripMenuItem.Text = "Insertar";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materia1ToolStripMenuItem,
            this.materia2ToolStripMenuItem,
            this.materia3ToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.alumnoToolStripMenuItem.Text = "Alumno calificaciones";
            // 
            // materia1ToolStripMenuItem
            // 
            this.materia1ToolStripMenuItem.Name = "materia1ToolStripMenuItem";
            this.materia1ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.materia1ToolStripMenuItem.Text = "Materia 1";
            // 
            // materia2ToolStripMenuItem
            // 
            this.materia2ToolStripMenuItem.Name = "materia2ToolStripMenuItem";
            this.materia2ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.materia2ToolStripMenuItem.Text = "Materia2";
            // 
            // materia3ToolStripMenuItem
            // 
            this.materia3ToolStripMenuItem.Name = "materia3ToolStripMenuItem";
            this.materia3ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.materia3ToolStripMenuItem.Text = "Materia3";
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            this.nuevoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlumnoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem1});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // alumnoToolStripMenuItem1
            // 
            this.alumnoToolStripMenuItem1.Name = "alumnoToolStripMenuItem1";
            this.alumnoToolStripMenuItem1.Size = new System.Drawing.Size(130, 24);
            this.alumnoToolStripMenuItem1.Text = "Alumno";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblBienvenida.Location = new System.Drawing.Point(70, 29);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(415, 36);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.Text = "Bienvenido a la base de datos del IOPIM \r\n(Instituto Orientado Para la Ingenieria" +
    " en Mecatronica)";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstConsultar
            // 
            this.lstConsultar.FormattingEnabled = true;
            this.lstConsultar.Location = new System.Drawing.Point(130, 80);
            this.lstConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstConsultar.Name = "lstConsultar";
            this.lstConsultar.Size = new System.Drawing.Size(366, 277);
            this.lstConsultar.TabIndex = 1;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Khaki;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(9, 80);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(108, 44);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar lista de alumnos \r\n";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lstConsultar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsulta";
            this.Text = "IOPIM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materia1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materia2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materia3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ListBox lstConsultar;
        private System.Windows.Forms.Button btnConsulta;
    }
}

