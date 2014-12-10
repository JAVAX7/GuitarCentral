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
    public partial class ProductosM : Form
    {
        public ProductosM()
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
            Productos frm = new Productos();
            frm.Show();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            ProductosT frm = new ProductosT();
            frm.Show();
        }
    }
}
