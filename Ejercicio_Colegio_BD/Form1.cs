using Ejercicio_Colegio_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Colegio_BD
{
    public partial class Form1 : Form
    {
        public static Bd_Colegio bd_colegio = new Bd_Colegio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bd_colegio.Cursos.ToList();
            comboBox1.DisplayMember="Nombre";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso cursoSeleccionado = (Curso)comboBox1.SelectedItem;
            textBox1.Text = cursoSeleccionado.Profesore.Nombre;

            List<Alumno> listaAlumnos = cursoSeleccionado.Alumnos.ToList();

            dataGridView1.DataSource = listaAlumnos;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }
    }
}
