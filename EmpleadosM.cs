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
    public partial class EmpleadosM : Form
    {
        public EmpleadosM()
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
            Empleados frm = new Empleados();
            frm.Show();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            EmpleadosT frm = new EmpleadosT();
            frm.Show();
        }
    }
}
