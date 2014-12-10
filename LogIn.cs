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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btni_Click(object sender, EventArgs e)
        {
            if(txtusern.Text==""&&txtpas.Text=="")
            {
                Form.ActiveForm.Visible = false;
                Bienvenido frm = new Bienvenido();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrasena incorrectos.");
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
