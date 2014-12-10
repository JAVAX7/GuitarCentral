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
    public partial class ClientesT : Form
    {
        public ClientesT()
        {
            InitializeComponent();
        }

        private void ClientesT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'guitarCentralDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.guitarCentralDataSet.Clientes);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
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
