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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Cerrando frm = new Cerrando();
            frm.Show();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ProductosM frm = new ProductosM();
            frm.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            VentasM frm = new VentasM();
            frm.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClientesM frm = new ClientesM();
            frm.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EmpleadosM frm = new EmpleadosM();
            frm.Show();
        }
    }
}
