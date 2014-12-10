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
    public partial class ClientesM : Form
    {
        public ClientesM()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInd_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Clientes frm = new Clientes();
            frm.Show();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            ClientesT frm = new ClientesT();
            frm.Show();
        }
    }
}
