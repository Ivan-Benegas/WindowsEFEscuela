using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.Dac;
using WindowsEF.Models;

namespace WindowsEF
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            MostrarTodosAlumnos();
        }

        private void MostrarTodosAlumnos()
        {
            gridAlumno.DataSource = AbmAlumno.SelectAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text) };

            int filasAfectadas = AbmAlumno.Insert(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok.");

                MostrarTodosAlumnos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { IdAlumno = Convert.ToInt32(txtId.Text), Nombre = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text) };

            int filasAfectadas = AbmAlumno.Update(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok.");

                MostrarTodosAlumnos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { IdAlumno = Convert.ToInt32(txtId.Text), Nombre = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text) };

            int filasAfectadas = AbmAlumno.Delete(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok.");

                MostrarTodosAlumnos();
            }
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Alumno alumno = AbmAlumno.SelectWhereById(id);

            MessageBox.Show(alumno.Nombre);
        }

    }
}
