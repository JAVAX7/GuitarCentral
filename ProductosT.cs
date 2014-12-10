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
    public partial class ProductosT : Form
    {
        public ProductosT()
        {
            InitializeComponent();
        }

        private void ProductosT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'guitarCentralDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.guitarCentralDataSet.Productos);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            productosBindingSource.MovePrevious();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveLast();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveFirst();
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
