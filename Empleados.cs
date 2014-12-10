using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarCentral
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'guitarCentralDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.guitarCentralDataSet.Empleados);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveFirst();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
