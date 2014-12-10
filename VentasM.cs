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
    public partial class VentasM : Form
    {
        public VentasM()
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
            Ventas frm = new Ventas();
            frm.Show();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            VentasT frm = new VentasT();
            frm.Show();
        }
    }
}
