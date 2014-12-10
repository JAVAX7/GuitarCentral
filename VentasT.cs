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
    public partial class VentasT : Form
    {
        public VentasT()
        {
            InitializeComponent();
        }

        private void VentasT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'guitarCentralDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.guitarCentralDataSet.Ventas);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
